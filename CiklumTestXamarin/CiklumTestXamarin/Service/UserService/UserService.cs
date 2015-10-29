using System.Threading.Tasks;
using CiklumTestXamarin.Models;
using CiklumTestXamarin.Service.Networking;
using Newtonsoft.Json;

namespace CiklumTestXamarin.Service.UserService
{
    public class UserService : IUserService
    {
        private const string APIAdress = "http://api.randomuser.me/";
        private readonly IRestClient _restClient = new RestClient();

        public async Task<User> GetUser()
        {
            var responce = await _restClient.GetAsync(APIAdress);
            return JsonConvert.DeserializeObject<User>(responce);
        }
    }
}
