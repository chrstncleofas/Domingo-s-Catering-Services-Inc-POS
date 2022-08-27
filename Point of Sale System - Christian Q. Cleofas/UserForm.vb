Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Public Class UserForm
    Sub autouseridnumber()
        Try
            db.Open()
            tbluser = New OleDb.OleDbDataAdapter("SELECT [User ID] FROM tbluser ORDER BY [User ID] DESC", db)
            dbds = New DataSet
            tbluser.Fill(dbds, "tbluser")
            If (dbds.Tables(0).Rows.Count > 0) Then
                Dim tempID = dbds.Tables(0).Rows(0)("User ID").ToString().Substring(3, 3)
                Dim newID As Integer = CInt(tempID) + 1
                txtid.Text = "EMP" & newID.ToString("000")
            Else
                txtid.Text = "EMP001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub display()
        Try
            txtid.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User ID")
            txtun.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User Name")
            txtfname.Text = dbds.Tables("tbluser").Rows(recpointer).Item("First Name")
            txtlname.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Last Name")
            txtpost.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Position")       
            cbopv.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Privileges")
            
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgList_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        recpointer = e.RowIndex
        display()
        Try
            idpict.ImageLocation = ""
            idpict.Refresh()
            idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
            idpict.Load()
        Catch ex As Exception

        End Try
    End Sub
    Sub lock()
        txtid.ReadOnly = True
        txtun.ReadOnly = True
        txtpw.ReadOnly = True
        txtrpw.ReadOnly = True
        txtpost.Enabled = False
        cbopv.Enabled = False
        txtfname.Enabled = True
        txtlname.Enabled = True
        btnSave.Enabled = False
    End Sub
    Sub unlock()
        txtid.ReadOnly = False
        txtun.ReadOnly = False
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpost.Enabled = True
        txtfname.Enabled = False
        txtlname.Enabled = False
        cbopv.Enabled = True
        btnSave.Enabled = False
    End Sub
    Sub txtclear()
        txtid.Text = ""
        txtun.Text = ""
        txtpw.Text = ""
        txtrpw.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtpost.Text = Nothing
        idpict.Image = Nothing
        cbopv.Text = Nothing
    End Sub  
    Private Sub UserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        'd1.Value = DateTime.Now
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"
        lblLoginAs.Text = "Login As : " + LoginForm.fname

        If LoginForm.xpriv = "User" Then
            btnUpdate.Enabled = True
            btnDelete.Enabled = False
            btnNext.Enabled = True
            btnPrev.Enabled = True
            btnFirst.Enabled = True
            btnLast.Enabled = True
            btnPrint.Enabled = False
            lock()
        End If
        If LoginForm.xpriv = "Admin" Then
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnNext.Enabled = True
            btnPrev.Enabled = True
            btnFirst.Enabled = True
            btnLast.Enabled = True
            btnPrint.Enabled = True
            txtid.ReadOnly = False
            txtun.ReadOnly = False
            txtpw.ReadOnly = False
            txtrpw.ReadOnly = False
            txtpost.Enabled = True
            cbopv.Enabled = True
            btnSave.Enabled = False
        End If
        opendb()
        sqlquery()
        dgList.DataSource = dbds.Tables("tbluser")
    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        dgList.Rows(recpointer).Selected = False
        recpointer = 0
        dgList.Rows(recpointer).Selected = True
        display()
        Try
            idpict.ImageLocation = ""
            idpict.Refresh()
            idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
            idpict.Load()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub chkShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = False Then
            txtpw.PasswordChar = "●"
        Else
            txtpw.PasswordChar = ""
        End If
    End Sub
    Private Sub chkShowRpw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowRpw.CheckedChanged
        If chkShowRpw.Checked = False Then
            txtrpw.PasswordChar = "●"
        Else
            txtrpw.PasswordChar = ""
        End If
    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        dgList.Rows(recpointer).Selected = False
        recpointer = trec
        dgList.Rows(recpointer).Selected = True
        display()
        Try
            idpict.ImageLocation = ""
            idpict.Refresh()
            idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
            idpict.Load()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If recpointer < trec Then
            dgList.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgList.Rows(recpointer).Selected = True
            display()
            Try
                idpict.ImageLocation = ""
                idpict.Refresh()
                idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                idpict.Load()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If recpointer > 0 Then
            dgList.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgList.Rows(recpointer).Selected = True
            display()
            Try
                idpict.ImageLocation = ""
                idpict.Refresh()
                idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                idpict.Load()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MsgBox("Are you sure do want to change your details", vbQuestion + vbYesNo, "Updating...") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE tbluser SET [User ID]= '" & txtid.Text.Trim & "', [User Name]= '" & txtun.Text.Trim & "', [Password]= '" & txtpw.Text.Trim & "', [Position]= '" & txtpost.Text.Trim & "', [First Name]= '" & txtfname.Text.Trim & "', [Last Name]='" & txtlname.Text.Trim & "', [Privileges]= '" & cbopv.Text.Trim & "' WHERE [User ID]like '" & txtid.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery()
            dgList.DataSource = dbds.Tables("tbluser")
            txtclear()
        Else
            MsgBox("Error", vbCritical, "Warning!!1!")
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure do want to delete this record, the file record will be permanently delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Delete....") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tbluser WHERE [User ID] like '" & txtid.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery()
            dgList.DataSource = dbds.Tables("tbluser")
            txtclear()
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtpw.Text.Trim = txtrpw.Text.Trim Then
            If sw = False Then
                If cbopv.Text = "" And txtun.Text = "" And txtpw.Text = "" And txtpost.Text = "" And txtrpw.Text = "" Then
                    MsgBox("Please fill up all fields", vbCritical, "Reminder..")
                ElseIf MsgBox("Are you sure do want to save this account?", vbInformation + vbYesNo, "Creating.....") = MsgBoxResult.Yes Then
                    db.Open()
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO tbluser([User ID],[User Name],[Password],[First Name],[Last Name],[Position],[Privileges],[DateTime]) VALUES ('" & txtid.Text.Trim & "','" & txtun.Text.Trim & "','" & txtpw.Text.Trim & "','" & txtfname.Text.Trim & "','" & txtlname.Text.Trim & "','" & txtpost.Text.Trim & "','" & cbopv.Text.Trim & "','" & d1.Value & "')", db)
                    dbcmd.ExecuteNonQuery()
                    sqlquery()
                    txtclear()
                    dgList.DataSource = dbds.Tables("tbluser")
                Else
                    txtid.Focus()
                End If
            End If
        Else
            MsgBox("Your password not match !!!", vbCritical, "Password Inccorrect")
            txtpw.Focus()
            txtpw.Clear()
            txtrpw.Clear()
        End If
    End Sub
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If txtid.Text.Trim.Length > 0 Then
            OpenFileDialog1.FileName = ""
            'OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Application.StartupPath & "\images\" & Trim(txtid.Text) & ".jpg", True)
                    idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                    idpict.Load()
                Catch err As Exception
                    MsgBox(err.Message)
                End Try
            End If
        Else
            MsgBox("Please type your User ID first before uploading image", MsgBoxStyle.Information, "Upload Image")
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        autouseridnumber()
        btnSave.Enabled = True
        txtid.ReadOnly = False
        txtun.ReadOnly = False
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpost.Enabled = True
        cbopv.Enabled = True
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim x As String
        x = txtSearch.Text
        If x.Length < 1 Then
            MsgBox("Please enter your User ID", vbInformation, "Search")
        Else
            Try
                tbluser = New OleDb.OleDbDataAdapter("SELECT [User ID],[User Name],[Position],[Privileges] FROM tbluser WHERE [User ID] like '%" & x.Trim & "%'", db)
                dbds = New DataSet()
                tbluser.Fill(dbds, "tbluser")
                If dbds.Tables("tbluser").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
                    dgList.DataSource = dbds.Tables("tbluser")
                    display()
                    idpict.ImageLocation = ""
                    idpict.Refresh()
                    idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                    idpict.Load()
                    btnNext.Enabled = True
                    btnPrev.Enabled = True
                    btnFirst.Enabled = True
                    btnLast.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                db.Close()
            End Try
        End If
    End Sub
    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        'ito ung trap na wala laman
        If txtSearch.Text = "" Then
            MsgBox("Nothing to clear this field, Please input first", vbCritical, "Error")
        Else
            'Babalik sa dati ung display ung Grid
            txtSearch.Clear()
            txtclear()
            sqlquery()
            dgList.DataSource = dbds.Tables("tbluser")
        End If
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
            Dim rawData(dgList.Rows.Count, dgList.Columns.Count - 1) As Object
            For col = 0 To dgList.Columns.Count - 1
                rawData(0, col) = dgList.Columns(col).HeaderText.ToUpper
            Next
            For col = 0 To dgList.Columns.Count - 1
                For row = 0 To dgList.Rows.Count - 1
                    rawData(row + 1, col) = dgList.Rows(row).Cells(col).Value
                Next
            Next
            Dim finalColLetter As String = String.Empty
            finalColLetter = ExcelColName(dgList.Columns.Count)
            sheetIndex += 1
            Ws = Wb.Worksheets(sheetIndex)
            Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, dgList.Rows.Count + 1)
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
        'Try
        '    Dim ctr As Integer
        '    Dim totalrec As Integer
        '    Dim recpointer As Integer
        '    Dim excelobject As New Microsoft.Office.Interop.Excel.Application
        '    Dim WSheet As New Microsoft.Office.Interop.Excel.Worksheet

        '    Process.Start(Application.StartupPath & "\reports\userlist.xlsx")

        '    WSheet = excelobject.Sheets("User Report")
        '    WSheet.Select()

        '    If dbds.Tables("tbluser").Rows.Count - 1 > 0 Then
        '        ctr = 9
        '        totalrec = dbds.Tables("tbluser").Rows.Count - 1
        '        recpointer = 0
        '        'WSheet.Range("A5").Value = "Printed :" & Format(Now(), "MMMM dd, yyyy")

        '        Do While recpointer <= totalrec
        '            WSheet.Range("A" & ctr).Value = recpointer + 1
        '            WSheet.Range("B" & ctr).Value = Trim(dbds.Tables("tbluser").Rows(recpointer).Item("User ID"))
        '            WSheet.Range("C" & ctr).Value = Trim(dbds.Tables("tbluser").Rows(recpointer).Item("User Name"))
        '            WSheet.Range("D" & ctr).Value = Trim(dbds.Tables("tbluser").Rows(recpointer).Item("Position"))
        '            WSheet.Range("E" & ctr).Value = Trim(dbds.Tables("tbluser").Rows(recpointer).Item("Privilege"))
        '            ctr = ctr + 1
        '            recpointer = recpointer + 1
        '        Loop
        '    End If
        'Catch ex As Exception
        'Finally
        'End Try
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
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtid.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        cbopv.Text = ""
        txtun.Clear()
        txtpw.Clear()
        txtrpw.Clear()
        txtpost.Text = "None"
        cbopv.Text = "None"
        chkShowRpw.Checked = False
        chkShow.Checked = False
        idpict.Image = Nothing
    End Sub
    Private Sub btnCloses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloses.Click
        Dim counter As Integer
        For counter = 90 To 10 Step -20
            Me.Opacity = counter / 100
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next counter
        MainForm.Show()
        Me.Close()
    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class