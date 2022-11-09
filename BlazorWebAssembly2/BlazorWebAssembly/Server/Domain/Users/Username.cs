using BlazorWebAssembly.Server.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class Username : IValueObject
    {
        public string username { get; set; } = String.Empty;

        
        public Username(String username) 
        {
            this.username = username;
        }

        public Username()
        {
        }
    }
}

