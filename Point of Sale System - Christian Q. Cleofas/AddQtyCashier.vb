Public Class AddQtyCashier

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FToolStripMenuItem.Click

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
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class