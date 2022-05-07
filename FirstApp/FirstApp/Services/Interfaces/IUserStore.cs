using FirstApp.Models;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public interface IUserStore
    {
        Task<bool> AddUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
        Task<User> GetUserAsync(int id);
        Task<bool> UpdateUserAsync(User user);
    }
}