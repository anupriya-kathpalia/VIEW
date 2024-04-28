using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIEW.Views;
using Microsoft.Toolkit.Mvvm.Input;

namespace VIEW.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [ICommand]
        async void SignOut()
        {
           
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
