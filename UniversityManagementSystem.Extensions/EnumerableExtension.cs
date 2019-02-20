using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityManagementSystem.Extensions
{
    public static class EnumerableExtension
    {
        public static IEnumerable<TResult> Distinct<TSource, TResult>(
            this IEnumerable<TSource> enumerable,
            Func<TSource, TResult> selector
        )
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

            return enumerable.Select(selector).Distinct();
        }
        
        public static TSource MaxBy<TSource>(
            this IEnumerable<TSource> enumerable,
            Func<TSource, int> selector
        )
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return enumerable.Aggregate((min, value) => selector(value) > selector(min) ? value : min);
        }

        public static TSource MinBy<TSource>(
            this IEnumerable<TSource> enumerable,
            Func<TSource, int> selector
        )
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return enumerable.Aggregate((min, value) => selector(value) < selector(min) ? value : min);
        }
    }
}