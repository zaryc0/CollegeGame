using Prism.Ioc;
using Prism.Unity;
using System.ComponentModel;
using System.Windows;
using TUC.ui;
using TUC.ui.viewModel;

namespace TUC.ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    internal partial class App
    {

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ShellViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }
    }
}
