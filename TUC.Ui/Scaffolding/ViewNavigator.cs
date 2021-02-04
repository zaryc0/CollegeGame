using Prism.Events;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TUC.Interfaces.Scaffolding;
using TUC.Interfaces.Shells;

namespace TUC.ui.Scaffolding
{
    class ViewNavigator : IViewNavigator
    {
        private readonly IContainerProvider _container;
        private readonly IRegionManager _regionManager;

        public ViewNavigator(IRegionManager regionManager, IContainerProvider container, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void ClearRegion(string regionName)
        {
            var region = _regionManager.Regions[regionName];
            foreach(var regionActiveView in region.ActiveViews)
            {
                var disposable = regionActiveView as IDisposable;
                disposable?.Dispose();
            }

            region.RemoveAll();
        }

        public void Navigate(string regionName, string viewName)
        {
            var viewType = Assembly.GetExecutingAssembly().GetType(viewName);
            var view = _container.Resolve(viewType);
            var region = _regionManager.Regions[regionName];
            ClearRegion(regionName);
            region.Add(view);
        }

        public void Navigate(string regionName, Type viewType)
        {
            RegionManager.UpdateRegions();
            var region = _regionManager.Regions[regionName];
            ClearRegion(regionName);
            var view = _container.Resolve(viewType);
            region.Add(view);
        }

        public void Navigate(string regionName, object view)
        {
            var region = _regionManager.Regions[regionName];
            ClearRegion(regionName);
            region.Add(view);
        }
    }
}
