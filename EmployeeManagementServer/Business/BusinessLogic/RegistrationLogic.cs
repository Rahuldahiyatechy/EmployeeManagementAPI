using Business.Interface;
using DTOs;
using Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.BusinessLogic
{
    public class RegistrationLogic : IRegistrationLogic
    {

        private readonly IUnitOfWork _unitOfWork;

        public RegistrationLogic(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }



        public RegistrationDto AddRegistration(RegistrationDto registrationDto)
        {

            Registration obj = new Registration();
            obj.Name = registrationDto.Name;
            obj.Password = registrationDto.Password;
            obj.DateOfJoining = registrationDto.DateOfJoining;
            obj.Designation = registrationDto.Designation;
            obj.Phone = registrationDto.Phone;
            obj.DateOfBirth = registrationDto.DateOfBirth;
            obj.AddressDescription1 = registrationDto.AddressDescription1;
            obj.AddressDescription2 = registrationDto.AddressDescription2;
            obj.City = registrationDto.City;
            obj.State = registrationDto.State;
            obj.ZipCode = registrationDto.ZipCode;
            
            //this for forign key from the Role table.
            //obj.DepartmentId = registrationDto.departmentId;
            obj.roleid = registrationDto.roleid;
            this._unitOfWork.registrationRepository.AddRegistration(obj);
            return registrationDto;
        }
        public RegistrationDto DeleteRegistration(int registrationDto)
        {
            var RegistrationRecordToDelete = _unitOfWork.registrationRepository.deleteRegistrationRecordById(registrationDto);

            this._unitOfWork.registrationRepository.deleteRegistration(RegistrationRecordToDelete);
            return new RegistrationDto();

            //throw new NotImplementedException();
        }

        public List<RegistrationDto> GetAllRegistration()
        {
            return _unitOfWork.registrationRepository.GetRegistration().Select(x => new RegistrationDto
            {
                Id = x.Id,
                Name = x.Name,
                Password = x.Password,
                DateOfJoining=x.DateOfJoining,
                Designation=x.Designation,
                Phone=x.Phone,
                DateOfBirth=x.DateOfBirth,
                AddressDescription1 = x.AddressDescription1,
                AddressDescription2 = x.AddressDescription2,
                City=x.City,
                State=x.State,
                ZipCode=x.ZipCode,
                //for forign key id from role table
                roleid = x.Role.Id,
                RoleType = x.Role.Name
            }).ToList();
        }

        public RegistrationDto GetRegistrationById(int id)
        {

            return _unitOfWork.registrationRepository.GetRegistration().Where(item => item.Id == id).Select(x => new RegistrationDto
            {
                Id = x.Id,
                Name = x.Name,
                Password = x.Password,
                DateOfJoining=x.DateOfJoining,
               Designation=x.Designation,
               Phone=x.Phone,
               DateOfBirth=x.DateOfBirth,
                AddressDescription1 = x.AddressDescription1,
                AddressDescription2 = x.AddressDescription2,
                City=x.City,
               State=x.State,
               ZipCode=x.ZipCode,
                //this is for Foreign Key from Role Table
                roleid = x.Role.Id,
                RoleType = x.Role.Name
            }).FirstOrDefault();

           
        }

        public RegistrationDto UpdateRegistration(RegistrationDto registrationDto)
        {
            var RegistrationRecord = _unitOfWork.registrationRepository.getRegistrationRecordById(registrationDto.Id);
            RegistrationRecord.Name = registrationDto.Name;
            RegistrationRecord.Password = registrationDto.Password;
            RegistrationRecord.DateOfJoining = registrationDto.DateOfJoining;
            RegistrationRecord.Designation = registrationDto.Designation;
            RegistrationRecord.Phone = registrationDto.Phone;
            RegistrationRecord.DateOfBirth = registrationDto.DateOfBirth;
            RegistrationRecord.AddressDescription1 = registrationDto.AddressDescription1;

            RegistrationRecord.AddressDescription2 = registrationDto.AddressDescription2;
            RegistrationRecord.City = registrationDto.City;
            RegistrationRecord.State = registrationDto.State;
            RegistrationRecord.ZipCode = registrationDto.ZipCode;

            //for forign key from Role  table
            RegistrationRecord.Id = registrationDto.Id;
            this._unitOfWork.registrationRepository.UpdateRegistration(RegistrationRecord);
            return registrationDto;
        }
    }
}
