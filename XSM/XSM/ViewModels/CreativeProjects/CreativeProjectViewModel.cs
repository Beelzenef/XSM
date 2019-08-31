using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.CreativeProjects
{
    public class CreativeProjectViewModel : BaseViewModel
    {
        private Models.CreativeProject _project;
        public Models.CreativeProject Project
        {
            get { return _project; }
            set { SetProperty(ref _project, value); }
        }

        public ICommand BackToProjectsCommand { get; private set; }

        public CreativeProjectViewModel() { }
        public CreativeProjectViewModel(Models.CreativeProject project)
        {
            Project = project;

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
