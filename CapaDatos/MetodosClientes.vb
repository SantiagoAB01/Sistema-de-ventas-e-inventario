Imports System.Data.SqlClient


Public Class MetodosClientes

    Public Shared Function listarClientes() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("MostrarClientes", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function

End Class
