using BlazorWebAssembly.Server.Domain.Shared;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class PasswordSalt
    {

        public byte[] _passwordSalt { get; set; } = new byte[128];

        public PasswordSalt()
        {
        }

        public PasswordSalt(byte[] passwordSalt)
        {
            if (passwordSalt.Length > 128)
                throw new BusinessRuleValidationException("Password salt must be an array of 128 bytes or below");
            _passwordSalt = passwordSalt;
        }

        public byte[] passwordSalt()
        {
            return _passwordSalt;
        }

    }
}