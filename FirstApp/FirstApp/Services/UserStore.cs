using FirstApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public class UserStore : IUserStore
    {
        private readonly List<User> users;
        public UserStore()
        {

            users = new List<User>()
                {
                    new User {Id = 1, Name = "1 User", Email = "a@g.com", Password = "12345678" },
                    new User {Id = 2, Name = "2 User", Email = "s@g.com", Password = "12345678" },
                    new User {Id = 3, Name = "3 User", Email = "d@g.com", Password = "12345678" },
                    new User {Id = 4, Name = "4 User", Email = "f@g.com", Password = "12345678" },
                    new User {Id = 5, Name = "5 User", Email = "g@g.com", Password = "12345678" },
                    new User {Id = 6, Name = "6 User", Email = "h@g.com", Password = "12345678" }
                };
        }
        public async Task<bool> AddUserAsync(User user)
        {
            users.Add(user);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var oldUser = users.Where((User arg) => arg.Id == user.Id).FirstOrDefault();
            users.Remove(oldUser);
            users.Add(user);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var oldItem = users.Where((User arg) => arg.Id == id).FirstOrDefault();
            users.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await Task.FromResult(users.FirstOrDefault(user => user.Id == id));
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await Task.FromResult(users);
        }

        public async Task<bool> Login(User user)
        {
            if (user == null) return false;
            if (string.IsNullOrWhiteSpace(user.Email)) return false;
            if (string.IsNullOrWhiteSpace(user.Password)) return false;

            bool exist = users.Where(arg => arg.Email == user.Email && arg.Password == user.Password).FirstOrDefault() != null;
            return await Task.FromResult(exist);
        }
        public async Task<bool> Logout()
        {
            return await Task.FromResult(true);
        }
    }
}
