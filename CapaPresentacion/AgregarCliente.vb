Public Class AgregarCliente
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txb_nombre.Text <> "" And txb_apellido.Text <> "" And txb_cedula.Text <> "" And txb_email.Text <> "" And txb_telefono.Text <> "" And txb_direccion.Text <> "" Then
            Try
                CapaDatos.MetodosClientes.InsertarCliente(txb_nombre.Text, txb_apellido.Text, cbx_sexo.Text, dat_fecha.Value.ToShortDateString, txb_cedula.Text, txb_direccion.Text, txb_telefono.Text, txb_email.Text)
                MsgBox("Cliente Agregado Correctamente!")
                txb_apellido.Text = ""
                txb_cedula.Text = ""
                txb_direccion.Text = ""
                txb_email.Text = ""
                txb_nombre.Text = ""
                txb_telefono.Text = ""
                cbx_sexo.Text = ""
                dat_fecha.Text = ""
                Clientes.dgv_clientes.Refresh()
                Clientes.dgv_clientes.DataSource = CapaDatos.MetodosClientes.listarClientes
            Catch ex As Exception

            End Try
        Else
            MsgBox("Campos Vacios!")
        End If
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class