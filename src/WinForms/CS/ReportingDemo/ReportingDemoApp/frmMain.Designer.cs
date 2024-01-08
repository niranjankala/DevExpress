
namespace ReportingDemoApp
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowClientStatReport = new System.Windows.Forms.Button();
            this.btnShowColumnChooserRpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowClientStatReport
            // 
            this.btnShowClientStatReport.Location = new System.Drawing.Point(662, 405);
            this.btnShowClientStatReport.Name = "btnShowClientStatReport";
            this.btnShowClientStatReport.Size = new System.Drawing.Size(126, 33);
            this.btnShowClientStatReport.TabIndex = 0;
            this.btnShowClientStatReport.Text = "Print Client Stat Report";
            this.btnShowClientStatReport.UseVisualStyleBackColor = true;
            this.btnShowClientStatReport.Click += new System.EventHandler(this.btnShowClientStatReport_Click);
            // 
            // btnShowColumnChooserRpt
            // 
            this.btnShowColumnChooserRpt.Location = new System.Drawing.Point(491, 405);
            this.btnShowColumnChooserRpt.Name = "btnShowColumnChooserRpt";
            this.btnShowColumnChooserRpt.Size = new System.Drawing.Size(165, 33);
            this.btnShowColumnChooserRpt.TabIndex = 1;
            this.btnShowColumnChooserRpt.Text = "Show Column Chooser Report";
            this.btnShowColumnChooserRpt.UseVisualStyleBackColor = true;
            this.btnShowColumnChooserRpt.Click += new System.EventHandler(this.btnShowColumnChooserRpt_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowColumnChooserRpt);
            this.Controls.Add(this.btnShowClientStatReport);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowClientStatReport;
        private System.Windows.Forms.Button btnShowColumnChooserRpt;
    }
}

