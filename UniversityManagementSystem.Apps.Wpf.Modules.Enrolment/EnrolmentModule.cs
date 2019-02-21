using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Enrolment.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Enrolment.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Enrolment
{
    public class EnrolmentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<EnrolmentsView, EnrolmentsViewModel>();
        }
    }
}