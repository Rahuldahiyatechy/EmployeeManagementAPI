using Business.Interface;
using DTOs;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.BusinessLogic
{
    public class LoginLogic : ILoginLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly ICryptopherHelper _cryptopherHelper;


        public LoginLogic(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public LoginDto ValidateUser(LoginDto loginDto)
        {
            this._unitOfWork.loginRepository.ValidateUserlogin(loginDto);
            return loginDto;
            //throw new NotImplementedException();
        }
    }
}
