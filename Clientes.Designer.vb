<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtBuscarCCidadao = New System.Windows.Forms.MaskedTextBox()
        Me.rbCC = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAtualiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtCC = New System.Windows.Forms.MaskedTextBox()
        Me.txtContato = New System.Windows.Forms.MaskedTextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(395, 393)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 33)
        Me.btnEditar.TabIndex = 58
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(809, 362)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 17)
        Me.lblTotal.TabIndex = 57
        Me.lblTotal.Text = "-"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(759, 362)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(40, 17)
        Me.lbl.TabIndex = 56
        Me.lbl.Text = "Total"
        '
        'txtBuscarCCidadao
        '
        Me.txtBuscarCCidadao.Location = New System.Drawing.Point(225, 43)
        Me.txtBuscarCCidadao.Mask = "00000000"
        Me.txtBuscarCCidadao.Name = "txtBuscarCCidadao"
        Me.txtBuscarCCidadao.Size = New System.Drawing.Size(133, 22)
        Me.txtBuscarCCidadao.TabIndex = 55
        '
        'rbCC
        '
        Me.rbCC.AutoSize = True
        Me.rbCC.Location = New System.Drawing.Point(99, 44)
        Me.rbCC.Name = "rbCC"
        Me.rbCC.Size = New System.Drawing.Size(127, 21)
        Me.rbCC.TabIndex = 54
        Me.rbCC.TabStop = True
        Me.rbCC.Text = "Cartão Cidadão"
        Me.rbCC.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(99, 8)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(66, 21)
        Me.rbNome.TabIndex = 53
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.White
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(755, 393)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 33)
        Me.btnExcluir.TabIndex = 47
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAtualiar
        '
        Me.btnAtualiar.BackColor = System.Drawing.Color.White
        Me.btnAtualiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtualiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAtualiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnAtualiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnAtualiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualiar.Location = New System.Drawing.Point(575, 393)
        Me.btnAtualiar.Name = "btnAtualiar"
        Me.btnAtualiar.Size = New System.Drawing.Size(75, 33)
        Me.btnAtualiar.TabIndex = 46
        Me.btnAtualiar.Text = "Atualizar"
        Me.btnAtualiar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(215, 393)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar.TabIndex = 44
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.White
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNovo.Location = New System.Drawing.Point(35, 393)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 33)
        Me.btnNovo.TabIndex = 43
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
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
        Me.dg.TabIndex = 52
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(715, 125)
        Me.txtCC.Mask = "00000000"
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(120, 22)
        Me.txtCC.TabIndex = 34
        '
        'txtContato
        '
        Me.txtContato.Location = New System.Drawing.Point(455, 166)
        Me.txtContato.Mask = "000000000"
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(120, 22)
        Me.txtContato.TabIndex = 37
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(455, 125)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(120, 24)
        Me.cbSexo.TabIndex = 33
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(715, 166)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(120, 22)
        Me.txtEmail.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(642, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Contato:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(103, 166)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(255, 22)
        Me.txtEndereco.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(602, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Cartão Cidadão:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Sexo:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(103, 127)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(255, 22)
        Me.txtNome.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nome:"
        '
        'txtBuscarNome
        '
        Me.txtBuscarNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscarNome.Location = New System.Drawing.Point(171, 7)
        Me.txtBuscarNome.Name = "txtBuscarNome"
        Me.txtBuscarNome.Size = New System.Drawing.Size(187, 22)
        Me.txtBuscarNome.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Pesquisar:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(897, 448)
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
        Me.Controls.Add(Me.cbSexo)
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
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lbl As Label
    Friend WithEvents txtBuscarCCidadao As MaskedTextBox
    Friend WithEvents rbCC As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAtualiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtCC As MaskedTextBox
    Friend WithEvents txtContato As MaskedTextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscarNome As TextBox
    Friend WithEvents Label1 As Label
End Class
