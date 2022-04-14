Imports System.Net
Imports System.Net.Mail

Module Correo

    Private correo As New MailMessage
    Private envios As New SmtpClient


    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String)
        Try
            correo.To.Clear()
            correo.Body = ""
            correo.Subject = ""
            correo.Body = mensaje
            correo.Subject = asunto
            correo.IsBodyHtml = True
            correo.To.Add(Trim(destinatario))

            If ruta <> "" Then
                Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
                correo.Attachments.Add(archivo)
            End If

            correo.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correo)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 4.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module

