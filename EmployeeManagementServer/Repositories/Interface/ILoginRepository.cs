using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
    public interface ILoginRepository
    {
        void ValidateUserlogin(LoginDto loginDto);
    }
}
