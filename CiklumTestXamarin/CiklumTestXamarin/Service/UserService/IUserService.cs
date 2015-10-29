using System.Threading.Tasks;

namespace CiklumTestXamarin.Service.User
{
    public interface IUserService
    {
        Task<UserService> GetUser();
    }
}
