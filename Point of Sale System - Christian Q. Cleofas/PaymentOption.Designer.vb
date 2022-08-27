<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentOption
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
        Me.chkCash = New Guna.UI.WinForms.GunaCheckBox()
        Me.chkDebit = New Guna.UI.WinForms.GunaCheckBox()
        Me.chkGCash = New Guna.UI.WinForms.GunaCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.chkAR = New Guna.UI.WinForms.GunaCheckBox()
        Me.chkCheque = New Guna.UI.WinForms.GunaCheckBox()
        Me.chkAB = New Guna.UI.WinForms.GunaCheckBox()
        Me.chkRoom = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.btnOk = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkCash
        '
        Me.chkCash.BaseColor = System.Drawing.Color.White
        Me.chkCash.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkCash.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkCash.FillColor = System.Drawing.Color.White
        Me.chkCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCash.Location = New System.Drawing.Point(26, 37)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Size = New System.Drawing.Size(70, 22)
        Me.chkCash.TabIndex = 0
        Me.chkCash.Text = "Cash"
        '
        'chkDebit
        '
        Me.chkDebit.BaseColor = System.Drawing.Color.White
        Me.chkDebit.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkDebit.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkDebit.FillColor = System.Drawing.Color.White
        Me.chkDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDebit.Location = New System.Drawing.Point(159, 35)
        Me.chkDebit.Name = "chkDebit"
        Me.chkDebit.Size = New System.Drawing.Size(167, 22)
        Me.chkDebit.TabIndex = 1
        Me.chkDebit.Text = "Debit / Credit Card"
        '
        'chkGCash
        '
        Me.chkGCash.BaseColor = System.Drawing.Color.White
        Me.chkGCash.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkGCash.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkGCash.FillColor = System.Drawing.Color.White
        Me.chkGCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGCash.Location = New System.Drawing.Point(363, 37)
        Me.chkGCash.Name = "chkGCash"
        Me.chkGCash.Size = New System.Drawing.Size(84, 22)
        Me.chkGCash.TabIndex = 2
        Me.chkGCash.Text = "G-cash"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GunaSeparator2)
        Me.GroupBox1.Controls.Add(Me.GunaSeparator1)
        Me.GroupBox1.Controls.Add(Me.chkAR)
        Me.GroupBox1.Controls.Add(Me.chkCheque)
        Me.GroupBox1.Controls.Add(Me.chkAB)
        Me.GroupBox1.Controls.Add(Me.chkRoom)
        Me.GroupBox1.Controls.Add(Me.GunaVSeparator2)
        Me.GroupBox1.Controls.Add(Me.GunaVSeparator1)
        Me.GroupBox1.Controls.Add(Me.chkCash)
        Me.GroupBox1.Controls.Add(Me.chkGCash)
        Me.GroupBox1.Controls.Add(Me.chkDebit)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 246)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator2.Location = New System.Drawing.Point(6, 162)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(572, 8)
        Me.GunaSeparator2.TabIndex = 10
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator1.Location = New System.Drawing.Point(6, 88)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(572, 8)
        Me.GunaSeparator1.TabIndex = 9
        '
        'chkAR
        '
        Me.chkAR.BaseColor = System.Drawing.Color.White
        Me.chkAR.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkAR.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAR.FillColor = System.Drawing.Color.White
        Me.chkAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAR.Location = New System.Drawing.Point(159, 196)
        Me.chkAR.Name = "chkAR"
        Me.chkAR.Size = New System.Drawing.Size(112, 22)
        Me.chkAR.TabIndex = 8
        Me.chkAR.Text = "A/R MNGT"
        '
        'chkCheque
        '
        Me.chkCheque.BaseColor = System.Drawing.Color.White
        Me.chkCheque.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkCheque.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkCheque.FillColor = System.Drawing.Color.White
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.Location = New System.Drawing.Point(26, 119)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(89, 22)
        Me.chkCheque.TabIndex = 5
        Me.chkCheque.Text = "Cheque"
        '
        'chkAB
        '
        Me.chkAB.BaseColor = System.Drawing.Color.White
        Me.chkAB.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkAB.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAB.FillColor = System.Drawing.Color.White
        Me.chkAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAB.Location = New System.Drawing.Point(363, 119)
        Me.chkAB.Name = "chkAB"
        Me.chkAB.Size = New System.Drawing.Size(97, 22)
        Me.chkAB.TabIndex = 7
        Me.chkAB.Text = "A/B CBR"
        '
        'chkRoom
        '
        Me.chkRoom.BaseColor = System.Drawing.Color.White
        Me.chkRoom.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkRoom.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkRoom.FillColor = System.Drawing.Color.White
        Me.chkRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoom.Location = New System.Drawing.Point(159, 117)
        Me.chkRoom.Name = "chkRoom"
        Me.chkRoom.Size = New System.Drawing.Size(134, 22)
        Me.chkRoom.TabIndex = 6
        Me.chkRoom.Text = "Room Charge"
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.Black
        Me.GunaVSeparator2.Location = New System.Drawing.Point(332, 17)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(8, 293)
        Me.GunaVSeparator2.TabIndex = 4
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.Black
        Me.GunaVSeparator1.Location = New System.Drawing.Point(134, 17)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(8, 293)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.AnimationHoverSpeed = 0.07!
        Me.btnOk.AnimationSpeed = 0.03!
        Me.btnOk.BaseColor = System.Drawing.Color.Lavender
        Me.btnOk.BorderColor = System.Drawing.Color.Black
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOk.FocusedColor = System.Drawing.Color.Empty
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Image = Nothing
        Me.btnOk.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnOk.Location = New System.Drawing.Point(23, 277)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnOk.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOk.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnOk.OnHoverImage = Nothing
        Me.btnOk.OnPressedColor = System.Drawing.Color.Black
        Me.btnOk.Size = New System.Drawing.Size(477, 64)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Ok"
        Me.btnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PaymentOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(520, 365)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PaymentOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkCash As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents chkDebit As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents chkGCash As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents chkCheque As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents chkAB As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents chkRoom As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents chkAR As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnOk As Guna.UI.WinForms.GunaButton
End Class
