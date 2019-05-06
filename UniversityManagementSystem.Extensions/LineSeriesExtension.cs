using LiveCharts;
using LiveCharts.Definitions.Series;

namespace UniversityManagementSystem.Extensions
{
    /// <summary>
    ///     Defines extension methods for line series.
    /// </summary>
    public static class LineSeriesExtension
    {
        /// <summary>
        ///     Maps a series view to a collection of series.
        /// </summary>
        /// <param name="series">The series view to map to a collection of series.</param>
        /// <returns>The collection of series mapped from the series view.</returns>
        public static SeriesCollection AsSeriesCollection(this ISeriesView series)
        {
            return new SeriesCollection {series};
        }
    }
}