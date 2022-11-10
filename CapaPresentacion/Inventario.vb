Imports System.Windows.Media.Animation
Public Class Inventario
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosIngreso.Listar_Inventario)
        vista.RowFilter = "[Nombre Producto] like '" & txb_buscar.Text & "%'"
        dgv_inventario.DataSource = vista
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_inventario.DataSource = CapaDatos.MetodosIngreso.Listar_Inventario

    End Sub




End Class