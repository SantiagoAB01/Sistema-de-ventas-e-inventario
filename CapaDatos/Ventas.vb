Imports System.Data.SqlClient

Public Class Ventas
    Public Shared Function MostrarLineaPedido(id_Producto As Integer) As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("exec MostrarLineaPedido " & id_Producto, CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function
End Class
