Public Class SearchItemForm
    Private Sub SearchItemForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb7()
        sqlquery7()
        dgItems.DataSource = dbds.Tables("tblstock")
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim counter As Integer
        For counter = 90 To 10 Step -20
            Me.Opacity = counter / 100
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next counter
        Me.Dispose()
    End Sub
End Class