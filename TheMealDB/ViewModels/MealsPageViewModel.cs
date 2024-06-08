using TheMealDB.Service;
using System.Windows.Input;
using TheMealDB.Interfaces;

namespace TheMealDB.ViewModels
{
    public class MealsPageViewModel : BaseViewModel
    {
        #region Constructor.
        public MealsPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Get Meals Command.
        private ICommand getMealsCommand;
        public ICommand GetMealsCommand
        {
            get => getMealsCommand ?? (getMealsCommand = new Command(async () => await ExecuteGetMealsCommand()));
        }
        private async Task ExecuteGetMealsCommand()
        {
            ICategoryService service = new CategoryService();
            Meal = await service.GetMealsAsync(SelectedCategory.strCategory);
        }
        #endregion

        #region Properties.
        private Models.MealResponse meal;
        public Models.MealResponse Meal
        {
            get => meal;
            set
            {
                meal = value;
                OnPropertyChanged("Meal");
            }
        }

        public Models.Category SelectedCategory => Helper.Helper.SelectedCategory;
        #endregion
    }
}
