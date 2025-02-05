namespace Refactor.Interface
{
    public interface IUserService
    {
        Task<string> WelcomeUser(string userName);
    }
}
