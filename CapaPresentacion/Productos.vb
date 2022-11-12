Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Interop

Public Class Productos





    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
        cbx_categoria.DisplayMember = "nombre"
        cbx_categoria.ValueMember = "id_categoria"
        cbx_categoria.DataSource = CapaDatos.MetodosCategoria.ListarCategoriasProductos
    End Sub

    Private Sub btn_codigo_Click(sender As Object, e As EventArgs) Handles btn_codigo.Click
        tbx_codigo.Text = CInt(Int((9999 * Rnd()) + 1)).ToString


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

        Dim picStream As New MemoryStream

        VistaCodigo.img_codigo.Image.Save(picStream, ImageFormat.Jpeg)
        Dim PicByte As Byte() = picStream.ToArray

        CapaDatos.MetodoProductos.InsertarProducto(cbx_categoria.SelectedValue, tbx_codigo.Text, txb_nombre.Text, txb_descripcion.Text, PicByte)
        MsgBox("Registro Exitoso!")
    End Sub

    Private Sub btn_vercodigo_Click(sender As Object, e As EventArgs) Handles btn_vercodigo.Click
        VistaCodigo.Show()
        btn_codigo.Enabled = False
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs)
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodoProductos.listarProductos)
        vista.RowFilter = "[NOMBRE DEL PRODUCTO] like '" & txb_buscar.Text & "%' or [CATEGORIA] like '" & txb_buscar.Text & "%'"
        dgv_prouctos.DataSource = vista
        If txb_buscar.Text = "" Then
            dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
        End If
    End Sub
End Class