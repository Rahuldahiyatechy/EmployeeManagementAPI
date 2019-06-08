using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
   public interface IRoleRepository
    {
        IEnumerable<Role> GetRole();

        void AddRole(Role role);


        //Below method is used to Find out the record from the database table "Department Table"
        Role getRoleRecordById(int id);


        //void updaterole(role rolerecord);

        void UpdateRole(Role roleRecord);


        //For Delete Opertion Method
        Role deleteRoleRecordById(int id);

        void deleteRole(Role roleRecord);

    }
}
