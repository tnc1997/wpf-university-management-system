using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.Modules.Home.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Home.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Home
{
    public class HomeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion("MainRegion", typeof(HomeView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeView, HomeViewModel>();
        }
    }
}