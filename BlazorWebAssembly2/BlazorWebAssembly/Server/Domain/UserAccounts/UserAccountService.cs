using BlazorWebAssembly.Server.Domain.Users;
using BlazorWebAssembly.Server.Domain.UserAccounts;

namespace BlazorWebAssembly.Server.Domain.UserAccounts
{
    public class UserAccountService
    {

        private readonly IUserAccountRepository _userAccountRepo;

        public UserAccountService()
        {
            //For ORM
        }

        public UserAccountService( IUserAccountRepository userAccountRepo)
        {
            _userAccountRepo = userAccountRepo;
        }

        public UserAccount? GetUserAccountByUsername(string userName)
        {
            return _userAccountRepo.GetUserAccountByUsername(userName);
        }

    }
}
