using System.Linq;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Enrolment.ViewModels
{
    public class EnrolmentsViewModel : BindableBase, INavigationAware
    {
        public EnrolmentsViewModel(IEnrolmentFactService enrolmentFactService)
        {
            EnrolmentFactService = enrolmentFactService;
        }

        public SeriesCollection SeriesCollection { get; } = new SeriesCollection();

        private IEnrolmentFactService EnrolmentFactService { get; }

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
            var enrolmentFacts = await EnrolmentFactService.GetAsync();

            var dictionary = enrolmentFacts
                .GroupBy(fact => fact.ModuleDim)
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
                        Title = pair.Key.ToString(),
                        Values = new ChartValues<ObservablePoint>(points)
                    };
                }).ToList();

            SeriesCollection.AddRange(seriesViews);
        }
    }
}