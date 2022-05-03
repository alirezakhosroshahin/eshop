using System.Collections.Generic;
using Test.Core.DTOs;
using Test.DataLayer.Entities.User;
using Test.DataLayer.Entities.Wallet;

namespace Test.Core.Services.Interface
{
    public interface IUserServices
    {
        #region Users

        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        bool ActiveAcount(string id);
        User GetUserByUserName(string username);
        void UpdateUser(User user);
        int GetUserIdByUserName(string userName);
        User GetUserById(int userId);
        void DeleteUser(int userId);

        #endregion

        #region user panel

        InformationUserViewModel GetUserInformation(string username);
        InformationUserViewModel GetUserInformation(int userId);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void EditProfile(string username,EditProfileViewModel profile);
        bool CompareOldPassword(string oldPassword, string username);
        void ChangeUserPassword(string userName, string newPassword);

        #endregion

        #region Wallet
        int BalanceUserWallet(string userName);
        List<WalletViewModel> GetWalletUser(string userName);
        int AddWallet(Wallet wallet);
        #endregion

        #region Admin Panel

        UserForAdminViewModel GetUser(int pageId = 1, string filterEmail = "", string filterUserName = "");
        UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);

        #endregion
    }
}