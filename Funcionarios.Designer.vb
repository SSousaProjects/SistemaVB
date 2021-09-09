<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Funcionarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarNome = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbTurno = New System.Windows.Forms.ComboBox()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.txtContato = New System.Windows.Forms.MaskedTextBox()
        Me.txtCC = New System.Windows.Forms.MaskedTextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAtualiar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbCC = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCCidadao = New System.Windows.Forms.MaskedTextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesquisar:"
        '
        'txtBuscarNome
        '
        Me.txtBuscarNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscarNome.Location = New System.Drawing.Point(171, 7)
        Me.txtBuscarNome.Name = "txtBuscarNome"
        Me.txtBuscarNome.Size = New System.Drawing.Size(187, 22)
        Me.txtBuscarNome.TabIndex = 21
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(103, 83)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(255, 22)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(602, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cartão Cidadão:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(715, 122)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(120, 22)
        Me.txtEmail.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(642, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Contato:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(103, 122)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(255, 22)
        Me.txtEndereco.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Endereço:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(398, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Data :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Turno:"
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(455, 81)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(120, 24)
        Me.cbSexo.TabIndex = 2
        '
        'cbTurno
        '
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.Items.AddRange(New Object() {"Manhã - entre as xx as yy horas", "Tarde - entre as xx as yy horas", "Noite - entre as xx as yy horas", "Madrugada - entre as xx as yy horas"})
        Me.cbTurno.Location = New System.Drawing.Point(103, 163)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(255, 24)
        Me.cbTurno.TabIndex = 7
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(455, 165)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(120, 22)
        Me.dtData.TabIndex = 8
        '
        'txtContato
        '
        Me.txtContato.Location = New System.Drawing.Point(455, 122)
        Me.txtContato.Mask = "000000000"
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(120, 22)
        Me.txtContato.TabIndex = 5
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(715, 81)
        Me.txtCC.Mask = "00000000"
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(120, 22)
        Me.txtCC.TabIndex = 3
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(35, 203)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersWidth = 51
        Me.dg.RowTemplate.Height = 24
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(800, 150)
        Me.dg.TabIndex = 23
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.LightCyan
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNovo.Location = New System.Drawing.Point(35, 393)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 33)
        Me.btnNovo.TabIndex = 9
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightCyan
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(215, 393)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnAtualiar
        '
        Me.btnAtualiar.BackColor = System.Drawing.Color.LightCyan
        Me.btnAtualiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtualiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAtualiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnAtualiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnAtualiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualiar.Location = New System.Drawing.Point(575, 393)
        Me.btnAtualiar.Name = "btnAtualiar"
        Me.btnAtualiar.Size = New System.Drawing.Size(75, 33)
        Me.btnAtualiar.TabIndex = 11
        Me.btnAtualiar.Text = "Atualizar"
        Me.btnAtualiar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.LightCyan
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(755, 393)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 33)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(99, 8)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(66, 21)
        Me.rbNome.TabIndex = 24
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCC
        '
        Me.rbCC.AutoSize = True
        Me.rbCC.Location = New System.Drawing.Point(99, 44)
        Me.rbCC.Name = "rbCC"
        Me.rbCC.Size = New System.Drawing.Size(127, 21)
        Me.rbCC.TabIndex = 25
        Me.rbCC.TabStop = True
        Me.rbCC.Text = "Cartão Cidadão"
        Me.rbCC.UseVisualStyleBackColor = True
        '
        'txtBuscarCCidadao
        '
        Me.txtBuscarCCidadao.Location = New System.Drawing.Point(225, 43)
        Me.txtBuscarCCidadao.Mask = "00000000"
        Me.txtBuscarCCidadao.Name = "txtBuscarCCidadao"
        Me.txtBuscarCCidadao.Size = New System.Drawing.Size(133, 22)
        Me.txtBuscarCCidadao.TabIndex = 26
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(759, 362)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(40, 17)
        Me.lbl.TabIndex = 27
        Me.lbl.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(809, 362)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 17)
        Me.lblTotal.TabIndex = 28
        Me.lblTotal.Text = "-"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.LightCyan
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(395, 393)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 33)
        Me.btnEditar.TabIndex = 29
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(893, 444)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtBuscarCCidadao)
        Me.Controls.Add(Me.rbCC)
        Me.Controls.Add(Me.rbNome)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAtualiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.txtContato)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.cbTurno)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscarNome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscarNome As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents cbTurno As ComboBox
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents txtContato As MaskedTextBox
    Friend WithEvents txtCC As MaskedTextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAtualiar As Button
    Friend WithEvents btnExcluir As Button

    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbCC As RadioButton
    Friend WithEvents txtBuscarCCidadao As MaskedTextBox
    Friend WithEvents lbl As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnEditar As Button
End Class
