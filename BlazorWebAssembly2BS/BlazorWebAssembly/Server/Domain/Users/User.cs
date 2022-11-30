using BlazorWebAssembly.Server.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace BlazorWebAssembly.Server.Domain.Users
{

    public class User //: Entity<Guid>, IAggregateRoot
    {

        [Key]
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Username Username { get; set; }

        //public PasswordHash PasswordHash { get; set; }

        //public PasswordSalt PasswordSalt { get; set; }
        [Required]
        public Password Password { get; set; }


        public User()
        {
            //For ORM
        }

        public User(Guid id, Username username, Password password)
        {
            UserId = id;
            Username = username;
            Password = password;
            //CreatePasswordHash(password._password, out byte[] passwordHash, out byte[] passwordSalt);
            //PasswordHash._passwordHash = passwordHash;
            //PasswordSalt._passwordSalt = passwordSalt;
            //PasswordHash = new PasswordHash(new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 });
            //PasswordSalt = new PasswordSalt(new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 });
        }

        /*
         * Duplicated code
         */
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }


    }
}
