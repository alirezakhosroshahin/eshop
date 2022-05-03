using System.ComponentModel.DataAnnotations;

namespace Test.DataLayer.Entities.User
{
    public class UserRole
    {
        public int UrId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}