using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TUC.plugins.interfaces;

namespace TUC.plugins.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, IMainViewModel
    {

        public MainViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
