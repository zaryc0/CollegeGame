using System.Windows.Controls;
using TUC.plugins.ViewModels;

namespace TUC.plugins.Views
{
    /// <summary>
    /// Interaction logic for HighScoreScreenView.xaml
    /// </summary>
    public partial class HighScoreScreenView :UserControl
    {
        public HighScoreScreenView(HighScoreScreenViewModel highScoreScreenViewModel)
        {
            DataContext = highScoreScreenViewModel;
            InitializeComponent();
        }
    }
}
