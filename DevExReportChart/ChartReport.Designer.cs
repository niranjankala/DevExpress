using DevExReportChart;
namespace DevExReportChart
{
    partial class ChartReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.consumptionChart = new DevExpress.XtraReports.UI.XRChart();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.eplusoutDataSet1 = new DevExReportChart.IDF_Output_DataSet();
            this.aLTERNATIVE_COST_AND_USAGETableAdapter = new DevExReportChart.eplusoutDataSetTableAdapters.ALTERNATIVE_COST_AND_USAGETableAdapter();
            this.aLTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter = new DevExReportChart.eplusoutDataSetTableAdapters.ALTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consumptionChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eplusoutDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.consumptionChart});
            this.Detail.HeightF = 200F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // consumptionChart
            // 
            this.consumptionChart.BorderColor = System.Drawing.Color.Black;
            this.consumptionChart.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.consumptionChart.DataAdapter = this.aLTERNATIVE_COST_AND_USAGETableAdapter;
            this.consumptionChart.DataMember = "ALTERNATIVE_MONTHLY_USAGE_CHART";
            this.consumptionChart.DataSource = this.eplusoutDataSet1;
            xyDiagram1.AxisX.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.consumptionChart.Diagram = xyDiagram1;
            this.consumptionChart.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.consumptionChart.Name = "consumptionChart";
            this.consumptionChart.SeriesDataMember = "Run Label";
            this.consumptionChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.consumptionChart.SeriesTemplate.ArgumentDataMember = "Month";
            this.consumptionChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.consumptionChart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.consumptionChart.SeriesTemplate.ValueDataMembersSerializable = "Consumption";
            this.consumptionChart.SizeF = new System.Drawing.SizeF(650F, 200F);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // eplusoutDataSet1
            // 
            this.eplusoutDataSet1.DataSetName = "eplusoutDataSet";
            this.eplusoutDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTERNATIVE_COST_AND_USAGETableAdapter
            // 
            this.aLTERNATIVE_COST_AND_USAGETableAdapter.ClearBeforeFill = true;
            // 
            // aLTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter
            // 
            this.aLTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter.ClearBeforeFill = true;
            // 
            // ChartReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Version = "13.1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumptionChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eplusoutDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;        
       
        //private IDF_Output_DataSetTableAdapters.ALTERNATIVE_MONTHLY_USAGETableAdapter aLTERNATIVE_MONTHLY_USAGETableAdapter;
        private DevExpress.XtraReports.UI.XRChart consumptionChart;
        private eplusoutDataSetTableAdapters.ALTERNATIVE_COST_AND_USAGETableAdapter aLTERNATIVE_COST_AND_USAGETableAdapter;
        private IDF_Output_DataSet eplusoutDataSet1;
        private eplusoutDataSetTableAdapters.ALTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter aLTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter;
        //private IDF_Output_DataSetTableAdapters.ALTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter aLTERNATIVE_MONTHLY_USAGE_CHARTTableAdapter;
    }
}
