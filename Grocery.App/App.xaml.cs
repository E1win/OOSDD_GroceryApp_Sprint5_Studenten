using Grocery.App.ViewModels;
using Grocery.App.Views;
using System.Globalization;

namespace Grocery.App
{
    public partial class App : Application
    {
        public App(LoginViewModel viewModel)
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-NL");
            //MainPage = new AppShell();
            MainPage = new LoginView(viewModel);

        }
    }
}
