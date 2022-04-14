Imports System.Data.SqlClient
Public Class Form2
    Private Sub B_registrar_Click(sender As Object, e As EventArgs) Handles B_registrar.Click

        If TX_DNI.Text = "" And TX_motivo.Text = "" And TX_organizacion.Text = "" And TX_visita_a.Text = "" Then
            MessageBox.Show("Error de parámetro")
        Else
            If consultar_visitante(TX_DNI.Text.Trim()) = True Then
                MessageBox.Show("Visitante ya registrado")
            Else
                Dim indice As Integer = Form1.get_indice("Visitantes")
                abrir_registro(indice)
                Me.Hide()

            End If
        End If

        vaciar_caja_texto()

    End Sub

    'Registrar en visitantes
    Public Function abrir_registro(id As Integer)
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim comando As New SqlCommand("INSERT INTO Visitantes(id, dni, organizacion, motivo, visita_a) 
                                       VALUES(@id, @dni, @organizacion, @motivo, @visita_a)")

        comando.Parameters.Add("@id", SqlDbType.Int).Value = id
        comando.Parameters.Add("@dni", SqlDbType.NText).Value = TX_DNI.Text.Trim()
        comando.Parameters.Add("@organizacion", SqlDbType.NText).Value = TX_organizacion.Text.Trim()
        comando.Parameters.Add("@motivo", SqlDbType.NText).Value = TX_motivo.Text.Trim()
        comando.Parameters.Add("@visita_a", SqlDbType.NText).Value = TX_visita_a.Text.Trim()
        comando.Connection = conexion
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Function

    Private Sub B_volver_Click(sender As Object, e As EventArgs) Handles B_volver.Click
        Me.Hide()
        vaciar_caja_texto()

    End Sub

    Public Function consultar_visitante(dni As String)
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim comando As New SqlCommand("SELECT * FROM Visitantes WHERE dni = @dni", conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni

        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            'El visitante ya está registrado
            Return True
        Else
            'El visitante NO está registrado
            Return False
        End If

    End Function

    Public Function vaciar_caja_texto()
        TX_DNI.Text = ""
        TX_motivo.Text = ""
        TX_organizacion.Text = ""
        TX_visita_a.Text = ""

    End Function

End Class


