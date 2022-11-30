using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Domain.Shared
{
    public interface IRepository<TEntity, TEntityId>
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TEntityId id);
        Task<List<TEntity>> GetByIdsAsync(List<TEntityId> ids);
        Task<TEntity> AddAsync(TEntity obj);
        void Remove(TEntity obj);
    }

}
