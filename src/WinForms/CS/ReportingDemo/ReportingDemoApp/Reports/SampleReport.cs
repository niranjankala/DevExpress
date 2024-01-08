using System;
using System.Linq;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace T333639 {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        LookUpValueCollection _reportColumns;

        public SampleReport() {
            InitializeComponent();

            // Initialize a list of lookup values for report columns.
            _reportColumns = new LookUpValueCollection() {
                    new LookUpValue("ID", "ID"),
                    new LookUpValue("Name", "Name"),
                    new LookUpValue("Category", "Category"),
                    new LookUpValue("Supplier", "Supplier"),
                    new LookUpValue("UnitPrice", "Price"),
                    new LookUpValue("UnitsInStock", "In Stock"),
                    new LookUpValue("UnitsOnOrder", "On Order"),
                    new LookUpValue("QuantityPerUnit", "Quantity Per Unit")
            };

            var reportColumnsLookUpSettings = new StaticListLookUpSettings();
            reportColumnsLookUpSettings.LookUpValues.AddRange(_reportColumns);

            // Assign the list of lookup values to the report's ReportColumns parameter.
            this.Parameters["ReportColumns"].LookUpSettings = reportColumnsLookUpSettings;

            // Specify default lookup values.
            this.Parameters["ReportColumns"].Value = new string[] { "ID", "Name", "Category", "Supplier", "UnitPrice" };
        }

        private void SampleReport_DataSourceDemanded(object sender, EventArgs e) {
            // Get the selected report columns.
            var columns = this.Parameters["ReportColumns"].Value as string[];
            
            this.tblHeader.BeginInit();
            this.tblDetail.BeginInit();

            this.trHeader.Cells.Clear();
            this.trDetail.Cells.Clear();

            // Create a table header cell and table body cell for each selected column.
            foreach (string column in columns) {
                string description = _reportColumns.Single(lookupValue => lookupValue.Value.Equals(column)).Description;

                // Assign a column description to the table header cell.
                var headerCell = new XRTableCell();
                headerCell.Text = description;
                this.trHeader.Cells.Add(headerCell);

                // Bind the table body cell to the column.
                var bodyCell = new XRTableCell();
                bodyCell.ExpressionBindings.Add(new ExpressionBinding("Text", "[" + column + "]"));
                this.trDetail.Cells.Add(bodyCell);
            }

            this.tblHeader.EndInit();
            this.tblDetail.EndInit();
        }

    }
}
