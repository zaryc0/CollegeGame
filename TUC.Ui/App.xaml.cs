using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using TUC.Interfaces.Scaffolding;
using TUC.ui.Scaffolding;

namespace TUC.ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    internal partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Scaffolding.Container.Register(containerRegistry.GetContainer());
            containerRegistry.RegisterSingleton<IViewNavigator, ViewNavigator>();
        }

        protected override Window CreateShell()
        {

            return Container.Resolve<Shell>();
        }

    }
}
