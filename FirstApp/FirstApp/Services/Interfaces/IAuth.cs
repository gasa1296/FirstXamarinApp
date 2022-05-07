using System.Threading.Tasks;

namespace FirstApp.Services
{
    public interface IAuth<T>
    {
        Task<bool> Login(T user);
        Task<bool> Logout();
    }
}