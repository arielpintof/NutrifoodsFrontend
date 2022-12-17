using NutrifoodsFrontend.Data.Dto;

namespace NutrifoodsFrontend.Data.State
{
    public class WeekPlanState
    {
        public List<DailyMealPlanDto> WeekPlan { get; } = new();
        
        public void AddDailyMealPlan(DailyMealPlanDto dailyMealPlan)
        {
            WeekPlan.Add(dailyMealPlan);
            NotifyStateChanged();

        }
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
