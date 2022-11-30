using BlazorWebAssembly.Server.Domain.Shared;

namespace BlazorWebAssembly.Server.Domain.UserAccounts
{
    public class Role : IValueObject
    {
        public string name { get; set; }

        public Role()
        {
            //For ORM
        }
        public Role(string name)
        {
            this.name = name;
        }

    }
}