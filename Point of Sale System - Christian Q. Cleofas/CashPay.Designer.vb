<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashPay
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
        Me.txtamt = New Guna.UI.WinForms.GunaTextBox()
        Me.SuspendLayout()
        '
        'txtamt
        '
        Me.txtamt.BackColor = System.Drawing.Color.SlateBlue
        Me.txtamt.BaseColor = System.Drawing.Color.SkyBlue
        Me.txtamt.BorderColor = System.Drawing.Color.SkyBlue
        Me.txtamt.BorderSize = 1
        Me.txtamt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamt.FocusedBaseColor = System.Drawing.Color.SkyBlue
        Me.txtamt.FocusedBorderColor = System.Drawing.Color.SkyBlue
        Me.txtamt.FocusedForeColor = System.Drawing.Color.Black
        Me.txtamt.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.ForeColor = System.Drawing.Color.Black
        Me.txtamt.Location = New System.Drawing.Point(12, 12)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamt.SelectedText = ""
        Me.txtamt.Size = New System.Drawing.Size(413, 79)
        Me.txtamt.TabIndex = 96
        Me.txtamt.Text = "0.00"
        Me.txtamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CashPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(437, 103)
        Me.Controls.Add(Me.txtamt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CashPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Amount"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtamt As Guna.UI.WinForms.GunaTextBox
End Class
