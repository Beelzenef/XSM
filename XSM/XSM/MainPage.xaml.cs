using Xamarin.Forms;

namespace XSM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnDisplay_Click(object sender, System.EventArgs e)
        {
            var answer = await DisplayAlert("Key question", "Do you like Xam.Forms?", "Yay!", "Nope");
            lbl_Answer.Text = answer ? "yay!" : "not that much...";
        }
    }
}
