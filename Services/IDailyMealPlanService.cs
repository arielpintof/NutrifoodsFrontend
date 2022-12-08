using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Services;

public interface IDailyMealPlanService
{
    Task<HttpResponseMessage?> GenerateDailyMealPlan(double energyTarget,
        bool isLunchFilling, Satiety breakfast, Satiety dinner,
        bool? includeBrunch = false, bool? includeLinner = false, DayOfTheWeek? dayOfWeek = DayOfTheWeek.None);
}