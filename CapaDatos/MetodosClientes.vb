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

    Public Shared Sub InsertarCliente(nombre As String, apellido As String, sexo As String, fecha As String, cedula As String, direccion As String, telefono As String, email As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("AgregarClientes", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@apellido ", apellido)
                CMD.Parameters.AddWithValue("@sexo", sexo)
                CMD.Parameters.AddWithValue("@fecha_nacimiento", fecha)
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CMD.Parameters.AddWithValue("@direccion", direccion)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@email", email)
                CN.Open()
                CMD.ExecuteNonQuery()



            End Using
        End Using
    End Sub

End Class
