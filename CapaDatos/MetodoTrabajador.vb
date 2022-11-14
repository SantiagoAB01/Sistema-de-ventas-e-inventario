Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.ComTypes
Imports ClosedXML.Excel.XLPredefinedFormat
Imports Microsoft.SqlServer.Server

Public Class MetodoTrabajador

    Public Shared Id_Trabajador As String

    Public Shared Function ValidarTrabajador(cedula As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("ValidarTrabajador", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CN.Open()


                Return CMD.ExecuteReader().HasRows.ToString


            End Using

        End Using

    End Function


    Public Shared Sub InsertarTrabajador(nombre As String, apellido As String, sexo As String, fecha As String, cedula As String, direccion As String, telefono As String, email As String, password As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("RegistrarTrabajador", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@apellido ", apellido)
                CMD.Parameters.AddWithValue("@sexo", sexo)
                CMD.Parameters.AddWithValue("@fecha", fecha)
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CMD.Parameters.AddWithValue("@direccion", direccion)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@email", email)
                CMD.Parameters.AddWithValue("@password", password)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub



    Public Shared Function ValidarLogin(cedula As String, password As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("ValidarLogin", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CMD.Parameters.AddWithValue("@password", password)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString
            End Using

        End Using

    End Function
End Class
