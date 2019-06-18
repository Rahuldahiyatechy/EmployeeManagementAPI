using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repository
{
    public class RegistrationRepository: IRegistrationRepository
    {

        private readonly AppDbContext context;

        public RegistrationRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }
        public IEnumerable<Registration> GetRegistration()
        {
            return context.Registration.Include(x => x.Role);
            //return context.Registration.AsEnumerable();
            //throw new NotImplementedException();
        }


        public void AddRegistration(Registration registration)
        {
            context.Registration.Add(registration);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public Registration getRegistrationRecordById(int id)
        {
            return context.Registration.SingleOrDefault(u => u.Id ==id);
           // throw new NotImplementedException();
        }

        public void UpdateRegistration(Registration registrationRecord)
        {
            context.Registration.Update(registrationRecord);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public Registration deleteRegistrationRecordById(int id)
        {
            //throw new NotImplementedException();
            return context.Registration.SingleOrDefault(u => u.Id == id);
        }

        public void deleteRegistration(Registration registrationRecord)
        {
            //throw new NotImplementedException();
            context.Registration.Remove(registrationRecord);
            context.SaveChanges();
        }

    }
}
