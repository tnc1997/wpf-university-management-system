using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Module.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Module.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Module
{
    public class ModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ModulesView, ModulesViewModel>();
        }
    }
}