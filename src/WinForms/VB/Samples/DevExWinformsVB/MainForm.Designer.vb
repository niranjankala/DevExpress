<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnXtraReportArraryListBinding = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnXtraReportArraryListBinding
        '
        Me.btnXtraReportArraryListBinding.Location = New System.Drawing.Point(3, 3)
        Me.btnXtraReportArraryListBinding.Name = "btnXtraReportArraryListBinding"
        Me.btnXtraReportArraryListBinding.Size = New System.Drawing.Size(170, 23)
        Me.btnXtraReportArraryListBinding.TabIndex = 0
        Me.btnXtraReportArraryListBinding.Text = "XtraReport ArrayList Binding"
        Me.btnXtraReportArraryListBinding.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 203)
        Me.Controls.Add(Me.btnXtraReportArraryListBinding)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnXtraReportArraryListBinding As Button
End Class
