using System;

namespace ReportChartDemo
{
	public class DataElement
	{
		public DataElement(DateTime time, decimal value)
		{
			Time = time;
			Value = value;
		}

		public DateTime Time { get; set; }
		public decimal Value { get; set; }
	}
}
