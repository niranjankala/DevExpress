using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace LimitNumberOfRecordsPerPage {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 detailreport = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(detailreport);
            printTool.ShowPreview();
        }
    }
}