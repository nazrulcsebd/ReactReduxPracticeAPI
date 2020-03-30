using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReactReduxPractice.Models;

namespace Alpha.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody]LoginModel login)
        {
            var dummy = new LoginModel()
            {
                LoginId = "demo",
                Password = "demo"
            };

            try
            {
                var isAuthenticate = login.LoginId == dummy.LoginId && login.Password == dummy.Password;

                if (isAuthenticate)
                {
                    var Data = new
                    {
                        token = "demo token 123456",
                        user = new
                        {
                            UserName = "Admin User"
                        }
                    };

                    return Ok(Data);

                }
                else
                {
                    var notification = new
                    {
                        Type = "error",
                        Message = "Credential not correct"
                    };
                    return BadRequest(notification);
                }
            }
            catch (Exception ex)
            {
                var notification = new
                {
                    Type = "error",
                    Message = ex.Message
                };

                return StatusCode(500, notification);
            }
        }


    }
}