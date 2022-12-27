using Microsoft.AspNetCore.Components.Authorization;
using NutrifoodsFrontend.UtilsFolder.ToolTip;

namespace NutrifoodsFrontend.UtilsFolder.AuthConnection;

public class Connection : IConnection
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    
    public Connection(AuthenticationStateProvider authenticationStateProvider)
    {
        _authenticationStateProvider = authenticationStateProvider;
    }

    public async Task<AuthenticationState> GetAuthenticationState()
    {
       return await _authenticationStateProvider.GetAuthenticationStateAsync();
    }
    public async Task<string> GetApiKey()
    {
        var state = await GetAuthenticationState();
        return state.User.Claims.FirstOrDefault(c => c.Type == Claims.NameIdentifier)!.Value;
    }

    public async Task<bool> IsAuthenticated()
    {
        var state = await GetAuthenticationState();
        return state.User.Identity!.IsAuthenticated;
    }

    public async Task<string> GetNickName()
    {
        var state = await GetAuthenticationState();
        return state.User.Claims.FirstOrDefault(c => c.Type == "nickname")!.Value;
    }

    public async Task<string> GetEmail()
    {
        var state = await GetAuthenticationState();
        return state.User.Claims.FirstOrDefault(c => c.Type == "name")!.Value;
    }
}