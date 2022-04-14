Imports System.Data.SqlClient
Public Class Form3
    Dim id_visita As String
    Dim motivo_visita As String
    Private Sub B_registro_Click(sender As Object, e As EventArgs) Handles B_registro.Click

        Try
            If buscar_visitante(TX_DNI.Text.Trim()) = True Then

                If Form1.consultar(id_visita, "id_visitante") = False Then
                    Dim indice As Integer = Form1.get_indice("Registros")
                    Form1.abrir_registro(indice, id_visita, "id_visitante", motivo_visita)

                Else
                    Form1.cerrrar_registro(id_visita, "id_visitante", "visita")

                End If

                Me.Hide()

            Else
                MessageBox.Show("Visitante no encontrado")

            End If

            vaciar_caja_texto()

        Catch ex As Exception
            MessageBox.Show("Edificio no seleccionado")

        End Try


    End Sub


    Public Function buscar_visitante(dni As String) As Boolean
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim comando As New SqlCommand("SELECT * FROM Visitantes WHERE dni = @dni", conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni

        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            'El visitante está registrado
            id_visita = tabla.Rows(0)(0)
            motivo_visita = tabla.Rows(0)(3)
            Return True
        Else
            'El visitante NO está registrado
            Return False
        End If

    End Function

    Private Sub B_volver_Click(sender As Object, e As EventArgs) Handles B_volver.Click
        Me.Hide()
        vaciar_caja_texto()

    End Sub

    Public Function vaciar_caja_texto()
        TX_DNI.Text = ""

    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "SELECT nombre
                             FROM Edificios"

        Dim comando As New SqlCommand(sql)
        Dim adaptador As New SqlDataAdapter(comando)
        comando.Connection = conexion
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

        Dim tabla As New DataTable()
        adaptador.Fill(tabla)

        For i As Integer = 0 To tabla.Rows.Count - 1
            ComboBox2.Items.Add(tabla.Rows(i)(0))
        Next

    End Sub

    Public Function getCombobox2()
        Return ComboBox2.Text

    End Function

End Class

