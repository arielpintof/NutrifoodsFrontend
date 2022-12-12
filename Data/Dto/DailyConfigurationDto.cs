using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Data.Dto;

public class DailyConfigurationDto
{
    public bool IsLunchFilling { get; set; }
    public Satiety Breakfast { get; set; }
    public Satiety Dinner { get; set; }
}