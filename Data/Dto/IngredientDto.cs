namespace NutrifoodsFrontend.Data.Dto;

public class IngredientDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsAnimal { get; set; }
    public bool ContainsGluten { get; set; }
    public TertiaryGroupDto TertiaryGroup { get; set; } = null!;
    public IEnumerable<IngredientMeasureDto> IngredientMeasures { get; set; } = null!;
    public IEnumerable<IngredientNutrientDto> IngredientNutrients { get; set; } = null!;
}