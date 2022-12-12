using NutrifoodsFrontend.Data.Dto;
using NutrifoodsFrontend.UtilsFolder.Enums;

namespace NutrifoodsFrontend.Data.State;

public class DailyConfigurationState
{
    private DailyConfigurationDto _savedDailyConfiguration;

    public DailyConfigurationDto Property
    {
        get => _savedDailyConfiguration;
        set
        {
            _savedDailyConfiguration = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}