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
                new NavigationViewItemModel("Home", "Home", "HomeView"),
                new NavigationViewItemModel("Assignments", "File", "AssignmentsView"),
                new NavigationViewItemModel("Books", "Book", "BooksView"),
                new NavigationViewItemModel("Enrolments", "BriefcaseAccount", "EnrolmentsView"),
                new NavigationViewItemModel("Graduations", "School", "GraduationsView"),
                new NavigationViewItemModel("Lectures", "Teach", "LecturesView"),
                new NavigationViewItemModel("Libraries", "Library", "LibrariesView"),
                new NavigationViewItemModel("Modules", "Briefcase", "ModulesView"),
                new NavigationViewItemModel("Rentals", "Timer", "RentalsView"),
                new NavigationViewItemModel("Results", "FileAccount", "ResultsView"),
                new NavigationViewItemModel("Rooms", "Domain", "RoomsView"),
                new NavigationViewItemModel("Students", "Account", "StudentsView")
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
                if (!SetProperty(ref _selectedItem, value)) return;

                RegionManager.RequestNavigate("MainRegion", _selectedItem.View);
            }
        }
    }
}