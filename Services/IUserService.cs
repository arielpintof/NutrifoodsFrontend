using NutrifoodsFrontend.Data.Dto;
using System.Reflection;

namespace NutrifoodsFrontend.Services
{
    public interface IUserService
    {
        Task<HttpResponseMessage?> Find(string apiKey);

        Task<HttpResponseMessage?> FindByUsername(string username, string password);

        Task<HttpResponseMessage?> FindByEmail(string email, string password);

        /*
        public Task<UserDto?> SaveUser(string username, string email, string password, string? name, string? lastName,
            DateOnly birthDate, Gender gender);

        public Task<UserDto?> SaveBodyMetrics(string apiKey, int height, double weight, PhysicalActivity level,
            double? muscleMassPercentage);
        */
    }
}
