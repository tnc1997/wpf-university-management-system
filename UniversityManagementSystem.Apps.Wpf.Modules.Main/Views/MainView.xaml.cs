using Prism.Regions;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Main.Views
{
    public partial class MainView
    {
        public MainView(IRegionManager regionManager)
        {
            InitializeComponent();

            RegionManager.SetRegionName(MainRegion, "MainRegion");
            RegionManager.SetRegionManager(MainRegion, regionManager);
        }
    }
}