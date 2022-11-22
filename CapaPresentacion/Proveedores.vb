Public Class Proveedores

    Dim id_proveedor As Integer
    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        lbl_titulo.Text = "Nuevo Proveedor"
        btn_actualizar.Visible = False
        btn_Agregar.Visible = True
        btn_eliminar.Visible = False
        Panel_Registro.BackColor = ColorTranslator.FromHtml("#BFCDDB")
        Panel_Registro.Visible = True
        dgv_Proveedores.Width = 482

        txb_nombre.Text = ""
        txb_email.Text = ""
        txb_sector.Text = ""
        txb_telefono.Text = ""
        txb_url.Text = ""
        txb_documento.Text = ""
        txb_direccion.Text = ""


    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores
    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosProveedores.ListarProveedores)
        vista.RowFilter = "[Nombre] like '" & txb_buscar.Text & "%' or [Sector Comercial] like '" & txb_buscar.Text & "%'"
        dgv_Proveedores.DataSource = vista

        If txb_buscar.Text = "" Then
            dgv_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores
        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        dgv_Proveedores.Width = 935
        Panel_Registro.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txb_documento.TextChanged

    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click

        Try
            If CapaDatos.MetodosProveedores.InsertarProvedor(txb_nombre.Text, txb_sector.Text, txb_documento.Text, txb_direccion.Text, txb_telefono.Text, txb_email.Text, txb_url.Text) Then
                MsgBox("Parece que este Proveedor esta Registrado")
            Else
                dgv_Proveedores.Refresh()

                MsgBox("Provedor Registrado Correctamente!")

            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
        dgv_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores

    End Sub



    Private Sub dgv_Proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Proveedores.CellContentClick
        btn_actualizar.Visible = True
        btn_Agregar.Visible = False
        btn_eliminar.Visible = True
        Panel_Registro.Visible = True
        Panel_Registro.BackColor = ColorTranslator.FromHtml("#eee8aa")
        lbl_titulo.Text = "Editar Proveedor"
        id_proveedor = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(0).Value.ToString
        txb_nombre.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(1).Value.ToString
        txb_email.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(2).Value.ToString
        txb_sector.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(3).Value.ToString
        txb_telefono.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(6).Value.ToString
        txb_url.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(7).Value.ToString
        txb_documento.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(4).Value.ToString
        txb_direccion.Text = dgv_Proveedores.Rows(dgv_Proveedores.CurrentRow.Index).Cells(5).Value.ToString
        dgv_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click



        Try


            CapaDatos.MetodosProveedores.actualizarProveedor(id_proveedor, txb_nombre.Text, txb_sector.Text, txb_documento.Text, txb_direccion.Text, txb_telefono.Text, txb_email.Text, txb_url.Text)


            MsgBox("Provedor Actualizado Correctamente!")


        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
        dgv_Proveedores.Refresh()
        dgv_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try


            CapaDatos.MetodosProveedores.EliminarProveedor(id_proveedor)


            MsgBox("Provedor Eliminado Correctamente!")


        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
        dgv_Proveedores.Refresh()
        dgv_Proveedores.DataSource = CapaDatos.MetodosProveedores.ListarProveedores
    End Sub
End Class