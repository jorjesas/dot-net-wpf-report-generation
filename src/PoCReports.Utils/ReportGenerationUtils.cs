using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCReports.Utils
{
    public class ReportGenerationUtils
    {
        public static bool GeneratePdfReport(XtraReport report, string fileName)
        {
            PdfExportOptions options = new PdfExportOptions();
            //options.PdfACompatibility = PdfACompatibility.PdfA1b;
            //options.PasswordSecurityOptions.PermissionsPassword = "pwd";
            //options.ShowPrintDialogOnOpen = true;
            IList<string> result = options.Validate();
            if (result.Count > 0)
            {
                //Console.WriteLine(String.Join(Environment.NewLine, result));
                return false;
            }

            Directory.CreateDirectory("PDF");

            report.ExportToPdf($"PDF/{fileName}.pdf", options);
            return true;
        }
    }
}
