using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using web_app1.Models;

namespace web_app1.Repository
{
    public interface IUserRepository
    {
        Task<IdentityResult> CreateUSerAsync(UserModel userModel);
    }
}