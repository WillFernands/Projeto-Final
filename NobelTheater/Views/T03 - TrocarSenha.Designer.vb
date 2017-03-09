<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrocarSenha
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
        Me.ConfirmarBT = New System.Windows.Forms.Button()
        Me.NewPasswordTF = New System.Windows.Forms.TextBox()
        Me.PasswordTF = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ConfirmarSenhaTF = New System.Windows.Forms.TextBox()
        Me.UserTF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LimparBT = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmarBT
        '
        Me.ConfirmarBT.Location = New System.Drawing.Point(506, 12)
        Me.ConfirmarBT.Name = "ConfirmarBT"
        Me.ConfirmarBT.Size = New System.Drawing.Size(94, 88)
        Me.ConfirmarBT.TabIndex = 18
        Me.ConfirmarBT.Text = "Confirmar"
        '
        'NewPasswordTF
        '
        Me.NewPasswordTF.Location = New System.Drawing.Point(347, 80)
        Me.NewPasswordTF.Name = "NewPasswordTF"
        Me.NewPasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTF.Size = New System.Drawing.Size(148, 20)
        Me.NewPasswordTF.TabIndex = 17
        '
        'PasswordTF
        '
        Me.PasswordTF.Location = New System.Drawing.Point(347, 47)
        Me.PasswordTF.Name = "PasswordTF"
        Me.PasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTF.Size = New System.Drawing.Size(148, 20)
        Me.PasswordTF.TabIndex = 15
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.NobelTheater.My.Resources.Resources.Nobel_Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 17)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(231, 105)
        Me.LogoPictureBox.TabIndex = 14
        Me.LogoPictureBox.TabStop = False
        '
        'ConfirmarSenhaTF
        '
        Me.ConfirmarSenhaTF.Location = New System.Drawing.Point(347, 113)
        Me.ConfirmarSenhaTF.Name = "ConfirmarSenhaTF"
        Me.ConfirmarSenhaTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmarSenhaTF.Size = New System.Drawing.Size(148, 20)
        Me.ConfirmarSenhaTF.TabIndex = 25
        '
        'UserTF
        '
        Me.UserTF.Enabled = False
        Me.UserTF.Location = New System.Drawing.Point(347, 14)
        Me.UserTF.Name = "UserTF"
        Me.UserTF.Size = New System.Drawing.Size(148, 20)
        Me.UserTF.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Confirmar senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nova senha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Senha antiga:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Funcionário:"
        '
        'LimparBT
        '
        Me.LimparBT.Location = New System.Drawing.Point(506, 106)
        Me.LimparBT.Name = "LimparBT"
        Me.LimparBT.Size = New System.Drawing.Size(94, 27)
        Me.LimparBT.TabIndex = 32
        Me.LimparBT.Text = "Limpar"
        '
        'TrocarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 141)
        Me.Controls.Add(Me.LimparBT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserTF)
        Me.Controls.Add(Me.ConfirmarSenhaTF)
        Me.Controls.Add(Me.ConfirmarBT)
        Me.Controls.Add(Me.NewPasswordTF)
        Me.Controls.Add(Me.PasswordTF)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TrocarSenha"
        Me.Text = "Trocar Senha"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmarBT As System.Windows.Forms.Button
    Friend WithEvents NewPasswordTF As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTF As System.Windows.Forms.TextBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ConfirmarSenhaTF As System.Windows.Forms.TextBox
    Friend WithEvents UserTF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LimparBT As Button
End Class
