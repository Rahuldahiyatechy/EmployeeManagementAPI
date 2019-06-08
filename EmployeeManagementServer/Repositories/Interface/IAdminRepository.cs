using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
   public interface IAdminRepository
    {
        IEnumerable<Admin> GetAdmin();
    }
}
