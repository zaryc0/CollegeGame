using JetBrains.Annotations;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TUC.plugins.interfaces;

namespace TUC.plugins.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, IMainViewModel
    {
        private ICommand _button1Command;
        public ICommand Button1Command
        {
            get
            {
                return _button1Command ?? (_button1Command = new CommandHandler(() 
                    => Button1Pressed(), () 
                    => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }
        public MainViewModel()
        {
            Title = "Turtle Unicorn\nCrown";
            Button1Text = "Play";
            Button2Text = "ScoreBoard";
        }

        public string Title { get; set; }
        public string Button1Text { get; set; }
        public string Button2Text { get; set; }


        public void Button1Pressed()
        {
            Button1Text = "click";
        }

        public void Button2Pressed()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
