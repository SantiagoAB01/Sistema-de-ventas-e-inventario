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

    Public Shared Function RegistrarInventario(id_producto As Integer, id_proveedor As String, fecha As String, precio_compra As Double, precio_venta As Double, stock As Integer, fecha_produccion As String, fecha_Vencimiento As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("RegistrarInventario", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_producto", id_producto)
                CMD.Parameters.AddWithValue("@id_proveedor", id_proveedor)
                CMD.Parameters.AddWithValue("@fecha", fecha)
                CMD.Parameters.AddWithValue("@precio_compra", precio_compra)
                CMD.Parameters.AddWithValue("@precio_venta", precio_venta)
                CMD.Parameters.AddWithValue("@stock", stock)
                CMD.Parameters.AddWithValue("@fecha_produccion", fecha_produccion)
                CMD.Parameters.AddWithValue("@fecha_vencimiento", fecha_Vencimiento)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString
            End Using

        End Using

    End Function

End Class
