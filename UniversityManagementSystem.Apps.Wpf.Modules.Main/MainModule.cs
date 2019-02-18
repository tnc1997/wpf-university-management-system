using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.Modules.Main.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Main.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion("ContentRegion", typeof(MainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
        }
    }
}