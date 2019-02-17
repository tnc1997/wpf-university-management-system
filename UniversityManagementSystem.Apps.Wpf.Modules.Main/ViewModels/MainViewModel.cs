using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.Modules.Main.Models;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Main.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private NavigationViewItemModel _selectedItem;

        public MainViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            MenuItems = new ObservableCollection<NavigationViewItemModel>
            {
                new NavigationViewItemModel("Home", "Home", "HomeView")
            };

            SelectedItem = MenuItems.First();
        }

        public ICollection<NavigationViewItemModel> MenuItems { get; }

        private IRegionManager RegionManager { get; }

        public NavigationViewItemModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);

                RegionManager.RequestNavigate("MainRegion", _selectedItem.View);
            }
        }
    }
}