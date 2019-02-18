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
        }

        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            var studentFacts = (await StudentFactService.GetAsync()).ToList();

            /*var moduleDictionary = studentFacts
                .GroupBy(fact => fact.ModuleDim)
                .ToDictionary(
                    facts => facts.Key,
                    facts => facts
                        .GroupBy(fact => fact.ClassificationDim)
                        .ToDictionary(
                            facts1 => facts1.Key,
                            facts1 => facts1
                                .GroupBy(fact => fact.YearDim)
                                .ToDictionary(
                                    facts2 => facts2.Key,
                                    facts2 => facts2.Sum(fact => fact.Count)
                                )
                        )
                );
            
            var moduleCollections = new List<SeriesCollection>();
            
            foreach (var pair in moduleDictionary)
            {
                moduleCollections.Add(
                    new SeriesCollection(
                        pair.Value.Select(pair1 => new LineSeries
                        {
                            Title = pair1.Key.Classification,
                            // Values = new ChartValues<int>(pair1.Value.Values)
                            Values = new ChartValues<ObservablePoint>(pair1.Value.Select(pair2 => new ObservablePoint(pair2.Key.Year, pair2.Value)))
                        })
                    )
                );
            }*/

            var dictionary = studentFacts
                .GroupBy(fact => fact.ClassificationDim)
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
                .Select(pair => new LineSeries
                {
                    Title = pair.Key.Classification,
                    Values = new ChartValues<ObservablePoint>(pair.Value.Select(pair2 => new ObservablePoint(pair2.Key.Year, pair2.Value)))
                }).ToList();

            SeriesCollection.AddRange(seriesViews);
        }
    }
}