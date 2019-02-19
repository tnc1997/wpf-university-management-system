using System.Linq;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Module.ViewModels
{
    public class ModulesViewModel : BindableBase, INavigationAware
    {
        public ModulesViewModel(IModuleFactService moduleFactService)
        {
            ModuleFactService = moduleFactService;
        }

        public SeriesCollection SeriesCollection { get; } = new SeriesCollection();

        private IModuleFactService ModuleFactService { get; }

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
            var moduleFacts = await ModuleFactService.GetAsync();

            var dictionary = moduleFacts
                .GroupBy(fact => fact.CourseDim)
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