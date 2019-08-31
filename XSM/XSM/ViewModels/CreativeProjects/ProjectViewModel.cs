using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.Services;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.Project
{
    public class ProjectViewModel : BaseViewModel
    {
        private Models.Project _project;
        public Models.Project Project
        {
            get { return _project; }
            set { SetProperty(ref _project, value); }
        }

        public ICommand BackToProjectsCommand { get; private set; }

        private readonly INavigationService _navigationService;

        public ProjectViewModel() { }
        public ProjectViewModel(Models.Project project)
        {
            Project = project;
            _navigationService = App.NavigationService;

            LoadData();

            BackToProjectsCommand = new Command(async () => await BackToProjectsExecute());
        }

        private void LoadData()
        {
            System.Diagnostics.Debug.WriteLine("Loading characters data");
        }

        private async Task BackToProjectsExecute()
        {
            await _navigationService.GoBack();
        }
    }
}
