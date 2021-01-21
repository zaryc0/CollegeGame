using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TUC.plugins.interfaces;

namespace TUC.plugins.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged, IGameViewModel
    {
        public GameViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
