namespace UniversityManagementSystem.Apps.Wpf.Modules.Main.Models
{
    public class NavigationViewItemModel
    {
        public NavigationViewItemModel(string title, string icon, string view)
        {
            Title = title;
            Icon = icon;
            View = view;
        }

        public string Title { get; set; }

        public string Icon { get; set; }

        public string View { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}