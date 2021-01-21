using Prism.Regions;
using System.Windows;
using TUC.Interfaces;
using TUC.plugins.Views;
using TUC.ui.viewModel;

namespace TUC.ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell: Window
    {
        public Shell(ShellViewModel shellViewModel, IRegionManager regionManager)
        {
            this.DataContext = shellViewModel;
            regionManager.RegisterViewWithRegion(RegionNames.ShellMainRegion, typeof(MainView));
            InitializeComponent();
        }
    }
}
