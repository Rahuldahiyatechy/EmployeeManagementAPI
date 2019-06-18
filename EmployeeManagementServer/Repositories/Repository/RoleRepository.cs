using Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repository
{
   public class RoleRepository: IRoleRepository
    {
        private readonly AppDbContext context;

        public RoleRepository (AppDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IEnumerable<Role> GetRole()
        {
            return context.Role.AsEnumerable();

        }

        

        public void AddRole(Role role)
        {
            context.Role.Add(role);
                context.SaveChanges();

            //throw new NotImplementedException();
        }
        public void UpdateRole(Role roleRecord)
        {
            context.Role.Update(roleRecord);
            context.SaveChanges();
          // throw new NotImplementedException();
        }

        public void deleteRole(Role RoleRecordToDelete)
        {
            context.Role.Remove(RoleRecordToDelete);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public Role deleteRoleRecordById(int id)
        {
            return context.Role.SingleOrDefault(u => u.Id == id);
        }


        public Role getRoleRecordById(int id)
        {
            return context.Role.SingleOrDefault(u => u.Id == id);

        }

    }
}


