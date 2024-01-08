using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using ReportingDemoApp.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportingDemoApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowClientStatReport()
        {            
            // ...
            ReportPrintTool printTool = new ReportPrintTool(new ClientStatReport());

            // Invoke the Ribbon Print Preview form  
            // and load the report document into it. 
            printTool.ShowRibbonPreview();

            // Invoke the Ribbon Print Preview form modally 
            // with the specified look and feel settings. 
            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);

            // Invoke the Print Preview form  
            // and load the report document into it. 
            printTool.ShowPreview();

            // Invoke the Print Preview form modally 
            // with the specified look and feel settings. 
            printTool.ShowPreviewDialog(UserLookAndFeel.Default);
        }

        private void btnShowClientStatReport_Click(object sender, EventArgs e)
        {
            ClientStatReport detailreport = new ClientStatReport();
            ReportPrintTool printTool = new ReportPrintTool(detailreport);
            printTool.ShowPreview();
        }

        private void btnShowColumnChooserRpt_Click(object sender, EventArgs e)
        {
            T333639.SampleReport rpt = new T333639.SampleReport();
            
                rpt.ShowPreview();
            
        }
    }
}
