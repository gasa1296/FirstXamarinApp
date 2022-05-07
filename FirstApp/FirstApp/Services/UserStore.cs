using FirstApp.Models;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public class UserStore : IUserStore
    {
        public UserStore()
        {
        }
        public async Task<User> GetUserAsync(int id)
        {
            return await Task.FromResult(new User());
        }
        public async Task<bool> AddUserAsync(User user)
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await Task.FromResult(true);
        }

    }
}
