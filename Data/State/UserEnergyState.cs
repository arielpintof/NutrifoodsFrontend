namespace NutrifoodsFrontend.Data.State
{
    public class UserEnergyState
    {
        private double _savedUserEnergy;

        public double Property
        {
            get => _savedUserEnergy;
            set
            {
                _savedUserEnergy = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
