using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIEW.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace VIEW.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private string _password;
        #region Commands
        [ICommand]
        async void Login()
        {
            
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            

        }
        #endregion

    }
}
