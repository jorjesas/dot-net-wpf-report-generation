using System.Collections.Generic;

namespace ReportChartDemo
{
	public class ChartInfo
	{
		public ChartInfo(IList<SeriesInfo> seriesList)
		{
			SeriesList = seriesList;
		}

		public IList<SeriesInfo> SeriesList { get; set; }
	}
}
