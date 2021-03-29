using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecondHandBook
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class MobileLoginController : ControllerBase
    {
        // GET: api/<MobileLoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MobileLoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MobileLoginController>
        [HttpPost]
        public void SignUp([FromBody] string value)
        {
            if (ModelState.IsValid)
            {
                // var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                // var result = await _userManager.CreateAsync(user, Input.Password);
                /*if (result.Succeeded)
                {
                }*/
            }
        }

        // POST api/<MobileLoginController>
        [HttpPost]
        public async Task<ActionResult<string>> Login([FromBody] string value)
        {
            return "Abcd";
        }

        // PUT api/<MobileLoginController>/5
        [HttpPut]
        [Route("LoginPut")]
        public string LoginPut([FromBody] string value) // 
        {
            return "My put request";
        }

        // DELETE api/<MobileLoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
