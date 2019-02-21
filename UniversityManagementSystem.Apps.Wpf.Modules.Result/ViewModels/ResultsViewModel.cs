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

namespace UniversityManagementSystem.Apps.Wpf.Modules.Result.ViewModels
{
    public class ResultsViewModel : BindableBase, INavigationAware
    {
        private int _axisMax;
        private int _axisMin;
        private ClassificationDim _classificationDim;
        private SeriesCollection _filteredSeriesCollection;
        private ModuleDim _moduleDim;

        public ResultsViewModel(IResultFactService resultFactService)
        {
            ResultFactService = resultFactService;
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

        private IDictionary<ModuleDim, SeriesCollection> ModuleFilteredSeriesCollections { get; set; }

        private SeriesCollection SeriesCollection { get; set; }

        private IResultFactService ResultFactService { get; }

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
            var resultFacts = (await ResultFactService.GetAsync()).ToList();

            ClassificationFilteredSeriesCollections = resultFacts
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

            ModuleFilteredSeriesCollections = resultFacts
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

            AxisMax = resultFacts.Max(fact => fact.YearDim.Year);
            AxisMin = resultFacts.Min(fact => fact.YearDim.Year);

            FilteredSeriesCollection = SeriesCollection = resultFacts
                .GroupBy(fact => fact.YearDim)
                .ToDictionary(
                    facts => facts.Key,
                    facts => facts.Sum(fact => fact.Count)
                ).AsObservablePoints(dim => dim.Year)
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