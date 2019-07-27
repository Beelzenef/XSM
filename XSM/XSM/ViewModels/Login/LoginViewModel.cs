﻿using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.Services;
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

        private INavigationService _navigationService;

        public LoginViewModel()
        {
            _navigationService = App.NavigationService;
            LoginCommand = new Command(async () => await LoginExecute());
        }

        private async Task LoginExecute()
        {
            await _navigationService.NavigateAsync(AppConstants.ProjectsPage);
        }
    }
}
