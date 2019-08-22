using System.Collections.Generic;

namespace ReportChartDemo
{
	public class SeriesInfo
	{
		public SeriesInfo(string name, IEnumerable<DataElement> data)
		{
			Name = name;
			Data = data;
		}

		public string Name { get; set; }
		public IEnumerable<DataElement> Data { get; set; }
	}
}
