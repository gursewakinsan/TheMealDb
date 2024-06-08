using System.Net;
using TheMealDB.Interfaces;

namespace TheMealDB.Service
{
    public class CategoryService : ICategoryService
    {
        public Task<Models.CategoryResponse> GetCategoryAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                var res = RestClient.Get<Models.CategoryResponse>(HttpWebRequest.Create(string.Format(EndPointsList.CategoriesUrl)));
                return res;
            });
        }

        public Task<Models.MealResponse> GetMealsAsync(string meal)
        {
            return Task.Factory.StartNew(() =>
            {
                var res = RestClient.Get<Models.MealResponse>(HttpWebRequest.Create(string.Format(EndPointsList.MealUrl, meal)));
                return res;
            });
        }

        public Task<Models.MealDetailResponse> MealDetailsAsync(string mealId)
        {
            return Task.Factory.StartNew(() =>
            {
                var res = RestClient.Get<Models.MealDetailResponse>(HttpWebRequest.Create(string.Format(EndPointsList.MealDetailsUrl, mealId)));
                return res;
            });
        }
    }
}
