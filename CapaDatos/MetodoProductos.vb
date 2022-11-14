Imports System.Data.SqlClient
Imports ClosedXML.Excel.XLPredefinedFormat

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

    Public Shared Sub InsertarProducto(id_categoria As String, codigo As String, nombre As String, descripcion As String, imagen As Byte(), precio_Venta As Double, precio_compra As Double)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("InsertarProducto", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_categoria", id_categoria)
                CMD.Parameters.AddWithValue("@codigo", codigo)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@descripcion", descripcion)
                CMD.Parameters.AddWithValue("@imagen", imagen)
                CMD.Parameters.AddWithValue("@Precio_venta", precio_Venta)
                CMD.Parameters.AddWithValue("@Precio_compra", precio_compra)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub ActualizarProducto(id_producto As Integer, id_categoria As String, codigo As String, nombre As String, descripcion As String, imagen As Byte(), precio_Venta As Double, precio_compra As Double)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("ActualizarProducto", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_producto", id_producto)
                CMD.Parameters.AddWithValue("@id_categoria", id_categoria)
                CMD.Parameters.AddWithValue("@codigo", codigo)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@descripcion", descripcion)
                CMD.Parameters.AddWithValue("@imagen", imagen)
                CMD.Parameters.AddWithValue("@Precio_venta", precio_Venta)
                CMD.Parameters.AddWithValue("@Precio_compra", precio_compra)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub EliminarProducto(id_producto As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("EliminarProducto", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id", id_producto)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub





End Class
