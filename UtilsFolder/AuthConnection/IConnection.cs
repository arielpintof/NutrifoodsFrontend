using Microsoft.AspNetCore.Components.Authorization;

namespace NutrifoodsFrontend.UtilsFolder.AuthConnection;

public interface IConnection
{
    Task<AuthenticationState> GetAuthenticationState();
    public Task<string> GetApiKey();
    public Task<bool> IsAuthenticated();
    public Task<string> GetNickName();
    public Task<string> GetEmail();
}