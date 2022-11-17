namespace NutrifoodsFrontend.Data.Dto;

public class MealMenuRecipeDto
{
    public RecipeDto Recipe { get; set; } = null!;
    public int Quantity { get; set; }
}