Public Class CrearVentas



    Dim trabajador_id As Integer = CInt(CapaDatos.MetodoTrabajador.Id_Trabajador)


    Private Sub CrearVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbx_clientes.DisplayMember = "nombre"
        cbx_clientes.ValueMember = "id_cliente"
        cbx_clientes.DataSource = CapaDatos.MetodosClientes.listarClientes

        cbx_productos.DisplayMember = "nombre"
        cbx_productos.ValueMember = "id_producto"
        cbx_productos.DataSource = CapaDatos.MetodosIngreso.Listar_Inventario

        dgv_producto.DataSource = CapaDatos.Ventas.MostrarLineaPedido(cbx_productos.SelectedValue)
        Me.Refresh()
    End Sub

    Private Sub cbx_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_productos.SelectedIndexChanged
        dgv_producto.DataSource = CapaDatos.Ventas.MostrarLineaPedido(cbx_productos.SelectedValue)
        num_cantidad.Value = 0
        Dim categoria As Integer = CInt(dgv_producto.Rows(0).Cells(3).Value.ToString)
        If categoria = 8 Then
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

        If num_cantidad.Value = 0 Then
            btn_Enviar.Visible = False
        Else
            btn_Enviar.Visible = True
            txb_subtotal.Text = Convert.ToDouble((dgv_producto.Rows(0).Cells(5).Value.ToString) * num_cantidad.Value)
            txb_total.Text = Convert.ToDouble((dgv_producto.Rows(0).Cells(5).Value.ToString) * num_cantidad.Value) * Convert.ToDouble(txb_itbms.Text) + Convert.ToDouble((dgv_producto.Rows(0).Cells(5).Value.ToString) * num_cantidad.Value).ToString
            If num_cantidad.Value > CInt(dgv_producto.Rows(0).Cells(6).Value.ToString) Then
                num_cantidad.Value = 0
                MsgBox("Se ha agotado los stocks")
            End If
        End If


    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If num_cantidad.Value <> 0 Then
            btn_Enviar.Visible = True
            Dim Precio_unitario As String = dgv_producto.Rows(0).Cells(5).Value.ToString
            Dim id_ingreso As Integer = CInt(dgv_producto.Rows(0).Cells(0).Value.ToString)
            Dim fechaActual As Date = Date.Now
            dgv_lineaPedidos.Rows.Add(id_ingreso, trabajador_id, cbx_clientes.SelectedValue, cbx_productos.SelectedValue, txb_descripcion.Text, Precio_unitario, num_cantidad.Value, fechaActual.ToShortDateString, txb_itbms.Text, txb_subtotal.Text, txb_total.Text)

            txb_descripcion.Text = ""
            txb_total.Text = ""
            txb_subtotal.Text = ""
            num_cantidad.Value = 0
            btn_Enviar.Visible = False

            If dgv_lineaPedidos.RowHeadersVisible Then
                btn_Enviar.Visible = True
            Else
                btn_Enviar.Visible = False

            End If
        Else
            MsgBox("Debe ingresar por lo menos un producto")

        End If
    End Sub



    Private Sub dgv_lineaPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lineaPedidos.CellContentClick
        If MessageBox.Show("¿Esta Seguro que desea remover esta fila?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = 6 Then
            dgv_lineaPedidos.Rows.Remove(dgv_lineaPedidos.Rows(dgv_lineaPedidos.CurrentRow.Index))
        End If
    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click

        Dim filas As Integer = dgv_lineaPedidos.Rows.Count
            If MessageBox.Show("¿Esta Seguro que desea registrar todos los registros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = 6 Then

                For i = 0 To filas Step 1
                If i = filas Then
                    Exit For
                End If
                dgv_producto.DataSource = CapaDatos.Ventas.MostrarLineaPedido(cbx_productos.SelectedValue)
                Dim cantidad_ac As Integer = CInt(dgv_producto.Rows(0).Cells(6).Value.ToString)
                If num_cantidad.Value < cantidad_ac Then
                    If dgv_lineaPedidos.Rows(i).Cells(0).Style.BackColor <> ColorTranslator.FromHtml("#D1EEB6") And dgv_lineaPedidos.Rows(i).Cells(0).Style.BackColor <> ColorTranslator.FromHtml("#E36F6F") Then
                        If CapaDatos.Ventas.CrearVenta(
                        (dgv_lineaPedidos.Rows(i).Cells(0).Value),
                        (dgv_lineaPedidos.Rows(i).Cells(1).Value),
                        (dgv_lineaPedidos.Rows(i).Cells(2).Value),
                        (dgv_lineaPedidos.Rows(i).Cells(3).Value),
                        dgv_lineaPedidos.Rows(i).Cells(4).Value.ToString,
                        Convert.ToDecimal(dgv_lineaPedidos.Rows(i).Cells(5).Value),
                        (dgv_lineaPedidos.Rows(i).Cells(6).Value),
                        dgv_lineaPedidos.Rows(i).Cells(7).Value.ToString,
                         dgv_lineaPedidos.Rows(i).Cells(8).Value,
                         Convert.ToDecimal(dgv_lineaPedidos.Rows(i).Cells(9).Value),
                         Convert.ToDecimal(dgv_lineaPedidos.Rows(i).Cells(10).Value)) Then

                            MsgBox("Se agotaron los stocks de un producto")
                            dgv_lineaPedidos.Rows(i).Cells(0).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(1).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(2).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(3).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(4).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(5).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(6).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(7).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(8).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(9).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                            dgv_lineaPedidos.Rows(i).Cells(10).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")

                        Else
                            dgv_lineaPedidos.Rows(i).Cells(0).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(1).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(2).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(3).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(4).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(5).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(6).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(7).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(8).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(9).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")
                            dgv_lineaPedidos.Rows(i).Cells(10).Style.BackColor = ColorTranslator.FromHtml("#D1EEB6")

                        End If
                    End If
                Else
                    MsgBox("Se agotaron los stocks de un producto")
                    dgv_lineaPedidos.Rows(i).Cells(0).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(1).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(2).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(3).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(4).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(5).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(6).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(7).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(8).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(9).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                    dgv_lineaPedidos.Rows(i).Cells(10).Style.BackColor = ColorTranslator.FromHtml("#E36F6F")
                End If

            Next
                MsgBox("Se han enviado correctamente los registros!")

                txb_descripcion.Text = ""
                txb_total.Text = ""
                txb_subtotal.Text = ""
                num_cantidad.Value = 0
            Inventario.dgv_inventario.DataSource = CapaDatos.MetodosIngreso.Listar_Inventario

        Else
                MsgBox("ha cancelado la operacion")
            End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        txb_descripcion.Text = ""
        txb_total.Text = ""
        txb_subtotal.Text = ""
        num_cantidad.Value = 0
        Me.Close()
    End Sub

    Private Sub cbx_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_clientes.SelectedIndexChanged
        txb_descripcion.Text = ""
        txb_total.Text = ""
        txb_subtotal.Text = ""
        num_cantidad.Value = 0
        Panel_LineaPedido.Visible = False
    End Sub
End Class