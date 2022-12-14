using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Domain.Shared
{

    public abstract class Entity<TEntityId>
    where TEntityId : EntityId
    {
        public TEntityId Id { get; protected set; }
    }
}
