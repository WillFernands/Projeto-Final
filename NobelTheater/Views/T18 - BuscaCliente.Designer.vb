<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaCliente
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PFRB = New System.Windows.Forms.RadioButton()
        Me.PJRB = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(23, 92)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(355, 212)
        Me.ListBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 20)
        Me.TextBox1.TabIndex = 6
        '
        'PFRB
        '
        Me.PFRB.AutoSize = True
        Me.PFRB.Checked = True
        Me.PFRB.Location = New System.Drawing.Point(297, 57)
        Me.PFRB.Name = "PFRB"
        Me.PFRB.Size = New System.Drawing.Size(38, 17)
        Me.PFRB.TabIndex = 8
        Me.PFRB.TabStop = True
        Me.PFRB.Text = "PF"
        Me.PFRB.UseVisualStyleBackColor = True
        '
        'PJRB
        '
        Me.PJRB.AutoSize = True
        Me.PJRB.Location = New System.Drawing.Point(341, 58)
        Me.PJRB.Name = "PJRB"
        Me.PJRB.Size = New System.Drawing.Size(37, 17)
        Me.PJRB.TabIndex = 9
        Me.PJRB.Text = "PJ"
        Me.PJRB.UseVisualStyleBackColor = True
        '
        'BuscaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 335)
        Me.Controls.Add(Me.PJRB)
        Me.Controls.Add(Me.PFRB)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "BuscaCliente"
        Me.Text = "BuscaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PFRB As RadioButton
    Friend WithEvents PJRB As RadioButton
End Class
