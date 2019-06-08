using Repositories.Interface;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitofWork
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext DbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        private IRoleRepository _roleRepository;
        private IRegistrationRepository _registrationRepository;
        private ILoginRepository _loginRepository;

        private IAdminRepository _adminRepository;
        private IUserRepository _userRepository;


        public IAdminRepository adminRepository => throw new NotImplementedException();


        public ILoginRepository loginRepository => throw new NotImplementedException();

        public IRegistrationRepository registrationRepository => throw new NotImplementedException();

        public ITimeTrackerRepository timeTrackerRepository => throw new NotImplementedException();

        public IUserRepository userRepository => throw new NotImplementedException();

        public IRoleRepository RoleRepository
        {
            get
            {
                if (this._roleRepository == null)
                {
                    this._roleRepository = new RoleRepository(DbContext);
                }
                return this._roleRepository;
            }
        }

        public int Complete()
        {
            return DbContext.SaveChanges();
            //throw new NotImplementedException();
        }

        public async Task<int> CompleteAsync()
        {
             return await DbContext.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        Task<int> IUnitOfWork.CompleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
