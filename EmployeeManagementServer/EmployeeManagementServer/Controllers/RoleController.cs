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
    public class RoleController : ControllerBase
    {
        private readonly IRoleLogic _roleLogic;
        public RoleController(IRoleLogic roleLogic)
        {
            this._roleLogic = roleLogic;
        }

        [HttpGet("get")]
        public IActionResult GetRole()
        {
            return Ok(this._roleLogic.GetAllRole());
        }


        [HttpGet]
        [Route("get/{id}")]
        public IActionResult RoleDetailById(int id)
        {
            var dto = _roleLogic.GetRoleById(id);
            return Ok(dto);
        }



        [HttpPost]
        [Route("create")]
        public IActionResult CreateRoleData([FromBody]RoleDto roleDto)
        {
            var dto = _roleLogic.AddRole(roleDto);

            return Ok(dto);
        }


        [HttpPost]
        [Route("update")]
        public IActionResult UpdateRoleData([FromBody]RoleDto roleDto)
        {
            var dto = _roleLogic.UpdateRole(roleDto);

            return Ok(dto);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult DeleteRoleRecord(int id)
        {
            var dto = _roleLogic.DeleteRole(id);
            return Ok(dto);

        }









    }
}