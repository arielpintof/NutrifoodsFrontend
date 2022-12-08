﻿namespace NutrifoodsFrontend.Data.Dto;

public class DailyMenuDto
{
    public string MealType { get; set; } = null!;
    public string Satiety { get; set; } = null!;
    public double EnergyTotal { get; set; }
    public double CarbohydratesTotal { get; set; }
    public double LipidsTotal { get; set; }
    public double ProteinsTotal { get; set; }
    public IList<DailyMenuNutrientDto> Nutrients { get; set; } = null!;
    public IList<MenuRecipeDto> MenuRecipes { get; set; } = null!;
}