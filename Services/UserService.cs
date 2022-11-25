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

        public async Task<HttpResponseMessage?> FindByEmail(string email, string password)
        {
            return await _httpClient.GetAsync($"api/v1/users/find-by-email?email={email}&password={password}");
        }

        public async Task<HttpResponseMessage?> FindByUsername(string username, string password)
        {
            return await _httpClient.GetAsync($"api/v1/users/find-by-username?username={username}&password={password}");
        }
    }
}
