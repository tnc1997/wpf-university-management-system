using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Graduation.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Graduation.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Graduation
{
    public class GraduationModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GraduationsView, GraduationsViewModel>();
        }
    }
}