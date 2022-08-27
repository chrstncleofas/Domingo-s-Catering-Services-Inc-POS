<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpload = New Guna.UI.WinForms.GunaButton()
        Me.idpict = New System.Windows.Forms.PictureBox()
        Me.btnCloses = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblLoginAs = New System.Windows.Forms.Label()
        Me.btnPrint = New Guna.UI.WinForms.GunaButton()
        Me.btnLast = New Guna.UI.WinForms.GunaButton()
        Me.btnFirst = New Guna.UI.WinForms.GunaButton()
        Me.btnNext = New Guna.UI.WinForms.GunaButton()
        Me.btnPrev = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.dgList = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnC = New Guna.UI.WinForms.GunaButton()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtun = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpw = New Guna.UI.WinForms.GunaTextBox()
        Me.cbopv = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpost = New Guna.UI.WinForms.GunaComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtrpw = New Guna.UI.WinForms.GunaTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkShowRpw = New Guna.UI.WinForms.GunaImageCheckBox()
        Me.chkShow = New Guna.UI.WinForms.GunaImageCheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtlname = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.idpict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Controls.Add(Me.idpict)
        Me.Panel1.Controls.Add(Me.btnCloses)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 550)
        Me.Panel1.TabIndex = 0
        '
        'btnUpload
        '
        Me.btnUpload.AnimationHoverSpeed = 0.07!
        Me.btnUpload.AnimationSpeed = 0.03!
        Me.btnUpload.BackColor = System.Drawing.Color.White
        Me.btnUpload.BaseColor = System.Drawing.Color.SkyBlue
        Me.btnUpload.BorderColor = System.Drawing.Color.Black
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpload.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.Black
        Me.btnUpload.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_upload_100
        Me.btnUpload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpload.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnUpload.Location = New System.Drawing.Point(44, 159)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.btnUpload.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpload.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnUpload.OnHoverImage = Nothing
        Me.btnUpload.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpload.Size = New System.Drawing.Size(119, 29)
        Me.btnUpload.TabIndex = 5
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'idpict
        '
        Me.idpict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.idpict.Location = New System.Drawing.Point(22, 13)
        Me.idpict.Name = "idpict"
        Me.idpict.Size = New System.Drawing.Size(165, 135)
        Me.idpict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpict.TabIndex = 4
        Me.idpict.TabStop = False
        '
        'btnCloses
        '
        Me.btnCloses.AnimationHoverSpeed = 0.07!
        Me.btnCloses.AnimationSpeed = 0.03!
        Me.btnCloses.BackColor = System.Drawing.Color.Lavender
        Me.btnCloses.BaseColor = System.Drawing.Color.White
        Me.btnCloses.BorderColor = System.Drawing.Color.Black
        Me.btnCloses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloses.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCloses.FocusedColor = System.Drawing.Color.Empty
        Me.btnCloses.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCloses.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_close_64__1_1
        Me.btnCloses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCloses.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCloses.Location = New System.Drawing.Point(1, 476)
        Me.btnCloses.Name = "btnCloses"
        Me.btnCloses.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.btnCloses.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloses.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloses.OnHoverImage = Nothing
        Me.btnCloses.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloses.Size = New System.Drawing.Size(208, 64)
        Me.btnCloses.TabIndex = 3
        Me.btnCloses.Text = "Close Form"
        Me.btnCloses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Lavender
        Me.btnClear.BaseColor = System.Drawing.Color.White
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_clear_symbol_100
        Me.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClear.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnClear.Location = New System.Drawing.Point(2, 409)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Size = New System.Drawing.Size(208, 64)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.AnimationHoverSpeed = 0.07!
        Me.btnAdd.AnimationSpeed = 0.03!
        Me.btnAdd.BackColor = System.Drawing.Color.Lavender
        Me.btnAdd.BaseColor = System.Drawing.Color.White
        Me.btnAdd.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_add_100
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAdd.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAdd.Location = New System.Drawing.Point(2, 343)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Size = New System.Drawing.Size(208, 64)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BackColor = System.Drawing.Color.Lavender
        Me.btnSave.BaseColor = System.Drawing.Color.White
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Maroon
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_save_100__1_
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSave.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSave.Location = New System.Drawing.Point(2, 276)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(208, 65)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.lblLoginAs)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnLast)
        Me.Panel2.Controls.Add(Me.btnFirst)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnPrev)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.dgList)
        Me.Panel2.Controls.Add(Me.btnC)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(751, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 550)
        Me.Panel2.TabIndex = 1
        '
        'lblLoginAs
        '
        Me.lblLoginAs.AutoSize = True
        Me.lblLoginAs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginAs.ForeColor = System.Drawing.Color.Black
        Me.lblLoginAs.Location = New System.Drawing.Point(19, 64)
        Me.lblLoginAs.Name = "lblLoginAs"
        Me.lblLoginAs.Size = New System.Drawing.Size(104, 25)
        Me.lblLoginAs.TabIndex = 55
        Me.lblLoginAs.Text = "Login As : "
        '
        'btnPrint
        '
        Me.btnPrint.AnimationHoverSpeed = 0.07!
        Me.btnPrint.AnimationSpeed = 0.03!
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BaseColor = System.Drawing.Color.Lavender
        Me.btnPrint.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_printer_64
        Me.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrint.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnPrint.Location = New System.Drawing.Point(372, 447)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint.Radius = 5
        Me.btnPrint.Size = New System.Drawing.Size(124, 39)
        Me.btnPrint.TabIndex = 52
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLast
        '
        Me.btnLast.AnimationHoverSpeed = 0.07!
        Me.btnLast.AnimationSpeed = 0.03!
        Me.btnLast.BackColor = System.Drawing.Color.Transparent
        Me.btnLast.BaseColor = System.Drawing.Color.Lavender
        Me.btnLast.BorderColor = System.Drawing.Color.Black
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLast.FocusedColor = System.Drawing.Color.Empty
        Me.btnLast.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_last_100
        Me.btnLast.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnLast.ImageSize = New System.Drawing.Size(17, 17)
        Me.btnLast.Location = New System.Drawing.Point(428, 495)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnLast.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLast.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnLast.OnHoverImage = Nothing
        Me.btnLast.OnPressedColor = System.Drawing.Color.Black
        Me.btnLast.Radius = 5
        Me.btnLast.Size = New System.Drawing.Size(124, 42)
        Me.btnLast.TabIndex = 51
        Me.btnLast.Text = "Last"
        Me.btnLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFirst
        '
        Me.btnFirst.AnimationHoverSpeed = 0.07!
        Me.btnFirst.AnimationSpeed = 0.03!
        Me.btnFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnFirst.BaseColor = System.Drawing.Color.Lavender
        Me.btnFirst.BorderColor = System.Drawing.Color.Black
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFirst.FocusedColor = System.Drawing.Color.Empty
        Me.btnFirst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_first_100
        Me.btnFirst.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFirst.ImageSize = New System.Drawing.Size(17, 17)
        Me.btnFirst.Location = New System.Drawing.Point(38, 495)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnFirst.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFirst.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnFirst.OnHoverImage = Nothing
        Me.btnFirst.OnPressedColor = System.Drawing.Color.Black
        Me.btnFirst.Radius = 5
        Me.btnFirst.Size = New System.Drawing.Size(124, 42)
        Me.btnFirst.TabIndex = 50
        Me.btnFirst.Text = "First"
        Me.btnFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNext
        '
        Me.btnNext.AnimationHoverSpeed = 0.07!
        Me.btnNext.AnimationSpeed = 0.03!
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BaseColor = System.Drawing.Color.Lavender
        Me.btnNext.BorderColor = System.Drawing.Color.Black
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.FocusedColor = System.Drawing.Color.Empty
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_skip_to_start_100
        Me.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnNext.ImageSize = New System.Drawing.Size(17, 17)
        Me.btnNext.Location = New System.Drawing.Point(168, 495)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnNext.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNext.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnNext.OnHoverImage = Nothing
        Me.btnNext.OnPressedColor = System.Drawing.Color.Black
        Me.btnNext.Radius = 5
        Me.btnNext.Size = New System.Drawing.Size(124, 42)
        Me.btnNext.TabIndex = 49
        Me.btnNext.Text = "Next"
        Me.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrev
        '
        Me.btnPrev.AnimationHoverSpeed = 0.07!
        Me.btnPrev.AnimationSpeed = 0.03!
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.BaseColor = System.Drawing.Color.Lavender
        Me.btnPrev.BorderColor = System.Drawing.Color.Black
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrev.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrev.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Black
        Me.btnPrev.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_end_100
        Me.btnPrev.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrev.ImageSize = New System.Drawing.Size(17, 17)
        Me.btnPrev.Location = New System.Drawing.Point(298, 495)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnPrev.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrev.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnPrev.OnHoverImage = Nothing
        Me.btnPrev.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrev.Radius = 5
        Me.btnPrev.Size = New System.Drawing.Size(124, 42)
        Me.btnPrev.TabIndex = 48
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.Lavender
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_remove_100
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDelete.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDelete.Location = New System.Drawing.Point(242, 447)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Radius = 5
        Me.btnDelete.Size = New System.Drawing.Size(124, 42)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdate
        '
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.Lavender
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_edit_file_64
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpdate.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnUpdate.Location = New System.Drawing.Point(112, 447)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 5
        Me.btnUpdate.Size = New System.Drawing.Size(124, 42)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.AllowUserToResizeColumns = False
        Me.dgList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgList.BackgroundColor = System.Drawing.Color.White
        Me.dgList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgList.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgList.EnableHeadersVisualStyles = False
        Me.dgList.GridColor = System.Drawing.Color.SkyBlue
        Me.dgList.Location = New System.Drawing.Point(14, 104)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.RowHeadersVisible = False
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(549, 337)
        Me.dgList.TabIndex = 46
        Me.dgList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.GridColor = System.Drawing.Color.SkyBlue
        Me.dgList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgList.ThemeStyle.HeaderStyle.Height = 21
        Me.dgList.ThemeStyle.ReadOnly = True
        Me.dgList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgList.ThemeStyle.RowsStyle.Height = 22
        Me.dgList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SkyBlue
        Me.dgList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'btnC
        '
        Me.btnC.AnimationHoverSpeed = 0.07!
        Me.btnC.AnimationSpeed = 0.03!
        Me.btnC.BaseColor = System.Drawing.Color.White
        Me.btnC.BorderColor = System.Drawing.Color.Black
        Me.btnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnC.FocusedColor = System.Drawing.Color.Empty
        Me.btnC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnC.ForeColor = System.Drawing.Color.White
        Me.btnC.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_clear_symbol_100
        Me.btnC.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnC.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnC.Location = New System.Drawing.Point(501, 60)
        Me.btnC.Name = "btnC"
        Me.btnC.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnC.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnC.OnHoverForeColor = System.Drawing.Color.White
        Me.btnC.OnHoverImage = Nothing
        Me.btnC.OnPressedColor = System.Drawing.Color.Black
        Me.btnC.Size = New System.Drawing.Size(29, 24)
        Me.btnC.TabIndex = 22
        '
        'btnSearch
        '
        Me.btnSearch.AnimationHoverSpeed = 0.07!
        Me.btnSearch.AnimationSpeed = 0.03!
        Me.btnSearch.BaseColor = System.Drawing.Color.White
        Me.btnSearch.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_search_50
        Me.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSearch.Location = New System.Drawing.Point(529, 60)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnSearch.Size = New System.Drawing.Size(29, 24)
        Me.btnSearch.TabIndex = 21
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(357, 57)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.PlaceholderText = "Enter User ID"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(202, 31)
        Me.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSearch.TabIndex = 54
        '
        'd1
        '
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d1.Location = New System.Drawing.Point(657, 523)
        Me.d1.Margin = New System.Windows.Forms.Padding(5)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(89, 20)
        Me.d1.TabIndex = 56
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(412, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 1)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(283, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 64)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "               POINT OF SALE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Domingo's Catering Services Inc."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(386, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please fill up all fields"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.Transparent
        Me.txtid.BaseColor = System.Drawing.Color.White
        Me.txtid.BorderColor = System.Drawing.Color.Black
        Me.txtid.BorderSize = 1
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid.FocusedBorderColor = System.Drawing.Color.Black
        Me.txtid.FocusedForeColor = System.Drawing.Color.Black
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(258, 186)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.Radius = 5
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(196, 34)
        Me.txtid.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(261, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "User ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(266, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Username"
        '
        'txtun
        '
        Me.txtun.BackColor = System.Drawing.Color.Transparent
        Me.txtun.BaseColor = System.Drawing.Color.White
        Me.txtun.BorderColor = System.Drawing.Color.Black
        Me.txtun.BorderSize = 1
        Me.txtun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtun.FocusedBaseColor = System.Drawing.Color.White
        Me.txtun.FocusedBorderColor = System.Drawing.Color.Black
        Me.txtun.FocusedForeColor = System.Drawing.Color.Black
        Me.txtun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtun.ForeColor = System.Drawing.Color.Black
        Me.txtun.Location = New System.Drawing.Point(258, 341)
        Me.txtun.Name = "txtun"
        Me.txtun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtun.Radius = 5
        Me.txtun.SelectedText = ""
        Me.txtun.Size = New System.Drawing.Size(196, 34)
        Me.txtun.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(504, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'txtpw
        '
        Me.txtpw.BackColor = System.Drawing.Color.Transparent
        Me.txtpw.BaseColor = System.Drawing.Color.White
        Me.txtpw.BorderColor = System.Drawing.Color.Black
        Me.txtpw.BorderSize = 1
        Me.txtpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpw.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpw.FocusedBorderColor = System.Drawing.Color.Black
        Me.txtpw.FocusedForeColor = System.Drawing.Color.Black
        Me.txtpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpw.ForeColor = System.Drawing.Color.Black
        Me.txtpw.Location = New System.Drawing.Point(496, 341)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpw.Radius = 5
        Me.txtpw.SelectedText = ""
        Me.txtpw.Size = New System.Drawing.Size(196, 34)
        Me.txtpw.TabIndex = 11
        '
        'cbopv
        '
        Me.cbopv.BackColor = System.Drawing.Color.Transparent
        Me.cbopv.BaseColor = System.Drawing.Color.White
        Me.cbopv.BorderColor = System.Drawing.Color.Black
        Me.cbopv.BorderSize = 1
        Me.cbopv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbopv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopv.FocusedColor = System.Drawing.Color.Empty
        Me.cbopv.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopv.ForeColor = System.Drawing.Color.Black
        Me.cbopv.FormattingEnabled = True
        Me.cbopv.Items.AddRange(New Object() {"Admin", "User"})
        Me.cbopv.Location = New System.Drawing.Point(496, 191)
        Me.cbopv.Name = "cbopv"
        Me.cbopv.OnHoverItemBaseColor = System.Drawing.Color.SkyBlue
        Me.cbopv.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.cbopv.Radius = 4
        Me.cbopv.Size = New System.Drawing.Size(196, 28)
        Me.cbopv.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(497, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Privileges"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(266, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Position"
        '
        'txtpost
        '
        Me.txtpost.BackColor = System.Drawing.Color.Transparent
        Me.txtpost.BaseColor = System.Drawing.Color.White
        Me.txtpost.BorderColor = System.Drawing.Color.Black
        Me.txtpost.BorderSize = 1
        Me.txtpost.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtpost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtpost.FocusedColor = System.Drawing.Color.Empty
        Me.txtpost.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpost.ForeColor = System.Drawing.Color.Black
        Me.txtpost.FormattingEnabled = True
        Me.txtpost.Items.AddRange(New Object() {"IT Manager", "Cashier", "Clerk", "Sales Agent", "Supervisor"})
        Me.txtpost.Location = New System.Drawing.Point(258, 421)
        Me.txtpost.Name = "txtpost"
        Me.txtpost.OnHoverItemBaseColor = System.Drawing.Color.SkyBlue
        Me.txtpost.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.txtpost.Radius = 4
        Me.txtpost.Size = New System.Drawing.Size(196, 28)
        Me.txtpost.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(502, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Re-type password"
        '
        'txtrpw
        '
        Me.txtrpw.BackColor = System.Drawing.Color.Transparent
        Me.txtrpw.BaseColor = System.Drawing.Color.White
        Me.txtrpw.BorderColor = System.Drawing.Color.Black
        Me.txtrpw.BorderSize = 1
        Me.txtrpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrpw.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrpw.FocusedBorderColor = System.Drawing.Color.Black
        Me.txtrpw.FocusedForeColor = System.Drawing.Color.Black
        Me.txtrpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtrpw.ForeColor = System.Drawing.Color.Black
        Me.txtrpw.Location = New System.Drawing.Point(496, 418)
        Me.txtrpw.Name = "txtrpw"
        Me.txtrpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtrpw.Radius = 5
        Me.txtrpw.SelectedText = ""
        Me.txtrpw.Size = New System.Drawing.Size(196, 34)
        Me.txtrpw.TabIndex = 19
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 3
        Me.GunaElipse2.TargetControl = Me.txtSearch
        '
        'chkShowRpw
        '
        Me.chkShowRpw.ImageCheckedOff = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_eye_unchecked_100
        Me.chkShowRpw.ImageCheckedOn = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_eye_checked_100
        Me.chkShowRpw.ImageSize = New System.Drawing.Size(25, 25)
        Me.chkShowRpw.Location = New System.Drawing.Point(659, 423)
        Me.chkShowRpw.Name = "chkShowRpw"
        Me.chkShowRpw.Size = New System.Drawing.Size(31, 25)
        Me.chkShowRpw.TabIndex = 55
        '
        'chkShow
        '
        Me.chkShow.ImageCheckedOff = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_eye_unchecked_100
        Me.chkShow.ImageCheckedOn = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_eye_checked_100
        Me.chkShow.ImageSize = New System.Drawing.Size(25, 25)
        Me.chkShow.Location = New System.Drawing.Point(657, 345)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(31, 25)
        Me.chkShow.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(266, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "First Name"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.Transparent
        Me.txtfname.BaseColor = System.Drawing.Color.White
        Me.txtfname.BorderColor = System.Drawing.Color.Black
        Me.txtfname.BorderSize = 1
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfname.FocusedBorderColor = System.Drawing.Color.Black
        Me.txtfname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(258, 263)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.Radius = 5
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(196, 34)
        Me.txtfname.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(504, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Last Name"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.Transparent
        Me.txtlname.BaseColor = System.Drawing.Color.White
        Me.txtlname.BorderColor = System.Drawing.Color.Black
        Me.txtlname.BorderSize = 1
        Me.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtlname.FocusedBorderColor = System.Drawing.Color.Black
        Me.txtlname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlname.ForeColor = System.Drawing.Color.Black
        Me.txtlname.Location = New System.Drawing.Point(496, 263)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.Radius = 5
        Me.txtlname.SelectedText = ""
        Me.txtlname.Size = New System.Drawing.Size(196, 34)
        Me.txtlname.TabIndex = 59
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1326, 550)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.chkShowRpw)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.txtrpw)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbopv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1111"
        Me.Panel1.ResumeLayout(False)
        CType(Me.idpict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCloses As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents idpict As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpload As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtun As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpw As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbopv As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpost As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtrpw As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnC As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgList As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPrev As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnLast As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnFirst As Guna.UI.WinForms.GunaButton
    Friend WithEvents chkShowRpw As Guna.UI.WinForms.GunaImageCheckBox
    Friend WithEvents chkShow As Guna.UI.WinForms.GunaImageCheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblLoginAs As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents d1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtlname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfname As Guna.UI.WinForms.GunaTextBox
End Class
