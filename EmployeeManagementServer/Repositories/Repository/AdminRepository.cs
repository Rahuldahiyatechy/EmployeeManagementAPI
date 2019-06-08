using Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repository
{
    public class AdminRepository : IAdminRepository
    {
        public IEnumerable<Admin> GetAdmin()
        {
            throw new NotImplementedException();
        }
    }
}
