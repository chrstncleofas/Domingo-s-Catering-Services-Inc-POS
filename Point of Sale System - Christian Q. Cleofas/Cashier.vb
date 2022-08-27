Imports System.Drawing.Printing
Imports System.Data.DataTable
Public Class Cashier
    Dim WithEvents PD As New PrintDocument
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
    Sub autotransid()
        Try
            db.Open()
            tbltran = New OleDb.OleDbDataAdapter("SELECT [Trans ID] FROM tbltran ORDER BY [Trans ID] DESC", db)
            dbds = New DataSet
            tbltran.Fill(dbds, "tbltran")
            If (dbds.Tables(0).Rows.Count > 0) Then
                Dim tempID = dbds.Tables(0).Rows(0)("Trans ID").ToString().Substring(2, 2)
                Dim newID As Integer = CInt(tempID) + 1
                lblTrans.Text = "75" & newID.ToString("00")
            Else
                lblTrans.Text = "7501"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub qty()
        Dim countItem As Long = 0
        For rowitem As Long = 0 To dgtemp.RowCount - 1
            countItem = countItem + dgtemp.Rows(rowitem).Cells(2).Value
        Next
        total_qty = countItem
    End Sub
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgtemp.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 300
    End Sub
    Sub lock()
        txtQ.Enabled = False
        txtamt.Enabled = False
        cmbPayment.Enabled = False
        txtDiscount.Enabled = False
        'Buttons
        btnDiscount.Enabled = False
        btnRemove.Enabled = False
        btnEdit.Enabled = False
        btnPaymentStyle.Enabled = False
        btnPayment.Enabled = False
        '
        RemoveItemToolStripMenuItem.Enabled = False
        EditItemToolStripMenuItem.Enabled = False
        PaymentToolStripMenuItem.Enabled = False
        PaymentMethodToolStripMenuItem.Enabled = False
        AddDiscountToolStripMenuItem.Enabled = False
    End Sub
    Sub unlock()
        txtQ.Enabled = True
        txtamt.Enabled = True
    End Sub
    Sub clearing()
        txtSN.Text = ""
        txtDesc.Text = Nothing
        txtQ.Text = ""
        lblPName.Text = Nothing
        lblchange.Text = "0.00"
        txtamt.Text = "0.00"
        lblTotal.Text = "0.00"
        lblDisplay.Text = "0.00"
        lblVAT.Text = "0.00"
        txtDiscount.Text = "0.00"
        vat = "0.00"
        cmbPayment.Text = ""
    End Sub
    Sub subcritical()
        'Critical Item
        crits = dbds.Tables("tblstock").Rows(0).Item("Product Quantity")
        If crits <= 5 And crits >= 1 Then
            MsgBox("This item is in only " & crits, vbCritical, "WARNING.!!!!")
        ElseIf crits = 0 Then
            MsgBox("This item has been out of stock", vbCritical, "WARNING!!!!!")
            clearing()
            lock()
        End If
        'End of Critical Codes
    End Sub
    Sub User()
        opendb()
        sqlquery()
        iduser = dbds.Tables("tbluser").Rows(0).Item("User ID")
    End Sub
    Private Sub Cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCashier.Text = LoginForm.fname
        changelongpaper()
        autotransid()
        lock()
        txtSN.Focus()
        'Delete Function direct table
        opendb3()
        sqlquery3()
        db.Open()
        dbcmd = New OleDb.OleDbCommand("DELETE * FROM tbltemp", db)
        dbcmd.ExecuteNonQuery()
        dgtemp.DataSource = dbds.Tables("tbltemp")
        dgtemp.Refresh()
        db.Close()
        'End Code
        'Date Function
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "dd/MM/yyyy"
        'Time Function
        t1.Format = DateTimePickerFormat.Time
        t1.CustomFormat = "HH:mm:ss tt"
        'End Codes
        xGTotal = 0
    End Sub
    Private Sub txtSN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock WHERE [Product Name] like '" & txtSN.Text.Trim & "' ", db)
                dbds = New DataSet()
                tblstock.Fill(dbds, "tblstock")
                txtQ.Enabled = True
                If dbds.Tables("tblstock").Rows.Count > 0 Then
                    xUP = dbds.Tables("tblstock").Rows(0).Item("Selling Price")
                    xUP = FormatCurrency(xUP)
                    'Critical Function
                    subcritical()
                    'End of Function
                    txtDesc.Text = dbds.Tables("tblstock").Rows(0).Item("Product Description")
                    lblPName.Text = dbds.Tables("tblstock").Rows(0).Item("Product Name")
                    txtStock.Text = dbds.Tables("tblstock").Rows(0).Item("Product ID")
                    tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp WHERE [Item Name] like '" & txtSN.Text.Trim & "'", db)
                    dbds = New DataSet()
                    tbltemp.Fill(dbds, "tbltemp")
                    If dbds.Tables("tbltemp").Rows.Count > 0 Then
                        If MsgBox("This item is already on your list, Would you like to add this one?", vbQuestion + vbYesNo, "Cashier Form") = vbYes Then
                            xtempq = dbds.Tables("tbltemp").Rows(0).Item("Quantity")
                            xGTotal = dbds.Tables("tbltemp").Rows(0).Item("Total")
                            txtQ.Focus()
                            sw = False
                        Else
                            txtSN.Clear()
                            lblDisplay.Text = "0.00"
                            txtDesc.Text = ""
                            Exit Sub
                        End If
                        Exit Sub
                    Else
                        sw = True
                        txtQ.Focus()
                    End If
                Else
                    MsgBox("Please enter a valid a Stock No., Thank you!", vbCritical, "Undefined Stock No.")
                    txtSN.Clear()
                    txtSN.Focus()
                End If
            Catch err As Exception
                MsgBox(err.ToString, vbCritical, "Error")
            Finally
                db.Close()
            End Try
        End If
    End Sub
    Private Sub txtQ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQ.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgtemp.DataSource = dbds.Tables("tbltemp")
            btnDiscount.Enabled = True
            btnRemove.Enabled = True
            btnEdit.Enabled = True
            btnPaymentStyle.Enabled = True
            btnPayment.Enabled = True
            '
            RemoveItemToolStripMenuItem.Enabled = True
            EditItemToolStripMenuItem.Enabled = True
            PaymentToolStripMenuItem.Enabled = True
            PaymentMethodToolStripMenuItem.Enabled = True
            AddDiscountToolStripMenuItem.Enabled = True
            If txtQ.Text = "" Or IsNumeric(txtQ.Text) = False Then
                MsgBox("Kindly enter the no. of quantity for this Item(s)!, Thank you...", vbCritical, "oops")
                txtQ.Focus()
                Exit Sub
            End If
            If e.KeyCode = Keys.Enter Then
                xGTotal = CInt(xGTotal) + CDbl(lblTotal.Text)
                lblDisplay.Text = Format(xGTotal, "Standard")
                db.Open()
                If sw = True Then
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO tbltemp([Stock No],[Item Name],[Description],[Quantity],[Unit Price],[Total],[VAT]) VALUES ('" & txtStock.Text.Trim & "','" & txtSN.Text.Trim & "','" & txtDesc.Text.Trim & "','" & txtQ.Text.Trim & "','" & xUP & "','" & lblTotal.Text.Trim & "', '" & lblVAT.Text.Trim & "')", db)
                    dbcmd.ExecuteNonQuery()
                Else
                    xtempq = xtempq + CInt(txtQ.Text)
                    xGTotal = CSng(xGTotal) + CSng(lblTotal.Text)
                    lblDisplay.Text = FormatCurrency(lblDisplay.Text)
                    dbcmd = New OleDb.OleDbCommand("UPDATE tbltemp set [Quantity]='" & xtempq & "',[Total]='" & lblDisplay.Text & "' WHERE [Item Name] like '" & txtSN.Text & "'", db)
                    dbcmd.ExecuteNonQuery()
                End If
                sqlquery3()
                dgtemp.DataSource = dbds.Tables("tbltemp")
                txtQ.Clear()
                txtSN.Clear()
                'Total funtion by Quantity
                tbltemp = New OleDb.OleDbDataAdapter("SELECT sum([Total]) + sum([VAT]) as xt FROM tbltemp", db)
                dbds = New DataSet()
                tbltemp.Fill(dbds, "tbltemp")
                If dbds.Tables("tbltemp").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
                End If
                lblDisplay.Text = dbds.Tables("tbltemp").Rows(0).Item("xt")
                lblDisplay.Text = FormatCurrency(lblDisplay.Text)

                'Computation of Vat by Quantity
                tbltemp = New OleDb.OleDbDataAdapter("SELECT sum([VAT]) as v FROM tbltemp", db)
                dbds = New DataSet()
                tbltemp.Fill(dbds, "tbltemp")
                If dbds.Tables("tbltemp").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
                End If
                vat = dbds.Tables("tbltemp").Rows(0).Item("v")
                txtSN.Focus()
            End If
        End If
    End Sub
    Private Sub txtQ_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQ.TextChanged
        Try
            lblTotal.Text = CInt(txtQ.Text) * CInt(xUP)
            'lblVAT.Text = CInt(txtQ.Text) * 0.2
            lblTotal.Text = FormatCurrency(lblTotal.Text)
        Catch err As Exception
            'MsgBox(err.Message, "Error")
        End Try
    End Sub
    Private Sub txtamt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamt.KeyDown
        
    End Sub
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PrintDocument1.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Sub Function Object
        changelongpaper()
        qty()
        User()
        'Variable
        Dim time As DateTime = DateTime.Parse(t1.Value)
        'font Variable
        Dim f4 As New Font("Segoe UI", 6, FontStyle.Regular)
        Dim f5 As New Font("Segoe UI", 6, FontStyle.Bold)
        Dim f8 As New Font("Segoe UI", 8, FontStyle.Regular)
        Dim f10 As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim f10b As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim f14 As New Font("Segoe UI", 12, FontStyle.Bold)
        'Margin Variable
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        ' Line Design Variable
        Dim line As String
        line = "============================================================================"

        'range from top
        e.Graphics.DrawString("Domingo's Catering Services, INC", f10, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("San Narciso Zambales PH", f8, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Contact No. 09610090120", f8, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Billing No", f5, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f5, Brushes.Black, 50, 60)
        e.Graphics.DrawString(lblTrans.Text, f5, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Date", f5, Brushes.Black, 0, 73)
        e.Graphics.DrawString(":", f5, Brushes.Black, 50, 73)
        e.Graphics.DrawString(d1.Value.Date, f5, Brushes.Black, 70, 73)

        e.Graphics.DrawString("Time", f5, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f5, Brushes.Black, 50, 85)
        e.Graphics.DrawString(time.ToString("hhh:mm:ss tt"), f5, Brushes.Black, 70, 85)

        e.Graphics.DrawString("Name of Client", f5, Brushes.Black, 0, 97)
        e.Graphics.DrawString(":", f5, Brushes.Black, 70, 97)
        'e.Graphics.DrawString(time.ToString("hhh:mm:ss tt"), f5, Brushes.Black, 70, 85)


        e.Graphics.DrawString("Description", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 110, 110)
        e.Graphics.DrawString("Amount", f8, Brushes.Black, 200, 110)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 124)

        Dim height As Integer 'Data Grid View Position
        Dim i As Long
        For row As Integer = 0 To dgtemp.RowCount - 1
            height += 15
            e.Graphics.DrawString(dgtemp.Rows(row).Cells(1).Value.ToString, f5, Brushes.Black, 0, 125 + height)
            e.Graphics.DrawString(dgtemp.Rows(row).Cells(2).Value.ToString, f5, Brushes.Black, 116, 125 + height)

            i = dgtemp.Rows(row).Cells(4).Value
            dgtemp.Rows(row).Cells(4).Value = FormatCurrency(i)
            e.Graphics.DrawString(dgtemp.Rows(row).Cells(4).Value.ToString, f5, Brushes.Black, rightmargin, 125 + height, right)
        Next
        Dim height2 As Integer
        height2 = 110 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 17 + height2)
        e.Graphics.DrawString("Total Due: " & lblDisplay.Text, f10b, Brushes.Black, rightmargin, 29 + height2, right)
        e.Graphics.DrawString("Cash: " & CashPay.txtamt.Text, f10b, Brushes.Black, rightmargin, 43 + height2, right)
        e.Graphics.DrawString("Change: " & lblchange.Text, f10b, Brushes.Black, rightmargin, 59 + height2, right)
        e.Graphics.DrawString("Discount: " & lblVAT.Text, f10b, Brushes.Black, rightmargin, 73 + height2, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 85 + height2)
        e.Graphics.DrawString("Total Item : " & total_qty, f8, Brushes.Black, 0, 98 + height2)
        '
        e.Graphics.DrawString("Cashier Name", f4, Brushes.Black, 0, 112 + height2)
        e.Graphics.DrawString(":", f4, Brushes.Black, 55, 112 + height2)
        e.Graphics.DrawString(iduser + " " + " " + txtCashier.Text, f4, Brushes.Black, 60, 112 + height2)
        'e.Graphics.DrawString("VAT: " & FormatCurrency(vat), f8, Brushes.Black, rightmargin, 80 + height2, right)
        'e.Graphics.DrawString("Sales Invoice ID : " & lblInvoice.Text, f5, Brushes.Black, 0, 95 + height2)

        e.Graphics.DrawString("~ This Invoice is not valid for input tax ~", f5, Brushes.Black, centermargin, 145 + height2, center)
        e.Graphics.DrawString("~ Thank You ! ~", f5, Brushes.Black, centermargin, 160 + height2, center)
        'e.Graphics.DrawString("~ will only be allowed within 7 days from date of purchase ~", f5, Brushes.Black, centermargin, 175 + height2, center)
    End Sub
    Private Sub MainFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainFormToolStripMenuItem.Click
        If MsgBox("This action will close the the transaction window, the next user will be ask to log - in! Do you wish to continue?", vbQuestion + vbYesNo, "logging - off") = vbYes Then
            Dim counter As Integer
            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter
            MainForm.Show()
            Me.Close()
        End If
    End Sub
    Private Sub ClearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        '
        lock()
        '
        txtSN.Focus()
        clearing()
        '
        opendb3()
        sqlquery3()
        '
        db.Open()
        dbcmd = New OleDb.OleDbCommand("DELETE * FROM tbltemp", db)
        dbcmd.ExecuteNonQuery()
        dgtemp.DataSource = dbds.Tables("tbltemp")
        db.Close()
        lblDisplay.Text = "0.00"
        dgtemp.Refresh()
        xGTotal = 0
        '
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        autotransid()
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        changelongpaper()
        PrintPreviewControl1.Document = PrintDocument1
    End Sub
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        PrintDocument1.Print()
    End Sub
    Private Sub PrinterSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrinterSetupToolStripMenuItem.Click
        FormPrinter.ShowDialog()
    End Sub
    Private Sub cmbPayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayment.SelectedIndexChanged
        If cmbPayment.Text = "Cash" Then
            txtamt.Enabled = True
            txtDiscount.Enabled = True
        ElseIf cmbPayment.Text = "Debit / Credit Card" Then
            txtamt.Enabled = True
            txtDiscount.Enabled = True
        End If
    End Sub
    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblDisplay.Text = lblDisplay.Text - txtDiscount.Text
        End If
    End Sub
    Private Sub dgtemp_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtemp.CellClick
        '
        'txtStock.Text = dgtemp.Rows(e.RowIndex).Cells(0).Value.ToString
        txtSN.Text = dgtemp.Rows(e.RowIndex).Cells(0).Value.ToString
        txtDesc.Text = dgtemp.Rows(e.RowIndex).Cells(1).Value.ToString
        txtQ.Text = dgtemp.Rows(e.RowIndex).Cells(2).Value.ToString
        lblTotal.Text = dgtemp.Rows(e.RowIndex).Cells(4).Value.ToString
        '
    End Sub
    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem.Click
        txtSN.Text = ""
        txtQ.Text = ""
        txtDesc.Text = ""
        lock()
    End Sub
    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        txtamt.Enabled = True
        PaymentOption.Show()
    End Sub
    Private Sub btnDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiscount.Click
        Discount.Show()
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MsgBox("Are you sure do want to remove this item on list?", vbQuestion + vbYesNo, "Remove Item") = vbYes Then
            'Insert Function
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", db)
            dbds = New DataSet()
            tbltemp.Fill(dbds, "tbltemp")
            '
            db.Open()
            xDesc = dbds.Tables("tbltemp").Rows(recpointer).Item("Description")
            xUP = dbds.Tables("tbltemp").Rows(recpointer).Item("Unit Price")
            xqty = dbds.Tables("tbltemp").Rows(recpointer).Item("Quantity")
            xsn = dbds.Tables("tbltemp").Rows(recpointer).Item("Item Name")
            xtotal = dbds.Tables("tbltemp").Rows(recpointer).Item("Total")
            dbcmd = New OleDb.OleDbCommand("INSERT INTO tblvoid([Trans No],[Item Name],[Description],[Qty],[Total],[Date Time],[Cashier Name]) VALUES ('" & lblTrans.Text.Trim & "','" & xsn & "','" & txtDesc.Text.Trim & "','" & xqty & "','" & xtotal & "','" & d1.Value & "', '" & txtCashier.Text.Trim & "')", db)
            dbcmd.ExecuteNonQuery()
            sqlquery6()
            db.Close()
            ' Delete Function
            xGTotal = CInt(xGTotal) - CDbl(lblTotal.Text)
            lblDisplay.Text = Format(xGTotal, "Standard")
            '
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tbltemp WHERE [Item Name] like '" & txtSN.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery3()
            dgtemp.DataSource = dbds.Tables("tbltemp")
            '
            txtSN.Text = ""
            txtQ.Text = ""
            txtDesc.Text = ""
            '
            db.Close()
            dgtemp.Refresh()
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        CashierEditForm.Show()
    End Sub
    Private Sub btnPaymentStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaymentStyle.Click
        CashPay.Show()
    End Sub
    Private Sub SearchItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchItemToolStripMenuItem.Click
        SearchItemForm.Show()
    End Sub
    Private Sub btnAddStockQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStockQty.Click
        AddQtyCashier.Show()
    End Sub
    Private Sub AddStockQtyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStockQtyToolStripMenuItem.Click
        AddQtyCashier.Show()
    End Sub
    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If MsgBox("Are you sure do want to remove this item on list?", vbQuestion + vbYesNo, "Remove Item") = vbYes Then
            'Insert Function
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", db)
            dbds = New DataSet()
            tbltemp.Fill(dbds, "tbltemp")
            '
            db.Open()
            xDesc = dbds.Tables("tbltemp").Rows(recpointer).Item("Description")
            xUP = dbds.Tables("tbltemp").Rows(recpointer).Item("Unit Price")
            xqty = dbds.Tables("tbltemp").Rows(recpointer).Item("Quantity")
            xsn = dbds.Tables("tbltemp").Rows(recpointer).Item("Item Name")
            xtotal = dbds.Tables("tbltemp").Rows(recpointer).Item("Total")
            dbcmd = New OleDb.OleDbCommand("INSERT INTO tblvoid([Trans No],[Item Name],[Description],[Qty],[Total],[Date Time],[Cashier Name]) VALUES ('" & lblTrans.Text.Trim & "','" & xsn & "','" & txtDesc.Text.Trim & "','" & xqty & "','" & xtotal & "','" & d1.Value & "', '" & txtCashier.Text.Trim & "')", db)
            dbcmd.ExecuteNonQuery()
            sqlquery6()
            db.Close()
            ' Delete Function
            xGTotal = CInt(xGTotal) - CDbl(lblTotal.Text)
            lblDisplay.Text = Format(xGTotal, "Standard")
            '
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tbltemp WHERE [Item Name] like '" & txtSN.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery3()
            dgtemp.DataSource = dbds.Tables("tbltemp")
            '
            txtSN.Text = ""
            txtQ.Text = ""
            txtDesc.Text = ""
            '
            db.Close()
            dgtemp.Refresh()
        End If
    End Sub
    Private Sub EditItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemToolStripMenuItem.Click
        CashierEditForm.Show()
    End Sub
    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        CashPay.Show()
    End Sub
    Private Sub PaymentMethodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentMethodToolStripMenuItem.Click
        txtamt.Enabled = True
        PaymentOption.Show()
    End Sub
    Private Sub AddDiscountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDiscountToolStripMenuItem.Click
        Discount.Show()
    End Sub
End Class