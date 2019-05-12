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
    /// <summary>
    ///     Defines generic implementations for members which are shared between fact chart view models.
    /// </summary>
    public abstract class FactChartViewModelBase<TFact> : ChartViewModelBase, IFactChartViewModel where TFact : IFact
    {
        protected FactChartViewModelBase(IFactService<TFact> factService)
        {
            FactService = factService;

            Specifications = new Dictionary<Type, ISpecification<TFact>>();
        }

        /// <summary>
        ///     Gets the specifications used to filter facts.
        /// </summary>
        protected IDictionary<Type, ISpecification<TFact>> Specifications { get; }

        /// <summary>
        ///     Gets the fact service used to retrieve facts.
        /// </summary>
        private IFactService<TFact> FactService { get; }

        /// <inheritdoc />
        protected override async Task<SeriesCollection> GetSeriesCollection()
        {
            // If the dictionary of specifications does not contain any non-null specifications, then get all the
            // facts; otherwise, get all the facts that are filtered by all the specifications.
            Task<IEnumerable<TFact>> GetFacts()
            {
                var specifications = Specifications.Values.Where(specification => specification != null).ToList();

                switch (specifications.Count)
                {
                    case 0:
                        // If there are no specifications, then get all the facts.
                        return FactService.GetAsync();
                    case 1:
                        // If there is one specification, then get all the facts that are filtered by that specification.
                        return FactService.GetAsync(specifications.Single());
                    default:
                        // If there are multiple specifications, then get all the facts that are filtered by all the specifications.
                        return FactService.GetAsync(specifications.Aggregate((a, b) => a.And(b)));
                }
            }

            var facts = await Task.Run(GetFacts);

            // Maps the facts to observable points, chart values, column series and then a collection of series.
            return facts.AsObservablePoints().AsChartValues().AsColumnSeries().AsSeriesCollection();
        }
    }
}