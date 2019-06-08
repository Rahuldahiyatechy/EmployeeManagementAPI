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
    public class RoleLogic : IRoleLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleLogic(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

       

        public List<RoleDto> GetAllRole()
        {
            return _unitOfWork.RoleRepository.GetRole().Select(x => new RoleDto
            {
                Id = x.Id,
                Name=x.Name


            }).ToList();
        }

        public RoleDto GetRoleById(int id)
        {

            return _unitOfWork.RoleRepository.GetRole().Where(item => item.Id == id).Select(x => new RoleDto
            {
                Id = x.Id,
                //Username = x.FirstName + " " + x.LastName,
                //FirstName = x.FirstName,
                //LastName = x.LastName,
                Name = x.Name,
            }).FirstOrDefault();


            //throw new NotImplementedException();
        }

        public RoleDto AddRole(RoleDto roleDto)
        {

            Role obj = new Role();
            obj.Name = roleDto.Name;
            
            this._unitOfWork.RoleRepository.AddRole(obj);
            return roleDto;



            //throw new NotImplementedException();
        }

        public RoleDto UpdateRole(RoleDto roleDto)
        {
            var RoleRecord = _unitOfWork.RoleRepository.getRoleRecordById(roleDto.Id);
            RoleRecord.Name = roleDto.Name;
            this._unitOfWork.RoleRepository.UpdateRole(RoleRecord);
            return roleDto;

            //throw new NotImplementedException();
        }

        public RoleDto DeleteRole(int roleDto)
        {
            var RoleRecordToDelete = _unitOfWork.RoleRepository.deleteRoleRecordById(roleDto);
            this._unitOfWork.RoleRepository.deleteRole(RoleRecordToDelete);
            return new RoleDto();
            //throw new NotImplementedException();
        }

        
    }
}
