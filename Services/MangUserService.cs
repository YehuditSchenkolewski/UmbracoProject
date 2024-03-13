using Microsoft.AspNetCore.Identity;
using MyProject.Interfaces;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Core.Services;

namespace MyProject.Services
{
    public class MangUserService(IUserService _userService, IPasswordHasher _passwordHasher) : IMangUserService
    {
        public bool resaetPassword()
        {
            var a = _userService.GetByEmail("yehudits@matrix.co.il");
            var pass = _passwordHasher.HashPassword("123456");
            a.RawPasswordValue = pass;
            _userService.Save(a);

            return true;
        }
    }
}
