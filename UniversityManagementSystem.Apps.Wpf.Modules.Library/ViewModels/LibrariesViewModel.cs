using System.Linq;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Library.ViewModels
{
    public class LibrariesViewModel : BindableBase, INavigationAware
    {
        public LibrariesViewModel(ILibraryFactService libraryFactService)
        {
            LibraryFactService = libraryFactService;
        }

        public SeriesCollection SeriesCollection { get; } = new SeriesCollection();

        private ILibraryFactService LibraryFactService { get; }

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
            var libraryFacts = await LibraryFactService.GetAsync();

            var dictionary = libraryFacts
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