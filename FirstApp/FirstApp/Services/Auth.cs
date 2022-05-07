using FirstApp.Models;
using FirstApp.Utils;
using System.Diagnostics;
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

            Debug.WriteLine("Creating Consumer");
            ApiConsumer consumer = new ApiConsumer();
            if (await consumer.PostRequest(user) != null)
                return await Task.FromResult(true);

            return await Task.FromResult(false);
        }
        public async Task<bool> Logout()
        {
            return await Task.FromResult(true);
        }
    }
}
