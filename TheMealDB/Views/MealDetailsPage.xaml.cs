using TheMealDB.ViewModels;

namespace TheMealDB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealDetailsPage : ContentPage
    {
        MealDetailsPageViewModel viewModel;
        public MealDetailsPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = viewModel = new MealDetailsPageViewModel(this.Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.MealDetailsCommand.Execute(null);
        }
    }
}