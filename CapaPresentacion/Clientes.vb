Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet
Imports Microsoft.Office.Interop

Public Class Clientes
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        AgregarCliente.Show()

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_clientes.DataSource = CapaDatos.MetodosClientes.listarClientes
    End Sub

    Private Sub txb_buscar_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        Dim vista As New DataView(CapaDatos.MetodosClientes.listarClientes)
        vista.RowFilter = "nombre like '" & txb_buscar.Text & "%' or apellido like '" & txb_buscar.Text & "%'"
        dgv_clientes.DataSource = vista
        If txb_buscar.Text = "" Then
            dgv_clientes.DataSource = CapaDatos.MetodosClientes.listarClientes
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click

        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()

                        workbook.Worksheets.Add(dgv_clientes.DataSource, "Clientes")
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