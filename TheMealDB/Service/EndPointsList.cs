namespace TheMealDB.Service
{
    public class EndPointsList
    {
        public const string CategoriesUrl = "https://www.themealdb.com/api/json/v1/1/categories.php";
        public const string MealUrl = "https://www.themealdb.com/api/json/v1/1/filter.php?c={0}";
        public const string MealDetailsUrl = "https://www.themealdb.com/api/json/v1/1/lookup.php?i={0}";
    }
}
