<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarSenha
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
        Me.PasswordTF = New System.Windows.Forms.TextBox()
        Me.PasswordNewTF = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordNewTF = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserTF = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ConfirmarBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PasswordTF
        '
        Me.PasswordTF.Location = New System.Drawing.Point(161, 104)
        Me.PasswordTF.Name = "PasswordTF"
        Me.PasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTF.Size = New System.Drawing.Size(255, 20)
        Me.PasswordTF.TabIndex = 4
        '
        'PasswordNewTF
        '
        Me.PasswordNewTF.Location = New System.Drawing.Point(161, 159)
        Me.PasswordNewTF.Name = "PasswordNewTF"
        Me.PasswordNewTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordNewTF.Size = New System.Drawing.Size(255, 20)
        Me.PasswordNewTF.TabIndex = 5
        '
        'ConfirmPasswordNewTF
        '
        Me.ConfirmPasswordNewTF.Location = New System.Drawing.Point(161, 213)
        Me.ConfirmPasswordNewTF.Name = "ConfirmPasswordNewTF"
        Me.ConfirmPasswordNewTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordNewTF.Size = New System.Drawing.Size(255, 20)
        Me.ConfirmPasswordNewTF.TabIndex = 6
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 102)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 7
        Me.PasswordLabel.Text = "Senha Atual:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Confirme a Nova Senha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nova Senha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserTF
        '
        Me.UserTF.Enabled = False
        Me.UserTF.Location = New System.Drawing.Point(161, 49)
        Me.UserTF.Name = "UserTF"
        Me.UserTF.Size = New System.Drawing.Size(255, 20)
        Me.UserTF.TabIndex = 11
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 47)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 10
        Me.UsernameLabel.Text = "Matrícula"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConfirmarBT
        '
        Me.ConfirmarBT.Location = New System.Drawing.Point(161, 261)
        Me.ConfirmarBT.Name = "ConfirmarBT"
        Me.ConfirmarBT.Size = New System.Drawing.Size(120, 23)
        Me.ConfirmarBT.TabIndex = 12
        Me.ConfirmarBT.Text = "Confirmar Alteração"
        '
        'AlterarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 296)
        Me.Controls.Add(Me.ConfirmarBT)
        Me.Controls.Add(Me.UserTF)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.ConfirmPasswordNewTF)
        Me.Controls.Add(Me.PasswordNewTF)
        Me.Controls.Add(Me.PasswordTF)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AlterarSenha"
        Me.Text = "AlterarSenha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordTF As TextBox
    Friend WithEvents PasswordNewTF As TextBox
    Friend WithEvents ConfirmPasswordNewTF As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserTF As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents ConfirmarBT As Button
End Class
