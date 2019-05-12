using System.Threading.Tasks;
using LiveCharts;
using Prism.Regions;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    /// <summary>
    ///     Defines generic implementations for members which are shared between chart view models.
    /// </summary>
    public abstract class ChartViewModelBase : ViewModelBase, IChartViewModel
    {
        private INotifyTaskCompletion<SeriesCollection> _seriesCollectionTask;

        /// <inheritdoc />
        public INotifyTaskCompletion<SeriesCollection> SeriesCollectionTask
        {
            get => _seriesCollectionTask;
            private set => SetProperty(ref _seriesCollectionTask, value);
        }

        /// <inheritdoc />
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            UpdateSeriesCollection();
        }

        /// <summary>
        ///     Updates the collection of series which are plotted on the chart.
        /// </summary>
        protected void UpdateSeriesCollection()
        {
            SeriesCollectionTask = new NotifyTaskCompletion<SeriesCollection>(GetSeriesCollection());
        }

        /// <summary>
        ///     Gets the collection of series to plot on the chart.
        /// </summary>
        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}