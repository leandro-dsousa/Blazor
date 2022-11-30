using BlazorWebAssembly.Server.Domain.Shared;

namespace BlazorWebAssembly.Server.Domain.UserAccounts
{
    public interface IUserAccountRepository : IRepository<UserAccount, AccountId>
    {
        UserAccount? GetUserAccountByUsername(string userName);
    }
}