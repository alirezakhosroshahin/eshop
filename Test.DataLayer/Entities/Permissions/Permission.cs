using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.DataLayer.Entities.Permissions
{
    public class Permission
    {
        public Permission()
        {
            InverseParent = new HashSet<Permission>();
            RolePermissions = new HashSet<RolePermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionTitle { get; set; }
        public int? ParentId { get; set; }

        public virtual Permission Parent { get; set; }
        public virtual ICollection<Permission> InverseParent { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}