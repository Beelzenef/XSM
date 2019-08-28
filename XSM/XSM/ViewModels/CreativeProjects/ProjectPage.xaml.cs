using Xamarin.Forms;

namespace XSM.ViewModels.Project
{
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage(Models.Project project)
        {
            InitializeComponent();

            BindingContext = new ProjectViewModel(project);
        }

        
    }
}
