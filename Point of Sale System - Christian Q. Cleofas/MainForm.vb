Public Class MainForm
    Public XName As String
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblLoginAs.Text = LoginForm.fname
        If LoginForm.xpriv = "User" Then
            ReportViewToolStripMenuItem.Enabled = False
            SalesReportToolStripMenuItem.Enabled = False
            InventoryToolStripMenuItem1.Enabled = False
            btnStock.Enabled = False
            btnReport.Enabled = False
        End If
        If LoginForm.xpriv = "Admin" Then
            ReportViewToolStripMenuItem.Enabled = True
            InventoryToolStripMenuItem1.Enabled = True
            btnStock.Enabled = True
            btnReport.Enabled = True
        End If
        dtTime.Value = DateTime.Now
    End Sub
    Private Sub LogoutUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutUserToolStripMenuItem.Click
        Dim counter As Integer
        For counter = 90 To 10 Step -20
            Me.Opacity = counter / 100
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next counter
        MsgBox("Logout Success", vbInformation, "Domingo's Catering Services Inc.")
        LoginForm.txtUsername.Clear()
        LoginForm.txtPassword.Clear()
        Me.Close()
        LoginForm.Show()
    End Sub
    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        SalesReportView.Show()
        Me.Hide()
    End Sub
    Private Sub UserReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UserReportView.Show()
        Me.Hide()
    End Sub
    Private Sub CashierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashierToolStripMenuItem1.Click
        Cashier.Show()
        Me.Hide()
    End Sub
    Private Sub NewUserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewUserToolStripMenuItem1.Click
        UserForm.Show()
        Me.Hide()
    End Sub
    Private Sub InventoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem1.Click
        InventoryDashBoard.Show()
        Me.Hide()
    End Sub
    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        UserForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashier.Click
        Cashier.Show()
        Me.Hide()
    End Sub
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        SalesReportView.Show()
        Me.Hide()
    End Sub
    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        InventoryDashBoard.Show()
        Me.Hide()
    End Sub
End Class