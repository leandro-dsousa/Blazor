using BlazorWebAssembly.Server.Domain.UserAccounts;
using BlazorWebAssembly.Shared;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlazorWebAssembly.Server.Authentication
{
    public class JwtAuthenticationManager
    {

        public const string JWT_SECURITY_KEY = "yPkCqn4kSWLtaJwXvN8jGzpQQyTZ3gdXkt7FeBJP";
        private const int JWT_TOKEN_VALIDITY_MINS = 20;

        private UserAccountService _userAccountService;

        public JwtAuthenticationManager(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        public UserSession? GenerateJWTToken(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return null;
        
            /* Validating User Credentials */
            var userAccount = _userAccountService.GetUserAccountByUsername(username);
            if (userAccount == null || userAccount.password.password != password) return null;

            /* Generating JWT Token */
            var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);
            var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);
            var claimsIdentity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userAccount.userName.username),
                    new Claim(ClaimTypes.Role, userAccount.role.name)
                });
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Expires = tokenExpiryTimeStamp,
                SigningCredentials = signingCredentials
            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(securityToken);

            /* Returning the User Session object */
            var userSession = new UserSession
            {
                UserName = userAccount.userName.username,
                Role = userAccount.role.name,
                Token = token,
                ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds
            };
            return userSession;
        }

    }
}
