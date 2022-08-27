<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtamt = New Guna.UI.WinForms.GunaTextBox()
        Me.lblPName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.txtDiscount = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPayment2 = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockQtyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentMethodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrinterSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnAddStockQty = New System.Windows.Forms.Button()
        Me.btnNewTrans = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New Guna.UI.WinForms.GunaButton()
        Me.btnDiscount = New Guna.UI.WinForms.GunaButton()
        Me.btnRemove = New Guna.UI.WinForms.GunaButton()
        Me.btnPayment = New Guna.UI.WinForms.GunaButton()
        Me.btnPaymentStyle = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDesc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSN = New Guna.UI.WinForms.GunaTextBox()
        Me.txtQ = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.DateTimePicker()
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCashier = New System.Windows.Forms.Label()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 341)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(856, 310)
        Me.TabControl1.TabIndex = 88
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgtemp)
        Me.TabPage1.Controls.Add(Me.txtPayment)
        Me.TabPage1.Controls.Add(Me.txtamt)
        Me.TabPage1.Controls.Add(Me.lblPName)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cmbPayment)
        Me.TabPage1.Controls.Add(Me.txtDiscount)
        Me.TabPage1.Controls.Add(Me.txtPayment2)
        Me.TabPage1.Controls.Add(Me.txtStock)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(848, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ITEM LIST"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.AllowUserToResizeColumns = False
        Me.dgtemp.AllowUserToResizeRows = False
        Me.dgtemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtemp.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgtemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtemp.Location = New System.Drawing.Point(3, 3)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.ReadOnly = True
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(842, 271)
        Me.dgtemp.TabIndex = 83
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(509, 34)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(218, 25)
        Me.txtPayment.TabIndex = 98
        '
        'txtamt
        '
        Me.txtamt.BaseColor = System.Drawing.SystemColors.Control
        Me.txtamt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtamt.BorderSize = 1
        Me.txtamt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamt.FocusedBaseColor = System.Drawing.SystemColors.Control
        Me.txtamt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtamt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtamt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtamt.Location = New System.Drawing.Point(709, 135)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamt.SelectedText = ""
        Me.txtamt.Size = New System.Drawing.Size(159, 27)
        Me.txtamt.TabIndex = 95
        Me.txtamt.Text = "0.00"
        Me.txtamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPName
        '
        Me.lblPName.BackColor = System.Drawing.Color.White
        Me.lblPName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPName.Location = New System.Drawing.Point(169, 29)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(265, 31)
        Me.lblPName.TabIndex = 82
        Me.lblPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(609, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "CASH AMOUNT :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(23, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "PRODUCT NAME  :"
        '
        'cmbPayment
        '
        Me.cmbPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {"Cash", "Debit / Credit Card", "G-cash", "Cheque", "Room Charge", "A/B CBR", "A/R Mngt."})
        Me.cmbPayment.Location = New System.Drawing.Point(563, 75)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(222, 26)
        Me.cmbPayment.TabIndex = 78
        '
        'txtDiscount
        '
        Me.txtDiscount.BaseColor = System.Drawing.SystemColors.Control
        Me.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiscount.BorderSize = 1
        Me.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiscount.FocusedBaseColor = System.Drawing.SystemColors.Control
        Me.txtDiscount.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDiscount.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDiscount.Location = New System.Drawing.Point(563, 339)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiscount.SelectedText = ""
        Me.txtDiscount.Size = New System.Drawing.Size(247, 32)
        Me.txtDiscount.TabIndex = 100
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPayment2
        '
        Me.txtPayment2.Location = New System.Drawing.Point(513, 204)
        Me.txtPayment2.Name = "txtPayment2"
        Me.txtPayment2.Size = New System.Drawing.Size(218, 25)
        Me.txtPayment2.TabIndex = 99
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(522, 65)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 25)
        Me.txtStock.TabIndex = 94
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PrintPreviewControl1)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(848, 277)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECIEPT VIEW"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(3, 3)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(842, 271)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 1.4563636363636363R
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip2.TabIndex = 92
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.CancelToolStripMenuItem, Me.MainFormToolStripMenuItem, Me.AddStockQtyToolStripMenuItem, Me.SearchItemToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.EditItemToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.PaymentMethodToolStripMenuItem, Me.AddDiscountToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RefreshToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_refresh_100
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClearToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ClearToolStripMenuItem1.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_remove_1001
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear / Delete"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CancelToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_close_64
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'MainFormToolStripMenuItem
        '
        Me.MainFormToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MainFormToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MainFormToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_logout_100
        Me.MainFormToolStripMenuItem.Name = "MainFormToolStripMenuItem"
        Me.MainFormToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.MainFormToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MainFormToolStripMenuItem.Text = "Logout"
        '
        'AddStockQtyToolStripMenuItem
        '
        Me.AddStockQtyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.AddStockQtyToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_add_100
        Me.AddStockQtyToolStripMenuItem.Name = "AddStockQtyToolStripMenuItem"
        Me.AddStockQtyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddStockQtyToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AddStockQtyToolStripMenuItem.Text = "Add Stock Qty"
        '
        'SearchItemToolStripMenuItem
        '
        Me.SearchItemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.SearchItemToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_search_501
        Me.SearchItemToolStripMenuItem.Name = "SearchItemToolStripMenuItem"
        Me.SearchItemToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SearchItemToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SearchItemToolStripMenuItem.Text = "Search Item"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.RemoveItemToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_remove_100
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Item"
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.EditItemToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_edit_file_64
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EditItemToolStripMenuItem.Text = "Edit Item"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PaymentToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_payment_64
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'PaymentMethodToolStripMenuItem
        '
        Me.PaymentMethodToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PaymentMethodToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_mts_money_100
        Me.PaymentMethodToolStripMenuItem.Name = "PaymentMethodToolStripMenuItem"
        Me.PaymentMethodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.PaymentMethodToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PaymentMethodToolStripMenuItem.Text = "Payment Method"
        '
        'AddDiscountToolStripMenuItem
        '
        Me.AddDiscountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.AddDiscountToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_voucher_641
        Me.AddDiscountToolStripMenuItem.Name = "AddDiscountToolStripMenuItem"
        Me.AddDiscountToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.AddDiscountToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AddDiscountToolStripMenuItem.Text = "Add Discount"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.PrinterSetupToolStripMenuItem})
        Me.NavigationToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NavigationToolStripMenuItem.Text = "&Navigation"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PrintPreviewToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_delete_receipt_100
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PrintToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_payment_check_64
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrinterSetupToolStripMenuItem
        '
        Me.PrinterSetupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PrinterSetupToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PrinterSetupToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_settings_100
        Me.PrinterSetupToolStripMenuItem.Name = "PrinterSetupToolStripMenuItem"
        Me.PrinterSetupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.PrinterSetupToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrinterSetupToolStripMenuItem.Text = "Printer Setup"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.btnAddStockQty)
        Me.Panel6.Controls.Add(Me.btnNewTrans)
        Me.Panel6.Controls.Add(Me.btnSearch)
        Me.Panel6.Controls.Add(Me.btnLogout)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 653)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1284, 54)
        Me.Panel6.TabIndex = 93
        '
        'btnAddStockQty
        '
        Me.btnAddStockQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStockQty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStockQty.Location = New System.Drawing.Point(595, 4)
        Me.btnAddStockQty.Name = "btnAddStockQty"
        Me.btnAddStockQty.Size = New System.Drawing.Size(202, 42)
        Me.btnAddStockQty.TabIndex = 3
        Me.btnAddStockQty.Text = "[ CTRL + A ] ADD STOCK QTY"
        Me.btnAddStockQty.UseVisualStyleBackColor = True
        '
        'btnNewTrans
        '
        Me.btnNewTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewTrans.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTrans.Location = New System.Drawing.Point(354, 4)
        Me.btnNewTrans.Name = "btnNewTrans"
        Me.btnNewTrans.Size = New System.Drawing.Size(238, 42)
        Me.btnNewTrans.TabIndex = 2
        Me.btnNewTrans.Text = "[ CTRL + N ] NEW TRANSACTION"
        Me.btnNewTrans.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(178, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(174, 42)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "[ CTRL + S ] SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(2, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(174, 42)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "[ CTRL + L ] LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox8.Controls.Add(Me.btnEdit)
        Me.GroupBox8.Controls.Add(Me.btnDiscount)
        Me.GroupBox8.Controls.Add(Me.btnRemove)
        Me.GroupBox8.Controls.Add(Me.btnPayment)
        Me.GroupBox8.Controls.Add(Me.btnPaymentStyle)
        Me.GroupBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(867, 341)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(405, 310)
        Me.GroupBox8.TabIndex = 97
        Me.GroupBox8.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.03!
        Me.btnEdit.BaseColor = System.Drawing.Color.Lavender
        Me.btnEdit.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_edit_file_64
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEdit.Location = New System.Drawing.Point(206, 17)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.Size = New System.Drawing.Size(182, 64)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "[ F5 ] EDIT ITEM"
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDiscount
        '
        Me.btnDiscount.AnimationHoverSpeed = 0.07!
        Me.btnDiscount.AnimationSpeed = 0.03!
        Me.btnDiscount.BaseColor = System.Drawing.Color.Lavender
        Me.btnDiscount.BorderColor = System.Drawing.Color.Black
        Me.btnDiscount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDiscount.FocusedColor = System.Drawing.Color.Empty
        Me.btnDiscount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.ForeColor = System.Drawing.Color.Black
        Me.btnDiscount.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_voucher_64
        Me.btnDiscount.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDiscount.Location = New System.Drawing.Point(20, 227)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDiscount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDiscount.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnDiscount.OnHoverImage = Nothing
        Me.btnDiscount.OnPressedColor = System.Drawing.Color.Black
        Me.btnDiscount.Size = New System.Drawing.Size(368, 64)
        Me.btnDiscount.TabIndex = 1
        Me.btnDiscount.Text = "[ F9 ] ADD DISCOUNT"
        Me.btnDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemove
        '
        Me.btnRemove.AnimationHoverSpeed = 0.07!
        Me.btnRemove.AnimationSpeed = 0.03!
        Me.btnRemove.BaseColor = System.Drawing.Color.Lavender
        Me.btnRemove.BorderColor = System.Drawing.Color.Black
        Me.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRemove.FocusedColor = System.Drawing.Color.Empty
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_remove_100
        Me.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRemove.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRemove.Location = New System.Drawing.Point(20, 17)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRemove.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnRemove.OnHoverImage = Nothing
        Me.btnRemove.OnPressedColor = System.Drawing.Color.Black
        Me.btnRemove.Size = New System.Drawing.Size(182, 64)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "[ F4 ] REMOVE ITEM"
        Me.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPayment
        '
        Me.btnPayment.AnimationHoverSpeed = 0.07!
        Me.btnPayment.AnimationSpeed = 0.03!
        Me.btnPayment.BaseColor = System.Drawing.Color.Lavender
        Me.btnPayment.BorderColor = System.Drawing.Color.Black
        Me.btnPayment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPayment.FocusedColor = System.Drawing.Color.Empty
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Black
        Me.btnPayment.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_mts_money_100
        Me.btnPayment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPayment.Location = New System.Drawing.Point(20, 158)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPayment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPayment.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnPayment.OnHoverImage = Nothing
        Me.btnPayment.OnPressedColor = System.Drawing.Color.Black
        Me.btnPayment.Size = New System.Drawing.Size(368, 64)
        Me.btnPayment.TabIndex = 1
        Me.btnPayment.Text = "[ F8 ] PAYMENT METHOD"
        Me.btnPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPaymentStyle
        '
        Me.btnPaymentStyle.AnimationHoverSpeed = 0.07!
        Me.btnPaymentStyle.AnimationSpeed = 0.03!
        Me.btnPaymentStyle.BaseColor = System.Drawing.Color.Lavender
        Me.btnPaymentStyle.BorderColor = System.Drawing.Color.Black
        Me.btnPaymentStyle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPaymentStyle.FocusedColor = System.Drawing.Color.Empty
        Me.btnPaymentStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaymentStyle.ForeColor = System.Drawing.Color.Black
        Me.btnPaymentStyle.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_payment_641
        Me.btnPaymentStyle.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnPaymentStyle.Location = New System.Drawing.Point(20, 87)
        Me.btnPaymentStyle.Name = "btnPaymentStyle"
        Me.btnPaymentStyle.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPaymentStyle.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPaymentStyle.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnPaymentStyle.OnHoverImage = Nothing
        Me.btnPaymentStyle.OnPressedColor = System.Drawing.Color.Black
        Me.btnPaymentStyle.Size = New System.Drawing.Size(368, 64)
        Me.btnPaymentStyle.TabIndex = 0
        Me.btnPaymentStyle.Text = "[ F7 ] PAYMENT"
        Me.btnPaymentStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblchange)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblVAT)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Location = New System.Drawing.Point(867, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 218)
        Me.Panel2.TabIndex = 98
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(19, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "TOTAL CHANGE"
        '
        'lblchange
        '
        Me.lblchange.BackColor = System.Drawing.Color.SteelBlue
        Me.lblchange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.White
        Me.lblchange.Location = New System.Drawing.Point(159, 139)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(234, 47)
        Me.lblchange.TabIndex = 102
        Me.lblchange.Text = "0.00"
        Me.lblchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(53, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "DISCOUNT"
        '
        'lblVAT
        '
        Me.lblVAT.BackColor = System.Drawing.Color.SteelBlue
        Me.lblVAT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.White
        Me.lblVAT.Location = New System.Drawing.Point(159, 77)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(234, 47)
        Me.lblVAT.TabIndex = 100
        Me.lblVAT.Text = "0.00"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "TOTAL AMOUNT"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(159, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(234, 47)
        Me.lblTotal.TabIndex = 98
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.SteelBlue
        Me.lblDisplay.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(867, 12)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(405, 54)
        Me.lblDisplay.TabIndex = 67
        Me.lblDisplay.Text = "0.00"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lblDisplay)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 81)
        Me.Panel3.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(494, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(251, 45)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "POINT OF SALE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(455, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 45)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "●"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(445, 45)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Domingo's Catering Services"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtDesc)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtSN)
        Me.GroupBox4.Controls.Add(Me.txtQ)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(5, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(585, 122)
        Me.GroupBox4.TabIndex = 102
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item and Qty and Description"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(142, 72)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(411, 31)
        Me.txtDesc.TabIndex = 81
        Me.txtDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(39, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Item Name :"
        '
        'txtSN
        '
        Me.txtSN.BaseColor = System.Drawing.Color.White
        Me.txtSN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSN.BorderSize = 1
        Me.txtSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSN.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSN.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSN.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSN.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSN.Location = New System.Drawing.Point(142, 32)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSN.SelectedText = ""
        Me.txtSN.Size = New System.Drawing.Size(276, 30)
        Me.txtSN.TabIndex = 78
        '
        'txtQ
        '
        Me.txtQ.BaseColor = System.Drawing.Color.White
        Me.txtQ.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtQ.BorderSize = 1
        Me.txtQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQ.FocusedBaseColor = System.Drawing.Color.White
        Me.txtQ.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtQ.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtQ.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtQ.Location = New System.Drawing.Point(471, 34)
        Me.txtQ.Name = "txtQ"
        Me.txtQ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQ.SelectedText = ""
        Me.txtQ.Size = New System.Drawing.Size(82, 30)
        Me.txtQ.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(424, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Qty :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.t1)
        Me.GroupBox2.Controls.Add(Me.d1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(588, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 122)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date and Time "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Time : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Date : "
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.t1.Location = New System.Drawing.Point(84, 73)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(160, 27)
        Me.t1.TabIndex = 72
        '
        'd1
        '
        Me.d1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d1.Location = New System.Drawing.Point(84, 38)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(160, 27)
        Me.d1.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCashier)
        Me.GroupBox1.Controls.Add(Me.lblCashierName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblTrans)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(7, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 95)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cashier Name and Other"
        '
        'txtCashier
        '
        Me.txtCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashier.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashier.ForeColor = System.Drawing.Color.Black
        Me.txtCashier.Location = New System.Drawing.Point(164, 42)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(155, 38)
        Me.txtCashier.TabIndex = 76
        Me.txtCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashierName.ForeColor = System.Drawing.Color.Black
        Me.lblCashierName.Location = New System.Drawing.Point(47, 51)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(111, 17)
        Me.lblCashierName.TabIndex = 54
        Me.lblCashierName.Text = "CASHIER NAME :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(327, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 17)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "TRANSACTION NUMBER :"
        '
        'lblTrans
        '
        Me.lblTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrans.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrans.ForeColor = System.Drawing.Color.Black
        Me.lblTrans.Location = New System.Drawing.Point(498, 42)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(314, 37)
        Me.lblTrans.TabIndex = 77
        Me.lblTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1284, 707)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents Label12 As System.Windows.Forms.Label

    Private Sub grpDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtamt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPName As System.Windows.Forms.Label
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrinterSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmbPayment As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiscount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDiscount As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnRemove As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtPayment2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPaymentStyle As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPayment As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSN As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtQ As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents d1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCashier As System.Windows.Forms.Label
    Friend WithEvents lblCashierName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTrans As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNewTrans As System.Windows.Forms.Button
    Friend WithEvents btnAddStockQty As System.Windows.Forms.Button
    Friend WithEvents AddStockQtyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentMethodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDiscountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
