using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.Modules.Auth.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Auth.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Auth
{
    public class AuthModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion("ContentRegion", typeof(LoginView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginView, LoginViewModel>();
        }
    }
}