Imports ClosedXML.Excel

Public Class ListadoVentas
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub ListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_ventas.DataSource = CapaDatos.Ventas.LISTA_VENTAS
    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.Ventas.LISTA_VENTAS)
        vista.RowFilter = "[Nombre Cliente] like '" & txb_buscar.Text & "%' or [Nombre Trabajador] like '" & txb_buscar.Text & "%'"
        dgv_ventas.DataSource = vista

        If txb_buscar.Text = "" Then
            dgv_ventas.DataSource = CapaDatos.Ventas.LISTA_VENTAS
        End If
    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click

        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()

                        workbook.Worksheets.Add(dgv_ventas.DataSource, "Lista Ventas")
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