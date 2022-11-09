Public Class Clientes
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        AgregarCliente.Show()

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_clientes.DataSource = CapaDatos.MetodosClientes.listarClientes
    End Sub
End Class