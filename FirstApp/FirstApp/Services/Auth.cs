using FirstApp.Models;
using FirstApp.Utils;
using System.Threading.Tasks;
namespace FirstApp.Services
{
    public class Auth : IAuth<User>
    {
        public async Task<bool> Login(User user)
        {
            if (user == null) return false;
            if (string.IsNullOrWhiteSpace(user.Email)) return false;
            if (string.IsNullOrWhiteSpace(user.Password)) return false;

            ApiConsumer consumer = new ApiConsumer();
            await consumer.PostRequest(user);

            return await Task.FromResult(false);
        }
        public async Task<bool> Logout()
        {
            return await Task.FromResult(true);
        }
    }
}
