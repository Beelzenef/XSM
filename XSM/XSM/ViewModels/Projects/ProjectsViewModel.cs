using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.Data;
using XSM.Services;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.Projects
{
    class ProjectsViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Project> _projects;
        public ObservableCollection<Models.Project> Projects
        {
            get { return _projects; }
            set { SetProperty(ref _projects, value); }
        }

        private readonly INavigationService _navigationService;

        public ProjectsViewModel()
        {
            _navigationService = App.NavigationService;

            Projects = new ObservableCollection<Models.Project>();

            ProjectData _context = new ProjectData();
            _context.Projects.ToList().ForEach(Projects.Add);

            GoToProjectCommand = new Command<Models.Project>(async (p) => await GoToProjectExecute(p));
        }

        public ICommand GoToProjectCommand { get; private set; }

        private async Task GoToProjectExecute(Models.Project project)
        {
            if (project != null)
            {
                await _navigationService.NavigateAsync(AppConstants.ProjectPage, project);
            }
        }
    }
}
