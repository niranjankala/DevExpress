Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI

Public Class MainForm
    Private Sub btnXtraReportArraryListBinding_Click(sender As Object, e As EventArgs) Handles btnXtraReportArraryListBinding.Click
        Dim listDataSource As New ArrayList()

        For index = 1 To 10



            listDataSource.Add(New RecordGastoDotacion(index,
                                                       DateTime.Now.AddDays(index),
                                                       DateTime.Now.AddDays(index + 4),
                                                       String.Format("AccountNumber:{0}", index + 1),
                                                       DateTime.Now.Year.ToString(),
                                                       index))
        Next


        Dim gastos As New XtraReport1() With {.Margins = New Printing.Margins(100, 100, 25, 25), .DataSource = listDataSource}



        gastos.AddBoundLabel("idgasto", New Rectangle(100, 20, 50, 30))
        gastos.AddBoundLabel("fef", New Rectangle(150, 20, 100, 30))
        gastos.AddBoundLabel("feh", New Rectangle(250, 20, 100, 30))
        gastos.AddBoundLabel("cant", New Rectangle(350, 20, 50, 30))
        gastos.AddBoundLabel("descr", New Rectangle(450, 20, 100, 30))
        gastos.AddBoundLabel("usuario", New Rectangle(550, 20, 50, 30))

        Using printTool As New ReportPrintTool(gastos)
            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
        End Using
    End Sub
End Class
