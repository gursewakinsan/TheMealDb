using TheMealDB.Service;
using System.Windows.Input;
using TheMealDB.Interfaces;

namespace TheMealDB.ViewModels
{
    public class MealDetailsPageViewModel : BaseViewModel
    {
        #region Constructor.
        public MealDetailsPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Meal Details Command.
        private ICommand mealDetailsCommand;
        public ICommand MealDetailsCommand
        {
            get => mealDetailsCommand ?? (mealDetailsCommand = new Command(async () => await ExecuteMealDetailsCommand()));
        }
        private async Task ExecuteMealDetailsCommand()
        {
            ICategoryService service = new CategoryService();
            var response = await service.MealDetailsAsync(SelectedMeal.idMeal);
            if (response != null)
                MealDetail = response.meals[0];
        }
        #endregion

        #region Properties.
        private Models.MealDetail mealDetail;
        public Models.MealDetail MealDetail
        {
            get => mealDetail;
            set
            {
                mealDetail = value;
                OnPropertyChanged("MealDetail");
            }
        }

        public Models.Meal SelectedMeal => Helper.Helper.SelectedMeal;
        #endregion
    }
}
