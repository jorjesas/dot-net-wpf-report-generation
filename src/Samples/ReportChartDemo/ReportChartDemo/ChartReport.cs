using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace ReportChartDemo
{
	public partial class ChartReport : DevExpress.XtraReports.UI.XtraReport
	{
		public ChartReport()
		{
			InitializeComponent();

			PrintingSystem.PageSettings.Landscape = Landscape;
			PrintingSystem.PageSettings.PaperKind = PaperKind;

			PrintingSystem.AfterMarginsChange += (sender, args) => UpdateReport();
			PrintingSystem.PageSettingsChanged += (sender, args) => UpdateReport();
		}

		public ChartInfo Chart { get { return DataSource as ChartInfo; } } 
	
		public void SetDataSource(ChartInfo chart)
		{
			DataSource = chart;
			CreateReport();
		}
		
		public void CreateReport()
		{
			xrChart1.Series.Clear();
			foreach (var seriesInfo in Chart.SeriesList)
			{
				AddInternalSeries(seriesInfo);
			}
		}

		private void AddInternalSeries(SeriesInfo seriesInfo)
		{
			
			var series = new Series(seriesInfo.Name, ViewType.Line);
			((LineSeriesView)series.View).MarkerVisibility = DefaultBoolean.False;
			series.ArgumentDataMember = "Time";
			series.ArgumentScaleType = ScaleType.DateTime;
			series.LabelsVisibility = DefaultBoolean.False;
			series.ValueDataMembersSerializable = "Value";
			series.DataSource = seriesInfo.Data;
			xrChart1.Series.Add(series);
		}

		public void AddSeries(SeriesInfo seriesInfo)
		{
			Chart.SeriesList.Add(seriesInfo);
			AddInternalSeries(seriesInfo);
		}

		private void UpdateReport()
		{
			TopMargin.Height = PrintingSystem.PageMargins.Top;
			BottomMargin.Height = PrintingSystem.PageMargins.Bottom;
			Margins.Left = PrintingSystem.PageMargins.Left;
			Margins.Right = PrintingSystem.PageMargins.Right;
			PaperKind = PrintingSystem.PageSettings.PaperKind;
			PaperName = PrintingSystem.PageSettings.PaperName;
			Landscape = PrintingSystem.PageSettings.Landscape;

			CreateReport();
			CreateDocument();
		}
	}
}
