using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Services;

public class DailyMealPlanService : IDailyMealPlanService
{
    private readonly HttpClient _httpClient;

    public DailyMealPlanService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<HttpResponseMessage?> GenerateDailyMealPlan(double energyTarget,
        bool isLunchFilling, Satiety breakfast, Satiety dinner,
        bool? includeBrunch = false, bool? includeLinner = false, DayOfTheWeek? dayOfWeek = DayOfTheWeek.None)
    {
        return await _httpClient.GetAsync(
            $"api/v1/daily-menus/default-parameters?energyTarget={energyTarget}&isLunchFilling={isLunchFilling}&breakfast={breakfast}&dinner={dinner}&includeBrunch={includeBrunch}&includeLinner={includeLinner}&dayOfWeek={dayOfWeek}");
    }

    
}