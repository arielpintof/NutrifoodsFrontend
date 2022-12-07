using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Data.State
{
    public class WeekPlan
    {
        private List<MealPlanDto> _weekPlan = new();
        private MealPlanDto _mealPlan = new();

        public List<MealPlanDto> Property
        {
            get => _weekPlan;
            set
            {
                _weekPlan = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
