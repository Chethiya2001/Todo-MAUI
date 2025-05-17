using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_MAUI.ViewModel;

public class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
   
}

