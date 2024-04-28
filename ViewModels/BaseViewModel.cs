using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace VIEW.ViewModels
{
   
        public partial class BaseViewModel : ObservableObject
        {
            [ObservableProperty]
            private bool _isBusy;

            [ObservableProperty]
            private string _title;
        }
    
}
