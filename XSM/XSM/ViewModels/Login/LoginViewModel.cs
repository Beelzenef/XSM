using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.Services.Users;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel
    {
        string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; private set; }

        private readonly IUserService _userService;

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginExecute());

            _userService = new UserService();
        }

        private async Task LoginExecute()
        {
            bool validCredentials = _userService.CheckUserData(Username, Password);

            if (validCredentials)
            {
                await _navigationService.NavigateAsync(AppConstants.ProjectsPage);
            }
            else
            {
                await _navigationService.DisplayAlertConfirm("Invalid credentials");
            }
        }
    }
}
