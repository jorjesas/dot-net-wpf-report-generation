using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using PoCReports.Models;

namespace PoCReports.Templates.ReportTemplates
{
    public partial class MonochromatorDeadTimeGraphicsRpt
    {
        public MonochromatorDeadTimeGraphicsRpt()
        {
            InitializeComponent();

            chart1.DataSource = GetCombinedSeriesData();
        }

        private IList<XYPointModel> GetSeries1Data()
        {
            return new List<XYPointModel>
            {
                new XYPointModel { Y = 75, X = 7},
                new XYPointModel { Y = 240, X = 20},
                new XYPointModel { Y = 420, X = 30},
                new XYPointModel { Y = 570, X = 40},
                new XYPointModel { Y = 690, X = 50},
                new XYPointModel { Y = 800, X = 60},
            };
        }

        private IList<XYPointModel> GetSeries2Data()
        {
            return new List<XYPointModel>
            {
                new XYPointModel { Y = 75, X = 7},
                new XYPointModel { Y = 105, X = 10},
                new XYPointModel { Y = 220, X = 20},
                new XYPointModel { Y = 400, X = 30},
                new XYPointModel { Y = 540, X = 40},
                new XYPointModel { Y = 650, X = 50},
                new XYPointModel { Y = 730, X = 60},
            };
        }

        private IList<XYPointCombinedSeriesModel> GetCombinedSeriesData()
        {
            return new List<XYPointCombinedSeriesModel>
            {
                new XYPointCombinedSeriesModel
                {
                    Series1 = GetSeries1Data(),
                    Series2 = GetSeries2Data()
                }
            };
        }
    }
}
