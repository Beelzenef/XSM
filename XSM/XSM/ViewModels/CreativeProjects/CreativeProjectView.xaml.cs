using Xamarin.Forms;

namespace XSM.ViewModels.CreativeProjects
{
    public partial class CreativeProjectView : ContentPage
    {
        public CreativeProjectView(Models.CreativeProject project)
        {
            InitializeComponent();

            BindingContext = new CreativeProjectViewModel(project);
        }
    }
}
