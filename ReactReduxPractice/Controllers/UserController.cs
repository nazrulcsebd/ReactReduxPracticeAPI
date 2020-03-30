using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactReduxPractice.Models;

namespace ReactReduxPractice.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var userData = new UserDemo().UserDemoData();
                if (userData != null)
                {
                    return Ok(userData);
                }
                else
                {
                    var notification = new
                    {
                        Type = "error",
                        Message = "Not found anything"
                    };

                    return StatusCode(500, notification);
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

        [HttpPost]
        public IActionResult Post([FromBody]UserDemo user)
        {
            if (!ModelState.IsValid)
            {
                var notification = new
                {
                    Type = "error",
                    Message = "Data is not valid"
                };

                return StatusCode(500, notification);
            }

            try
            {
                var userData = new UserDemo().UserDemoData();
                userData.Add(user);

                var notification = new
                {
                    Type = "success",
                    Message = "user added"
                };

                return Created(string.Empty, notification);
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