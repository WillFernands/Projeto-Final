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
        Me.PasswordNewTF = New System.Windows.Forms.TextBox()
        Me.PasswordTF = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ConfirmPasswordNewTF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmarBT
        '
        Me.ConfirmarBT.Location = New System.Drawing.Point(506, 47)
        Me.ConfirmarBT.Name = "ConfirmarBT"
        Me.ConfirmarBT.Size = New System.Drawing.Size(94, 48)
        Me.ConfirmarBT.TabIndex = 18
        Me.ConfirmarBT.Text = "Confirmar"
        '
        'PasswordNewTF
        '
        Me.PasswordNewTF.Location = New System.Drawing.Point(348, 78)
        Me.PasswordNewTF.Name = "PasswordNewTF"
        Me.PasswordNewTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordNewTF.Size = New System.Drawing.Size(148, 20)
        Me.PasswordNewTF.TabIndex = 17
        '
        'PasswordTF
        '
        Me.PasswordTF.Location = New System.Drawing.Point(348, 45)
        Me.PasswordTF.Name = "PasswordTF"
        Me.PasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTF.Size = New System.Drawing.Size(148, 20)
        Me.PasswordTF.TabIndex = 15
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(255, 77)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 16
        Me.PasswordLabel.Text = "Nova Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(255, 43)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 13
        Me.UsernameLabel.Text = "Antiga Senha"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ConfirmPasswordNewTF
        '
        Me.ConfirmPasswordNewTF.Location = New System.Drawing.Point(348, 113)
        Me.ConfirmPasswordNewTF.Name = "ConfirmPasswordNewTF"
        Me.ConfirmPasswordNewTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordNewTF.Size = New System.Drawing.Size(148, 20)
        Me.ConfirmPasswordNewTF.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(255, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Confirmar Senha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserTF
        '
        Me.UserTF.Enabled = False
        Me.UserTF.Location = New System.Drawing.Point(348, 9)
        Me.UserTF.Name = "UserTF"
        Me.UserTF.Size = New System.Drawing.Size(148, 20)
        Me.UserTF.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(255, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Funcionário:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TrocarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 141)
        Me.Controls.Add(Me.UserTF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConfirmPasswordNewTF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmarBT)
        Me.Controls.Add(Me.PasswordNewTF)
        Me.Controls.Add(Me.PasswordTF)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TrocarSenha"
        Me.Text = "Trocar Senha"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmarBT As System.Windows.Forms.Button
    Friend WithEvents PasswordNewTF As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTF As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ConfirmPasswordNewTF As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserTF As TextBox
    Friend WithEvents Label1 As Label
End Class
