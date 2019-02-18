using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Room.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Room.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Room
{
    public class RoomModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RoomsView, RoomsViewModel>();
        }
    }
}