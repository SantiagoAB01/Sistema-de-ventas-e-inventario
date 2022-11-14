Public Class CrearVentas




    Private Sub CrearVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_clientes.DisplayMember = "nombre"
        cbx_clientes.ValueMember = "id_cliente"
        cbx_clientes.DataSource = CapaDatos.MetodosClientes.listarClientes

        cbx_productos.DisplayMember = "nombre"
        cbx_productos.ValueMember = "id_producto"
        cbx_productos.DataSource = CapaDatos.MetodosIngreso.Listar_Inventario

        dgv_producto.DataSource = CapaDatos.Ventas.MostrarLineaPedido(cbx_productos.SelectedValue)
    End Sub

    Private Sub cbx_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_productos.SelectedIndexChanged
        dgv_producto.DataSource = CapaDatos.Ventas.MostrarLineaPedido(cbx_productos.SelectedValue)
        num_cantidad.Value = 0
        Dim categoria As Integer = CInt(dgv_producto.Rows(0).Cells(3).Value.ToString)
        If categoria = 9 Then
            txb_itbms.Text = "0.10"
        Else
            txb_itbms.Text = "0.07"

        End If

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Panel_LineaPedido.Visible = True
        dgv_lineaPedidos.Visible = True
        lbl_linea.Visible = True
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Panel_LineaPedido.Visible = False
        dgv_lineaPedidos.Visible = False
        lbl_linea.Visible = False
        btn_Enviar.Visible = True

    End Sub

    Private Sub num_cantidad_ValueChanged(sender As Object, e As EventArgs) Handles num_cantidad.ValueChanged


        txb_subtotal.Text = Convert.ToDouble((dgv_producto.Rows(0).Cells(5).Value.ToString) * num_cantidad.Value)
        txb_total.Text = Convert.ToDouble((dgv_producto.Rows(0).Cells(5).Value.ToString) * num_cantidad.Value) * Convert.ToDouble(txb_itbms.Text) + Convert.ToDouble((dgv_producto.Rows(0).Cells(5).Value.ToString) * num_cantidad.Value)
        If num_cantidad.Value > CInt(dgv_producto.Rows(0).Cells(6).Value.ToString) Then
            num_cantidad.Value = num_cantidad.Value - 1
            MsgBox("Se ha agotado los stocks")
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        btn_Enviar.Visible = True
        Dim id_ingreso As Integer = CInt(dgv_producto.Rows(0).Cells(0).Value.ToString)
        Dim fechaActual As Date = Date.Now
        dgv_lineaPedidos.Rows.Add(id_ingreso, cbx_clientes.SelectedValue, cbx_productos.SelectedValue, txb_descripcion.Text, num_cantidad.Value, fechaActual.ToShortDateString, txb_itbms.Text, txb_subtotal.Text, txb_total.Text)


    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub
End Class