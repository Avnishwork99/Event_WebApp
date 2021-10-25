using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_app1.Models;
using web_app1.Repository;

namespace web_app1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Route("Signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [Route("Signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                //logic
                var result = await _userRepository.CreateUSerAsync(userModel);
                if (!result.Succeeded)
                {
                    foreach(var errormessage in result.Errors)
                    {
                        ModelState.AddModelError("", errormessage.Description);
                    }
                    return View(userModel);
                }
                ModelState.Clear();
            }
            return View();
        }
    }
}
