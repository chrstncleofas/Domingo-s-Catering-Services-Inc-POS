Imports System.Drawing.Printing
Imports System.Data.DataTable
Public Class CashierEditForm
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
    Sub Open1()
        tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock WHERE [Product Name] like '" & Cashier.txtSN.Text.Trim & "' ", db)
        dbds = New DataSet()
        tblstock.Fill(dbds, "tblstock")
        xUP = dbds.Tables("tblstock").Rows(0).Item("Selling Price")
        xUP = FormatCurrency(xUP)
    End Sub
    Sub Open2()
        tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", db)
        dbds = New DataSet()
        tbltemp.Fill(dbds, "tbltemp")
        xtempq = dbds.Tables("tbltemp").Rows(0).Item("Quantity")
        xGTotal = dbds.Tables("tbltemp").Rows(0).Item("Total")
    End Sub
    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtQty.Text) = False And txtQty.Text = "" Then
                MsgBox("Number's Only and Type Correct Number", vbCritical, "Edit Item Failed")
                txtQty.Focus()
                txtQty.Clear()
                Exit Sub
            Else
                Open2()
                '
                xGTotal = CInt(xGTotal) - CDbl(Cashier.lblTotal.Text)
                Cashier.lblDisplay.Text = Format(xGTotal, "Standard")
                '
                db.Open()
                '
                xtempq = xtempq - CInt(txtQty.Text)
                xGTotal = CSng(xGTotal) - CSng(Cashier.lblTotal.Text)
                Cashier.lblTotal.Text = FormatCurrency(Cashier.lblDisplay.Text)
                dbcmd = New OleDb.OleDbCommand("UPDATE tbltemp set [Quantity]='" & xtempq & "',[Total]='" & Cashier.lblDisplay.Text & "' WHERE [Item Name] like '" & Cashier.txtSN.Text.Trim & "'", db)
                dbcmd.ExecuteNonQuery()
                '
                sqlquery3()
                Cashier.dgtemp.DataSource = dbds.Tables("tbltemp")
                Cashier.txtQ.Clear()
                Cashier.txtSN.Clear()


                'Total funtion by Quantity
                tbltemp = New OleDb.OleDbDataAdapter("SELECT sum([Total]) as xt FROM tbltemp", db)
                dbds = New DataSet()
                tbltemp.Fill(dbds, "tbltemp")
                If dbds.Tables("tbltemp").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
                End If
                Cashier.lblDisplay.Text = dbds.Tables("tbltemp").Rows(0).Item("xt")
                Cashier.lblDisplay.Text = FormatCurrency(Cashier.lblDisplay.Text)
                '
                Me.Close()
            End If
        End If
    End Sub
    Private Sub txtQty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        Open1()
        Try
            Cashier.lblTotal.Text = CInt(txtQty.Text) * CInt(xUP)
            Cashier.lblTotal.Text = FormatCurrency(Cashier.lblTotal.Text)
        Catch err As Exception
            'MsgBox(err.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtQty.Clear()
        Me.Close()
    End Sub
    Private Sub CashierEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xtempq = 0
        xGTotal = 0
    End Sub
End Class