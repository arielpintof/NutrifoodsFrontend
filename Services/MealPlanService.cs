using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Services
{
    public class MealPlanService : IMealPlanService
    {
        private readonly HttpClient _httpClient;
        public MealPlanService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MealPlanDto?> GenerateBasedOnMbr(double totalMetabolicRate, string isLunchFilling, string breakfastSatiety, string dinnerSatiety)
        {
            return await _httpClient.GetFromJsonAsync<MealPlanDto?>
                ($"api/v1/meal-plans/mbr-based?totalMetabolicRate={totalMetabolicRate}&isLunchFilling={isLunchFilling}&breakfastSatiety={breakfastSatiety}&dinnerSatiety={dinnerSatiety}");
        }

        public async Task<MealPlanDto?> GenerateBasedOnMetrics(string gender, int height, double weight, int age, string physicalActivity, string isLunchFilling, string breakfastSatiety, string dinnerSatiety)
        {
            return await _httpClient.GetFromJsonAsync<MealPlanDto?>
                ($"api/v1/meal-plans/metrics-based?gender={gender}&height={height}&weight={weight}&age={age}&physicalActivity={physicalActivity}&isLunchFilling={isLunchFilling}&breakfastSatiety={breakfastSatiety}&dinnerSatiety={dinnerSatiety}");
        }
    }
}
