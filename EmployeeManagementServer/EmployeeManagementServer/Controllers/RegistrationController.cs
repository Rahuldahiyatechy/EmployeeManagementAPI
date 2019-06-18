using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interface;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationLogic _registrationLogic;
        public RegistrationController(IRegistrationLogic registrationLogic)
        {
            this._registrationLogic = registrationLogic;
        }

        [HttpGet("get")]
        public IActionResult GetRegistration()
        {
            return Ok(this._registrationLogic.GetAllRegistration());
        }


        [HttpGet]
        [Route("get/{id}")]
        public IActionResult RegistrationDetailById(int id)
        {
            var dto = _registrationLogic.GetRegistrationById(id);
            return Ok(dto);
        }



        [HttpPost]
        [Route("create")]
        public IActionResult CreateRegistrationData([FromBody]RegistrationDto registrationDto)
        {
            var dto = _registrationLogic.AddRegistration(registrationDto);

            return Ok(dto);
        }


        [HttpPost]
        [Route("update")]
        public IActionResult UpdateRegistrationData([FromBody]RegistrationDto registrationDto)
        {
            var dto = _registrationLogic.UpdateRegistration(registrationDto);

            return Ok(dto);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult DeleteRegistrationRecord(int id)
        {
            var dto = _registrationLogic.DeleteRegistration(id);
            return Ok(dto);

        }






    }
}