using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface ILoginLogic
    {
        //RegistrationDto GetRegistrationById(int id);

        //LoginDto GetLoginById(int id);
        //LoginDto FindByCredentials(int id);
        LoginDto ValidateUser(LoginDto loginDto);

    }
}
