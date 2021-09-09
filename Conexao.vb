Imports System.Data.SqlClient

Module Conexao

    Public con As New SqlConnection("Server=SOUSAZEUS\SQLEXPRESS; DataBase=sistemavb; User Id=sergio; Password=Sousazeus792020")

    Sub abrir()
        If con.State = 0 Then
            con.Open()

        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()

        End If


    End Sub


End Module
