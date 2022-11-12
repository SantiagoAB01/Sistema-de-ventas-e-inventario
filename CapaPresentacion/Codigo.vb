Imports iTextSharp.text.pdf

Public Class Codigo

    Public Shared Function codigo128(ByVal _code As String, Optional ByVal height As Single = 0)

        Dim barcode As New BarcodeCodabar
        barcode.StartStopText = False
        If height <> 0 Then
            barcode.BarHeight = height
        End If
        barcode.Code = _code
        Try
            Dim bm As New System.Drawing.Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White))

            Dim bmT As Image
            bmT = New Bitmap(bm.Width, bm.Height + 14)
            Dim g As Graphics = Graphics.FromImage(bmT)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 14)

            Dim PintarTexto As New Font("Arial", 8)
            Dim brocha As New SolidBrush(Color.Black)

            Dim StringSize As New SizeF
            StringSize = g.MeasureString(_code, PintarTexto)

            Dim centrox As Single = (bm.Width - StringSize.Width) / 2
            Dim x As Single = centrox
            Dim y As Single = bm.Height

            Dim drawFormat As New StringFormat
            drawFormat.FormatFlags = StringFormatFlags.NoWrap
            g.DrawImage(bm, 0, 0)

            Dim nconde As String = _code.Substring(1, _code.Length - 2)
            g.DrawString(_code, PintarTexto, brocha, x, y, drawFormat)
            Return bmT



        Catch ex As Exception
            Throw New Exception("Error al generar el codigo " & ex.ToString)
        End Try

    End Function

End Class
