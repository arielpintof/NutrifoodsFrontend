using NutrifoodsFrontend.Data.Dto.Abridged;

namespace NutrifoodsFrontend.Data.Dto;

public class RecipeQuantityDto
{
    public IngredientAbridged Ingredient { get; set; } = null!;
    public double Grams { get; set; }
    public string Description { get; set; } = string.Empty;
}