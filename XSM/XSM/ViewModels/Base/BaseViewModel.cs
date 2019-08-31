using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using XSM.Services;

namespace XSM.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigationService _navigationService { get; private set; }

        public BaseViewModel()
        {
            _navigationService = App.NavigationService;
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ExecuteAction(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                //await _navigationService.DisplayAlertConfirm(e.Message);
            }
        }

        public async Task ExecuteActionAsync(Func<Task> func)
        {
            try
            {
                await func.Invoke();
            }
            catch (Exception e)
            {
                await _navigationService.DisplayAlertConfirm(e.Message);
            }
        }
    }
}
