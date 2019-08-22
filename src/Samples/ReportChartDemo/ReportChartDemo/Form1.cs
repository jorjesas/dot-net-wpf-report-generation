using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;

namespace ReportChartDemo
{
	public partial class Form1 : Form
	{
		ChartInfo _chartInfo;
		ChartReport _report;

		public Form1()
		{
			InitializeComponent();

			_chartInfo = new ChartInfo(new List<SeriesInfo> { GenerateSeries(1) });
			_report = new ChartReport();
			var panel = new XRDesignPanel {Dock = DockStyle.Fill};
			
			Controls.Add(panel);
			panel.OpenReport(_report);

			_report.SetDataSource(_chartInfo);
		}

		private void addSeriesButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var series = GenerateSeries(_chartInfo.SeriesList.Count + 1);
			
			_report.AddSeries(series);
		}
		
		private SeriesInfo GenerateSeries(int seriesIndex)
		{
			var startDate = new DateTime(2016, 1, 1);
			var endDate = new DateTime(2016, 3, 1);
			var data = new List<DataElement>();

			for (var date = startDate; date < endDate; date = date.AddDays(1))
			{
				data.Add(new DataElement(date, (decimal)Math.Sin(date.Day) + seriesIndex));
			}

			return new SeriesInfo("Series " + seriesIndex, data);
		}
	}
}
