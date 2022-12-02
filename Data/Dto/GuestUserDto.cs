namespace NutrifoodsFrontend.Data.Dto;

public class GuestUserDto
{
    public int Height { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string PhysicalActivity { get; set; } = null!;
}