using MudBlazor;
using NutrifoodsFrontend.UtilsFolder.Enums;
using NutrifoodsFrontend.UtilsFolder.Nutrition;

namespace NutrifoodsFrontend.Pages.Components.Metrics;

// ReSharper disable once ClassNeverInstantiated.Global
public partial class GuestMetrics
{
    private MudForm? _form;
    private bool _success;
    private string[] _errors = { };
    private double? _weightValue;
    private int? _heightValue;
    private int? _ageValue;
    private GenderEnum? _genderValue;
    private PhysicalActivityEnum? _physicalValue;
    
    protected override void OnInitialized() => UserEnergyState.OnChange += StateHasChanged;

    private void ChangePropertyValue() => UserEnergyState.Property = TotalMetabolicRate.Calculate(_genderValue!, (double) _weightValue!, 
        (int)_heightValue!, (int)_ageValue!, PhysicalActivityEnum.Active);
    
    private static IEnumerable<GenderEnum> GenderEnumList => GenderEnum.NonNullValues;
    
    private static IEnumerable<PhysicalActivityEnum> PhysicalActivityEnumList => PhysicalActivityEnum.NonNullValues;

    void IDisposable.Dispose() => UserEnergyState.OnChange -= StateHasChanged;
}