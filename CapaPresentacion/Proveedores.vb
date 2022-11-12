Public Class Proveedores


    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        dgv_proveedores.Width = 687
        Panel_Registro.Visible = True

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_proveedores.DataSource = CapaDatos.MetodosProveedor.ListarProveedores
    End Sub


    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        dgv_proveedores.Width = 854
        Panel_Registro.Visible = False


    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            If CapaDatos.MetodosProveedor.InsertarProveedor(txb_nombre.Text, txb_sector.Text, txb_numdoc.Text, txb_direccion.Text, txb_telefono.Text, txb_email.Text, txb_url.Text) Then
                MsgBox("Al pacerer ya tiene un Proveedor con este Correo :" & txb_email.Text)

            Else
                MsgBox("Regsitro Exitoso!")
            End If
        Catch ex As Exception
            MsgBox("Error :" & ex.ToString)

        End Try
    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosProveedor.ListarProveedores)
        vista.RowFilter = "[Nombre] like '" & txb_buscar.Text & "%' or [Sector Comercial] like '" & txb_buscar.Text & "%'"
        dgv_proveedores.DataSource = vista
        If txb_buscar.Text = "" Then
            dgv_proveedores.DataSource = CapaDatos.MetodosProveedor.ListarProveedores
        End If
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub dgv_proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_proveedores.CellContentClick
        VistaCodigo.Show()

        MsgBox("Celda : " & dgv_proveedores.Rows.GetRowCount(DataGridViewElementStates.Selected).ToString)

    End Sub
End Class