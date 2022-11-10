Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Productos
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub




    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_prouctos.DataSource = CapaDatos.MetodoProductos.listarProductos
        cbx_categoria.DisplayMember = "nombre"
        cbx_categoria.ValueMember = "id_categoria"
        cbx_categoria.DataSource = CapaDatos.MetodosCategoria.ListarCategoriasProductos
    End Sub

    Private Sub btn_codigo_Click(sender As Object, e As EventArgs) Handles btn_codigo.Click
        tbx_codigo.Text = CInt(Int((9999 * Rnd()) + 1)).ToString

        btn_codigo.Enabled = False
        btn_codigo.Text = "CODIGO GENERADO!"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn_codigo.Enabled = True
        btn_codigo.Text = "Generar Codigo"
        tbx_codigo.Text = ""

    End Sub


End Class