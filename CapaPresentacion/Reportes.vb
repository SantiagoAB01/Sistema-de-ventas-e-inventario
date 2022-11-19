Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ClosedXML.Excel

Public Class Reportes
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_cliente.SelectedIndexChanged


        dgv_reportes.DataSource = CapaDatos.Ventas.Reporte_Personalizado(cbx_mes.SelectedValue, cbx_year.SelectedValue, cbx_cliente.SelectedValue)



    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_reportes.DataSource = CapaDatos.Ventas.Reportes
        CapaDatos.Ventas.ObtenerCantidadStocks()
        CapaDatos.Ventas.ObtenerTotalVentas()
        lbl_CantidadStock.Text = "TOTAL DE STOCKS :" & CapaDatos.Ventas.Cantidad_Stock
        lbl_Total.Text = "TOTAL $" & CapaDatos.Ventas.Venta_Total

        cbx_cliente.DisplayMember = "nombre"
        cbx_cliente.ValueMember = "id_cliente"
        cbx_cliente.DataSource = CapaDatos.MetodosClientes.listarClientes

        cbx_mes.DisplayMember = "MES"
        cbx_mes.ValueMember = "ID"
        cbx_mes.DataSource = CapaDatos.Ventas.Fecha_venta_MES


        cbx_year.DisplayMember = "ID"
        cbx_year.ValueMember = "ID"
        cbx_year.DataSource = CapaDatos.Ventas.Fecha_venta_YEAR


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            cbx_cliente.Enabled = True
            cbx_year.Enabled = True
            cbx_mes.Enabled = True
        Else
            cbx_cliente.Enabled = False
            cbx_year.Enabled = False
            cbx_mes.Enabled = False


        End If
    End Sub

    Private Sub cbx_fecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_year.SelectedIndexChanged
        dgv_reportes.DataSource = (CapaDatos.Ventas.Reporte_Personalizado(cbx_mes.SelectedValue, cbx_year.SelectedValue, cbx_cliente.SelectedValue))

    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.Ventas.Reportes)
        vista.RowFilter = "[PRODUCTO] like '" & txb_buscar.Text & "%' or [NOMBRE TRABAJADOR] like '" & txb_buscar.Text & "%' or [NOMBRE CLIENTE] Like '" & txb_buscar.Text & "%'"
        dgv_reportes.DataSource = vista

        If txb_buscar.Text = "" Then
            dgv_reportes.DataSource = CapaDatos.Ventas.Reportes
        End If
    End Sub

    Private Sub cbx_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mes.SelectedIndexChanged
        dgv_reportes.DataSource = CapaDatos.Ventas.Reporte_Personalizado(cbx_mes.SelectedValue, cbx_year.SelectedValue, cbx_cliente.SelectedValue)

    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click

        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()

                        workbook.Worksheets.Add(dgv_reportes.DataSource, "Reporte")
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Haz exportado tus datos a un archivo excel")
                Catch ex As Exception
                    MessageBox.Show("Ha habido un Error: " & ex.ToString)

                End Try
            End If
        End Using
    End Sub
End Class