using System;
using System.Collections.Generic;
using System.Linq;
using LiveCharts.Defaults;

namespace UniversityManagementSystem.Extensions
{
    public static class DictionaryExtension
    {
        public static IEnumerable<ObservablePoint> AsObservablePoints(this IDictionary<int, int> dictionary)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(pair => pair.Key, pair => pair.Value);
        }
        
        public static IEnumerable<ObservablePoint> AsObservablePoints<TKey>(
            this IDictionary<TKey, int> dictionary,
            Func<TKey, int> xSelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(pair => xSelector(pair.Key), pair => pair.Value);
        }

        public static IEnumerable<ObservablePoint> AsObservablePoints<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            Func<KeyValuePair<TKey, TValue>, int> xSelector,
            Func<KeyValuePair<TKey, TValue>, int> ySelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.Select(pair => new ObservablePoint(xSelector(pair), ySelector(pair)));
        }
    }
}