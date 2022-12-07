using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Services;

public class DailyMealPlanService : IDailyMealPlanService
{
    private readonly HttpClient _httpClient;

    public DailyMealPlanService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<HttpResponseMessage?> GenerateDailyMealPlan(double energyTarget, Satiety breakfast, Satiety lunch, Satiety dinner, bool? includeBrunch,
        bool? includeLinner)
    {
        return await _httpClient.GetAsync(
            $"api/v1/daily-menus/default-parameters?energyTarget={energyTarget}&breakfast={breakfast}&lunch={lunch}&dinner={dinner}&includeBrunch={includeBrunch}&includeLinner={includeLinner}");
    }

    
}