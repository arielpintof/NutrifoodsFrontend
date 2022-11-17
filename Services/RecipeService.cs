using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly HttpClient _httpClient;
        public RecipeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<RecipeDto>?> FilterByCarbohydrates(int lowerBound, int upperBound)
        {
            throw new NotImplementedException();
        }

        //PENDIENTE
        public async Task<List<RecipeDto>?> FilterByEnergy(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>($"api/v1/recipes/energy?=");
        }

        public Task<List<RecipeDto>?> FilterByLipids(int lowerBound, int upperBound)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RecipeDto>?> FilterByPortions(int portions)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/portions/{portions}");
        }

        public async Task<List<RecipeDto>?> FilterByPortions(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/portions/?lower={lowerBound}&upper={upperBound}");
        }

        public Task<List<RecipeDto>?> FilterByPreparationTime(int lowerBound, int upperBound)
        {
            throw new NotImplementedException();
        }

        public Task<List<RecipeDto>?> FilterByProteins(int lowerBound, int upperBound)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RecipeDto>?> FindAll()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes");
        }

        public async Task<RecipeDto?> FindById(int id)
        {
            return await _httpClient.GetFromJsonAsync<RecipeDto?>
                ($"api/v1/recipes/id/{id}");
        }

        public async Task<RecipeDto?> FindByName(string name)
        {
            return await _httpClient.GetFromJsonAsync<RecipeDto?>
                ($"api/v1/recipes/name/{name}");
        }

        public async Task<List<RecipeDto>?> GetLactoVegetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/lacto-vegetarian");
        }

        public async Task<List<RecipeDto>?> GetOvoLactoVegetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/ovo-lacto-vegetarian");
        }

        public async Task<List<RecipeDto>?> GetOvoVegetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/ovo-vegetarian");
        }

        public Task<List<RecipeDto>?> GetPescetarianRecipes()
        {
            throw new NotImplementedException();
        }

        public Task<List<RecipeDto>?> GetPolloPescetarianRecipes()
        {
            throw new NotImplementedException();
        }

        public Task<List<RecipeDto>?> GetPollotarianRecipes()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RecipeDto>?> GetVegetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/vegetarian"); ;
        }
    }
}
