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

            return dictionary.AsObservablePoints(i => i, i => i);
        }

        public static IEnumerable<ObservablePoint> AsObservablePoints<TKey>(
            this IDictionary<TKey, int> dictionary,
            Func<TKey, int> xSelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(xSelector, i => i);
        }

        public static IEnumerable<ObservablePoint> AsObservablePoints<TValue>(
            this IDictionary<int, TValue> dictionary,
            Func<TValue, int> ySelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(i => i, ySelector);
        }

        public static IEnumerable<ObservablePoint> AsObservablePoints<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            Func<TKey, int> xSelector,
            Func<TValue, int> ySelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(pair => xSelector(pair.Key), pair => ySelector(pair.Value));
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