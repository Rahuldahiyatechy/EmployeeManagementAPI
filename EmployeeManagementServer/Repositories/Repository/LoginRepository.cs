using DTOs;
using Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repository
{
    public class LoginRepository: ILoginRepository
    {
        private readonly AppDbContext context;
        public LoginRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }

        public void ValidateUserlogin(Registration registrationDto)
        {

            //Registration usr = context.Registration.FirstOrDefault(x => x.Name.Equals(registrationDto.Name) && x.Password.Equals(registrationDto.Password));

            //usr.Password = "";
            //return Ok(usr);

            //if (usr == null)
            //{
            //    return BadRequest();
            //}

            throw new NotImplementedException();
            //return context.Registration.Include(x => x.Role);
        }

        public void ValidateUserlogin(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }
    }
}















//public async Task<IActionResult> LoginUser(User user)
//{
//    if (!ModelState.IsValid)
//    {
//        return BadRequest(ModelState);
//    }

//    User usr = _context.Users.FirstOrDefault(x => x.Email.Equals(user.Email) && x.Password.Equals(user.Password));
//    //await _context.SaveChangesAsync();
//    if (usr == null)
//    {
//        return BadRequest();
//    }

//    usr.Password = "";
//    return Ok(usr);
//}
