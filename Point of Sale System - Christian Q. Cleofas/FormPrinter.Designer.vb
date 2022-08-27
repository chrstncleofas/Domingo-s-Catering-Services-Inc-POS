<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrinter
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnChoose = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(23, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(408, 57)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnChoose
        '
        Me.btnChoose.AnimationHoverSpeed = 0.07!
        Me.btnChoose.AnimationSpeed = 0.03!
        Me.btnChoose.BackColor = System.Drawing.Color.Transparent
        Me.btnChoose.BaseColor = System.Drawing.Color.White
        Me.btnChoose.BorderColor = System.Drawing.Color.Black
        Me.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChoose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChoose.FocusedColor = System.Drawing.Color.Empty
        Me.btnChoose.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoose.ForeColor = System.Drawing.Color.Black
        Me.btnChoose.Image = Global.Point_of_Sale_System___Christian_Q.Cleofas.My.Resources.Resources.icons8_printer_642
        Me.btnChoose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnChoose.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnChoose.Location = New System.Drawing.Point(23, 79)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.OnHoverBaseColor = System.Drawing.Color.Lavender
        Me.btnChoose.OnHoverBorderColor = System.Drawing.Color.Lavender
        Me.btnChoose.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnChoose.OnHoverImage = Nothing
        Me.btnChoose.OnPressedColor = System.Drawing.Color.Lavender
        Me.btnChoose.Radius = 4
        Me.btnChoose.Size = New System.Drawing.Size(408, 70)
        Me.btnChoose.TabIndex = 3
        Me.btnChoose.Text = "Choose Printer"
        Me.btnChoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(453, 165)
        Me.Controls.Add(Me.btnChoose)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormPrinter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnChoose As Guna.UI.WinForms.GunaButton
End Class
