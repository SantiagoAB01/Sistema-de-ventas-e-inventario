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


End Class
