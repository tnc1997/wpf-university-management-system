using System.Linq;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Room.ViewModels
{
    public class RoomsViewModel : BindableBase, INavigationAware
    {
        public RoomsViewModel(IRoomFactService roomFactService)
        {
            RoomFactService = roomFactService;
        }

        public SeriesCollection SeriesCollection { get; } = new SeriesCollection();

        private IRoomFactService RoomFactService { get; }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            SeriesCollection.Clear();
        }

        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            var studentFacts = await RoomFactService.GetAsync();

            var dictionary = studentFacts
                .GroupBy(fact => fact.CampusDim)
                .ToDictionary(
                    facts => facts.Key,
                    facts => facts
                        .GroupBy(fact => fact.YearDim)
                        .ToDictionary(
                            facts1 => facts1.Key,
                            facts1 => facts1.Sum(fact => fact.Count)
                        )
                );

            var seriesViews = dictionary
                .Select(pair =>
                {
                    var points = pair.Value.Select(pair1 => new ObservablePoint(pair1.Key.Year, pair1.Value));
                    
                    return new LineSeries
                    {
                        Title = pair.Key.Name,
                        Values = new ChartValues<ObservablePoint>(points)
                    };
                }).ToList();

            SeriesCollection.AddRange(seriesViews);
        }
    }
}