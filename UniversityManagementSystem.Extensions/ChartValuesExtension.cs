using LiveCharts;
using LiveCharts.Definitions.Series;

namespace UniversityManagementSystem.Extensions
{
    /// <summary>
    ///     Defines extension methods for chart values.
    /// </summary>
    public static class ChartValuesExtension
    {
        /// <summary>
        ///     Maps chart values to a series view.
        /// </summary>
        /// <param name="values">The values to map to a series view.</param>
        /// <typeparam name="TSeriesView">The type of the series view.</typeparam>
        /// <returns>The series view mapped from the values.</returns>
        public static TSeriesView AsSeriesView<TSeriesView>(this IChartValues values)
            where TSeriesView : ISeriesView, new()
        {
            return new TSeriesView
            {
                Values = values
            };
        }
    }
}