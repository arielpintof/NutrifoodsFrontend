using NutrifoodsFrontend.Data.Dto.Abridged;

namespace NutrifoodsFrontend.Data.Dto;

public class RecipeMeasureDto
{
    public int IntegerPart { get; set; }
    public int Numerator { get; set; }
    public int Denominator { get; set; }
    public IngredientMeasureAbridged IngredientMeasure { get; set; } = null!;
}