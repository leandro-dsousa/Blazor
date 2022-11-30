using BlazorWebAssembly.Server.Domain.Users;
using BlazorWebAssembly.Server.Infraestructure.Shared;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BlazorWebAssembly.Server.Infraestructure.Users
{
    public class UserRepository //: BaseRepository<User, Guid>, IUserRepository
    {

        private readonly AppDbContext _context;

        private readonly DbSet<User> _objs;

        public UserRepository(AppDbContext context) //: base(context.Users)
        {
            _context = context;
            _objs = context.Users;
        }

        public Task<User> AddAsync(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(UserId id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetByIdsAsync(List<UserId> ids)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByUsername(string name)
        {
            return await _objs.Where(user => user.Username.Equals(name)).FirstOrDefaultAsync();
        }

        public void Remove(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
