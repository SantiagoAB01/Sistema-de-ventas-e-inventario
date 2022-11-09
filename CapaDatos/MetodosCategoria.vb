Imports System.Data.SqlClient

Public Class MetodosCategoria
    Public Shared Function ListarCategoriasProductos() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("listarCategoriaproductos", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function
End Class
