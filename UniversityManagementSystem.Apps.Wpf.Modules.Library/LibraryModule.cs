using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Library.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Library.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Library
{
    public class LibraryModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LibrariesView, LibrariesViewModel>();
        }
    }
}