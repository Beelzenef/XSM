using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.Data;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.ProjectList
{
    class ProjectListViewModel : BaseViewModel
    {
        private ObservableCollection<Models.CreativeProject> _projects;
        public ObservableCollection<Models.CreativeProject> Projects
        {
            get { return _projects; }
            set { SetProperty(ref _projects, value); }
        }

        public ProjectListViewModel()
        {
            Projects = new ObservableCollection<Models.CreativeProject>();

            ProjectData _context = new ProjectData();
            _context.Projects.ToList().ForEach(Projects.Add);

            GoToProjectCommand = new Command<Models.CreativeProject>(async (p) => await GoToProjectExecute(p));
        }

        public ICommand GoToProjectCommand { get; private set; }

        private async Task GoToProjectExecute(Models.CreativeProject project)
        {
            await ExecuteActionAsync(async () =>
            {
                if (project != null)
                {
                    await _navigationService.NavigateAsync(AppConstants.ProjectPage, project);
                }
            });
        }
    }
}
