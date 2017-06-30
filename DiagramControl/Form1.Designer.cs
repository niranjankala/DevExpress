namespace DiagramControl
{
    partial class Form1
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
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl.Location = new System.Drawing.Point(275, 0);
            this.diagramControl.Name = "diagramControl1";
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.Size = new System.Drawing.Size(744, 600);
            this.diagramControl.TabIndex = 0;
            this.diagramControl.Text = "diagramControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 600);
            this.panel1.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(168, 565);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(275, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 600);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 600);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.diagramControl);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Systems Creation Diagram..";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDraw;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}

