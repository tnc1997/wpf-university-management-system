using LiveCharts;
using LiveCharts.Wpf;
using UniversityManagementSystem.Extensions;

namespace UniversityManagementSystem.Apps.Wpf.Extensions
{
    /// <summary>
    ///     Defines extension methods for chart values.
    /// </summary>
    public static class ChartValuesExtension
    {
        /// <summary>
        ///     Maps chart values to a column series.
        /// </summary>
        /// <param name="values">The values to map to a column series.</param>
        /// <returns>The column series mapped from the values.</returns>
        public static ColumnSeries AsColumnSeries(this IChartValues values)
        {
            return values.AsSeriesView<ColumnSeries>();
        }

        /// <summary>
        ///     Maps chart values to a line series.
        /// </summary>
        /// <param name="values">The values to map to a line series.</param>
        /// <returns>The line series mapped from the values.</returns>
        public static LineSeries AsLineSeries(this IChartValues values)
        {
            return values.AsSeriesView<LineSeries>();
        }
    }
}