using TheMealDB.ViewModels;

namespace TheMealDB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        CategoryViewModel viewModel;
        public CategoryPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new CategoryViewModel(this.Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.GetCategoryCommand.Execute(null);
        }

        private async void OnItemClicked(object sender, EventArgs e)
        {
            ImageButton imageButton = (ImageButton)sender;
            Helper.Helper.SelectedCategory = imageButton.BindingContext as Models.Category;
            await Navigation.PushAsync(new MealsPage());
        }
    }
}