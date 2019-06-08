using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
   public interface IRoleLogic
    {
        List<RoleDto> GetAllRole();

        RoleDto GetRoleById(int id);

        RoleDto AddRole(RoleDto roleDto);
        RoleDto UpdateRole(RoleDto roleDto);


        RoleDto DeleteRole(int roleDto);
    }
}
