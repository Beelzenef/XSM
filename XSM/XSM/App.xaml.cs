using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XSM.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XSM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new BookPage();
        }
    }
}
