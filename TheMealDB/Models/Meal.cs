namespace TheMealDB.Models
{
    public class Meal
    {
        public string strMeal { get; set; }
        public string strMealThumb { get; set; }
        public string idMeal { get; set; }
    }

    public class MealResponse
    {
        public List<Meal> meals { get; set; }
    }
}
