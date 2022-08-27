Public Class FormPrinter
    Private Sub FormPrinter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.printer = TextBox1.Text
        My.Settings.Save()
    End Sub
    Private Sub FormPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.printer
    End Sub
    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoose.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        TextBox1.Text = PrintDialog1.PrinterSettings.PrinterName
    End Sub
End Class