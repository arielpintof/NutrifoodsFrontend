﻿namespace NutrifoodsFrontend.Data.Dto;

public class MenuRecipeDto
{
    public RecipeDto Recipe { get; set; } = null!;
    public int Portions { get; set; }
}