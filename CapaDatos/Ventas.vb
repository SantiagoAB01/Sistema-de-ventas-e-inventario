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

    Public Shared Function LISTA_VENTAS() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("LISTA_VENTAS", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using

    End Function
    Public Shared Function CrearVenta(id_ingreso As Integer, id_trabajador As Integer, id_cliente As Integer, id_producto As Integer, descripcion As String, precio_unitario As Decimal, cantidad As Integer, fecha As String, itbms As Decimal, sub_total As Decimal, Total_Venta As Decimal) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("CrearVenta", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_ingreso", id_ingreso)
                CMD.Parameters.AddWithValue("@id_trabajador", id_trabajador)
                CMD.Parameters.AddWithValue("@id_cliente", id_cliente)
                CMD.Parameters.AddWithValue("@id_producto", id_producto)
                CMD.Parameters.AddWithValue("@descripcion", descripcion)
                CMD.Parameters.AddWithValue("@precio_unitario", precio_unitario)
                CMD.Parameters.AddWithValue("@cantidad", cantidad)
                CMD.Parameters.AddWithValue("@fecha", fecha)
                CMD.Parameters.AddWithValue("@itbms", itbms)
                CMD.Parameters.AddWithValue("@sub_total", sub_total)
                CMD.Parameters.AddWithValue("@venta_total", Total_Venta)


                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString
            End Using
        End Using
    End Function




End Class
