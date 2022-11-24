Imports System.Drawing.Imaging
Imports System.IO

Public Class InfoProducto
    Private Sub InfoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_categoria.DisplayMember = "nombre"
        cbx_categoria.ValueMember = "id_categoria"
        cbx_categoria.DataSource = CapaDatos.MetodosCategoria.ListarCategoriasProductos


        cbx_Proveedores.DisplayMember = "nombre"
        cbx_Proveedores.ValueMember = "id_proveedor"
        cbx_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores


    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If MessageBox.Show("¿Esta Seguro que desea Eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = 6 Then
            Try
                CapaDatos.MetodoProductos.EliminarProducto(CInt(txb_id.Text))

            Catch ex As Exception
                MsgBox("Error : " & ex.ToString)
            End Try
            MsgBox("El Producto se ha Eliminado!")
            Productos.dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos

        Else
            MsgBox("Ha cancelado la Operacion!")

        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        If txb_descripcion.Text <> "" And txb_nombre.Text <> "" And txb_preciocompra.Text <> "" And txb_precioventa.Text <> "" Then

            Try
                Dim picStream As New MemoryStream

                img_codigo.Image.Save(picStream, ImageFormat.Jpeg)
                Dim PicByte As Byte() = picStream.ToArray
                CapaDatos.MetodoProductos.ActualizarProducto(CInt(txb_id.Text), cbx_categoria.SelectedValue, tbx_codigo.Text, txb_nombre.Text, txb_descripcion.Text, PicByte, Convert.ToDecimal(txb_precioventa.Text), Convert.ToDecimal(txb_preciocompra.Text), CInt(cbx_Proveedores.SelectedValue.ToString))
            Catch ex As Exception
                MsgBox("Error : " & ex.ToString)
            End Try
            MsgBox("Actualizacion Exitosa!")
            Productos.dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub

    Private Sub btn_codigo_Click(sender As Object, e As EventArgs) Handles btn_codigo.Click
        tbx_codigo.Text = CInt(Int((9999 * Rnd()) + 10)).ToString


        Dim bm As Bitmap = Nothing
        bm = Codigo.codigo128("A" & tbx_codigo.Text & "B", 70)
        If Not IsNothing(bm) Then
            img_codigo.Image = bm
        End If


        btn_codigo.Enabled = False
        btn_codigo.Text = "CODIGO GENERADO!"
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        tbx_codigo.Text = ""
        btn_codigo.Enabled = True
        btn_codigo.Text = "Generar Codigo"
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class