using BlazorWebAssembly.Server.Domain.UserAccounts;

namespace BlazorWebAssembly.Server.Domain.Users
{
    public class UserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IUserAccountRepository _userAccountRepo;

        public UserService()
        {
            //For ORM
        }

        public UserService(IUserRepository userRepository, IUserAccountRepository userAccountRepo)
        {
            _userRepository = userRepository;
            _userAccountRepo = userAccountRepo;
        }

        public UserAccount? GetUserAccountByUsername(string userName)
        {
            return _userAccountRepo.GetUserAccountByUsername(userName);
        }

    }
}
