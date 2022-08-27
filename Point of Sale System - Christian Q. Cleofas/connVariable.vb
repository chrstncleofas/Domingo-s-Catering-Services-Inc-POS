Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Module connVariable

    Public db As New OleDbConnection

    Public tbluser As New OleDbDataAdapter
    Public tblstock As New OleDbDataAdapter
    Public tbltemp As New OleDbDataAdapter
    Public tbltran As New OleDbDataAdapter
    Public tblinvoice As New OleDbDataAdapter
    Public tblvoid As New OleDbDataAdapter

    Public dbcmd As New OleDbCommand
    Public dbds As New DataSet

    Public recpointer As Integer
    Public trec As Integer
    Public sw As Boolean
    Sub opendb()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tbluser = New OleDb.OleDbDataAdapter("SELECT * FROM tbluser", db)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")

            If dbds.Tables("tbluser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery()
        Try
            tbluser = New OleDb.OleDbDataAdapter("SELECT [User ID],[User Name],[First Name],[Last Name],[Position],[Privileges] FROM tbluser", db)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")
            If dbds.Tables("tbluser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub opendb2()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock", db)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")

            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery2()
        Try
            tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock", db)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")
            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub opendb3()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", db)
            dbds = New DataSet()
            tbltemp.Fill(dbds, "tbltemp")

            If dbds.Tables("tbltemp").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery3()
        Try
            tbltemp = New OleDb.OleDbDataAdapter("SELECT [Item Name],[Description],[Quantity],[Unit Price],[Total] FROM tbltemp", db)
            dbds = New DataSet()
            tbltemp.Fill(dbds, "tbltemp")
            If dbds.Tables("tbltemp").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub opendb4()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tbltran = New OleDb.OleDbDataAdapter("SELECT * FROM tbltran", db)
            dbds = New DataSet()
            tbltran.Fill(dbds, "tbltran")

            If dbds.Tables("tbltran").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbltran").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery4()
        Try
            tbltran = New OleDb.OleDbDataAdapter("SELECT [Trans ID],[Item Name],[Quantity],[Total],[Date Time],[Cashier Name],[Payment Method] FROM tbltran", db)
            dbds = New DataSet()
            tbltran.Fill(dbds, "tbltran")
            If dbds.Tables("tbltran").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbltran").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub opendb5()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tblinvoice = New OleDb.OleDbDataAdapter("SELECT * FROM tblinvoice", db)
            dbds = New DataSet()
            tblinvoice.Fill(dbds, "tblinvoice")

            If dbds.Tables("tblinvoice").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblinvoice").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery5()
        Try
            tblinvoice = New OleDb.OleDbDataAdapter("SELECT * FROM tblinvoice", db)
            dbds = New DataSet()
            tblinvoice.Fill(dbds, "tblinvoice")
            If dbds.Tables("tblinvoice").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblinvoice").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub opendb6()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tblvoid = New OleDb.OleDbDataAdapter("SELECT * FROM tblvoid", db)
            dbds = New DataSet()
            tblvoid.Fill(dbds, "tblvoid")

            If dbds.Tables("tblvoid").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblvoid").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery6()
        Try
            tblvoid = New OleDb.OleDbDataAdapter("SELECT * FROM tblvoid", db)
            dbds = New DataSet()
            tblvoid.Fill(dbds, "tblvoid")
            If dbds.Tables("tblvoid").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblvoid").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub opendb7()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\myDbase.mdb")
            tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM tblstock", db)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")

            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery7()
        Try
            tblstock = New OleDb.OleDbDataAdapter("SELECT [Product Name],[Product Quantity],[Selling Price] FROM tblstock", db)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")
            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            db.Close()
        End Try
    End Sub
End Module
