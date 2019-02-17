using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XSM.ViewModels;

namespace XSM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            InitializeComponent();
            BindingContext = new BookViewModel();
        }
    }
}