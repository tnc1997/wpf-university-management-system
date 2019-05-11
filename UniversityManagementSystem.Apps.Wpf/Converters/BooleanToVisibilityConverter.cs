using System.Windows;

namespace UniversityManagementSystem.Apps.Wpf.Converters
{
    /// <summary>
    ///     https://stackoverflow.com/a/5182660
    /// </summary>
    public class BooleanToVisibilityConverter : BooleanConverter<Visibility>
    {
        public BooleanToVisibilityConverter() : base(Visibility.Visible, Visibility.Hidden)
        {
        }
    }
}