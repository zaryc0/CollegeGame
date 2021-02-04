using Prism.Regions;
using System.Windows.Controls;
using TUC.plugins.ViewModels;

namespace TUC.plugins.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView(MainViewModel mainViewModel)
        {
            DataContext = mainViewModel;
            InitializeComponent();
        }
    }
}
