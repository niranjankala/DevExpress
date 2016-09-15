Imports System.Drawing
Imports DevExpress.XtraReports.UI
Public Class XtraReport1
    Public Sub AddBoundLabel(ByVal bindingMember As String, ByVal bounds As Rectangle)
        ' Create a label. 
        Dim label As New XRLabel()

        ' Add the label to the report's Detail band. 
        Detail.Controls.Add(label)

        ' Set its location and size. 
        label.Location = bounds.Location
        label.Size = bounds.Size

        ' Bind it to the bindingMember data field. 
        ' When the dataSource parameter is Nothing, the report's data source is used. 
        label.DataBindings.Add("Text", Nothing, bindingMember)
    End Sub
End Class