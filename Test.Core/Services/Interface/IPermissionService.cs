using System;
using System.Collections.Generic;
using Test.DataLayer.Entities.Permissions;
using Test.DataLayer.Entities.User;

namespace Test.Core.Services.Interface
{
    public interface IPermissionService
    {
        #region Role

        List<Role> GetRole();
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> roles, int userId);
        void EditRolesUser(int userId, List<int> rolesId);

        #endregion

        #region Permission

        List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);

        #endregion
        
        bool CheckPermission(int permissionId, string userName);
    }
}