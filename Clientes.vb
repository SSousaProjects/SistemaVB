Imports System.Data.SqlClient

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
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
            da = New SqlDataAdapter("SELECT * FROM clientes", con)
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
        dg.Columns(7).HeaderText = "Data Registo"


        dg.Columns(6).Width = 130




    End Sub

    Private Sub DesabilitarCampos()

        txtNome.Enabled = False
        cbSexo.Enabled = False
        txtCC.Enabled = False
        txtEndereco.Enabled = False
        txtContato.Enabled = False
        txtEmail.Enabled = False


    End Sub

    Private Sub HabilitarCampos()

        txtNome.Enabled = True
        cbSexo.Enabled = True
        txtCC.Enabled = True
        txtEndereco.Enabled = True
        txtContato.Enabled = True
        txtEmail.Enabled = True

        txtBuscarNome.Enabled = False


    End Sub

    Private Sub LimparCampos()

        txtNome.Text = ""
        cbSexo.Text = ""
        txtCC.Text = ""
        txtEndereco.Text = ""
        txtContato.Text = ""
        txtEmail.Text = ""

        txtBuscarNome.Text = ""




    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

        FormatarDG()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        LimparCampos()
        txtBuscarCCidadao.Visible = False
        txtBuscarNome.Visible = False
        btnGuardar.Enabled = True

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cmd As SqlCommand

        If txtCC.Text <> "" And txtNome.Text <> "" Then


            Try
                abrir()
                cmd = New SqlCommand("sp_salvarcliente", con)
                cmd.CommandType = CommandType.StoredProcedure 'este comando e necessario para o sistema entender que é do tipo store procedure fazendo a leitura por essa via

                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@cartao_cidadao", txtCC.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txtContato.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@data_registo", Now.Date())


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
End Class