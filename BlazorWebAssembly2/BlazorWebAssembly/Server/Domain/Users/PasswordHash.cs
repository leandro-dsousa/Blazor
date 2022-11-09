using BlazorWebAssembly.Server.Domain.Shared;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class PasswordHash
    {

        public byte[] _passwordHash { get; set; } = new byte[128];

        public PasswordHash()
        {
        }

        public PasswordHash(byte[] passwordHash)
        {
            if (passwordHash.Length > 128)
                throw new BusinessRuleValidationException("Password hash must be an array of 128 bytes or below");
            _passwordHash = passwordHash;
        }

        public byte[] passwordHash()
        {
            return _passwordHash;
        }

    }
}