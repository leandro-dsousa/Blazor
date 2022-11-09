using BlazorWebAssembly.Server.Domain.Shared;
using BlazorWebAssembly.Server.Domain.Users;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssembly.Server.Domain.UserAccounts
{
    public class UserAccount : IAggregateRoot
    {

        public Guid accountId { get; set; }

        public Username userName { get; set; }

        public Password password { get; set; }

        public Role role { get; set; }

        public UserAccount() {
            //For ORM
        }

        public UserAccount(string userName, string password, string role)
        {
            accountId = Guid.NewGuid();
            this.userName = new Username(userName);
            this.password = new Password(password);
            this.role = new Role(role);
        }

        public Username UserName()
        {
            return this.userName;
        }

        public Password Password()
        {
            return this.password;
        }
        public Role Role()
        {
            return this.role;
        }
    }
}
