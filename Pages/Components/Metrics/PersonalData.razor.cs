using MudBlazor;
using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;
using NutrifoodsFrontend.UtilsFolder.ToolTip;
using NutrifoodsFrontend.UtilsFolder.Validation;

namespace NutrifoodsFrontend.Pages.Components.Metrics;

public partial class PersonalData
{
    private bool _success;
    private string[] _errors = { };
    private MudForm? _form;
    private MudDatePicker? _picker;
    private DateTime? _date = DateTime.Today;
    private UserDataValidator _userDataValidator = new();
    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    private UserDataDto _userDataModel = new();

    protected override async Task OnInitializedAsync()
    {
        var authenticationState = await AuthState.GetAuthenticationStateAsync();
        var apiKey = authenticationState.User.Claims
            .Where(c => c.Type.Equals(Claims.NameIdentifier))
            .Select(c => c.Value).FirstOrDefault() ?? string.Empty;

        var findUserResponse = await UserService.Find(apiKey);
        var userContent = await findUserResponse!.Content.ReadFromJsonAsync<UserDto>();
        if (userContent!.UserData != null)
        {
            NavigationManager.NavigateTo("/body");
        }

        await base.OnInitializedAsync();
    }

    private async Task SaveUserData()
    {
        var authenticationState = await AuthState.GetAuthenticationStateAsync();
        var apiKey = authenticationState.User.Claims
            .Where(c => c.Type.Equals(Claims.NameIdentifier))
            .Select(c => c.Value).FirstOrDefault() ?? string.Empty;

        var findUserResponse = await UserService.Find(apiKey);

        if (findUserResponse!.IsSuccessStatusCode)
        {
            var userContent = await findUserResponse.Content.ReadFromJsonAsync<UserDto>();
            if (userContent!.UserData != null)
                return;
        }

        await UserService.SavePersonalData(
            apiKey, _date!.Value.ToString("yyyy-MM-dd"), GenderEnum.FromReadableName(
                _userDataModel.Gender)!.Token, _userDataModel.Name, _userDataModel.LastName, Diet.None, 
            IntendedUseEnum.FromReadableName(_userDataModel.IntendedUse!)!.Token,
            UpdateFrequencyEnum.FromReadableName(_userDataModel.UpdateFrequency!)!.Token);
    }


}