Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Interop
Imports iTextSharp.text.pdf.qrcode

Public Class Productos





    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_prouctos.RowTemplate.Height = 83

        dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
        cbx_categoria.DisplayMember = "nombre"
        cbx_categoria.ValueMember = "id_categoria"
        cbx_categoria.DataSource = CapaDatos.MetodosCategoria.ListarCategoriasProductos

        cbx_Proveedores.DisplayMember = "nombre"
        cbx_Proveedores.ValueMember = "id_proveedor"
        cbx_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores


    End Sub

    Private Sub btn_codigo_Click(sender As Object, e As EventArgs) Handles btn_codigo.Click
        tbx_codigo.Text = CInt(Int((9999 * Rnd()) + 10)).ToString


        Dim bm As Bitmap = Nothing
        bm = Codigo.codigo128("A" & tbx_codigo.Text & "B", 70)
        If Not IsNothing(bm) Then
            VistaCodigo.img_codigo.Image = bm
        End If


        btn_codigo.Enabled = False
        btn_codigo.Text = "CODIGO GENERADO!"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn_codigo.Enabled = True
        btn_codigo.Text = "Generar Codigo"
        tbx_codigo.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If txb_descripcion.Text <> "" And txb_nombre.Text <> "" And txb_preciocompra.Text <> "" And txb_precioventa.Text <> "" And tbx_codigo.Text <> "" Then
                Dim picStream As New MemoryStream

                VistaCodigo.img_codigo.Image.Save(picStream, ImageFormat.Jpeg)
                Dim PicByte As Byte() = picStream.ToArray

                CapaDatos.MetodoProductos.InsertarProducto(cbx_categoria.SelectedValue, tbx_codigo.Text, txb_nombre.Text, txb_descripcion.Text, PicByte, Convert.ToDecimal(txb_precioventa.Text), Convert.ToDecimal(txb_preciocompra.Text), cbx_Proveedores.SelectedValue)
                MsgBox("Registro Exitoso!")
                dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
            Else
                MsgBox("Campos Vacios!")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_vercodigo_Click(sender As Object, e As EventArgs) Handles btn_vercodigo.Click
        VistaCodigo.Show()
        btn_codigo.Enabled = False
    End Sub


    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodoProductos.listarProductos)
        vista.RowFilter = "[NOMBRE DEL PRODUCTO] like '" & txb_buscar.Text & "%' or [CATEGORIA] like '" & txb_buscar.Text & "%'"
        dgv_prouctos.DataSource = vista
        dgv_prouctos.RowTemplate.Height = 83

        If txb_buscar.Text = "" Then
            dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
            dgv_prouctos.RowTemplate.Height = 83
        End If
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgv_prouctos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prouctos.CellContentClick
        InfoProducto.Show()
        InfoProducto.txb_id.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(0).Value.ToString
        InfoProducto.tbx_codigo.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(1).Value.ToString
        InfoProducto.txb_nombre.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(2).Value.ToString
        InfoProducto.txb_descripcion.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(3).Value.ToString
        InfoProducto.cbx_categoria.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(4).Value.ToString
        InfoProducto.txb_precioventa.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(5).Value.ToString
        InfoProducto.txb_preciocompra.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(6).Value.ToString
        InfoProducto.cbx_Proveedores.Text = dgv_prouctos.Rows(dgv_prouctos.CurrentRow.Index).Cells(7).Value.ToString

        Dim bm As Bitmap = Nothing
        bm = Codigo.codigo128("A" & InfoProducto.tbx_codigo.Text & "B", 70)
        If Not IsNothing(bm) Then
            InfoProducto.img_codigo.Image = bm
        End If

    End Sub
    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Close()
    End Sub


End Class