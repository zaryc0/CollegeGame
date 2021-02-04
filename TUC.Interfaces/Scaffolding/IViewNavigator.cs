using System;
using System.Collections.Generic;
using System.Text;

namespace TUC.Interfaces.Scaffolding
{
    public interface IViewNavigator
    {
        void Navigate(string regionName, string viewName);
        void ClearRegion(string overlayRegion);
        void Navigate(string regionName, Type viewType);
        void Navigate(string regionName, object view);
    }
}
