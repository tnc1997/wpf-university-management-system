using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using Prism.Mvvm;
using Prism.Regions;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Extensions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Student.ViewModels
{
    public class StudentsViewModel : BindableBase, INavigationAware
    {
        private int _axisMax;
        private int _axisMin;
        private ClassificationDim _classificationDim;
        private SeriesCollection _filteredSeriesCollection;
        private ModuleDim _moduleDim;

        public StudentsViewModel(IEnrolmentService enrolmentService, IStudentFactService studentFactService)
        {
            EnrolmentService = enrolmentService;
            StudentFactService = studentFactService;
        }

        public int AxisMax
        {
            get => _axisMax;
            set => SetProperty(ref _axisMax, value);
        }

        public int AxisMin
        {
            get => _axisMin;
            set => SetProperty(ref _axisMin, value);
        }

        public ClassificationDim ClassificationDim
        {
            get => _classificationDim;
            set
            {
                if (!SetProperty(ref _classificationDim, value)) return;

                FilteredSeriesCollection =
                    _classificationDim != null
                        ? ClassificationFilteredSeriesCollections[_classificationDim]
                        : SeriesCollection;
            }
        }

        public ICollection<ClassificationDim> ClassificationDims { get; } = new ObservableCollection<ClassificationDim>();

        public SeriesCollection FilteredSeriesCollection
        {
            get => _filteredSeriesCollection;
            set => SetProperty(ref _filteredSeriesCollection, value);
        }

        public ModuleDim ModuleDim
        {
            get => _moduleDim;
            set
            {
                if (!SetProperty(ref _moduleDim, value)) return;

                FilteredSeriesCollection =
                    _moduleDim != null
                        ? ModuleFilteredSeriesCollections[_moduleDim]
                        : SeriesCollection;
            }
        }

        public ICollection<ModuleDim> ModuleDims { get; } = new ObservableCollection<ModuleDim>();

        private IDictionary<ClassificationDim, SeriesCollection> ClassificationFilteredSeriesCollections { get; set; }
        
        private IEnrolmentService EnrolmentService { get; }

        private IDictionary<ModuleDim, SeriesCollection> ModuleFilteredSeriesCollections { get; set; }

        private SeriesCollection SeriesCollection { get; set; }

        private IStudentFactService StudentFactService { get; }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            ClassificationDims.Clear();
            ModuleDims.Clear();
        }

        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            var studentFacts = (await StudentFactService.GetAsync()).ToList();

            ClassificationFilteredSeriesCollections = studentFacts
                .GroupBy(fact => fact.ClassificationDim)
                .ToDictionary(
                    facts => facts.Key,
                    facts => facts
                        .GroupBy(fact => fact.ModuleDim)
                        .ToDictionary(
                            facts1 => facts1.Key,
                            facts1 => facts1
                                .GroupBy(fact => fact.YearDim)
                                .ToDictionary(
                                    facts2 => facts2.Key,
                                    facts2 => facts2.Sum(fact => fact.Count)
                                )
                        ).Select(LineSeriesSelector)
                        .AsSeriesCollection()
                );

            ClassificationDims.AddRange(ClassificationFilteredSeriesCollections.Keys);

            ModuleFilteredSeriesCollections = studentFacts
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
                        ).Select(LineSeriesSelector)
                        .AsSeriesCollection()
                );

            ModuleDims.AddRange(ModuleFilteredSeriesCollections.Keys);

            AxisMax = studentFacts.Max(fact => fact.YearDim.Year);
            AxisMin = studentFacts.Min(fact => fact.YearDim.Year);

            var enrolments = await EnrolmentService.GetAsync();

            FilteredSeriesCollection = SeriesCollection = enrolments
                .GroupBy(enrolment => enrolment.Year)
                .ToDictionary(
                    enrolments1 => enrolments1.Key,
                    enrolments1 => enrolments1.Distinct(enrolment => enrolment.UserId).Count()
                ).AsObservablePoints()
                .AsChartValues()
                .AsSeriesView<LineSeries>()
                .AsSeriesCollection();
        }

        private static LineSeries LineSeriesSelector<TKey>(KeyValuePair<TKey, Dictionary<YearDim, int>> pair)
        {
            return new LineSeries
            {
                Title = pair.Key.ToString(),
                Values = pair.Value.AsObservablePoints(dim => dim.Year).AsChartValues()
            };
        }
    }
}