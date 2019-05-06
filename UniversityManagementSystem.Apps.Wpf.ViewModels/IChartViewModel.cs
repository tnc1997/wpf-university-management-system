using LiveCharts;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    /// <summary>
    ///     Declares generic members that each chart view model must implement.
    /// </summary>
    public interface IChartViewModel : IViewModel
    {
        /// <summary>
        ///     Gets the collection of series to plot on the chart.
        /// </summary>
        INotifyTaskCompletion<SeriesCollection> SeriesCollectionTask { get; }
    }
}