using System;
using System.Collections.Generic;
using System.Linq;
using LiveCharts.Defaults;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Extensions
{
    public static class EnumerableExtension
    {
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