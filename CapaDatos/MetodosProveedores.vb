Imports System.Data.SqlClient

Public Class MetodosProveedores
    Public Shared Function ListarProveedores() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("ListarProveedores", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function


    Public Shared Function InsertarProvedor(nombre As String, sector As String, num_documento As String, direccion As String, telefono As String, email As String, url As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("InsertarProvedor", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@nombre ", nombre)
                CMD.Parameters.AddWithValue("@sector  ", sector)

                CMD.Parameters.AddWithValue("@num_documento   ", num_documento)
                CMD.Parameters.AddWithValue("@direccion  ", direccion)
                CMD.Parameters.AddWithValue("@telefono  ", telefono)
                CMD.Parameters.AddWithValue("@email  ", email)
                CMD.Parameters.AddWithValue("@dirc_url  ", url)


                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString
            End Using

        End Using

    End Function

End Class
