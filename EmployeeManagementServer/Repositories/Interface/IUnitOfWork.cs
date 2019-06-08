using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
   public interface IUnitOfWork
    {

        IRoleRepository RoleRepository { get; }
        IAdminRepository adminRepository { get; }
        ILoginRepository loginRepository { get; }
        IRegistrationRepository registrationRepository { get; }
        ITimeTrackerRepository timeTrackerRepository { get; }
        IUserRepository userRepository { get; }

        Task<int> CompleteAsync();
        int Complete();
    }
}
