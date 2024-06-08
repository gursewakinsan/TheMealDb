namespace TheMealDB.Models
{
    public class MealDetail
    {
        public string strMeal { get; set; }
        public string strMealThumb { get; set; }
        public string strInstructions { get; set; }
    }

    public class MealDetailResponse
    {
        public List<MealDetail> meals { get; set; }
    }
}
