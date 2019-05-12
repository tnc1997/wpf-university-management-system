using System;
using System.Collections.Generic;
using System.Linq;
using LiveCharts.Defaults;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Extensions
{
    /// <summary>
    ///     Defines extension methods for enumerables.
    /// </summary>
    public static class EnumerableExtension
    {
        /// <summary>
        ///     Maps facts to observable points.
        /// </summary>
        /// <param name="facts">The facts to map to observable points.</param>
        /// <typeparam name="TFact">The type of the facts.</typeparam>
        /// <returns>The observable points mapped from the facts.</returns>
        /// <exception cref="ArgumentNullException">Thrown when facts is null.</exception>
        public static IEnumerable<ObservablePoint> AsObservablePoints<TFact>(this IEnumerable<TFact> facts)
            where TFact : IFact
        {
            if (facts == null) throw new ArgumentNullException(nameof(facts));

            return facts
                .GroupBy(fact => fact.YearDim)
                .ToDictionary(
                    facts1 => facts1.Key,
                    facts1 => facts1.Sum(fact => fact.Count)
                ).AsObservablePoints(dim => dim.Year);
        }
    }
}