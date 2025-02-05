using Refactor.Entities;

namespace Refactor.Interface
{
    public interface IUserRepository
    {
        User GetUser(string userName);
    }
}
