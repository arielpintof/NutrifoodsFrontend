using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Data
{
    public class StateContainer
    {
        private UserBodyMetricDto? savedUserData;

        public UserBodyMetricDto Property
        {
            get => savedUserData;
            set
            {
                savedUserData = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
