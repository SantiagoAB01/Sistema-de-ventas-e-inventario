Imports System.Windows.Media.Animation
Imports ClosedXML.Excel

Public Class Inventario

    Dim id_producto As Integer = 0

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosIngreso.Listar_Inventario)
        vista.RowFilter = "[Nombre Producto] like '" & txb_buscar.Text & "%'"
        dgv_inventario.DataSource = vista



    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_inventario.DataSource = CapaDatos.MetodosIngreso.Listar_Inventario
        dgv_productos.DataSource = CapaDatos.MetodoProductos.listarProductos

        cbx_Proveedores.DisplayMember = "nombre"
        cbx_Proveedores.ValueMember = "id_proveedor"
        cbx_Proveedores.DataSource = CapaDatos.MetodosProveedor.ListarProveedores_Inventario

    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()

                        workbook.Worksheets.Add(dgv_inventario.DataSource, "Mi Inventario")
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Haz exportado tus datos a un archivo excel")
                Catch ex As Exception
                    MessageBox.Show("Ha habido un Error: " & ex.ToString)

                End Try
            End If
        End Using
    End Sub



    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Panel_Registro.Visible = True
        lbl_titulo.Text = "Nuevo"
        dgv_inventario.Width = 514
        Panel_Registro.BackColor = ColorTranslator.FromHtml("#BFCDDB")
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        dgv_inventario.Width = 998
        Panel_Registro.Visible = False
    End Sub

    Private Sub txb_buscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txb_buscarProducto.TextChanged
        Dim vista As New DataView(CapaDatos.MetodoProductos.listarProductos)
        vista.RowFilter = "[NOMBRE DEL PRODUCTO] like '" & txb_buscarProducto.Text & "%' or [CATEGORIA] like '" & txb_buscarProducto.Text & "%'"
        dgv_productos.DataSource = vista

        If txb_buscar.Text = "" Then
            dgv_productos.DataSource = CapaDatos.MetodoProductos.listarProductos
        End If
    End Sub

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick
        txb_id_Producto.Text = dgv_productos.Rows(dgv_productos.CurrentRow.Index).Cells(2).Value.ToString
        id_producto = CInt(dgv_productos.Rows(dgv_productos.CurrentRow.Index).Cells(0).Value.ToString)
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If MessageBox.Show("¿Esta Seguro de De realizar esta Accion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then

            Dim fechaActual As Date = Date.Now
            If CapaDatos.MetodosIngreso.RegistrarInventario(CInt(id_producto), cbx_Proveedores.SelectedValue, fechaActual.ToShortDateString, Convert.ToDouble(txb_PrecioCompra.Text), Convert.ToDouble(txb_PrecioVenta.Text), CInt(num_Cantidad.Value.ToString), dte_FechaProduccion.Value.ToLongDateString, dte_Vencimiento.Value.ToLongDateString) Then
                MsgBox("Parece que ya esta registrado este producto en el inventario")

            Else
                MsgBox("Registro Exitso!")
                End If

        Else
            MsgBox("ha cancelado la operacion!")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_inventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_inventario.CellContentClick
        Panel_Registro.BackColor = ColorTranslator.FromHtml("#eee8aa")
        lbl_titulo.Text = "Actualizar"
        dgv_inventario.Width = 514
        Panel_Registro.Visible = True
    End Sub
End Class