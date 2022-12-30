using Microsoft.AspNetCore.Components;
using MudBlazor;
using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;
using NutrifoodsFrontend.UtilsFolder.Nutrition;
using NutrifoodsFrontend.UtilsFolder.Validation;

namespace NutrifoodsFrontend.Pages.Components.Metrics;

// ReSharper disable once ClassNeverInstantiated.Global
// ReSharper disable once FieldCanBeMadeReadOnly.Local
public partial class GuestMetrics 
{
    private MudForm? _form;
    private bool _success;
    private string[] _errors = Array.Empty<string>();
    private GuestUserBodyMetricValidator _metricValidator = new();
    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    private GuestUserDto _metricModel= new();
    protected override void OnInitialized() => UserEnergyState.OnChange += StateHasChanged;

    private void ChangePropertyValue() => UserEnergyState.Property = TotalMetabolicRate.Calculate(_metricModel.Gender!, 
        (double)_metricModel.Weight!, (int)_metricModel.Height!, (int) _metricModel.Age!, _metricModel.PhysicalActivity);
    
    private static IEnumerable<GenderEnum> GenderEnumList => GenderEnum.NonNullValues;
    
    private static IEnumerable<PhysicalActivityEnum> PhysicalActivityEnumList => PhysicalActivityEnum.NonNullValues;

    void IDisposable.Dispose() => UserEnergyState.OnChange -= StateHasChanged;
    
    
}