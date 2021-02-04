using System;
using System.Collections.Generic;
using System.Text;
using TUC.Interfaces.Scaffolding;
using Unity;

namespace TUC.ui.Scaffolding
{
    public static class Container
    {
        public static void Register(IUnityContainer containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewNavigator, ViewNavigator>();
        }
    }
}
