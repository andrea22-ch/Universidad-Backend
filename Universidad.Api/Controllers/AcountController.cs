using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Universidad.Logica_.DTOs;
namespace Universidad.Api.Controllers
{
    [AllowAnonymous]
    public class AcountController : ApiController
    {

        /// <summary>
        /// metodo encargado de realizar la autenticacion
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Login(LoginDTO login)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            bool isCredentialValid = (login.Password =="123456");
            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.UserName);
                return Ok(token);
            }
            else { return Unauthorized();//status code 401
            }
              
        }
    }
}
