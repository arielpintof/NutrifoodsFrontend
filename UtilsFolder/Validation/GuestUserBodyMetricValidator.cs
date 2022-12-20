using NutrifoodsFrontend.Data.Dto;
using FluentValidation;
using Newtonsoft.Json;
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.UtilsFolder.Validation;

public class GuestUserBodyMetricValidator : AbstractValidator<GuestUserDto>
{
    public GuestUserBodyMetricValidator()
    {
        RuleFor(e => e.Height).InclusiveBetween(150, 200)
            .WithMessage(e => "Por favor ingresa una altura entre 150 y 200 cm.");
        RuleFor(e => e.Weight).InclusiveBetween(45.0, 200.0)
            .WithMessage(e => "El rango aceptado es entre 45 y 200 kg.");
        RuleFor(e => e.PhysicalActivity)
            .Must(e => true);
        RuleFor(e => e.Gender)
            .Must(e => true);
        
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<GuestUserDto>.CreateWithOptions((GuestUserDto)model, x => x.IncludeProperties(propertyName)));
        return result.IsValid ? Array.Empty<string>() : result.Errors.Select(e => e.ErrorMessage);
    };
}