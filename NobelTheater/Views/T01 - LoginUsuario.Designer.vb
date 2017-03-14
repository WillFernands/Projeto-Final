<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginUsuario
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserTF As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTF As System.Windows.Forms.TextBox
    Friend WithEvents LogarBT As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserTF = New System.Windows.Forms.TextBox()
        Me.PasswordTF = New System.Windows.Forms.TextBox()
        Me.LogarBT = New System.Windows.Forms.Button()
        Me.AlterarSenhaLL = New System.Windows.Forms.LinkLabel()
        Me.EsqueciSenhaLL = New System.Windows.Forms.LinkLabel()
        Me.SaidaRB = New System.Windows.Forms.RadioButton()
        Me.EntradaRB = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RegistrarPontoBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.NobelTheater.My.Resources.Resources.Nobel_Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(73, 5)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(215, 104)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 119)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(63, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Matrícula:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 162)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(63, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Senha:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserTF
        '
        Me.UserTF.Location = New System.Drawing.Point(73, 121)
        Me.UserTF.Name = "UserTF"
        Me.UserTF.Size = New System.Drawing.Size(253, 20)
        Me.UserTF.TabIndex = 1
        '
        'PasswordTF
        '
        Me.PasswordTF.Location = New System.Drawing.Point(73, 162)
        Me.PasswordTF.Name = "PasswordTF"
        Me.PasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTF.Size = New System.Drawing.Size(253, 20)
        Me.PasswordTF.TabIndex = 3
        '
        'LogarBT
        '
        Me.LogarBT.Location = New System.Drawing.Point(133, 306)
        Me.LogarBT.Name = "LogarBT"
        Me.LogarBT.Size = New System.Drawing.Size(94, 23)
        Me.LogarBT.TabIndex = 4
        Me.LogarBT.Text = "Logar"
        '
        'AlterarSenhaLL
        '
        Me.AlterarSenhaLL.AutoSize = True
        Me.AlterarSenhaLL.Location = New System.Drawing.Point(93, 203)
        Me.AlterarSenhaLL.Name = "AlterarSenhaLL"
        Me.AlterarSenhaLL.Size = New System.Drawing.Size(71, 13)
        Me.AlterarSenhaLL.TabIndex = 6
        Me.AlterarSenhaLL.TabStop = True
        Me.AlterarSenhaLL.Text = "Alterar Senha"
        '
        'EsqueciSenhaLL
        '
        Me.EsqueciSenhaLL.AutoSize = True
        Me.EsqueciSenhaLL.Location = New System.Drawing.Point(181, 203)
        Me.EsqueciSenhaLL.Name = "EsqueciSenhaLL"
        Me.EsqueciSenhaLL.Size = New System.Drawing.Size(88, 13)
        Me.EsqueciSenhaLL.TabIndex = 7
        Me.EsqueciSenhaLL.TabStop = True
        Me.EsqueciSenhaLL.Text = "Esqueci a Senha"
        '
        'SaidaRB
        '
        Me.SaidaRB.AutoSize = True
        Me.SaidaRB.Location = New System.Drawing.Point(88, 20)
        Me.SaidaRB.Name = "SaidaRB"
        Me.SaidaRB.Size = New System.Drawing.Size(54, 17)
        Me.SaidaRB.TabIndex = 8
        Me.SaidaRB.Text = "Saída"
        Me.SaidaRB.UseVisualStyleBackColor = True
        '
        'EntradaRB
        '
        Me.EntradaRB.AutoSize = True
        Me.EntradaRB.Checked = True
        Me.EntradaRB.Location = New System.Drawing.Point(13, 20)
        Me.EntradaRB.Name = "EntradaRB"
        Me.EntradaRB.Size = New System.Drawing.Size(62, 17)
        Me.EntradaRB.TabIndex = 9
        Me.EntradaRB.TabStop = True
        Me.EntradaRB.Text = "Entrada"
        Me.EntradaRB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RegistrarPontoBT)
        Me.GroupBox1.Controls.Add(Me.EntradaRB)
        Me.GroupBox1.Controls.Add(Me.SaidaRB)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 49)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de Ponto"
        '
        'RegistrarPontoBT
        '
        Me.RegistrarPontoBT.Location = New System.Drawing.Point(179, 17)
        Me.RegistrarPontoBT.Name = "RegistrarPontoBT"
        Me.RegistrarPontoBT.Size = New System.Drawing.Size(94, 23)
        Me.RegistrarPontoBT.TabIndex = 13
        Me.RegistrarPontoBT.Text = "Registrar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Versão 0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nobel HOME 2016-2017 © - Todos os direitos reservados "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LoginUsuario
        '
        Me.AcceptButton = Me.LogarBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 385)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EsqueciSenhaLL)
        Me.Controls.Add(Me.AlterarSenhaLL)
        Me.Controls.Add(Me.LogarBT)
        Me.Controls.Add(Me.PasswordTF)
        Me.Controls.Add(Me.UserTF)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginUsuario"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login de Usuário e Registro de Ponto"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlterarSenhaLL As System.Windows.Forms.LinkLabel
    Friend WithEvents EsqueciSenhaLL As System.Windows.Forms.LinkLabel
    Friend WithEvents SaidaRB As System.Windows.Forms.RadioButton
    Friend WithEvents EntradaRB As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RegistrarPontoBT As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
