using System.Linq;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Student.ViewModels
{
    public class StudentsViewModel : BindableBase, INavigationAware
    {
        public StudentsViewModel(IStudentFactService studentFactService)
        {
            StudentFactService = studentFactService;
        }

        public SeriesCollection SeriesCollection { get; } = new SeriesCollection();

        private IStudentFactService StudentFactService { get; }

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
            var studentFacts = await StudentFactService.GetAsync();

            var dictionary = studentFacts
                .GroupBy(fact => fact.CountryDim)
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