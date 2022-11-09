using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [Required]
        public string NIF { get; set; }

        public string phoneNumber { get; set; }

        public DateTime createdIn { get; set; }

        public Client()
        {
            //For ORM purposes
        }

        public Client(string name, string lastname, string nif, string phonenumber)
        {
            Id = new Guid();
            Name = name;
            Last_Name = lastname;
            NIF = nif;
            phoneNumber = phonenumber;
            createdIn = DateTime.Now;
        }
    }
}
