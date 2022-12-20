using FluentValidation;
using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.UtilsFolder.Validation;

public class UserBodyMetricValidator : AbstractValidator<UserBodyMetricDto>
{
    public UserBodyMetricValidator()
    {
        RuleFor(e => e.Height).InclusiveBetween(150, 200)
            .WithMessage(e => "El rango aceptado es entre 150 y 200 cm.");
        RuleFor(e => e.Weight).InclusiveBetween(45.0, 200.0)
            .WithMessage(e => "El rango aceptado es entre 45 y 200 kg.");
        RuleFor(e => e.PhysicalActivity)
            .Must(e => PhysicalActivityEnum.FromReadableName(e) != null);
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<UserBodyMetricDto>.CreateWithOptions((UserBodyMetricDto)model, x => x.IncludeProperties(propertyName)));
        return result.IsValid ? Array.Empty<string>() : result.Errors.Select(e => e.ErrorMessage);
    };
}