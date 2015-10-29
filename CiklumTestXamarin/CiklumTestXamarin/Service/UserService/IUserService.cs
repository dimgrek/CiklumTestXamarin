using System.Threading.Tasks;
using CiklumTestXamarin.Models;

namespace CiklumTestXamarin.Service.UserService
{
    public interface IUserService
    {
        Task<Result> GetUser();
    }
}
