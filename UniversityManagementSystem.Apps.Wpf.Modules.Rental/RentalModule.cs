using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Rental.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Rental.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Rental
{
    public class RentalModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RentalsView, RentalsViewModel>();
        }
    }
}