using BlazorWebAssembly.Server.Domain.Shared;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BlazorWebAssembly.Server.Domain.UserAccounts
{
    public class AccountId
    {

        public Guid accountId { get; set; }

        public AccountId()
        {

        }

        public AccountId(Guid value) {
            accountId = value;
        }

        public AccountId(string value) {
            accountId = Guid.Parse(value);
        }
    }
}