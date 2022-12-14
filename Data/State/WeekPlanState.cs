using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Data.State
{
    public class WeekPlanState
    {
        private List<DailyMealPlanDto> _weekPlan = new();

        public List<DailyMealPlanDto> Property
        {
            get => _weekPlan;
            set
            {
                _weekPlan = value;
                
                NotifyStateChanged();
            }
        }
        public void AddDailyMealPlan(DailyMealPlanDto dailyMealPlan)
        {
            if(_weekPlan.Count >= 7)
            {
                throw new Exception("La lista de planes ya está completa (7 elementos)");
            }

            _weekPlan.Add(dailyMealPlan);
            NotifyStateChanged();
        }
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
