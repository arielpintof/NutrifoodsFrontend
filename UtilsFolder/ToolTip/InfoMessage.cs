namespace NutrifoodsFrontend.UtilsFolder.ToolTip
{
    public static class InfoMessage
    {
        public const string DailyConfiguration = "Modifica la cantidad de comidas y sus contundencias";

        public const string UserWarning = "Tu proceso de registro está incompleto";
        
        public static string RegenerateMealMenu(string mealType)
        {
            return $"Regenera para obtener nuevas recetas de {mealType}";
        }


        public const string IndexImage =
            "https://o.remove.bg/downloads/cad9602f-c1c8-4a3b-82ab-98f49c7b4c85/png-clipart-fruit-" +
            "healthy-diet-food-healthy-girl-natural-foods-food-removebg-preview.png";
    }
}
