using BlazorWebAssembly.Server.Domain.UserAccounts;
using BlazorWebAssembly.Server.Infraestructure.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssembly.Server.Infraestructure.UserAccounts
{
    public class UserAccountRepository : IUserAccountRepository
    {

        private readonly AppDbContext _context;

        private readonly DbSet<UserAccount> _objs;

        public UserAccountRepository(AppDbContext context) 
        {
            _context = context;
            _objs = context.UserAccounts;
        }

        public Task<UserAccount> AddAsync(UserAccount obj)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserAccount>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserAccount> GetByIdAsync(AccountId id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserAccount>> GetByIdsAsync(List<AccountId> ids)
        {
            throw new NotImplementedException();
        }

        public UserAccount? GetUserAccountByUsername(string userName)
        {
            return this._objs.Where(x => x.userName.username == userName).FirstOrDefault();
        }

        public void Remove(UserAccount obj)
        {
            throw new NotImplementedException();
        }
    }
}
