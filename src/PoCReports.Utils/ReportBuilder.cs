using DevExpress.XtraReports.Configuration;
using DevExpress.XtraReports.UI;
using PoCReports.BusinessLayer;
using PoCReports.Models;
using PoCReports.Templates.ReportTemplates;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PoCReports.Utils
{
    public class ReportBuilder
    {
        public static QAGeneralInstrumentDataReport CreateQAGeneralInstrumentDataReport()
        {
            QAGeneralInstrumentDataReport report = new QAGeneralInstrumentDataReport();
            report.DataSource = GetQAInstrumentGeneralData();

            return report;
        }

        public static InstrumentConfigurationRpt CreateInstrumentConfigurationReport()
        {
            InstrumentConfigurationRpt report = new InstrumentConfigurationRpt();
            report.DataSource = GetICHeaderData();

            return report;
        }

        public static SpectrometerLayoutRpt CreateSpectrometerLayoutReport()
        {
            SpectrometerLayoutRpt report = new SpectrometerLayoutRpt();

            return report;
        }

        public static GoniometerScanGraphicsRpt CreateGoniometerScanGraphicsReport()
        {
            GoniometerScanGraphicsRpt report = new GoniometerScanGraphicsRpt();
            report.DataSource = GetGoniometerScanGraphicsData();
            report.ReportPrintOptions.DetailCount = 1;

            return report;
        }

        public static GoniometerScanGraphicsCombinedSeriesRpt CreateGoniometerScanGraphicsCombinedSeriesReport()
        {
            GoniometerScanGraphicsCombinedSeriesRpt report = new GoniometerScanGraphicsCombinedSeriesRpt();
            report.DataSource = GetGoniometerScanGraphicsCombinedSeriesData();
            report.ReportPrintOptions.DetailCount = 1;

            return report;
        }

        public static MonochromatorDeadTimeGraphicsRpt CreateMonochromatorDeadTimeGraphicsCombinedSeriesReport()
        {
            MonochromatorDeadTimeGraphicsRpt report = new MonochromatorDeadTimeGraphicsRpt();
            report.ReportPrintOptions.DetailCount = 1;

            return report;
        }

        public static XtraReport CreateMasterDetailReport()
        {
            var report = new MasterDetailsRpt();        

            return report;
        }

        //public static XtraReport CreateMasterDetailReport()
        //{
        //    XtraReport report = new XtraReport();

        //    DetailBand detail = new DetailBand();
        //    detail.Height = 30;
        //    report.Bands.Add(detail);

        //    DetailReportBand detailReport1 = new DetailReportBand();
        //    report.Bands.Add(detailReport1);

        //    DetailBand detail1 = new DetailBand();
        //    detail1.Height = 30;
        //    detailReport1.Bands.Add(detail1);

        //    DetailReportBand detailReport2 = new DetailReportBand();
        //    detailReport1.Bands.Add(detailReport2);

        //    DetailBand detail2 = new DetailBand();
        //    detail2.Height = 30;
        //    detailReport2.Bands.Add(detail2);

        //    report.DataSource = ReportsDataBL.GetSupplierData();
        //    detailReport1.DataMember = "Products";
        //    detailReport2.DataMember = "Products.OrderDetails";

        //    detail.Controls.Add(CreateBoundLabel("CompanyName", Color.Gold, 0));
        //    detail1.Controls.Add(CreateBoundLabel("Products.ProductName", Color.Aqua, 100));
        //    detail2.Controls.Add(CreateBoundLabel("Products.OrderDetails.Quantity", Color.Pink, 200));

        //    return report;
        //}

        public static XtraReport CreateCombinedReport()
        {
            // Create the 1st report and generate its document. 
            QAGeneralInstrumentDataReport report1 = CreateQAGeneralInstrumentDataReport();
            report1.CreateDocument();

            // Create the 2nd report and generate its document. 
            InstrumentConfigurationRpt report2 = CreateInstrumentConfigurationReport();
            report2.CreateDocument();

            // Create the 3rd report and generate its document. 
            GoniometerScanGraphicsRpt report3 = CreateGoniometerScanGraphicsReport();
            report3.CreateDocument();

            // Add all pages of the 2nd report to the end of the 1st report. 
            report1.ModifyDocument(x => {
                x.AddPages(report2.Pages);
                x.AddPages(report3.Pages);
            });

            // Reset all page numbers in the resulting document. 
            report1.PrintingSystem.ContinuousPageNumbering = true;

            return report1;
        }

        private static IList<QAInstrumentGeneralDataModel> GetQAInstrumentGeneralData()
        {
            return new List<QAInstrumentGeneralDataModel>
            {
                new QAInstrumentGeneralDataModel()
                {
                    InstrumentName = "Name#1",
                    InstrumentNumber = "Number#1"
                }
            };
        }

        private static IList<InstrumentConfigurationHeaderDataModel> GetICHeaderData()
        {
            return new List<InstrumentConfigurationHeaderDataModel>
            {
                new InstrumentConfigurationHeaderDataModel
                {
                    InstrumentName = "9900",
                    XRayTubePowerSupply = 60,
                    ConveyorType = "X-Y manipulator",
                    PositionNumber = 91,
                    Target = "Rh"
                }
            };
        }

        private static IList<XYPointModel> GetGoniometerScanGraphicsData()
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

        private static IList<XYPointModel> GetGoniometerScanGraphicsData2()
        {
            return new List<XYPointModel>
            {
                new XYPointModel { Y = 0.1, X = 44.8},
                new XYPointModel { Y = 25, X = 44.8},
                new XYPointModel { Y = 25, X = 45.2},
                new XYPointModel { Y = 0.1, X = 45.2}
            };
        }

        private static IList<XYPointCombinedSeriesModel> GetGoniometerScanGraphicsCombinedSeriesData()
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

        private static XRLabel CreateBoundLabel(string dataMember, Color backColor, int offset)
        {
            XRLabel label = new XRLabel();
            // Specify the label's binding depending on the data binding mode. 
            if (Settings.Default.UserDesignerOptions.DataBindingMode == DataBindingMode.Bindings)
                label.DataBindings.Add(new XRBinding("Text", null, dataMember));
            else label.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", dataMember));


            label.BackColor = backColor;
            label.Location = new Point(offset, 0);

            return label;
        }


    }
}
