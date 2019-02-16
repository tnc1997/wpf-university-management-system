using System.Windows;
using Prism.Regions;

namespace UniversityManagementSystem.Apps.Wpf.Views
{
    public partial class MainWindow
    {
        public MainWindow(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            InitializeComponent();
        }

        private IRegionManager RegionManager { get; }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate("ContentRegion", "LoginPage");
        }
    }
}