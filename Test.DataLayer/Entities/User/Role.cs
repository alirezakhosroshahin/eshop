using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Test.DataLayer.Entities.Permissions;

namespace Test.DataLayer.Entities.User
{
    public class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleTitle { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}