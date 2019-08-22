using System;
using System.Drawing;
using DevExpress.XtraReports.Configuration;
using DevExpress.XtraReports.UI;
using PoCReports.BusinessLayer;
using PoCReports.Models;

namespace PoCReports.Templates.ReportTemplates
{
    public partial class MasterDetailsRpt
    {
        public MasterDetailsRpt()
        {
            InitializeComponent();

            Detail.HeightF = 30;

            this.DataSource = ReportsDataBL.GetSupplierData();
            this.DetailReport.DataMember = "Products";
            this.DetailReportInner.DataMember = "Products.OrderDetails";

            AssignControlDataMember(SupplierLabel, "CompanyName", true);
            AssignControlDataMember(ProductLabel, "Products.ProductName", true);
            AssignControlDataMember(tcProductQuantity, "Products.OrderDetails.Quantity");
            AssignControlDataMember(tcProductUnitPrice, "Products.Price");

            // Create a calculated field  
            // and add it to the report's collection. 
            CalculatedField calcField = new CalculatedField();
            // Define the calculated field's properties. 
            calcField.DataSource = ReportsDataBL.GetSupplierData();
            calcField.DataMember = "Products.OrderDetails";
            calcField.FieldType = FieldType.Double;
            calcField.DisplayName = "Calculated Field";
            calcField.Name = "TotalOrderProductPrice";
            calcField.Expression = "[Products.OrderDetails.Quantity] * [Products.Price]";

            AssignControlDataMember(tcProductPriceTotal, "[Products.OrderDetails.Quantity]*[Products.Price]");

            //Detail.Controls.Add(CreateBoundLabel("CompanyName", Color.Gold, 0));
            //DetailReportDetail.Controls.Add(CreateBoundLabel("Products.ProductName", Color.Aqua, 100));
            //DetailReportInnerDetail.Controls.Add(CreateBoundLabel("Products.OrderDetails.Quantity", Color.Pink, 200));
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

        private void AssignControlDataMember(XRControl control, string dataMember, bool isBookmark = false)
        {
            // Specify the label's binding depending on the data binding mode. 
            if (Settings.Default.UserDesignerOptions.DataBindingMode == DataBindingMode.Bindings)
                control.DataBindings.Add(new XRBinding("Text", null, dataMember));
            else control.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", dataMember));

            if (isBookmark)
            {
                control.Bookmark = dataMember;
            }            
        }

    }
}
