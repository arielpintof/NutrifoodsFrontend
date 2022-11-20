using NutrifoodsFrontend.Data.Dto;
using System.ComponentModel.DataAnnotations;

namespace NutrifoodsFrontend.Services
{
    public interface IMealPlanService
    {
        Task<MealPlanDto?> GenerateBasedOnMetrics(string gender, int height,
        double weight, int age, string physicalActivity,
        string isLunchFilling, string breakfastSatiety, string dinnerSatiety);

        Task<MealPlanDto?> GenerateBasedOnMbr(double totalMetabolicRate, string isLunchFilling, string breakfastSatiety,
            string dinnerSatiety);
    }
}
