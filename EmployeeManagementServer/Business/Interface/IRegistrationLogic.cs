using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IRegistrationLogic
    {
        List<RegistrationDto> GetAllRegistration();

        RegistrationDto GetRegistrationById(int id);

        RegistrationDto AddRegistration(RegistrationDto registrationDto);
        RegistrationDto UpdateRegistration(RegistrationDto registrationDto);


        RegistrationDto DeleteRegistration(int registrationDto);
    }
}
