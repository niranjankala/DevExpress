<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xtraGoogleSheet
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridGoogle = New DevExpress.XtraGrid.GridControl()
        Me.UspGoogleSheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._2020BEAMSandBoxDataSetGoogleSheet = New BEAM2014._2020BEAMSandBoxDataSetGoogleSheet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssignedToField = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScopeDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobScopeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssignment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScopeCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECORDDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUPDATEDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUPDATEBY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeqNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApptDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApptTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colworkorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWODESCRIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDidWhat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTimeOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHeadCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpecialMatEquip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplexTimeDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNTRCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UspGoogleSheetTableAdapter = New BEAM2014._2020BEAMSandBoxDataSetGoogleSheetTableAdapters.uspGoogleSheetTableAdapter()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.lblStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblEndDate = New DevExpress.XtraEditors.LabelControl()
        Me.txtStartDate = New DevExpress.XtraEditors.TextEdit()
        Me.txtEndDate = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GridGoogle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGoogleSheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._2020BEAMSandBoxDataSetGoogleSheet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridGoogle
        '
        Me.GridGoogle.DataSource = Me.UspGoogleSheetBindingSource
        Me.GridGoogle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGoogle.Location = New System.Drawing.Point(0, 0)
        Me.GridGoogle.MainView = Me.GridView1
        Me.GridGoogle.Name = "GridGoogle"
        Me.GridGoogle.Size = New System.Drawing.Size(1819, 1779)
        Me.GridGoogle.TabIndex = 0
        Me.GridGoogle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'UspGoogleSheetBindingSource
        '
        Me.UspGoogleSheetBindingSource.DataMember = "uspGoogleSheet"
        Me.UspGoogleSheetBindingSource.DataSource = Me._2020BEAMSandBoxDataSetGoogleSheet
        '
        '_2020BEAMSandBoxDataSetGoogleSheet
        '
        Me._2020BEAMSandBoxDataSetGoogleSheet.DataSetName = "_2020BEAMSandBoxDataSetGoogleSheet"
        Me._2020BEAMSandBoxDataSetGoogleSheet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colParentID, Me.colFullName, Me.colAssignedToField, Me.colEmployeeCode, Me.colScopeDescription, Me.colJobScopeID, Me.colAssignment, Me.colScopeCompleted, Me.colRECORDDATE, Me.colUPDATEDATE, Me.colUPDATEBY, Me.colSeqNo, Me.colApptDate, Me.colApptTime, Me.colworkorder, Me.colWODESCRIP, Me.colCUSTOMER, Me.colDidWhat, Me.colTimeOut, Me.colComplex, Me.colIsCompleted, Me.colHeadCount, Me.colHours, Me.colReason, Me.colSpecialMatEquip, Me.colComplexTimeDetails, Me.colNTRCompleted})
        Me.GridView1.GridControl = Me.GridGoogle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.AllowCellMerge = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 50
        Me.colID.Name = "colID"
        Me.colID.Width = 187
        '
        'colParentID
        '
        Me.colParentID.FieldName = "ParentID"
        Me.colParentID.MinWidth = 50
        Me.colParentID.Name = "colParentID"
        Me.colParentID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colParentID.Width = 187
        '
        'colFullName
        '
        Me.colFullName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colFullName.AppearanceCell.Options.UseFont = True
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.MinWidth = 50
        Me.colFullName.Name = "colFullName"
        Me.colFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 0
        Me.colFullName.Width = 189
        '
        'colAssignedToField
        '
        Me.colAssignedToField.FieldName = "AssignedToField"
        Me.colAssignedToField.MinWidth = 50
        Me.colAssignedToField.Name = "colAssignedToField"
        Me.colAssignedToField.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAssignedToField.Width = 187
        '
        'colEmployeeCode
        '
        Me.colEmployeeCode.FieldName = "EmployeeCode"
        Me.colEmployeeCode.MinWidth = 50
        Me.colEmployeeCode.Name = "colEmployeeCode"
        Me.colEmployeeCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEmployeeCode.Width = 187
        '
        'colScopeDescription
        '
        Me.colScopeDescription.FieldName = "ScopeDescription"
        Me.colScopeDescription.MinWidth = 50
        Me.colScopeDescription.Name = "colScopeDescription"
        Me.colScopeDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colScopeDescription.Width = 161
        '
        'colJobScopeID
        '
        Me.colJobScopeID.FieldName = "JobScopeID"
        Me.colJobScopeID.MinWidth = 50
        Me.colJobScopeID.Name = "colJobScopeID"
        Me.colJobScopeID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colJobScopeID.Width = 187
        '
        'colAssignment
        '
        Me.colAssignment.FieldName = "Assignment"
        Me.colAssignment.MinWidth = 50
        Me.colAssignment.Name = "colAssignment"
        Me.colAssignment.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAssignment.Width = 68
        '
        'colScopeCompleted
        '
        Me.colScopeCompleted.FieldName = "ScopeCompleted"
        Me.colScopeCompleted.MinWidth = 50
        Me.colScopeCompleted.Name = "colScopeCompleted"
        Me.colScopeCompleted.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colScopeCompleted.Width = 68
        '
        'colRECORDDATE
        '
        Me.colRECORDDATE.FieldName = "RECORDDATE"
        Me.colRECORDDATE.MinWidth = 50
        Me.colRECORDDATE.Name = "colRECORDDATE"
        Me.colRECORDDATE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRECORDDATE.Width = 187
        '
        'colUPDATEDATE
        '
        Me.colUPDATEDATE.FieldName = "UPDATEDATE"
        Me.colUPDATEDATE.MinWidth = 50
        Me.colUPDATEDATE.Name = "colUPDATEDATE"
        Me.colUPDATEDATE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colUPDATEDATE.Width = 187
        '
        'colUPDATEBY
        '
        Me.colUPDATEBY.FieldName = "UPDATEBY"
        Me.colUPDATEBY.MinWidth = 50
        Me.colUPDATEBY.Name = "colUPDATEBY"
        Me.colUPDATEBY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colUPDATEBY.Width = 187
        '
        'colSeqNo
        '
        Me.colSeqNo.FieldName = "SeqNo"
        Me.colSeqNo.MinWidth = 50
        Me.colSeqNo.Name = "colSeqNo"
        Me.colSeqNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSeqNo.Width = 68
        '
        'colApptDate
        '
        Me.colApptDate.FieldName = "ApptDate"
        Me.colApptDate.MinWidth = 50
        Me.colApptDate.Name = "colApptDate"
        Me.colApptDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colApptDate.Width = 68
        '
        'colApptTime
        '
        Me.colApptTime.FieldName = "ApptTime"
        Me.colApptTime.MinWidth = 50
        Me.colApptTime.Name = "colApptTime"
        Me.colApptTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colApptTime.Width = 68
        '
        'colworkorder
        '
        Me.colworkorder.FieldName = "workorder"
        Me.colworkorder.MinWidth = 50
        Me.colworkorder.Name = "colworkorder"
        Me.colworkorder.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colworkorder.Width = 164
        '
        'colWODESCRIP
        '
        Me.colWODESCRIP.FieldName = "WODESCRIP"
        Me.colWODESCRIP.MinWidth = 50
        Me.colWODESCRIP.Name = "colWODESCRIP"
        Me.colWODESCRIP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colWODESCRIP.Width = 239
        '
        'colCUSTOMER
        '
        Me.colCUSTOMER.FieldName = "CUSTOMER"
        Me.colCUSTOMER.MinWidth = 50
        Me.colCUSTOMER.Name = "colCUSTOMER"
        Me.colCUSTOMER.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCUSTOMER.Width = 68
        '
        'colDidWhat
        '
        Me.colDidWhat.FieldName = "DidWhat"
        Me.colDidWhat.MinWidth = 50
        Me.colDidWhat.Name = "colDidWhat"
        Me.colDidWhat.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDidWhat.Width = 68
        '
        'colTimeOut
        '
        Me.colTimeOut.Caption = "Ending Time"
        Me.colTimeOut.FieldName = "TimeOut"
        Me.colTimeOut.MinWidth = 50
        Me.colTimeOut.Name = "colTimeOut"
        Me.colTimeOut.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTimeOut.Visible = True
        Me.colTimeOut.VisibleIndex = 2
        Me.colTimeOut.Width = 68
        '
        'colComplex
        '
        Me.colComplex.FieldName = "Complex"
        Me.colComplex.MinWidth = 50
        Me.colComplex.Name = "colComplex"
        Me.colComplex.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colComplex.Width = 68
        '
        'colIsCompleted
        '
        Me.colIsCompleted.FieldName = "IsCompleted"
        Me.colIsCompleted.MinWidth = 50
        Me.colIsCompleted.Name = "colIsCompleted"
        Me.colIsCompleted.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colIsCompleted.Width = 68
        '
        'colHeadCount
        '
        Me.colHeadCount.FieldName = "HeadCount"
        Me.colHeadCount.MinWidth = 50
        Me.colHeadCount.Name = "colHeadCount"
        Me.colHeadCount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colHeadCount.Width = 68
        '
        'colHours
        '
        Me.colHours.FieldName = "Hours"
        Me.colHours.MinWidth = 50
        Me.colHours.Name = "colHours"
        Me.colHours.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colHours.Width = 68
        '
        'colReason
        '
        Me.colReason.FieldName = "Reason"
        Me.colReason.MinWidth = 50
        Me.colReason.Name = "colReason"
        Me.colReason.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colReason.Width = 68
        '
        'colSpecialMatEquip
        '
        Me.colSpecialMatEquip.FieldName = "SpecialMatEquip"
        Me.colSpecialMatEquip.MinWidth = 50
        Me.colSpecialMatEquip.Name = "colSpecialMatEquip"
        Me.colSpecialMatEquip.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSpecialMatEquip.Width = 121
        '
        'colComplexTimeDetails
        '
        Me.colComplexTimeDetails.Caption = "Job Name & Complex, Time and Details"
        Me.colComplexTimeDetails.FieldName = "colComplexTimeDetails"
        Me.colComplexTimeDetails.MinWidth = 50
        Me.colComplexTimeDetails.Name = "colComplexTimeDetails"
        Me.colComplexTimeDetails.UnboundDataType = GetType(String)
        Me.colComplexTimeDetails.Visible = True
        Me.colComplexTimeDetails.VisibleIndex = 1
        Me.colComplexTimeDetails.Width = 187
        '
        'colNTRCompleted
        '
        Me.colNTRCompleted.Caption = "Completed or NTR to do what"
        Me.colNTRCompleted.FieldName = "colNTRCompleted"
        Me.colNTRCompleted.MinWidth = 50
        Me.colNTRCompleted.Name = "colNTRCompleted"
        Me.colNTRCompleted.UnboundDataType = GetType(String)
        Me.colNTRCompleted.Visible = True
        Me.colNTRCompleted.VisibleIndex = 3
        Me.colNTRCompleted.Width = 187
        '
        'UspGoogleSheetTableAdapter
        '
        Me.UspGoogleSheetTableAdapter.ClearBeforeFill = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtEndDate)
        Me.PanelControl1.Controls.Add(Me.txtStartDate)
        Me.PanelControl1.Controls.Add(Me.lblEndDate)
        Me.PanelControl1.Controls.Add(Me.lblStartDate)
        Me.PanelControl1.Controls.Add(Me.btnRefresh)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 1676)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1819, 103)
        Me.PanelControl1.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1569, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(192, 70)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(140, 38)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(120, 33)
        Me.lblStartDate.TabIndex = 1
        Me.lblStartDate.Text = "Start Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.Location = New System.Drawing.Point(659, 38)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(108, 33)
        Me.lblEndDate.TabIndex = 1
        Me.lblEndDate.Text = "End Date"
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(326, 23)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Properties.BeepOnError = False
        Me.txtStartDate.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.txtStartDate.Properties.MaskSettings.Set("mask", "d")
        Me.txtStartDate.Size = New System.Drawing.Size(250, 48)
        Me.txtStartDate.TabIndex = 2
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(844, 23)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Properties.BeepOnError = False
        Me.txtEndDate.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.txtEndDate.Properties.MaskSettings.Set("mask", "d")
        Me.txtEndDate.Size = New System.Drawing.Size(250, 48)
        Me.txtEndDate.TabIndex = 2
        '
        'xtraGoogleSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1819, 1779)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GridGoogle)
        Me.Name = "xtraGoogleSheet"
        Me.Text = "Google Sheet"
        CType(Me.GridGoogle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGoogleSheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._2020BEAMSandBoxDataSetGoogleSheet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridGoogle As DevExpress.XtraGrid.GridControl
    Friend WithEvents UspGoogleSheetBindingSource As BindingSource
    Friend WithEvents _2020BEAMSandBoxDataSetGoogleSheet As _2020BEAMSandBoxDataSetGoogleSheet
    Friend WithEvents UspGoogleSheetTableAdapter As _2020BEAMSandBoxDataSetGoogleSheetTableAdapters.uspGoogleSheetTableAdapter
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssignedToField As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScopeDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobScopeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssignment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScopeCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECORDDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUPDATEDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUPDATEBY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeqNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApptDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApptTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colworkorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWODESCRIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDidWhat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTimeOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHeadCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpecialMatEquip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplexTimeDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTRCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtEndDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStartDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
End Class
