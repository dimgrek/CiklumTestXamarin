using System.Threading.Tasks;

namespace CiklumTestXamarin.Service.Networking
{
    public interface IRestClient
    {
        Task<string> GetAsync(string uri);
    }
}
