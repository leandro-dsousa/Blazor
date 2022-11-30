using BlazorWebAssembly.Server.Domain.Shared;

namespace BlazorWebAssembly.Server.Domain.Users
{

    public interface IUserRepository : IRepository<User, Guid>
    {
        Task<User> GetUserByUsername(string name);
    }
}
