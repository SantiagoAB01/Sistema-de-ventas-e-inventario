Imports System.Data.SqlClient

Public Class MetodoProductos

    Public Shared Function listarProductos() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("LISTAR_PRODUCTOS", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function

    Public Shared Sub InsertarProducto(id_categoria As String, codigo As String, nombre As String, descripcion As String, imagen As Byte())
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("InsertarProducto", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_categoria", id_categoria)
                CMD.Parameters.AddWithValue("@codigo", codigo)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@descripcion", descripcion)
                CMD.Parameters.AddWithValue("@imagen", imagen)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub




End Class
