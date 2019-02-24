using LiveCharts;
using LiveCharts.Wpf;
using UniversityManagementSystem.Extensions;

namespace UniversityManagementSystem.Apps.Wpf.Extensions
{
    public static class ChartValuesExtension
    {
        public static ColumnSeries AsColumnSeries(this IChartValues values)
        {
            return values.AsSeriesView<ColumnSeries>();
        }

        public static LineSeries AsLineSeries(this IChartValues values)
        {
            return values.AsSeriesView<LineSeries>();
        }
    }
}