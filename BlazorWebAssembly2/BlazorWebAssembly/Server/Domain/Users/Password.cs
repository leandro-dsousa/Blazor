using BlazorWebAssembly.Server.Domain.Shared;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class Password : IValueObject
    {

        public string password { get; set; } = string.Empty;

        public Password()
        {
            //For ORM
        }

        public Password(string password)
        {
            this.password = password;
        }

    }
}