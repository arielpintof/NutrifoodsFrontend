using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage?> Find(string apiKey)
        {
            return await _httpClient.GetAsync($"api/v1/users/api-key?apiKey={apiKey}");
        }

        public async Task<HttpResponseMessage?> Save(string username, string email, string apiKey)
        {
            var user = new UserDto
            {
                Username = username,
                Email = email,
                ApiKey = apiKey
            };
            var userSerialized = JsonSerializer.Serialize(user);
            var content = new StringContent(userSerialized, Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync
                ($"api/v1/users/save-user?username={username}&email={email}&apiKey={apiKey}", content);
        }
    }
}
