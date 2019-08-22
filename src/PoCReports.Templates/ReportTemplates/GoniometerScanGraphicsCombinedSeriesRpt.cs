using System;
using System.Collections.Generic;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using PoCReports.Models;

namespace PoCReports.Templates.ReportTemplates
{
    public partial class GoniometerScanGraphicsCombinedSeriesRpt
    {
        public GoniometerScanGraphicsCombinedSeriesRpt()
        {
            InitializeComponent();

            //this.Detail.Controls.Add(CreateChart());

            chart1.DataSource = GetData();
            chart1.CustomDrawSeriesPoint += OnCustomDrawSeriesPoint;
        }

        private XRControl CreateChart()
        {
            XRChart xrChart1 = new XRChart();
            xrChart1.WidthF = 640;
            xrChart1.HeightF = 400;

            xrChart1.DataSource = GetData();

            Series series1 = new Series("Spline Series 1", ViewType.Spline);
            series1.ArgumentDataMember = "GoniometerScanGraphicsSeries1.Angle";
            series1.ValueDataMembers.AddRange(new string[] { "GoniometerScanGraphicsSeries1.Intensity" });
            series1.Visible = true;

            Series series2 = new Series("Spline Series 2", ViewType.Spline);
            series2.ArgumentDataMember = "GoniometerScanGraphicsSeries2.Angle";
            series2.ValueDataMembers.AddRange(new string[] { "GoniometerScanGraphicsSeries2.Intensity" });
            series2.Visible = true;

            xrChart1.Series.Add(series1);
            xrChart1.Series.Add(series2);

            return xrChart1;
        }

        private object GetData()
        {
            var dataSource = GetGoniometerScanGraphicsCombinedSeriesData();
            return dataSource;
        }

        private IList<XYPointModel> GetGoniometerScanGraphicsData()
        {
            return new List<XYPointModel>
            {
                new XYPointModel { Y = 0.1, X = 44},
                new XYPointModel { Y = 0.2, X = 44.1},
                new XYPointModel { Y = 0.3, X = 44.2},
                new XYPointModel { Y = 0.3, X = 44.3},
                new XYPointModel { Y = 0.3, X = 44.4},
                new XYPointModel { Y = 0.3, X = 44.5},
                new XYPointModel { Y = 0.5, X = 44.6},
                new XYPointModel { Y = 2, X = 44.7},
                new XYPointModel { Y = 9, X = 44.8},
                new XYPointModel { Y = 35, X = 44.9},
                new XYPointModel { Y = 60, X = 45},
                new XYPointModel { Y = 35, X = 45.1},
                new XYPointModel { Y = 8, X = 45.2},
                new XYPointModel { Y = 2, X = 45.3},
                new XYPointModel { Y = 0.5, X = 45.4},
                new XYPointModel { Y = 0.3, X = 45.5},
                new XYPointModel { Y = 0.3, X = 45.6},
                new XYPointModel { Y = 0.3, X = 45.7},
                new XYPointModel { Y = 0.2, X = 45.8},
                new XYPointModel { Y = 0.2, X = 45.9},
                new XYPointModel { Y = 0.1, X = 46},
            };
        }

        private IList<XYPointModel> GetGoniometerScanGraphicsData2()
        {
            return new List<XYPointModel>
            {
                new XYPointModel { Y = 0.1, X = 44.8},
                new XYPointModel { Y = 25, X = 44.8},
                new XYPointModel { Y = 25, X = 45.2},
                new XYPointModel { Y = 0.1, X = 45.2}
            };
        }

        private IList<XYPointCombinedSeriesModel> GetGoniometerScanGraphicsCombinedSeriesData()
        {
            return new List<XYPointCombinedSeriesModel>
            {
                new XYPointCombinedSeriesModel
                {
                    Series1 = GetGoniometerScanGraphicsData(),
                    Series2 = GetGoniometerScanGraphicsData2()
                }
            };
        }

        private void OnCustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            if (e.SeriesPoint.Values.Length > 0)
            {
                var value = e.SeriesPoint.Values[0];
                if (value > 50)
                {
                    e.LabelText = $"{value}";
                }
                else
                {
                    e.LabelText = string.Empty;
                }
            }          
        }
    }
}
