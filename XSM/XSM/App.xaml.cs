using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XSM.Services.Navigation;
using XSM.ViewModels.CreativeProjects;
using XSM.ViewModels.Login;
using XSM.ViewModels.ProjectList;

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
            NavigationService.Configure(AppConstants.LoginPage, typeof(LoginView));
            NavigationService.Configure(AppConstants.ProjectsPage, typeof(ProjectListView));
            NavigationService.Configure(AppConstants.ProjectPage, typeof(CreativeProjectView));
            var mainPage = ((NavigationService)NavigationService).SetRootPage(AppConstants.LoginPage);

            return mainPage;
        }

    }
}
