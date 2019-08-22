using PoCReports.Templates.ReportTemplates;
using PoCReports.Utils;
using System;

namespace PoCReportGenerationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating pdf reports...");

            //var connectionstring = @"Server=(localdb)\mssqllocaldb;Database=TestReportDB;Integrated Security=True";
            //var optionsBuilder = new DbContextOptionsBuilder<ReportDBContext>();
            //optionsBuilder.UseSqlServer(connectionstring);
            //ReportDBContext reportDBContext = new ReportDBContext(optionsBuilder.Options);
            //IntensityCheckRepository pr = new IntensityCheckRepository(reportDBContext);

            //var data = pr.GetAll().FirstOrDefaultAsync().Result;
            //Console.WriteLine(data.Name);   

            //var slReport = new SpectrometerLayoutRpt();
            //ReportGenerationUtils.GeneratePdfReport(slReport, "SpectrometerLayoutReport");

            GenerateReports();

            Console.WriteLine("Reports generated.");
            Console.ReadKey();
        }

        public static void GenerateReports()
        {
            //var qaGeneralInstrumentDataReport = ReportBuilder.CreateQAGeneralInstrumentDataReport();
            //ReportGenerationUtils.GeneratePdfReport(qaGeneralInstrumentDataReport, "QAGeneralInstrumentDataReport");

            //var icReport = ReportBuilder.CreateInstrumentConfigurationReport();
            //ReportGenerationUtils.GeneratePdfReport(icReport, "InstrumentConfigurationReport");

            //var intensityCheckReport = new IntensityCheckRpt();
            //ReportGenerationUtils.GeneratePdfReport(intensityCheckReport, "IntensityCheckReport");

            //var gsgReport = ReportBuilder.CreateGoniometerScanGraphicsReport();
            //ReportGenerationUtils.GeneratePdfReport(gsgReport, "GoniometerGraphicsReport");

            //var gsgCombinedReport = ReportBuilder.CreateGoniometerScanGraphicsCombinedSeriesReport();
            //ReportGenerationUtils.GeneratePdfReport(gsgCombinedReport, "GoniometerGraphicsCombinedSeriesReport");

            //var mdtCombinedReport = ReportBuilder.CreateMonochromatorDeadTimeGraphicsCombinedSeriesReport();
            //ReportGenerationUtils.GeneratePdfReport(mdtCombinedReport, "MonochromatorDeadTimeSeriesReport");

            var mdReport = ReportBuilder.CreateMasterDetailReport();
            ReportGenerationUtils.GeneratePdfReport(mdReport, "MasterDetailReport");

            //var combinedReport = ReportBuilder.CreateCombinedReport();
            //ReportGenerationUtils.GeneratePdfReport(combinedReport, "CombinedReport");
        }
    }
}
