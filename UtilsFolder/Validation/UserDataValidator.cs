using System.Globalization;
using FluentValidation;
using Newtonsoft.Json;
using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Date;
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.UtilsFolder.Validation;

public class UserDataValidator : AbstractValidator<UserDataDto>
{
    public UserDataValidator()
    {
        // Name
        RuleFor(e => e.Name)
            .Must(e => !string.IsNullOrWhiteSpace(e) && e.Length >= 2)
            .WithMessage(e => "No puede contener espacios en blanco ni ser menor a 2 caracteres");

        // Last name
        RuleFor(e => e.LastName)
            .Must(e => !string.IsNullOrWhiteSpace(e) && e.Length >= 2)
            .WithMessage(e => "No puede contener espacios en blanco ni ser menor a 2 caracteres");

        //Birthdate
        /*RuleFor(e => e.Birthdate).Custom((str, context) =>
        {
            if (!DateOnly.TryParseExact(str, DateOnlyUtils.AllowedFormats, null, DateTimeStyles.None, out var date))
            {
                context.AddFailure(
                    $@"Provided argument “{str}” does not correspond to a valid date.
Recognized formats are:
{string.Join('\n', DateOnlyUtils.AllowedFormats)}");
                return;
            }

            var age = DateOnlyUtils.Difference(date, Interval.Years, false);
            switch (age)
            {
                case < 0:
                    context.AddFailure(
                        "User's date of birth can't be greater than current date (User's birth date: {str} - Current date: {DateOnlyUtils.ToDateOnly(DateTime.Now)})");
                    break;
                case < 18 or > 60:
                    context.AddFailure(
                        $"User's age is not in allowed range (User's birth date: {str} - User's age: {age} years old - Allowed age range: 18-60 years old");
                    break;
            }
        });*/

        // Gender
        RuleFor(e => e.Gender)
            .Must(e => GenderEnum.FromReadableName(e!) != null);

        // Diet
        RuleFor(e => e.Diet)
            .Must(e => DietEnum.FromReadableName(e!) != null)
            .WithMessage(e =>
                $@" Provided argument “{e}” does not correspond to a valid diet value. Recognized values are:
{string.Join('\n', DietEnum.List)}");

        // Intended Use
        RuleFor(e => e.IntendedUse)
            .Must(e => IntendedUseEnum.FromReadableName(e!) != null);

        // Update frequency
        RuleFor(e => e.UpdateFrequency)
            .Must(e => UpdateFrequencyEnum.FromReadableName(e!) != null);
    }


public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<UserDataDto>.CreateWithOptions((UserDataDto)model, x => x.IncludeProperties(propertyName)));
        return result.IsValid ? Array.Empty<string>() : result.Errors.Select(e => e.ErrorMessage);
    };

    
}