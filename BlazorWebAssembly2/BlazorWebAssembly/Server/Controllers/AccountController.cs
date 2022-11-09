using BlazorWebAssembly.Server.Authentication;
using BlazorWebAssembly.Server.Domain.UserAccounts;
using BlazorWebAssembly.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly UserAccountService _userAccountService;

        public AccountController(UserAccountService accountService)
        {
            _userAccountService = accountService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]

        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
            var userSession = jwtAuthenticationManager.GenerateJWTToken(loginRequest.Username, loginRequest.Password);
            return userSession is null ? (ActionResult<UserSession>)Unauthorized() : (ActionResult<UserSession>)userSession;
        }
    }
}
