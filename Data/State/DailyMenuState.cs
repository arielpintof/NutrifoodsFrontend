using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Data.State;

public class DailyMenuState
{
    private DailyMenuDto _savedDailyMenu;

    public DailyMenuDto Property
    {
        get => _savedDailyMenu;
        set
        {
            _savedDailyMenu = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
