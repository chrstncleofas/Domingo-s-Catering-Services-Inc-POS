Public Class CashPay
    'Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim pname As String
    Dim xUP As Double
    Dim xDesc As String
    Dim xtempq As String
    Dim xGTotal As Double
    Dim crit As Integer
    Dim xqty As Integer
    Dim xsn As String
    Dim vat As Double
    Dim xtotal As Integer
    Dim change As Double
    Dim cash As Double
    Dim inn As String
    Dim Tamount As Double
    Dim xtime As String
    Dim stocksqty As Integer
    Dim total_qty As Long
    Dim disc As Double
    Public XName As String
    Dim crits As Integer
    Dim transac As String
    Dim iduser As String
    Dim itemName As String
    Private Sub CashPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtamt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamt.KeyDown
        xDesc = Cashier.txtDesc.Text
        xsn = Cashier.txtSN.Text
        xtotal = Cashier.lblDisplay.Text
        transac = Cashier.lblTrans.Text
        If e.KeyCode = Keys.Enter Then
            Cashier.btnDiscount.Enabled = False
            Cashier.btnRemove.Enabled = False
            Cashier.btnEdit.Enabled = False
            Cashier.btnPaymentStyle.Enabled = False
            Cashier.btnPayment.Enabled = False
            '
            Cashier.RemoveItemToolStripMenuItem.Enabled = False
            Cashier.EditItemToolStripMenuItem.Enabled = False
            Cashier.PaymentToolStripMenuItem.Enabled = False
            Cashier.PaymentMethodToolStripMenuItem.Enabled = False
            Cashier.AddDiscountToolStripMenuItem.Enabled = False
            'Cashier.PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
            'Cashier.PrintDocument1.Print()
            Cashier.txtDesc.Text = ""
            Cashier.lblTotal.Text = "0.00"
            If CSng(txtamt.Text) < CSng(Cashier.lblDisplay.Text) Then
                MsgBox("Oops, but you have an insufficiecnt money to make this transaction!", vbInformation, "wait a minute..")
                txtamt.Text = ""
                Exit Sub
            End If
            Cashier.lblchange.Text = CSng(txtamt.Text) - CSng(Cashier.lblDisplay.Text)
            txtamt.Text = FormatCurrency(txtamt.Text)
            Cashier.lblchange.Text = FormatCurrency(Cashier.lblchange.Text)
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", db)
            dbds = New DataSet()
            tbltemp.Fill(dbds, "tbltemp")
            trec = dbds.Tables("tbltemp").Rows.Count - 1
            recpointer = 0
            For recpointer As Integer = 0 To trec
                db.Open()
                pname = dbds.Tables("tbltemp").Rows(recpointer).Item("Item Name")
                xDesc = dbds.Tables("tbltemp").Rows(recpointer).Item("Description")
                xUP = dbds.Tables("tbltemp").Rows(recpointer).Item("Unit Price")
                xqty = dbds.Tables("tbltemp").Rows(recpointer).Item("Quantity")
                xsn = dbds.Tables("tbltemp").Rows(recpointer).Item("Item Name")
                xtotal = dbds.Tables("tbltemp").Rows(recpointer).Item("Total")
                dbcmd = New OleDb.OleDbCommand("INSERT INTO tbltran([Trans ID],[Stock No],[Item Name],[Description],[Quantity],[Unit Price],[Total], [Date Time], [Cashier Name], [Payment Method]) VALUES ('" & transac & "', '" & Cashier.txtStock.Text.Trim & "', '" & pname & "','" & xDesc & "','" & xqty & "','" & FormatCurrency(xUP) & "','" & FormatCurrency(xtotal) & "','" & Cashier.d1.Value & "','" & Cashier.txtCashier.Text & "', '" & Cashier.txtPayment.Text & "')", db)
                dbcmd.ExecuteNonQuery()
                db.Close()
                '
                db.Open()
                tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock WHERE [Product Name] like '" & xsn & "' ", db)
                dbds = New DataSet()
                tblstock.Fill(dbds, "tblstock")
                stocksqty = dbds.Tables("tblstock").Rows(0).Item("Product Quantity")
                stocksqty = stocksqty - xqty
                dbcmd = New OleDb.OleDbCommand("UPDATE tblstock set [Product Quantity] = '" & stocksqty & "' WHERE [Product Name] like '" & xsn & "'", db)
                dbcmd.ExecuteNonQuery()
                sqlquery3()
                db.Close()
            Next
        End If
    End Sub
End Class