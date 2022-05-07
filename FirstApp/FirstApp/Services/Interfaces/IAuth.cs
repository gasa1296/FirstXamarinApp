using System.Threading.Tasks;

namespace FirstApp.Services
{
    public interface IAuth
    {
        Task<bool> Login(string Email, string Password);
        Task<bool> Logout();
    }
}