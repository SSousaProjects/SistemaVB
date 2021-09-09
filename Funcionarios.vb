Imports System.Data.SqlClient

Public Class Funcionarios


    Private Sub Funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        dtData.Value = Now
        btnGuardar.Enabled = False
        txtBuscarCCidadao.Visible = False
        txtBuscarNome.Visible = False
        rbNome.Checked = True
        Listar()

        btnAtualiar.Enabled = False
        btnExcluir.Enabled = False

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable 'a variável dt cria uma tabela com os campos recebidos pela Base de Dados
        Dim da As SqlDataAdapter 'a variável da passa os dados da tabela para o DataGrid


        Try
            'tudo que for avaliado aqui se der erro vai para o catch para ser tratado como exceçao
            abrir()
            da = New SqlDataAdapter("SELECT * FROM funcionarios", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas() 'metodo criadop para contar as linahs preenchidas




        Catch ex As Exception
            'tudo que foi avaliado e deu erro no try sera avaliado como exceçao
            MessageBox.Show("Erro ao listar" + ex.Message)
            fechar()

        End Try


    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(3).Visible = True

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Sexo"
        dg.Columns(3).HeaderText = "C. Cidadao"
        dg.Columns(4).HeaderText = "Morada"
        dg.Columns(5).HeaderText = "Contato"
        dg.Columns(6).HeaderText = "Email"
        dg.Columns(7).HeaderText = "Turno"
        dg.Columns(8).HeaderText = "Data Contratação"


        dg.Columns(6).Width = 130
        dg.Columns(7).Width = 80




    End Sub

    Private Sub DesabilitarCampos()

        txtNome.Enabled = False
        cbSexo.Enabled = False
        txtCC.Enabled = False
        txtEndereco.Enabled = False
        txtContato.Enabled = False
        txtEmail.Enabled = False
        cbTurno.Enabled = False
        dtData.Enabled = False

    End Sub

    Private Sub HabilitarCampos()

        txtNome.Enabled = True
        cbSexo.Enabled = True
        txtCC.Enabled = True
        txtEndereco.Enabled = True
        txtContato.Enabled = True
        txtEmail.Enabled = True
        cbTurno.Enabled = True
        dtData.Enabled = True
        txtBuscarNome.Enabled = False


    End Sub

    Private Sub LimparCampos()

        txtNome.Text = ""
        cbSexo.Text = ""
        txtCC.Text = ""
        txtEndereco.Text = ""
        txtContato.Text = ""
        txtEmail.Text = ""
        cbTurno.Text = ""
        txtBuscarNome.Text = ""
        dtData.Value = Now



    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        LimparCampos()
        txtBuscarCCidadao.Visible = False
        txtBuscarNome.Visible = False
        btnGuardar.Enabled = True

    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCCidadao.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = True
        txtBuscarCCidadao.Visible = False
        txtBuscarNome.Focus()
    End Sub

    Private Sub rbCC_CheckedChanged(sender As Object, e As EventArgs) Handles rbCC.CheckedChanged
        txtBuscarNome.Text = ""
        txtBuscarCCidadao.Text = ""
        txtBuscarCCidadao.Visible = True
        txtBuscarNome.Visible = False
        txtBuscarCCidadao.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim cmd As SqlCommand

        If txtCC.Text <> "" And txtNome.Text <> "" Then


            Try
                abrir()
                cmd = New SqlCommand("sp_salvarfunc", con)
                cmd.CommandType = CommandType.StoredProcedure 'este comando e necessario para o sistema entender que é do tipo store procedure fazendo a leitura por essa via

                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@cartao_cidadao", txtCC.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txtContato.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@turno", cbTurno.Text)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                LimparCampos()

                btnGuardar.Enabled = False



            Catch ex As Exception
                MessageBox.Show("Erro ao guardar os dados!" + ex.Message)
                fechar()

            End Try
        End If

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualiar.Click
        Dim cmd As SqlCommand

        If txtCC.Text <> "" And txtNome.Text <> "" Then


            Try
                abrir()
                cmd = New SqlCommand("sp_editarfunc", con)
                cmd.CommandType = CommandType.StoredProcedure 'este comando e necessario para o sistema entender que é do tipo store procedure fazendo a leitura por essa via

                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@cartao_cidadao", txtCC.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txtContato.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@turno", cbTurno.Text)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                LimparCampos()
                btnNovo.Enabled = True
                btnEditar.Enabled = True





            Catch ex As Exception
                MessageBox.Show("Erro ao guardar os dados!" + ex.Message)
                fechar()

            End Try
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        'btnEditar.Enabled = True
        'btnExcluir.Enabled = True
        'HabilitarCampos()
        'txtCC.Enabled = False

        'txtNome.Text = dg.CurrentRow.Cells(1).Value
        'cbSexo.Text = dg.CurrentRow.Cells(2).Value
        'txtCC.Text = dg.CurrentRow.Cells(3).Value
        'txtEndereco.Text = dg.CurrentRow.Cells(4).Value
        'txtContato.Text = dg.CurrentRow.Cells(5).Value
        'txtEmail.Text = dg.CurrentRow.Cells(6).Value
        'cbTurno.Text = dg.CurrentRow.Cells(7).Value
        'dtData.Text = dg.CurrentRow.Cells(8).Value



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'botao criado para permitir editar a linha selecionada para depois no botao Atualizar gravar alteraçoes MAIS SEGURO
        btnAtualiar.Enabled = True
        btnExcluir.Enabled = True
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        HabilitarCampos()
        txtCC.Enabled = False

        txtNome.Text = dg.CurrentRow.Cells(1).Value
        cbSexo.Text = dg.CurrentRow.Cells(2).Value
        txtCC.Text = dg.CurrentRow.Cells(3).Value
        txtEndereco.Text = dg.CurrentRow.Cells(4).Value
        txtContato.Text = dg.CurrentRow.Cells(5).Value
        txtEmail.Text = dg.CurrentRow.Cells(6).Value
        cbTurno.Text = dg.CurrentRow.Cells(7).Value
        dtData.Text = dg.CurrentRow.Cells(8).Value

    End Sub

    Private Sub txtBuscarCCidadao_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCCidadao.TextChanged
        If txtBuscarCCidadao.Text = "" And dg.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable 'a variável dt cria uma tabela com os campos recebidos pela Base de Dados
            Dim da As SqlDataAdapter 'a variável da passa os dados da tabela para o DataGrid


            Try
                'tudo que for avaliado aqui se der erro vai para o catch para ser tratado como exceçao
                abrir() 'iniciada nova ligaçao a Base de dados
                da = New SqlDataAdapter("sp_buscarFuncCC", con) 'variavel que recebe os dados da pesquisa efetuada e passa para o datagrid             
                da.SelectCommand.CommandType = CommandType.StoredProcedure 'este comando e necessario para o sistema entender que é do tipo store procedure fazendo a leitura por essa via
                da.SelectCommand.Parameters.AddWithValue("@cartao_cidadao", txtBuscarCCidadao.Text)
                da.Fill(dt) 'precnhe a tabela dt com os campos recebidos da var da
                dg.DataSource = dt 'o datagrid e alimentado com os campos recebidos da var "dt"

                ContarLinhas() 'metodo criado para contar as linhas preenchidas





            Catch ex As Exception
                'tudo que foi avaliado e deu erro no try aqui será avaliado como exceçao
                MessageBox.Show("Erro ao pesquisar" + ex.Message)
                fechar()

            End Try
        End If


    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

        FormatarDG()
    End Sub

    Private Sub txtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged

        If txtBuscarNome.Text = "" And dg.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable 'a variável dt cria uma tabela com os campos recebidos pela Base de Dados
            Dim da As SqlDataAdapter 'a variável da passa os dados da tabela para o DataGrid


            Try
                'tudo que for avaliado aqui se der erro vai para o catch para ser tratado como exceçao
                abrir() 'iniciada nova ligaçao a Base de dados
                da = New SqlDataAdapter("sp_buscarFuncNome", con) 'variavel que recebe os dados da pesquisa efetuada e passa para o datagrid             
                da.SelectCommand.CommandType = CommandType.StoredProcedure 'este comando e necessario para o sistema entender que é do tipo store procedure fazendo a leitura por essa via
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscarNome.Text)
                da.Fill(dt) 'precnhe a tabela dt com os campos recebidos da var da
                dg.DataSource = dt 'o datagrid e alimentado com os campos recebidos da var "dt"

                ContarLinhas() 'metodo criado para contar as linhas preenchidas





            Catch ex As Exception
                'tudo que foi avaliado e deu erro no try aqui será avaliado como exceçao
                MessageBox.Show("Erro ao pesquisar" + ex.Message)
                fechar()

            End Try
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim cmd As SqlCommand

        If txtCC.Text <> "" Then


            Try
                abrir()
                cmd = New SqlCommand("sp_excluirFunc", con)
                cmd.CommandType = CommandType.StoredProcedure 'este comando e necessario para o sistema entender que é do tipo store procedure fazendo a leitura por essa via


                cmd.Parameters.AddWithValue("@cartao_cidadao", txtCC.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                LimparCampos()


                btnExcluir.Enabled = False
                btnEditar.Enabled = False



            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados!" + ex.Message)
                fechar()

            End Try
        End If

    End Sub


End Class