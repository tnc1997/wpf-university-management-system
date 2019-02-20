using LiveCharts;
using LiveCharts.Definitions.Series;

namespace UniversityManagementSystem.Extensions
{
    public static class ChartValuesExtension
    {
        public static TSeriesView AsSeriesView<TSeriesView>(this IChartValues values) where TSeriesView : ISeriesView, new()
        {
            return new TSeriesView
            {
                Values = values
            };
        }
    }
}