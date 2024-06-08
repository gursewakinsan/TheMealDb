using TheMealDB.ViewModels;

namespace TheMealDB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealsPage : ContentPage
    {
        MealsPageViewModel viewModel;
        public MealsPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new MealsPageViewModel(this.Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.GetMealsCommand.Execute(null);
        }

        private async void OnMealClicked(object sender, EventArgs e)
        {
            ImageButton imageButton = (ImageButton)sender;
            Helper.Helper.SelectedMeal = imageButton.BindingContext as Models.Meal;
            await Navigation.PushAsync(new MealDetailsPage());
        }
    }
}