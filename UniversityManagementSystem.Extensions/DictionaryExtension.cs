using System;
using System.Collections.Generic;
using System.Linq;
using LiveCharts.Defaults;

namespace UniversityManagementSystem.Extensions
{
    /// <summary>
    ///     Defines extension methods for dictionaries.
    /// </summary>
    public static class DictionaryExtension
    {
        /// <summary>
        ///     Maps a dictionary to observable points.
        /// </summary>
        /// <param name="dictionary">The dictionary to map to observable points.</param>
        /// <returns>The observable points mapped from the dictionary.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the dictionary is null.</exception>
        public static IEnumerable<ObservablePoint> AsObservablePoints(this IDictionary<int, int> dictionary)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(i => i, i => i);
        }

        /// <summary>
        ///     Maps a dictionary to observable points.
        /// </summary>
        /// <param name="dictionary">The dictionary to map to observable points.</param>
        /// <param name="xSelector">The function to map dictionary keys to x co-ordinates.</param>
        /// <typeparam name="TKey">The type of the dictionary keys.</typeparam>
        /// <returns>The observable points mapped from the dictionary.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the dictionary is null.</exception>
        public static IEnumerable<ObservablePoint> AsObservablePoints<TKey>(
            this IDictionary<TKey, int> dictionary,
            Func<TKey, int> xSelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(xSelector, i => i);
        }

        /// <summary>
        ///     Maps a dictionary to observable points.
        /// </summary>
        /// <param name="dictionary">The dictionary to map to observable points.</param>
        /// <param name="ySelector">The function to map dictionary values to y co-ordinates.</param>
        /// <typeparam name="TValue">The type of the dictionary values.</typeparam>
        /// <returns>The observable points mapped from the dictionary.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the dictionary is null.</exception>
        public static IEnumerable<ObservablePoint> AsObservablePoints<TValue>(
            this IDictionary<int, TValue> dictionary,
            Func<TValue, int> ySelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(i => i, ySelector);
        }

        /// <summary>
        ///     Maps a dictionary to observable points.
        /// </summary>
        /// <param name="dictionary">The dictionary to map to observable points.</param>
        /// <param name="xSelector">The function to map dictionary keys to x co-ordinates.</param>
        /// <param name="ySelector">The function to map dictionary values to y co-ordinates.</param>
        /// <typeparam name="TKey">The type of the dictionary keys.</typeparam>
        /// <typeparam name="TValue">The type of the dictionary values.</typeparam>
        /// <returns>The observable points mapped from the dictionary.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the dictionary is null.</exception>
        public static IEnumerable<ObservablePoint> AsObservablePoints<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            Func<TKey, int> xSelector,
            Func<TValue, int> ySelector
        )
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.AsObservablePoints(pair => xSelector(pair.Key), pair => ySelector(pair.Value));
        }

        /// <summary>
        ///     Maps a dictionary to observable points.
        /// </summary>
        /// <param name="dictionary">The dictionary to map to observable points.</param>
        /// <param name="xSelector">The function to map dictionary key value pairs to x co-ordinates.</param>
        /// <param name="ySelector">The function to map dictionary key value pairs to y co-ordinates.</param>
        /// <typeparam name="TKey">The type of the dictionary keys.</typeparam>
        /// <typeparam name="TValue">The type of the dictionary values.</typeparam>
        /// <returns>The observable points mapped from the dictionary.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the dictionary is null.</exception>
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