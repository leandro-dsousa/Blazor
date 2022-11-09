using BlazorWebAssembly.Server.Domain.Shared;
using System.Text.Json.Serialization;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class UserId : EntityId
    {

        public Guid _userId { get; set; }


        public UserId() : base(string.Empty)
        {
            //for ORM
        }

        
        public UserId(Guid value) : base(value.ToString())
        {
        }

        [JsonConstructor]
        public UserId(String value) : base(value)
        {
        }

        
        protected override Object createFromString(String text)
        {
            return new Guid(text);
        }

        
        public override String AsString()
        {
            Guid obj = (Guid)base.ObjValue;
            return obj.ToString();
        }

        public Guid AsGuid()
        {
            return (Guid)base.ObjValue;
        }
    }
}