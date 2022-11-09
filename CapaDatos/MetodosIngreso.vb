Imports System.Data.SqlClient

Public Class MetodosIngreso
    Public Shared Function Listar_Inventario() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("LISTAR_INVENTARIO", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function
End Class
