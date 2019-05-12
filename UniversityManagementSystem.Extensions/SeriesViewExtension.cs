using System;
using LiveCharts;
using LiveCharts.Definitions.Series;

namespace UniversityManagementSystem.Extensions
{
    /// <summary>
    ///     Defines extension methods for series views.
    /// </summary>
    public static class SeriesViewExtension
    {
        /// <summary>
        ///     Maps a series view to a collection of series.
        /// </summary>
        /// <param name="series">The series view to map to a collection of series.</param>
        /// <returns>The collection of series mapped from the series view.</returns>
        /// <exception cref="ArgumentNullException">Thrown when series is null.</exception>
        public static SeriesCollection AsSeriesCollection(this ISeriesView series)
        {
            if (series == null) throw new ArgumentNullException(nameof(series));
            
            return new SeriesCollection {series};
        }
    }
}