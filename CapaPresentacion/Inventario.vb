Imports System.Windows.Media.Animation
Imports ClosedXML.Excel

Public Class Inventario


    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosIngreso.Listar_Inventario)
        vista.RowFilter = "[Nombre Producto] like '" & txb_buscar.Text & "%'"
        dgv_inventario.DataSource = vista
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_inventario.DataSource = CapaDatos.MetodosIngreso.Listar_Inventario

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

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub
End Class