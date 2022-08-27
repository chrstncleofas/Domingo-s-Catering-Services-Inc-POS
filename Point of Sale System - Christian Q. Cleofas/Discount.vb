Public Class Discount
    Private Sub Discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cashier.lblDisplay.Text = Cashier.lblDisplay.Text - Cashier.lblVAT.Text
            Cashier.lblDisplay.Text = FormatCurrency(Cashier.lblDisplay.Text)
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Cashier.lblVAT.Text = Cashier.lblDisplay.Text * 0.2
            Cashier.lblTotal.Text = FormatCurrency(Cashier.lblTotal.Text)
            Cashier.lblVAT.Text = FormatCurrency(Cashier.lblVAT.Text)
        Catch err As Exception
            'MsgBox(err.Message, "Error")
        End Try
    End Sub
End Class