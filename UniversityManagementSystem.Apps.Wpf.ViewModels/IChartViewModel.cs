using LiveCharts;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public interface IChartViewModel : IViewModel
    {
        INotifyTaskCompletion<SeriesCollection> SeriesCollectionTask { get; }
    }
}