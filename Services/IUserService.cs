using NutrifoodsFrontend.Data.Dto;
using System.Reflection;
using UtilsFolder.Enums;

namespace NutrifoodsFrontend.Services
{
    public interface IUserService
    {
        Task<HttpResponseMessage?> Find(string apiKey);

        Task<HttpResponseMessage?> Save(string username, string email, string apiKey);

        /*
        public Task<HttpResponseMessage?> SavePersonalData(string apiKey, string birthdate, Gender gender,
            string? name = "", string? lastName = "", Diet diet = Diet.None, IntendedUse intendedUse = IntendedUse.None,
            UpdateFrequency updateFrequency = UpdateFrequency.None);
        */
    }
}
