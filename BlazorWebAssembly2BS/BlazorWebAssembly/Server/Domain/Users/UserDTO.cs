using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class UserDTO
    {

        public UserId UserId { get; set; } = new UserId(new Guid());

        public Username UserName { get; set; } = new Username();

        public Password Password { get; set; } = new Password();    

        public PasswordHash PasswordHash { get; set; } = new PasswordHash(); 

        public PasswordSalt PasswordSalt { get; set; } = new PasswordSalt(); 


    }
}
