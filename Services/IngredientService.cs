using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using NutrifoodsFrontend.Data.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using System.Xml.Linq;

namespace NutrifoodsFrontend.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly HttpClient _httpClient;
        public IngredientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<IngredientDto>?> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>("api/v1/ingredients");
        }

        public async Task<IngredientDto?> FindByName(string name)
        {
                return await _httpClient.GetFromJsonAsync<IngredientDto?>($"api/v1/ingredients/name/{name}");
        }

        public async Task<IngredientDto?> FindById(int id)
        {
            return await _httpClient.GetFromJsonAsync<IngredientDto?>($"api/v1/ingredients/id/{id}");
        }

        public async Task<ICollection<IngredientDto>?> FindByPrimaryGroup(string name)
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>($"api/v1/ingredients/primaryGroup/{name}");
        }

        public async Task<ICollection<IngredientDto>?> FindByPrimaryGroup(int id)
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>($"api/v1/ingredients/primaryGroup/{id}");
        }

        public async Task<ICollection<IngredientDto>?> FindBySecondaryGroup(string name)
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>($"api/v1/ingredients/secondaryGroup/{name}");
        }

        public async Task<ICollection<IngredientDto>?> FindBySecondaryGroup(int id)
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>($"api/v1/ingredients/secondaryGroup/{id}");
        }

        public async Task<ICollection<IngredientDto>?> FindByTertiaryGroup(string name)
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>($"api/v1/ingredients/tertiaryGroup/{name}");
        }

        public async Task<ICollection<IngredientDto>?> FindByTertiaryGroup(int id)
        {
            return await _httpClient.GetFromJsonAsync<ICollection<IngredientDto>?>($"api/v1/ingredients/tertiaryGroup/{id}");
        }
    }
}
