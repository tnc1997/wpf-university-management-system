using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Helpers;
using UniversityManagementSystem.Apps.Wpf.Extensions;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Extensions;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public abstract class FactChartViewModelBase<TFact> : ChartViewModelBase, IFactChartViewModel where TFact : IFact
    {
        protected FactChartViewModelBase(IFactService<TFact> factService)
        {
            FactService = factService;

            Specifications = new Dictionary<Type, ISpecification<TFact>>();
        }

        protected IDictionary<Type, ISpecification<TFact>> Specifications { get; }

        private IFactService<TFact> FactService { get; }

        protected override async Task<SeriesCollection> GetSeriesCollection()
        {
            Task<IEnumerable<TFact>> GetFacts()
            {
                return Specifications.Values.All(specification => specification == null)
                    ? FactService.GetAsync()
                    : FactService.GetAsync(Specifications.Values.Aggregate((a, b) => a.And(b)));
            }

            var facts = await Task.Run(GetFacts);

            return facts.AsObservablePoints().AsChartValues().AsColumnSeries().AsSeriesCollection();
        }
    }
}