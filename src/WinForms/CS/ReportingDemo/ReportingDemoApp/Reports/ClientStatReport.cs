using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

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

            }
        }
    }
}
