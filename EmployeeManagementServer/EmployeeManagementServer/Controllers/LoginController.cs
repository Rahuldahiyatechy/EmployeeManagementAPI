using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interface;
using DTOs;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EmployeeManagementServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;

        private readonly ILoginLogic _loginLogic;
        private readonly IRegistrationLogic _registrationLogic;

        //public LoginController(ILoginLogic loginLogic, IRegistrationLogic registrationLogic, AppDbContext context)
        public LoginController(AppDbContext context)

        {
            //this._loginLogic = loginLogic;
            //_registrationLogic = registrationLogic;
            _context = context;

        }


        [HttpPost]
        [Route("UserLogin")]

        //POST : /api/ApplicationUser/Login
        //public IActionResult LoginAction([FromBody]LoginDto loginDto)
        //        {

        //    var dto = _loginLogic.ValidateUser(loginDto);

        //    return Ok(dto);

        //}


        public async Task<IActionResult> LoginUser(Registration user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Registration usr = _context.Registration.FirstOrDefault(x => x.Name.Equals(user.Name) && x.Password.Equals(user.Password));
            //await _context.SaveChangesAsync();
            if (usr == null)
            {
                return BadRequest();
            }

            usr.Password = "";
            return Ok(usr);
        }



    }
}


