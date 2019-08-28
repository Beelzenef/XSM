using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XSM.Services;
using XSM.ViewModels.Login;
using XSM.ViewModels.Project;
using XSM.ViewModels.Projects;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XSM
{
    public partial class App : Application
    {
        public static INavigationService NavigationService { get; } = new NavigationService();

        public App()
        {
            InitializeComponent();

            MainPage = SetNavigations();
        }

        private Page SetNavigations()
        {
            NavigationService.Configure(AppConstants.LoginPage, typeof(LoginPage));
            NavigationService.Configure(AppConstants.ProjectsPage, typeof(ProjectsPage));
            NavigationService.Configure(AppConstants.ProjectPage, typeof(ProjectPage));
            var mainPage = ((NavigationService)NavigationService).SetRootPage(AppConstants.LoginPage);

            return mainPage;
        }

    }
}
