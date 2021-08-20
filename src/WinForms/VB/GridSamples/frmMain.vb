Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As New xtraGoogleSheet()
        frm.ShowDialog()

    End Sub
End Class
