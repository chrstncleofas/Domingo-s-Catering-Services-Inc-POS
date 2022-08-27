Public Class LoginForm
    Public xname As String
    Public xpost As String
    Public xpriv As String
    Public fname As String
    Dim xtry As String
    Private Sub chkShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = False Then
            txtPassword.PasswordChar = "●"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please type your username and password! ", vbCritical, "Error")
        Else
            opendb()
            tbluser = New OleDb.OleDbDataAdapter("SELECT * FROM tbluser WHERE [User Name] like '" & txtUsername.Text & "' and [Password] like '" & txtPassword.Text & "'", db)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")
            trec = dbds.Tables("tbluser").Rows.Count
            If trec > 0 Then
                xname = txtUsername.Text
                'Cashier.txtCashier.Text = txtUsername.Text
                xpost = dbds.Tables("tbluser").Rows(0).Item("Position")
                xpriv = dbds.Tables("tbluser").Rows(0).Item("Privileges")
                fname = dbds.Tables("tbluser").Rows(0).Item("First Name")
                xname = dbds.Tables("tbluser").Rows(0).Item("User Name")
                MsgBox("Welcome to Domingo's Catering Services Inc. " + " " + fname + " : )", vbInformation, "POINT OF SALE")
                txtUsername.Clear()
                txtPassword.Clear()
                MainForm.Show()
                Me.Hide()
            Else
                MsgBox("The username and password not match, please try again!", vbCritical, "Error")
                xtry = xtry + 1
                If xtry = 3 Then
                    Me.Close()
                End If
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            End If
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure do you want to close this window?", vbQuestion + vbYesNo, "Exit") = vbYes Then
            Dim counter As Integer
            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub
End Class
