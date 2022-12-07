
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Services;

public interface IDailyMenuService
{
    Task<HttpResponseMessage?> GenerateDailyMenu(double energyTarget, double carbsPercent, double fatsPercent,
        double proteinsPercent, MealType mealType = MealType.None, Satiety satiety = Satiety.None);

    Task<HttpResponseMessage?> GenerateDailyMenu(double energyTarget, MealType mealType = MealType.None,
        Satiety satiety = Satiety.None);

}