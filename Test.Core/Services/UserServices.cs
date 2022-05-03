using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Test.Core.DTOs;
using Test.Core.Generator;
using Test.Core.Security;
using Test.Core.Services.Interface;
using Test.DataLayer.Context;
using Test.DataLayer.Entities.User;
using Test.DataLayer.Entities.Wallet;

namespace Test.Core.Services
{
    public class UserServices : IUserServices
    {
        private TestContext _context;

        public UserServices(TestContext context)
        {
            _context = context;
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(p => p.UserName == userName);
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(p => p.Email == email);
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public User LoginUser(LoginViewModel login)
        {
            var email = login.Email.ToLower().Trim();
            var hashpass = PasswordHelper.EncodePasswordMd5(login.Password);

            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == hashpass);
        }

        public bool ActiveAcount(string id)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == id);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUnicCode();
            _context.SaveChanges();
            return true;
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public int GetUserIdByUserName(string userName)
        {
            return _context.Users.Single(u => u.UserName == userName).UserId;
        }

        public void DeleteUser(int userId)
        {
            User user = GetUserById(userId);
            user.IsDelete = true;
            UpdateUser(user);
        }

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == username);
            InformationUserViewModel info = new InformationUserViewModel();
            info.UserName = user.UserName;
            info.RegisterDate = user.RegisterDate;
            info.Email = user.Email;
            info.Wallet = BalanceUserWallet(username);

            return info;
        }

        public InformationUserViewModel GetUserInformation(int userId)
        {
            var user = GetUserById(userId);
            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(user.UserName);

            return information;
        }

        public SideBarUserPanelViewModel GetSideBarUserPanelData(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(s => new SideBarUserPanelViewModel()
                {
                    ImageName = s.UserAvatar,
                    RegisterDate = s.RegisterDate,
                    UserName = s.UserName
                })
                .Single();
        }

        public EditProfileViewModel GetDataForEditProfileUser(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel()
            {
                AvatarName = u.UserAvatar,
                Email = u.Email,
                UserName = u.UserName
            }).Single();
        }

        public void EditProfile(string username, EditProfileViewModel profile)
        {
            if (profile.UserAvatar != null)
            {
                string imagePath = "";
                if (profile.AvatarName != "Defult.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                profile.AvatarName = NameGenerator.GenerateUnicCode() + Path.GetExtension(profile.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    profile.UserAvatar.CopyTo(stream);
                }
            }

            var user = GetUserByUserName(username);
            user.Email = profile.Email.Trim().ToLower();
            user.UserAvatar = profile.AvatarName;
            user.UserName = profile.UserName;

            UpdateUser(user);
        }

        public bool CompareOldPassword(string oldPassword, string username)
        {
            var hashpass = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.Password == hashpass && u.UserName == username);
        }

        public void ChangeUserPassword(string userName, string newPassword)
        {
            var user = GetUserByUserName(userName);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }

        public int BalanceUserWallet(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            var enter = _context.Wallets.Where(w => w.IsPay && w.UserId == userId && w.TypeId == 1)
                .Select(w => w.Amount).ToList();
            var exit = _context.Wallets.Where(w => w.UserId == userId && w.TypeId == 2)
                .Select(w => w.Amount).ToList();

            return (enter.Sum() - exit.Sum());
        }

        public List<WalletViewModel> GetWalletUser(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            return _context.Wallets.Where(u => u.UserId == userId).Select(w => new WalletViewModel()
            {
                Amount = w.Amount,
                Description = w.Description,
                Type = w.TypeId,
                DateTime = w.CreateDate
            }).ToList();
        }

       

        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public UserForAdminViewModel GetUser(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users;
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }
            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }

            int take = 10;
            int skip = (pageId - 1) * take;
            UserForAdminViewModel info = new UserForAdminViewModel();
            info.PageCount = (result.Count() / take)+1;
            info.CurrentPage = pageId;
            
            info.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return info;

        }

        public UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users.IgnoreQueryFilters().Where(u=>u.IsDelete);

            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }

            // Show Item In Page
            int take = 20;
            int skip = (pageId - 1) * take;


            UserForAdminViewModel list = new UserForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();

            return list;
        }

        public int AddUserFromAdmin(CreateUserViewModel user)
        {
            User Adduser = new User();
            Adduser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            Adduser.Email = user.Email.Trim().ToLower();
            Adduser.ActiveCode = NameGenerator.GenerateUnicCode();
            Adduser.RegisterDate=DateTime.Now;
            Adduser.UserName = user.UserName;
            Adduser.IsActive = true;
            
            if (user.UserAvatar != null)
            {
                string imagePath = "";
                Adduser.UserAvatar = NameGenerator.GenerateUnicCode() + Path.GetExtension(user.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", Adduser.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    user.UserAvatar.CopyTo(stream);
                }
            }

            return AddUser(Adduser);

        }

        public EditUserViewModel GetUserForShowInEditMode(int userId)
        {
            return _context.Users.Where(u => u.UserId == userId)
                .Select(u=>new EditUserViewModel()
                {
                    UserId = u.UserId,
                    Email = u.Email,
                    AvatarName = u.UserAvatar,
                    UserName = u.UserName,
                    UserRoles = u.UserRoles.Select(r=>r.RoleId).ToList()
                }).Single();
        }
        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }
        public void EditUserFromAdmin(EditUserViewModel editUser)
        {
            User user = GetUserById(editUser.UserId);
            user.Email = editUser.Email;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }
            
            if (editUser.UserAvatar != null)
            {
                //Delete old Image
                if (editUser.AvatarName != "Defult.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editUser.AvatarName);
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }
                //Save New Image
                user.UserAvatar = NameGenerator.GenerateUnicCode() + Path.GetExtension(editUser.UserAvatar.FileName);
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editUser.UserAvatar.CopyTo(stream);
                }
            }
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}