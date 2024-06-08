using TheMealDB.Service;
using System.Windows.Input;
using TheMealDB.Interfaces;

namespace TheMealDB.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        #region Constructor.
        public CategoryViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Get Category Command.
        private ICommand getCategoryCommand;
        public ICommand GetCategoryCommand
        {
            get => getCategoryCommand ?? (getCategoryCommand = new Command(async () => await ExecuteGetCategoryCommand()));
        }
        private async Task ExecuteGetCategoryCommand()
        {
            ICategoryService service = new CategoryService();
            Category = await service.GetCategoryAsync();
        }
        #endregion

        #region Properties.
        private Models.CategoryResponse category;
        public Models.CategoryResponse Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }
        #endregion
    }
}
