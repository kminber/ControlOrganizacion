Public Class Form7
    Private Sub B_adjuntar_Click(sender As Object, e As EventArgs) Handles B_adjuntar.Click

        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" Then
            TX_adjuntar.Text = Me.OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub B_enviar_Click(sender As Object, e As EventArgs) Handles B_enviar.Click
        'enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String)
        enviarCorreo(TX_emisor.Text, TX_pwd.Text, TX_texto.Text, TX_asunto.Text, TX_para.Text, TX_adjuntar.Text)
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class


