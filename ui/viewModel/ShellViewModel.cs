using Prism.Commands;
using System.ComponentModel;
using System.Windows;

namespace TUC.ui.viewModel
{
    public  class ShellViewModel : INotifyPropertyChanged
    {
        public ShellViewModel()
        {
            Title = "Mobile flight recorder";

            CloseCommand = new DelegateCommand(CloseApp);
        }

        private void CloseApp()
        {
            Application.Current.MainWindow.Close();
        }

        public string Title { get; set; }

        public DelegateCommand CloseCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
