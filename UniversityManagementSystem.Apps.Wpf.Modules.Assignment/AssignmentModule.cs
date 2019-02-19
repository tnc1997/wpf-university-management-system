using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Assignment.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Assignment.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Assignment
{
    public class AssignmentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AssignmentsView, AssignmentsViewModel>();
        }
    }
}