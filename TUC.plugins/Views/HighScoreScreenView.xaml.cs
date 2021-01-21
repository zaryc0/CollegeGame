using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TUC.plugins.ViewModels;

namespace TUC.plugins.Views
{
    /// <summary>
    /// Interaction logic for HighScoreScreenView.xaml
    /// </summary>
    public partial class HighScoreScreenView : Page
    {
        public HighScoreScreenView(HighScoreScreenViewModel highScoreScreenViewModel)
        {
            InitializeComponent();
        }
    }
}
