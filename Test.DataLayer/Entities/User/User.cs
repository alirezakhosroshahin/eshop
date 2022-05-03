using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Test.DataLayer.Entities.Course;

namespace Test.DataLayer.Entities.User
{
    public class User
    {
        public User()
        {
           
            Courses = new HashSet<Course.Course>();
            UserRoles = new HashSet<UserRole>();
            Wallets = new HashSet<Wallet.Wallet>();
            UserDiscountCodes = new HashSet<UserDiscountCode>();
            UserCourses = new HashSet<UserCourse>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ActiveCode { get; set; }
        public bool IsActive { get; set; }
        public string UserAvatar { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDelete { get; set; }
        public virtual ICollection<UserDiscountCode> UserDiscountCodes { get; set; }
        public virtual ICollection<Course.Course> Courses { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Wallet.Wallet> Wallets { get; set; }
        public virtual ICollection<Order.Order> Orders { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
 