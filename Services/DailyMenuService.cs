using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;


namespace NutrifoodsFrontend.Services;

public class DailyMenuService : IDailyMenuService
{
    private readonly HttpClient _httpClient;

    public DailyMenuService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<HttpResponseMessage?> GenerateDailyMenu(double energyTarget, double carbsPercent, double fatsPercent, double proteinsPercent,
        MealType mealType = MealType.None, Satiety satiety = Satiety.None)
    {
        return await _httpClient.GetAsync($"api/v1/daily-meals/custom-percentages?energyTarget={energyTarget}&carbsPercent={carbsPercent}&fatsPercent={fatsPercent}&proteinsPercent={proteinsPercent}&mealType={mealType}&satiety={satiety}");
    }

    public async Task<HttpResponseMessage?> GenerateDailyMenu(double energyTarget, MealType mealType = MealType.None, 
        Satiety satiety = Satiety.None)
    {
        return await _httpClient.GetAsync($"api/v1/daily-meals/default-percentages?energyTarget={energyTarget}&mealType={mealType}&satiety={satiety}");
    }
}