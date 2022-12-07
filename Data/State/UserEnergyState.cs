namespace NutrifoodsFrontend.Data.State
{
    public class UserEnergyState
    {
        private double _savedUserData;

        public double Property
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
