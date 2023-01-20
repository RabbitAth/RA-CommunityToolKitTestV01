using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolKitTest.ViewModel
{
    public partial class TestViewModel : BaseViewModel
    {
        [ObservableProperty]
        string someProperty;

        [RelayCommand]
        void SomeCommand()
        {
            throw new NotImplementedException();
        }
    }
}
