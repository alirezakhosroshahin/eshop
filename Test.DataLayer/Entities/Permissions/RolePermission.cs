using System.ComponentModel.DataAnnotations;
using Test.DataLayer.Entities.User;

namespace Test.DataLayer.Entities.Permissions
{
    public class RolePermission
    {
        public int RpId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
    }
}