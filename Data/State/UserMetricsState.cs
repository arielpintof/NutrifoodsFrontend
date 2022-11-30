using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Data
{
    public class UserMetricsState
    {
        private GuestUserDto? _savedUserData;

        public GuestUserDto? Property
        {
            get => _savedUserData;
            set
            {
                _savedUserData = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
