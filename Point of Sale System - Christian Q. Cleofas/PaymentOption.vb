Public Class PaymentOption
    Private Sub PaymentOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub chkCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCash.CheckedChanged
        If chkCash.Checked = True Then
            Cashier.txtPayment.Text = "Cash"
        End If
    End Sub
    Private Sub chkDebit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDebit.CheckedChanged
        If chkDebit.Checked = True Then
            Cashier.txtPayment.Text = "Debit / Credit Card"
        End If
    End Sub
    Private Sub chkGCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGCash.CheckedChanged
        If chkGCash.Checked = True Then
            Cashier.txtPayment.Text = "G-cash"
        End If
    End Sub
    Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        If chkCheque.Checked = True Then
            Cashier.txtPayment.Text = "Cheque"
        End If
    End Sub
    Private Sub chkRoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRoom.CheckedChanged
        If chkRoom.Checked = True Then
            Cashier.txtPayment.Text = "Room Charge"
        End If
    End Sub
    Private Sub chkAB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAB.CheckedChanged
        If chkAB.Checked = True Then
            Cashier.txtPayment.Text = "A/B CBR"
        End If
    End Sub
    Private Sub chkAR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAR.CheckedChanged
        If chkAR.Checked = True Then
            Cashier.txtPayment.Text = "A/R MNGT"
        End If
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim str As String
        str = " "
        If chkCash.Checked = True Then
            str &= chkCash.Text
            str &= " "
        End If
        If chkDebit.Checked = True Then
            str &= chkDebit.Text
            str &= " "
        End If
        If chkGCash.Checked = True Then
            str &= chkGCash.Text
            str &= " "
        End If
        If chkCheque.Checked = True Then
            str &= chkCheque.Text
            str &= " "
        End If
        If chkRoom.Checked = True Then
            str &= chkRoom.Text
            str &= " "
        End If
        If chkAB.Checked = True Then
            str &= chkAB.Text
            str &= " "
        End If
        If chkAR.Checked = True Then
            str &= chkAR.Text
            str &= " "
        End If
        If str <> Nothing Then
            'MsgBox(str + vbLf + "Thank you")
            Cashier.txtPayment.Text = " " + str
        End If
    End Sub
End Class