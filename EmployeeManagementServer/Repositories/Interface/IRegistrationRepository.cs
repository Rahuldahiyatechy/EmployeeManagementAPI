using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
    public interface IRegistrationRepository
    {

        IEnumerable<Registration> GetRegistration();

        void AddRegistration(Registration registration);


        //Below method is used to Find out the record from the database table "Department Table"
        Registration getRegistrationRecordById(int id);


        //void updateregistration(registration registrationrecord);

        void UpdateRegistration(Registration registrationRecord);


        //For Delete Opertion Method
        Registration deleteRegistrationRecordById(int id);

        void deleteRegistration(Registration registrationRecord);


    }
}
