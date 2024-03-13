using Microsoft.AspNetCore.Identity;
using MyProject.Interfaces;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Core.Services;

namespace MyProject.Services
{
    public class MangUserService(IUserService _userService, IPasswordHasher _passwordHasher) : IMangUserService
    {
        public async Task<bool> ResaetPassword(string mail, string password)
        {
            var a = _userService.GetByEmail(mail);
            var pass = _passwordHasher.HashPassword(password);            
            a.RawPasswordValue = pass;
            _userService.Save(a);

            return true;
        }
    }
}
