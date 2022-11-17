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

        public async Task<List<RecipeDto>?> FilterByCarbohydrates(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/carbohydrates?lower={lowerBound}&upper={upperBound}");
        }

        public async Task<List<RecipeDto>?> FilterByEnergy(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/energy?lower={lowerBound}&upper={upperBound}");
        }

        public async Task<List<RecipeDto>?> FilterByLipids(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/lipids?lower={lowerBound}&upper={upperBound}");
        }

        public async Task<List<RecipeDto>?> FilterByPortions(int portions)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/portions/{portions}");
        }

        public async Task<List<RecipeDto>?> FilterByPortions(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/portions?lower={lowerBound}&upper={upperBound}");
        }

        public async Task<List<RecipeDto>?> FilterByPreparationTime(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/preparationTime?lower={lowerBound}&upper={upperBound}");
        }

        public async Task<List<RecipeDto>?> FilterByProteins(int lowerBound, int upperBound)
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/proteins?lower={lowerBound}&upper={upperBound}");
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

        public async Task<List<RecipeDto>?> GetPescetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/pescetarian");
        }

        public async Task<List<RecipeDto>?> GetPolloPescetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/pollo-pescetarian");
        }

        public async Task<List<RecipeDto>?> GetPollotarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/pollotarian");
        }

        public async Task<List<RecipeDto>?> GetVegetarianRecipes()
        {
            return await _httpClient.GetFromJsonAsync<List<RecipeDto>?>
                ($"api/v1/recipes/vegetarian"); ;
        }
    }
}
