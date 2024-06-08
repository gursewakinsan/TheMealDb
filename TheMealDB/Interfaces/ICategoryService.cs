namespace TheMealDB.Interfaces
{
    public interface ICategoryService
    {
        Task<Models.CategoryResponse> GetCategoryAsync();
        Task<Models.MealResponse> GetMealsAsync(string meal);
        Task<Models.MealDetailResponse> MealDetailsAsync(string mealId);
    }
}
