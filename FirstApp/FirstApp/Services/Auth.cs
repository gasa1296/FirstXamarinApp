using FirstApp.Models;
using FirstApp.Utils;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FirstApp.Services
{
    public class Auth : IAuth
    {
        private ApiConsumer consumer = new ApiConsumer();
        public async Task<bool> Login(string Email, string Password)
        {
            if (string.IsNullOrWhiteSpace(Email)) return false;
            if (string.IsNullOrWhiteSpace(Password)) return false;

            string token = await consumer.PostRequest(new LoginModel { Email = Email, Password = Password, Device = DeviceInfo.Name });
            if (token != null)
            {
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }
        public async Task<bool> Logout()
        {
            return await Task.FromResult(true);
        }
    }
}
