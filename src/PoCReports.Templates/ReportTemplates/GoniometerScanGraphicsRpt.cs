using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using PoCReports.Models;

namespace PoCReports.Templates.ReportTemplates
{
    public partial class GoniometerScanGraphicsRpt
    {
        public GoniometerScanGraphicsRpt()
        {
            InitializeComponent();

            this.chart1.DataSource = GetGoniometerScanGraphicsData();
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
    }
}
