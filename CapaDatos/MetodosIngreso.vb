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

    Public Shared Function RegistrarInventario(id_producto As Integer, fecha As String, stock As Integer) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("RegistrarInventario", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_producto", id_producto)
                CMD.Parameters.AddWithValue("@fecha", fecha)
                CMD.Parameters.AddWithValue("@stock", stock)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString
            End Using

        End Using

    End Function



    Public Shared Function ActualizarInventario(id_ingreso As Integer, id_producto As Integer, fecha As String, stock_actual As Integer) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("ActualizarInventario", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_ingreso", id_ingreso)
                CMD.Parameters.AddWithValue("@id_producto", id_producto)
                CMD.Parameters.AddWithValue("@fecha", fecha)
                CMD.Parameters.AddWithValue("@stock_actual", stock_actual)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString
            End Using

        End Using

    End Function

    Public Shared Sub EliminarInventario(id_Ingreso As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("EliminarInventario", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_Ingreso", id_Ingreso)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub





End Class
