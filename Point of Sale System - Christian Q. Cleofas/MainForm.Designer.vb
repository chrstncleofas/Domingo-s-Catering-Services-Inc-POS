<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.dtTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoginAs = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStock = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnReport = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnCashier = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnNewUser = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTime
        '
        Me.dtTime.BorderRadius = 1
        Me.dtTime.BorderThickness = 1
        Me.dtTime.CheckedState.Parent = Me.dtTime
        Me.dtTime.FillColor = System.Drawing.Color.White
        Me.dtTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTime.ForeColor = System.Drawing.Color.Black
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtTime.HoverState.Parent = Me.dtTime
        Me.dtTime.Location = New System.Drawing.Point(320, 191)
        Me.dtTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.ShadowDecoration.Parent = Me.dtTime
        Me.dtTime.Size = New System.Drawing.Size(206, 23)
        Me.dtTime.TabIndex = 33
        Me.dtTime.Value = New Date(2021, 5, 15, 20, 7, 31, 573)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(187, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 80)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "               POINT OF SALE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Domingo's Catering Services Inc."
        '
        'lblLoginAs
        '
        Me.lblLoginAs.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginAs.ForeColor = System.Drawing.Color.Black
        Me.lblLoginAs.Location = New System.Drawing.Point(267, 132)
        Me.lblLoginAs.Name = "lblLoginAs"
        Me.lblLoginAs.Size = New System.Drawing.Size(318, 48)
        Me.lblLoginAs.TabIndex = 32
        Me.lblLoginAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashierToolStripMenuItem1, Me.NewUserToolStripMenuItem1, Me.InventoryToolStripMenuItem1, Me.LogoutUserToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CashierToolStripMenuItem1
        '
        Me.CashierToolStripMenuItem1.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_cashier_60
        Me.CashierToolStripMenuItem1.Name = "CashierToolStripMenuItem1"
        Me.CashierToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CashierToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.CashierToolStripMenuItem1.Text = "Cashier"
        '
        'NewUserToolStripMenuItem1
        '
        Me.NewUserToolStripMenuItem1.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_add_user_male_100
        Me.NewUserToolStripMenuItem1.Name = "NewUserToolStripMenuItem1"
        Me.NewUserToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewUserToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.NewUserToolStripMenuItem1.Text = "New User"
        '
        'InventoryToolStripMenuItem1
        '
        Me.InventoryToolStripMenuItem1.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_new_product_1002
        Me.InventoryToolStripMenuItem1.Name = "InventoryToolStripMenuItem1"
        Me.InventoryToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.InventoryToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.InventoryToolStripMenuItem1.Text = "Inventory"
        '
        'LogoutUserToolStripMenuItem
        '
        Me.LogoutUserToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_logout_100__1_
        Me.LogoutUserToolStripMenuItem.Name = "LogoutUserToolStripMenuItem"
        Me.LogoutUserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.LogoutUserToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LogoutUserToolStripMenuItem.Text = "Logout / Exit"
        '
        'ReportViewToolStripMenuItem
        '
        Me.ReportViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportToolStripMenuItem})
        Me.ReportViewToolStripMenuItem.Name = "ReportViewToolStripMenuItem"
        Me.ReportViewToolStripMenuItem.ShortcutKeyDisplayString = "Escape"
        Me.ReportViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ReportViewToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportViewToolStripMenuItem.Text = "Report"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_report_641
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'btnStock
        '
        Me.btnStock.AnimationHoverSpeed = 0.07!
        Me.btnStock.AnimationSpeed = 0.03!
        Me.btnStock.BaseColor = System.Drawing.Color.Lavender
        Me.btnStock.BorderColor = System.Drawing.Color.Black
        Me.btnStock.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnStock.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStock.CheckedForeColor = System.Drawing.Color.White
        Me.btnStock.CheckedImage = CType(resources.GetObject("btnStock.CheckedImage"), System.Drawing.Image)
        Me.btnStock.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStock.FocusedColor = System.Drawing.Color.Empty
        Me.btnStock.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.Black
        Me.btnStock.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_new_product_1003
        Me.btnStock.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnStock.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStock.Location = New System.Drawing.Point(625, 259)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnStock.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStock.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnStock.OnHoverImage = Nothing
        Me.btnStock.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStock.OnPressedColor = System.Drawing.Color.Black
        Me.btnStock.Size = New System.Drawing.Size(192, 158)
        Me.btnStock.TabIndex = 37
        Me.btnStock.Text = "Inventory"
        '
        'btnReport
        '
        Me.btnReport.AnimationHoverSpeed = 0.07!
        Me.btnReport.AnimationSpeed = 0.03!
        Me.btnReport.BaseColor = System.Drawing.Color.Lavender
        Me.btnReport.BorderColor = System.Drawing.Color.Black
        Me.btnReport.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnReport.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnReport.CheckedForeColor = System.Drawing.Color.White
        Me.btnReport.CheckedImage = CType(resources.GetObject("btnReport.CheckedImage"), System.Drawing.Image)
        Me.btnReport.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReport.FocusedColor = System.Drawing.Color.Empty
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_report_64
        Me.btnReport.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnReport.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReport.Location = New System.Drawing.Point(427, 259)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnReport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReport.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnReport.OnHoverImage = Nothing
        Me.btnReport.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnReport.OnPressedColor = System.Drawing.Color.Black
        Me.btnReport.Size = New System.Drawing.Size(192, 158)
        Me.btnReport.TabIndex = 36
        Me.btnReport.Text = "Report"
        '
        'btnCashier
        '
        Me.btnCashier.AnimationHoverSpeed = 0.07!
        Me.btnCashier.AnimationSpeed = 0.03!
        Me.btnCashier.BaseColor = System.Drawing.Color.Lavender
        Me.btnCashier.BorderColor = System.Drawing.Color.Black
        Me.btnCashier.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCashier.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCashier.CheckedForeColor = System.Drawing.Color.White
        Me.btnCashier.CheckedImage = CType(resources.GetObject("btnCashier.CheckedImage"), System.Drawing.Image)
        Me.btnCashier.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCashier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCashier.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCashier.FocusedColor = System.Drawing.Color.Empty
        Me.btnCashier.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashier.ForeColor = System.Drawing.Color.Black
        Me.btnCashier.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_cashier_601
        Me.btnCashier.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnCashier.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCashier.Location = New System.Drawing.Point(229, 259)
        Me.btnCashier.Name = "btnCashier"
        Me.btnCashier.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnCashier.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCashier.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnCashier.OnHoverImage = Nothing
        Me.btnCashier.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCashier.OnPressedColor = System.Drawing.Color.Black
        Me.btnCashier.Size = New System.Drawing.Size(192, 158)
        Me.btnCashier.TabIndex = 35
        Me.btnCashier.Text = "Cashier"
        '
        'btnNewUser
        '
        Me.btnNewUser.AnimationHoverSpeed = 0.07!
        Me.btnNewUser.AnimationSpeed = 0.03!
        Me.btnNewUser.BaseColor = System.Drawing.Color.Lavender
        Me.btnNewUser.BorderColor = System.Drawing.Color.Black
        Me.btnNewUser.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnNewUser.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNewUser.CheckedForeColor = System.Drawing.Color.White
        Me.btnNewUser.CheckedImage = CType(resources.GetObject("btnNewUser.CheckedImage"), System.Drawing.Image)
        Me.btnNewUser.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewUser.FocusedColor = System.Drawing.Color.Empty
        Me.btnNewUser.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.ForeColor = System.Drawing.Color.Black
        Me.btnNewUser.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_add_user_male_1001
        Me.btnNewUser.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnNewUser.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNewUser.Location = New System.Drawing.Point(31, 259)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnNewUser.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNewUser.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnNewUser.OnHoverImage = Nothing
        Me.btnNewUser.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNewUser.OnPressedColor = System.Drawing.Color.Black
        Me.btnNewUser.Size = New System.Drawing.Size(192, 158)
        Me.btnNewUser.TabIndex = 34
        Me.btnNewUser.Text = "New User"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(844, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnCashier)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dtTime)
        Me.Controls.Add(Me.lblLoginAs)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLoginAs As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNewUser As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnCashier As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnReport As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnStock As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
