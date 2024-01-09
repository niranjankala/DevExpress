using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace ReportingDemoApp.Reports
{
    public partial class ClientStatReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ClientStatReport()
        {
            InitializeComponent();
        }

        private void ClientStatReport_DataSourceDemanded(object sender, EventArgs e)
        {
            if (this.Parameters?.Count > 0)
            {
                // Get the selected report columns.
                var searchBy = (SearchBy)(int)this.Parameters["searchBy"].Value;
                var sortResultsBy = (SortResultsBy)(int)this.Parameters["sortResultsBy"].Value;
                // Manage Group Bands
                if (sortResultsBy == SortResultsBy.ManagementCompany || sortResultsBy == SortResultsBy.Complex)
                {
                    if (!this.Bands.Contains(GroupFooter2))
                    {
                        this.SuspendLayout();
                        this.Bands.Add(GroupFooter2);
                        this.Bands.SetChildIndex(GroupFooter2, this.Bands.Count - 2);
                        this.ResumeLayout();
                    }
                    tbGroupSummary.SuspendLayout();
                    trGroupSummary.Cells.Clear();
                }
                else
                {
                    if (this.Bands.Contains(GroupFooter2))
                    {
                        this.SuspendLayout();
                        this.Bands.Remove(GroupFooter2);
                        this.ResumeLayout();
                    }
                }

                List<ReportColumn> columns = GetReportColumns(searchBy, sortResultsBy);
                tblHeader.SuspendLayout();
                tblDetails.SuspendLayout();
                tblGrandTotal.SuspendLayout();
                trHeader.Cells.Clear();
                trDetail.Cells.Clear();
                trGrandTotal.Cells.Clear();
                for (int columnIndex = 0; columnIndex < columns.Count; columnIndex++)
                {
                    ReportColumn column = columns[columnIndex];
                    AddHeaderCells(trHeader, column);
                    AddDetailCells(trDetail, column);
                    if (sortResultsBy == SortResultsBy.ManagementCompany || sortResultsBy == SortResultsBy.Complex)
                    {
                        AddSummaryCells(trGroupSummary, column, "TotalData1", SummaryRunning.Group, null);
                        AddSummaryCells(trGrandTotal, column, "GrandTotalData1", SummaryRunning.Report, columnIndex == 0 ? "Totals:" : null);
                    }
                }

                if (sortResultsBy == SortResultsBy.ManagementCompany || sortResultsBy == SortResultsBy.Complex)
                {
                    tbGroupSummary.PerformLayout();
                }

                tblHeader.PerformLayout();
                tblDetails.PerformLayout();
                tblGrandTotal.PerformLayout();
            }
        }

        private void AddSummaryCells(XRTableRow row, ReportColumn column, string styleName, SummaryRunning summaryLevel, string rowTitle)
        {
            XRTableCell summaryCell = new XRTableCell();
            summaryCell.StyleName = styleName;
            if (string.IsNullOrEmpty(rowTitle))
            {
                if (column.Type == typeof(decimal))
                {
                    summaryCell.StylePriority.UseTextAlignment = false;
                    summaryCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                }
                if (column.AggregationType != AggregationType.None)
                {
                    // summaryCell.ExpressionBindings.Add(new ExpressionBinding("Text", "[" + column.FieldName + "]"));
                    summaryCell.ExpressionBindings.AddRange(new ExpressionBinding[] {
            new ExpressionBinding("BeforePrint", "Text", $"sumSum([{column.FieldName}])")});
                    XRSummary summary = new XRSummary();
                    summary.Running = summaryLevel;
                    summaryCell.Summary = summary;
                }

                if (!string.IsNullOrEmpty(column.TextFormatString))
                {
                    summaryCell.TextFormatString = column.TextFormatString;
                }
            }
            else
            {
                summaryCell.Text = rowTitle;
            }
            row.Cells.Add(summaryCell);

        }

        private void AddDetailCells(XRTableRow trDetail, ReportColumn column)
        {
            XRTableCell bodyCell = new XRTableCell();
            bodyCell.StyleName = "DetailData1";
            if (column.Type == typeof(decimal))
            {
                bodyCell.StylePriority.UseTextAlignment = false;
                bodyCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            }
            bodyCell.ExpressionBindings.Add(new ExpressionBinding("Text", "[" + column.FieldName + "]"));
            if (!string.IsNullOrEmpty(column.TextFormatString))
            {
                bodyCell.TextFormatString = column.TextFormatString;
            }
            trDetail.Cells.Add(bodyCell);



        }

        private void AddHeaderCells(XRTableRow trHeader, ReportColumn column)
        {
            XRTableCell headerCell = new XRTableCell();
            headerCell.Text = column.HeaderText;
            headerCell.StyleName = "DetailCaption1";
            if (column.Type == typeof(decimal))
            {
                headerCell.StylePriority.UseTextAlignment = false;
                headerCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            }
            trHeader.Cells.Add(headerCell);
        }

        private List<ReportColumn> GetReportColumns(SearchBy searchBy, SortResultsBy sortResultsBy)
        {
            //Invoice Date - INVDATE
            //Invoice Due Date - DATEDUE
            //Invoice Paid Date - DATEPAID
            //Invoice Due Amount - amtdue
            //Invoice Amount - invtotal

            // Work Order Date - DATELOGGED
            // Work Order Number  - WORKORDER
            // Complex - Complex
            //Assignment Text - assignmentText
            //First Name - EmpFirstName
            //Last Name - EmpLastName
            //Material Total - MaterialTotal
            //Labor Amount - TOTLaborAmount
            //Other Amount - OtherAmount

            var fields = this.Parameters["includeFields"].Value as string[];
            bool isComplexSelected = this.Parameters["complex"].Value != null;
            bool isCompanySelected = this.Parameters["company"].Value != null;
            List<ReportColumn> columns = new List<ReportColumn>();
            int columnVisiblePostion = 0;

            if (searchBy == SearchBy.WorkOrderDate)
            {
                columns.Add(new ReportColumn("DATELOGGED", "Work Order Date", null, null, "{0:MM/dd/yyyy}", typeof(DateTime), AggregationType.None, columnVisiblePostion));
            }
            else if (searchBy == SearchBy.InvoiceDate)
            {
                columns.Add(new ReportColumn("INVDATE", "Invoice Date", null, null, "{0:MM/dd/yyyy}", typeof(DateTime), AggregationType.None, columnVisiblePostion));
            }
            else if (searchBy == SearchBy.InvoicePaidDate)
            {
                columns.Add(new ReportColumn("DATEPAID", "Invoice Paid Date", null, null, "{0:MM/dd/yyyy}", typeof(DateTime), AggregationType.None, columnVisiblePostion));
            }

            if (searchBy != SearchBy.WorkOrderDate && fields?.Contains(((int)ReportFields.WorkOrderDate).ToString()) == true)
            {
                columns.Add(new ReportColumn("DATELOGGED", "Work Order Date", null, null, "{0:MM/dd/yyyy}", typeof(DateTime), AggregationType.None, ++columnVisiblePostion));
            }

            if (fields?.Contains(((int)ReportFields.InvoiceNumber).ToString()) == true)
            {
                columns.Add(new ReportColumn("INVNUM", "Invoice Number", null, null, null, typeof(int), AggregationType.None, ++columnVisiblePostion));
            }

            if (searchBy != SearchBy.InvoiceDate && fields?.Contains(((int)ReportFields.InvoiceDate).ToString()) == true)
            {
                columns.Add(new ReportColumn("INVDATE", "Invoice Date", null, null, "{0:MM/dd/yyyy}", typeof(DateTime), AggregationType.None, ++columnVisiblePostion));
            }

            if (searchBy != SearchBy.InvoicePaidDate && fields?.Contains(((int)ReportFields.InvoicePaidDate).ToString()) == true)
            {
                columns.Add(new ReportColumn("DATEPAID", "Invoice Paid Date", null, null, "{0:MM/dd/yyyy}", typeof(DateTime), AggregationType.None, ++columnVisiblePostion));
            }

            if (sortResultsBy == SortResultsBy.Complex)
            {
                columns.Add(new ReportColumn("Complex", "Complex", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
            }
            else if (sortResultsBy == SortResultsBy.ManagementCompany)
            {
                columns.Add(new ReportColumn("BillingOffice", "Management Company", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
            }

            if (isCompanySelected && sortResultsBy != SortResultsBy.ManagementCompany)
            {
                columns.Add(new ReportColumn("BillingOffice", "Management Company", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
            }

            if (isComplexSelected && sortResultsBy != SortResultsBy.Complex)
            {
                columns.Add(new ReportColumn("Complex", "Complex", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
            }

            if (fields?.Contains(((int)ReportFields.Name).ToString()) == true)
            {
                columns.Add(new ReportColumn("EmpFirstName", "First Name", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
                columns.Add(new ReportColumn("EmpLastName", "Last Name", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
            }
            if (fields?.Contains(((int)ReportFields.Assignment).ToString()) == true)
            {
                columns.Add(new ReportColumn("assignmentText", "Assignment", null, null, null, typeof(string), AggregationType.None, ++columnVisiblePostion));
            }

            if (fields?.Contains(((int)ReportFields.JobCost).ToString()) == true)
            {
                columns.Add(new ReportColumn("MaterialTotal", "Material Cost", null, null, "{0:C2}", typeof(decimal), AggregationType.Sum, ++columnVisiblePostion));
                columns.Add(new ReportColumn("TOTLaborAmount", "Labor Cost", null, null, "{0:C2}", typeof(decimal), AggregationType.Sum, ++columnVisiblePostion));
                columns.Add(new ReportColumn("OtherAmount", "Other Amount", null, null, "{0:C2}", typeof(decimal), AggregationType.Sum, ++columnVisiblePostion));
            }

            if (fields?.Contains(((int)ReportFields.InvoiceAmount).ToString()) == true)
            {
                columns.Add(new ReportColumn("INVNUM", "Invoice Amount", null, null, "{0:C2}", typeof(decimal), AggregationType.Sum, ++columnVisiblePostion));
            }

            return columns;
        }

        private void ClientStatReport_BeforePrint(object sender, CancelEventArgs e)
        {

            if (this.Parameters?.Count > 0)
            {

            }
        }
    }
    public enum SearchBy
    {
        None,
        WorkOrderDate,
        InvoiceDate,
        InvoicePaidDate

    }
    public enum SortResultsBy
    {
        None,
        Date,
        Complex,
        ManagementCompany
    }

    public enum ReportFields
    {
        InvoiceAmount = 1,
        InvoiceDate = 2,
        InvoicePaidDate = 3,
        WorkOrderNumber = 4,
        WorkOrderDate = 5,
        InvoiceNumber = 6,
        Assignment = 7,
        Name = 8,
        JobCost = 9
    }

    public class ReportColumn
    {
        public ReportColumn()
        {

        }
        public ReportColumn(string fieldName, string headerText, string text, string expression, string formatString, Type columnType, AggregationType aggregation, int visiblePosition)
        {
            FieldName = fieldName;
            HeaderText = headerText;
            Text = text;
            Expression = expression;
            VisiblePosition = visiblePosition;
            Type = columnType;
            AggregationType = aggregation;
            TextFormatString = formatString;
        }
        public string Name { get; set; }
        public string FieldName { get; set; }
        public string HeaderText { get; set; }
        public string Text { get; set; }
        public string Expression { get; set; }
        public int VisiblePosition { get; set; }
        public string TextFormatString { get; internal set; }
        public AggregationType AggregationType { get; set; } = AggregationType.None;
        public Type Type { get; set; }
    }
}
