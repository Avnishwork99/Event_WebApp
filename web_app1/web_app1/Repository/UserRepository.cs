using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_app1.Models;

namespace web_app1.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<IdentityUser> _usermanager;
        public UserRepository(UserManager<IdentityUser> userManager)
        {
            _usermanager = userManager;
        }
        public async Task<IdentityResult> CreateUSerAsync(UserModel userModel)
        {
            var user = new IdentityUser()
            {
                Email = userModel.EMail,
                UserName = userModel.EMail
            };
            var result = await _usermanager.CreateAsync(user,userModel.Password);
            return result;
        }
    }
}
