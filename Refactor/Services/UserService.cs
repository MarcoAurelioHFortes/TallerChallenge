using Refactor.Interface;
using System.Text;

namespace Refactor.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<string> WelcomeUser(string userName)
        {
            try
            {
                var user = _userRepository.GetUser(userName);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Welcome to the Employer Portal");
                sb.AppendLine($"Hello, {user.Name}");

                return Task.FromResult(sb.ToString());
            }
            catch (Exception ex)
            {
                //LOG
                throw;
            }
        }
    }
}
