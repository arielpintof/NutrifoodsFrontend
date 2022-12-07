using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Services;

public interface IDailyMealPlanService
{
    Task<HttpResponseMessage?> GenerateDailyMealPlan(double energyTarget,
        Satiety breakfast, Satiety lunch, Satiety dinner, bool? includeBrunch = false,
        bool? includeLinner = false);
}