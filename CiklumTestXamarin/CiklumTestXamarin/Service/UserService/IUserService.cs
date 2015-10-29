using System.Threading.Tasks;

namespace CiklumTestXamarin.Service.UserService
{
    public interface IUserService
    {
        Task<Models.User> GetUser();
    }
}
