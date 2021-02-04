using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Input;
using TUC.Interfaces;
using TUC.plugins.ViewModels;
using TUC.plugins.Views;

namespace TUC.ui
{
    public class ShellViewModel :BindableBase, INotifyPropertyChanged , IShellViewModel
    {

        public ShellViewModel(IRegionManager regionManager)
        {
            BackGround = "C:\\Users\\callu\\OneDrive\\Documents\\college work\\ObjectOrientedProgramming\\repo\\CollegeGame\\TUC.ui\\Resources\\background.png";
            Title = "Turtle Unicorn\nCrown";

            RegisterViewsWithRegions(regionManager);

        }

        private void RegisterViewsWithRegions(IRegionManager regionManager)
        {
          //  regionManager.RegisterViewWithRegion(RegionNames.ShellMainRegion, typeof(MainView));
            //regionManager.RegisterViewWithRegion(RegionNames.ShellMainRegion, typeof(HighScoreScreenView));
            regionManager.RegisterViewWithRegion(RegionNames.ShellMainRegion, typeof(GameView));
        }

        

        public string Title { get; set; }
        public string BackGround { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
