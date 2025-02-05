using Refactor.Entities;
using Refactor.Interface;

namespace Refactor.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IList<User> _dbSet { get; set; } = new List<User>()
        {
            new() { Name = "John", Id = 1 },
            new() { Name = "Tris", Id =2 },
            new() { Name = "Caleb", Id =3  }
        };
        public User GetUser(string userName)
        {
            var user = _dbSet.FirstOrDefault(u => u.Name == userName);
            if (user == null)
                throw new ArgumentNullException("User not found");
            return user;            
        }
    }
}
