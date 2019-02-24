using System.Threading.Tasks;
using LiveCharts;
using Prism.Regions;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public abstract class ChartViewModelBase : ViewModelBase, IChartViewModel
    {
        private INotifyTaskCompletion<SeriesCollection> _seriesCollectionTask;

        public INotifyTaskCompletion<SeriesCollection> SeriesCollectionTask
        {
            get => _seriesCollectionTask;
            private set => SetProperty(ref _seriesCollectionTask, value);
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            UpdateSeriesCollection();
        }

        protected void UpdateSeriesCollection()
        {
            SeriesCollectionTask = new NotifyTaskCompletion<SeriesCollection>(GetSeriesCollection());
        }

        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}