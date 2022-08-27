Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Public Class UserReportView
    Sub lock()
        d1.Enabled = False
        d2.Enabled = False
        t1.Enabled = False
        t2.Enabled = False
    End Sub
    Sub unlock()
        d1.Enabled = True
        d2.Enabled = True
        t1.Enabled = True
        t2.Enabled = True
    End Sub
    Private Sub UserReportView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lock()
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy - HH:mm:ss tt"
        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy - HH:mm:ss tt"
        t1.Format = DateTimePickerFormat.Time
        t1.CustomFormat = "HH:mm:ss tt"
        t2.Format = DateTimePickerFormat.Time
        t2.CustomFormat = "HH:mm:ss tt"
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'Same ito din
        Dim date1 As DateTime = DateTime.Parse(d1.Value)
        Dim date2 As DateTime = DateTime.Parse(d2.Value)
        Dim time1 As DateTime = DateTime.Parse(t1.Value)
        Dim time2 As DateTime = DateTime.Parse(t2.Value)
        Dim report As New user
        If cmbFilter.Text = "Load All Data" Then
            opendb()
            sqlquery()
            dgStock.DataSource = dbds.Tables("tbluser")
            report.SetDataSource(dbds)
            CrystalReportViewer1.ReportSource = report
        ElseIf cmbFilter.Text = "Filter by Date" Then
            Try
                tbluser = New OleDb.OleDbDataAdapter("SELECT [User ID],[User Name],[Position],[Privileges],[DateTime] FROM tbluser WHERE [DateTime] BETWEEN #" & date1.ToString("MM/dd/yyyy") & " " & time1.ToString("HH:mm:ss tt") & "# and #" & date2.ToString("MM/dd/yyyy") & " " & time2.ToString("HH:mm:ss tt") & "# ORDER BY [DateTime] DESC", db)
                dbds = New DataSet()
                tbluser.Fill(dbds, "tbluser")
                report.SetDataSource(dbds)
                If dbds.Tables("tbluser").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
                    CrystalReportViewer1.ReportSource = report
                    dgStock.DataSource = dbds.Tables("tbluser")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                db.Close()
            End Try
        End If
    End Sub
    Private Sub cmbFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.Text = "Filter by Date" Then
            Unlock()
            dgStock.DataSource = Nothing
        ElseIf cmbFilter.Text = "Load All Data" Then
            Lock()
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If MsgBox("Are you sure do you want to close this window?", vbQuestion + vbYesNo, "Closing........") = vbYes Then
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
    Private Sub btnPrintExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintExcel.Click
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
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        SaveFileDialog1.Filter = "Excel Documents|*.xlsx"
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dgStock.DataSource = Nothing
    End Sub
End Class