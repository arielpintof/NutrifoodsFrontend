using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Data.Dto;

public class GuestUserDto
{
    public int? Height { get; set; }
    public double? Weight { get; set; }
    public int? Age { get; set; }
    public GenderEnum? Gender { get; set; }
    public PhysicalActivityEnum PhysicalActivity { get; set; } = null!;
}