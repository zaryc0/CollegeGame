using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TUC.plugins.interfaces;

namespace TUC.plugins.ViewModels
{
    public class HighScoreScreenViewModel : INotifyPropertyChanged, IHighScoreScreenViewModel
    {
        public HighScoreScreenViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
