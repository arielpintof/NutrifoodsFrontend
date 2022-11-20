﻿namespace NutrifoodsFrontend.Data.Dto;

public class NutrientSubtypeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool ProvidesEnergy { get; set; }
    public NutrientTypeDto Type { get; set; } = null!;
}