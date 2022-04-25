using FirstApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public interface IUserStore
    {
        Task<bool> AddUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
        Task<User> GetUserAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> Login(User user);
        Task<bool> Logout();
        Task<bool> UpdateUserAsync(User user);
    }
}