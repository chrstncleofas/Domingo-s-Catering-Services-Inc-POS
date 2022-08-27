Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Public Class InventoryDashBoard
    Dim crit As Integer
    Sub txtclear()
        txtProductID.Text = ""
        txtProductName.Text = ""
        txtCategory.Text = ""
        txtDescription.Text = ""
        txtProductQuan.Value = 0
        txtBuyingPrice.Text = ""
        txtSellingPrice.Text = ""
        pdID.Image = Nothing

        ProductID.Text = ""
        Description.Text = ""
        Quantity.Value = 0
        BuyingPrice.Text = ""
        SellingPrice.Text = ""
        Images.Image = Nothing
    End Sub
    Sub Criticals()
        If Quantity.Value <= "5" And Quantity.Value >= "1" Then
            MsgBox("Your Stock is " & Quantity.Value, vbCritical, "Please Re-Stock")
        ElseIf Quantity.Value = "0" Then
            MsgBox("Out of Stock", vbCritical, "Please Re-Stock")
        End If
    End Sub
    Private Sub dgStock_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        recpointer = e.RowIndex
        display()
        Criticals()
        Try
            pdID.ImageLocation = ""
            pdID.Refresh()
            pdID.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
            pdID.Load()
        Catch ex As Exception
        End Try
    End Sub
    Sub display()
        Try
            ProductID.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product ID")
            ''txtProductName.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Name")
            ''txtCategory.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Category")
            Description.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Description")
            Quantity.Value = dbds.Tables("tblstock").Rows(recpointer).Item("Product Quantity")
            BuyingPrice.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Buying Price")
            SellingPrice.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Selling Price")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub StockDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb2()
        sqlquery2()
        dgStock.DataSource = dbds.Tables("tblstock")
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"
    End Sub
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        pnStock.Visible = False
        pnAddProduct.Visible = False
        pnEditPage.Visible = False
        txtclear()
    End Sub
    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        pnStock.Visible = True
        pnAddProduct.Visible = False
        pnEditPage.Visible = False
    End Sub
    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click
        pnStock.Visible = False
        pnAddProduct.Visible = True
        pnEditPage.Visible = False
    End Sub
    Private Sub btnEditing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditing.Click
        pnStock.Visible = False
        pnAddProduct.Visible = False
        pnEditPage.Visible = True
    End Sub
    Private Sub btnSP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSP.Click
        pnStock.Visible = True
        pnAddProduct.Visible = False
        pnEditPage.Visible = False
    End Sub
    Private Sub btnAP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAP.Click
        pnStock.Visible = False
        pnAddProduct.Visible = True
        pnEditPage.Visible = False
    End Sub
    Private Sub btnEP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEP.Click
        pnStock.Visible = False
        pnAddProduct.Visible = False
        pnEditPage.Visible = True
    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        dgStock.Rows(recpointer).Selected = False
        recpointer = 0
        dgStock.Rows(recpointer).Selected = True
        display()
        Criticals()
        Try
            Images.ImageLocation = ""
            Images.Refresh()
            Images.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
            Images.Load()

            Images1.ImageLocation = ""
            Images1.Refresh()
            Images1.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
            Images1.Load()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        dgStock.Rows(recpointer).Selected = False
        recpointer = trec
        dgStock.Rows(recpointer).Selected = True
        display()
        Criticals()
        Try
            Images.ImageLocation = ""
            Images.Refresh()
            Images.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
            Images.Load()

            Images1.ImageLocation = ""
            Images1.Refresh()
            Images1.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
            Images1.Load()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure do want to delete this from database?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Delete....") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tblstock WHERE [Product ID] like '" & ProductID.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery2()
            dgStock.DataSource = dbds.Tables("tblstock")
            txtclear()
        End If
    End Sub
    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        If txtSearch.Text = "" Then
            MsgBox("Nothing to clear this field, Please input first", vbCritical, "Error")
        End If
        'Babalik sa dati ung display ung Grid
        txtSearch.Clear()
        sqlquery2()
        dgStock.DataSource = dbds.Tables("tblstock")
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim x As String
        x = txtSearch.Text

        If x.Length < 1 Then
            MsgBox("Please enter your Product Name", vbInformation, "Search")
        Else
            Try
                tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock WHERE [Product ID] like '%" & x.Trim & "%'", db)
                dbds = New DataSet()
                tblstock.Fill(dbds, "tblstock")
                If dbds.Tables("tblstock").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
                    dgStock.DataSource = dbds.Tables("tblstock")
                    display()
                    Images1.ImageLocation = ""
                    Images1.Refresh()
                    Images1.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
                    Images1.Load()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                db.Close()
            End Try
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtProductID.Text = "" And txtProductName.Text = "" And txtCategory.Text = "" And txtDescription.Text = "" And txtProductQuan.Value = 0 And txtBuyingPrice.Text = "" And txtSellingPrice.Text = "" Then
            MsgBox("Please fill up all field before click add button", vbCritical, "Invalid Add Item")
        ElseIf MsgBox("The data are now successfuly save into database...", vbQuestion + vbYesNo, "Saving file into database...") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("INSERT INTO tblstock([Product ID],[Product Name],[Product Category],[Product Description],[Product Quantity], [Buying Price], [Selling Price],[Date and Time]) VALUES ('" & txtProductID.Text.Trim & "','" & txtProductName.Text.Trim & "','" & txtCategory.Text.Trim & "','" & txtDescription.Text.Trim & "','" & txtProductQuan.Value & "','" & txtBuyingPrice.Text.Trim & "','" & txtSellingPrice.Text.Trim & "','" & d1.Value & "')", db)
            dbcmd.ExecuteNonQuery()
            sqlquery2()
            'Lock()
            'cboChoose.Enabled = True
            txtclear()
            dgStock.DataSource = dbds.Tables("tblstock")
        Else

        End If
    End Sub
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If txtProductID.Text.Trim.Length > 0 Then
            OpenFileDialog1.FileName = ""
            'OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Application.StartupPath & "\products\" & Trim(txtProductID.Text) & ".jpg", True)
                    pdID.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
                    pdID.Load()
                Catch err As Exception
                    MsgBox(err.Message)
                End Try
            End If
        Else
            MsgBox("Please type the Product ID before browsing for images...", MsgBoxStyle.Information, "Upload Image")
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If ProductID.Text = "" And Quantity.Value = 0 And BuyingPrice.Text = "" And SellingPrice.Text = "" And Description.Text = "" Then
            MsgBox("Please select from stock page list of item that update", vbCritical, "Invalid Update")
        ElseIf MsgBox("Do you want to save the changes you made to its database?", vbQuestion + vbYesNo, "Updating...") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE tblstock SET [Product ID]= '" & ProductID.Text.Trim & "', [Product Description]= '" & Description.Text.Trim & "', [Product Quantity]= '" & Quantity.Value & "', [Buying Price]= '" & BuyingPrice.Text.Trim & "', [Selling Price]= '" & SellingPrice.Text.Trim & "' WHERE [Product ID]like '" & ProductID.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery2()
            dgStock.DataSource = dbds.Tables("tblstock")
            txtclear()
        Else
        End If
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim counter As Integer
        For counter = 90 To 10 Step -20
            Me.Opacity = counter / 100
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next counter
        MainForm.Show()
        Me.Close()
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If recpointer > 0 Then
            dgStock.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgStock.Rows(recpointer).Selected = True
            display()
            Criticals()

            Try
                Images.ImageLocation = ""
                Images.Refresh()
                Images.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
                Images.Load()

                Images1.ImageLocation = ""
                Images1.Refresh()
                Images1.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
                Images1.Load()

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If recpointer < trec Then
            dgStock.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgStock.Rows(recpointer).Selected = True
            display()
            Criticals()
            Try
                Images.ImageLocation = ""
                Images.Refresh()
                Images.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
                Images.Load()

                Images1.ImageLocation = ""
                Images1.Refresh()
                Images1.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
                Images1.Load()

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'My.Computer.FileSystem.DeleteFile(OpenFileDialog1.FileName, Application.StartupPath & "\products\" & Trim(ProductID.Text) & ".jpg", True)
        'Images.ImageLocation = Application.StartupPath & "\products\" & ProductID.Text.Trim & ".jpg"
        'Images.Load()
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim sheetIndex As Integer
            Dim Ex As Object
            Dim Wb As Object
            Dim Ws As Object
            Ex = CreateObject("Excel.Application")
            Wb = Ex.workbooks.add
            Dim col, row As Integer
            Dim rawData(dgStock.Rows.Count, dgStock.Columns.Count - 1) As Object
            For col = 0 To dgStock.Columns.Count - 1
                rawData(0, col) = dgStock.Columns(col).HeaderText.ToUpper
            Next
            For col = 0 To dgStock.Columns.Count - 1
                For row = 0 To dgStock.Rows.Count - 1
                    rawData(row + 1, col) = dgStock.Rows(row).Cells(col).Value
                Next
            Next
            Dim finalColLetter As String = String.Empty
            finalColLetter = ExcelColName(dgStock.Columns.Count)
            sheetIndex += 1
            Ws = Wb.Worksheets(sheetIndex)
            Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, dgStock.Rows.Count + 1)
            Ws.Range(excelRange, Type.Missing).Value2 = rawData
            Ws = Nothing
            Wb.SaveAs(SaveFileDialog1.FileName, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Wb.Close(True, Type.Missing, Type.Missing)
            Wb = Nothing
            ' Release the Application object
            Ex.Quit()
            Ex = Nothing
            ' Collect the unreferenced objects
            GC.Collect()
            MsgBox("Exported Successfully.", vbInformation, "Point of Sales, Exported Complete")
        End If
    End Sub
    Public Function ExcelColName(ByVal Col As Integer) As String
        If Col < 0 And Col > 256 Then
            MsgBox("Invalid Argument", vbCritical, "Error Process")
            Return Nothing
            Exit Function
        End If
        Dim i As Int16
        Dim r As Int16
        Dim S As String
        If Col <= 26 Then
            S = Chr(Col + 64)
        Else
            r = Col Mod 26
            i = System.Math.Floor(Col / 26)
            If r = 0 Then
                r = 26
                i = i - 1
            End If
            S = Chr(i + 64) & Chr(r + 64)
        End If
        ExcelColName = S
    End Function
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        SaveFileDialog1.Filter = "Excel Documents|*.xlsx"
    End Sub
End Class