<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerSalarios
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
        Me.SalariosDT = New System.Windows.Forms.DataGridView()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioNovoTF = New System.Windows.Forms.TextBox()
        Me.SalarioNovoFuncionarioLB = New System.Windows.Forms.Label()
        Me.MotivoTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdicionarSalarioIMG = New System.Windows.Forms.PictureBox()
        Me.SalvarSalariosBT = New System.Windows.Forms.Button()
        CType(Me.SalariosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdicionarSalarioIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalariosDT
        '
        Me.SalariosDT.AllowUserToAddRows = False
        Me.SalariosDT.AllowUserToDeleteRows = False
        Me.SalariosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SalariosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalariosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Motivo, Me.DataGridViewTextBoxColumn1, Me.Descricao, Me.DataGridViewTextBoxColumn3})
        Me.SalariosDT.Location = New System.Drawing.Point(4, 38)
        Me.SalariosDT.Name = "SalariosDT"
        Me.SalariosDT.ReadOnly = True
        Me.SalariosDT.RowHeadersVisible = False
        Me.SalariosDT.Size = New System.Drawing.Size(661, 238)
        Me.SalariosDT.TabIndex = 10
        '
        'Motivo
        '
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        Me.Motivo.Width = 300
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Descricao
        '
        Me.Descricao.HeaderText = "Inicio"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fim"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'SalarioNovoTF
        '
        Me.SalarioNovoTF.Location = New System.Drawing.Point(83, 12)
        Me.SalarioNovoTF.Name = "SalarioNovoTF"
        Me.SalarioNovoTF.Size = New System.Drawing.Size(126, 20)
        Me.SalarioNovoTF.TabIndex = 15
        '
        'SalarioNovoFuncionarioLB
        '
        Me.SalarioNovoFuncionarioLB.AutoSize = True
        Me.SalarioNovoFuncionarioLB.Location = New System.Drawing.Point(8, 15)
        Me.SalarioNovoFuncionarioLB.Name = "SalarioNovoFuncionarioLB"
        Me.SalarioNovoFuncionarioLB.Size = New System.Drawing.Size(69, 13)
        Me.SalarioNovoFuncionarioLB.TabIndex = 14
        Me.SalarioNovoFuncionarioLB.Text = "Novo salário:"
        '
        'MotivoTF
        '
        Me.MotivoTF.Location = New System.Drawing.Point(345, 12)
        Me.MotivoTF.Name = "MotivoTF"
        Me.MotivoTF.Size = New System.Drawing.Size(287, 20)
        Me.MotivoTF.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Motivo da atualização:"
        '
        'AdicionarSalarioIMG
        '
        Me.AdicionarSalarioIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdicionarSalarioIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.AdicionarSalarioIMG.Location = New System.Drawing.Point(638, 12)
        Me.AdicionarSalarioIMG.Name = "AdicionarSalarioIMG"
        Me.AdicionarSalarioIMG.Size = New System.Drawing.Size(27, 20)
        Me.AdicionarSalarioIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdicionarSalarioIMG.TabIndex = 18
        Me.AdicionarSalarioIMG.TabStop = False
        '
        'SalvarSalariosBT
        '
        Me.SalvarSalariosBT.Location = New System.Drawing.Point(278, 286)
        Me.SalvarSalariosBT.Name = "SalvarSalariosBT"
        Me.SalvarSalariosBT.Size = New System.Drawing.Size(112, 23)
        Me.SalvarSalariosBT.TabIndex = 19
        Me.SalvarSalariosBT.Text = "Salvar Alterações"
        Me.SalvarSalariosBT.UseVisualStyleBackColor = True
        '
        'VerSalarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 321)
        Me.Controls.Add(Me.SalvarSalariosBT)
        Me.Controls.Add(Me.AdicionarSalarioIMG)
        Me.Controls.Add(Me.MotivoTF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SalarioNovoTF)
        Me.Controls.Add(Me.SalarioNovoFuncionarioLB)
        Me.Controls.Add(Me.SalariosDT)
        Me.Name = "VerSalarios"
        Me.Text = "VerSalarios"
        CType(Me.SalariosDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdicionarSalarioIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalariosDT As DataGridView
    Friend WithEvents Motivo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SalarioNovoTF As TextBox
    Friend WithEvents SalarioNovoFuncionarioLB As Label
    Friend WithEvents MotivoTF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AdicionarSalarioIMG As PictureBox
    Friend WithEvents SalvarSalariosBT As Button
End Class
