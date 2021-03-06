﻿using System;
using System.Collections.Generic;

namespace UniversityManagementSystem.Extensions
{
    /// <summary>
    ///     Defines extension methods for collections.
    /// </summary>
    public static class CollectionExtension
    {
        /// <summary>
        ///     Adds an enumerable of items to the end of the collection.
        /// </summary>
        /// <typeparam name="TSource">The type of the items.</typeparam>
        /// <param name="collection">The collection to add the items to.</param>
        /// <param name="items">The items to add to the collection.</param>
        public static void AddRange<TSource>(this ICollection<TSource> collection, IEnumerable<TSource> items)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            if (items == null) throw new ArgumentNullException(nameof(items));

            foreach (var item in items) collection.Add(item);
        }
    }
}