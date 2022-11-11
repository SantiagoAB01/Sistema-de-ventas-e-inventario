Imports System.Net.Security
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class Registro
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txb_password.Text = "" Or txb_telefono.Text = "" Or txb_apellido.Text = "" Or txb_cedula.Text = "" Or txb_direccion.Text = "" Or txb_nombre.Text = "" Or cbx_sexo.Text = "" Then
            MsgBox("Asegurese de completar todos los campos.")
        Else

            If CapaDatos.MetodoTrabajador.ValidarTrabajador(txb_cedula.Text) Then
                MsgBox("Error: Este usuario con la cedula '" & txb_cedula.Text & "' ya ha sido registrado!")
            Else
                CapaDatos.MetodoTrabajador.InsertarTrabajador(txb_nombre.Text, txb_apellido.Text, cbx_sexo.Text, dte_fecha.Value.ToShortDateString, txb_cedula.Text, txb_direccion.Text, txb_telefono.Text, txb_email.Text, txb_password.Text)
                MsgBox("Trabajador Registrado Correctamete!")
            End If
            txb_apellido.Text = ""
            txb_cedula.Text = ""
            txb_direccion.Text = ""
            txb_email.Text = ""
            txb_nombre.Text = ""
            txb_telefono.Text = ""
            cbx_sexo.Text = ""
            dte_fecha.Text = ""
            txb_password.Text = ""

        End If


    End Sub
End Class