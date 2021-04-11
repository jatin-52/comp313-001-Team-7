using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SecondHandBook.VMs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecondHandBook
{
    [EnableCors]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MobileLoginController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public MobileLoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<ActionResult> Test()
        {
            return Ok("success");
        }

        [HttpPost]
        public async Task<ActionResult> SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Ok(user.Id);
                }
                else
                {
                    return BadRequest(string.Join(",", result.Errors.Select(x => x.Description).ToList()));
                }
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    return Ok(user.Id);
                }
                else
                {
                    return BadRequest("Invalid UserName or Password");
                }
            }
            return BadRequest();
        }


    }
}
