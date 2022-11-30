namespace NutrifoodsFrontend.Data.Dto;

public class GuestUserDto
{
    public int? Height { get; set; }
    public int? Weight { get; set; }
    public int? Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string PhysicalActivity { get; set; } = null!;
}