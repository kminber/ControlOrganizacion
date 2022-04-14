Imports System.Data.SqlClient

Public Class Form1

    Dim ultimo_r_abierto As DateTime
    Dim ultimo_r_cerrado As DateTime
    Dim Mensaje As String

    Private Sub B_insertar_Click(sender As Object, e As EventArgs) Handles B_insertar.Click

        Dim id_insertado As String = TextBox_insertar.Text

        Try
            If Mid(id_insertado, 1, 3) = "001" And Mid(id_insertado, id_insertado.Length) = "f" Then

                Dim id_trabajador As String = Mid(id_insertado, 1, (id_insertado.Length - 1))
                id_trabajador = Mid(id_trabajador, 4)

                Dim t_abierto As TimeSpan = DateTime.Now.Subtract(ultimo_r_abierto)
                Dim m_abierto As Integer = t_abierto.Minutes

                Dim t_cerrado As TimeSpan = DateTime.Now.Subtract(ultimo_r_cerrado)
                Dim m_cerrado As Integer = t_cerrado.Minutes

                If consultar(id_trabajador, "id_trabajador") = False Then

                    If m_cerrado >= 1 Then

                        Dim indice As Integer = get_indice("Registros")
                        abrir_registro(indice, id_trabajador, "id_trabajador", "")
                        ultimo_r_abierto = DateTime.Now

                    End If

                Else

                    If m_abierto >= 1 Then

                        cerrrar_registro(id_trabajador, "id_trabajador", "trabajador")
                        ultimo_r_cerrado = DateTime.Now

                    End If

                End If

            Else
                MessageBox.Show("Error de parámetro")

            End If

        Catch ex As Exception
            MessageBox.Show("Error de parámetro")

        End Try

        TextBox_insertar.Text = ""

    End Sub

    'número de registros
    Public Function get_indice(tabla_a As String) As Integer
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim comando As New SqlCommand("SELECT * FROM " & tabla_a & "", conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        Dim ind As Integer = tabla.Rows.Count + 1 'número de filas + 1
        Return ind

    End Function

    'insertar nuevo registro
    Public Function abrir_registro(ind As Integer, id_p As String, insertar_a As String, motivo As String)
        Dim conexion As New SqlConnection(My.Settings.conexion)

        If motivo.Equals("") = True Then
            Dim comando As New SqlCommand("INSERT INTO Registros(id, f_entrada, " & insertar_a & ", e_entrada) VALUES(@id, @f_entrada, @id_persona, @e_entrada)", conexion)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            comando.Parameters.Add("@id", SqlDbType.Int).Value = ind
            comando.Parameters.Add("@f_entrada", SqlDbType.DateTime).Value = DateTime.Now
            comando.Parameters.Add("@id_persona", SqlDbType.Int).Value = id_p
            comando.Parameters.Add("@e_entrada", SqlDbType.Int).Value = get_id_edificio(ComboBox.Text.Trim())
            adaptador.Fill(tabla)

        Else
            Dim comando As New SqlCommand("INSERT INTO Registros(id, f_entrada, " & insertar_a & ", motivo, e_entrada) VALUES(@id, @f_entrada, @id_persona, @motivo, @e_entrada)", conexion)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            comando.Parameters.Add("@id", SqlDbType.Int).Value = ind
            comando.Parameters.Add("@f_entrada", SqlDbType.DateTime).Value = DateTime.Now
            comando.Parameters.Add("@id_persona", SqlDbType.Int).Value = id_p
            comando.Parameters.Add("@motivo", SqlDbType.NChar).Value = motivo
            comando.Parameters.Add("@e_entrada", SqlDbType.Int).Value = get_id_edificio(Form3.getCombobox2.Trim())
            adaptador.Fill(tabla)

        End If



    End Function

    Public Function consultar(id_p As String, consultar_a As String) As Boolean
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim comando As New SqlCommand("SELECT * FROM Registros WHERE " & consultar_a & " = " & id_p & "AND f_salida IS NULL", conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            'El trabajador tiene un registro abierto
            Return True
        Else
            'El trabajador NO tiene un registro abierto
            Return False
        End If

    End Function

    'cerrar registro
    Public Function cerrrar_registro(id_p As String, cerrar_a As String, tipo As String)

        If (tipo = "trabajador") Then
            Dim conexion As New SqlConnection(My.Settings.conexion)
            Dim comando As New SqlCommand("UPDATE Registros
                                           SET f_salida = @f_salida, duracion = @duracion , e_salida = @e_salida
                                           FROM Registros
                                           WHERE " + cerrar_a & " = " & id_p + "AND f_salida IS NULL", conexion)

            comando.Parameters.Add("@f_salida", SqlDbType.DateTime).Value = DateTime.Now
            comando.Parameters.Add("@duracion", SqlDbType.Float).Value = Math.Round(DateTime.Now.Subtract(obtener_f_entrada(id_p, cerrar_a)).Days * 24 + DateTime.Now.Subtract(obtener_f_entrada(id_p, cerrar_a)).Hours + DateTime.Now.Subtract(obtener_f_entrada(id_p, cerrar_a)).Minutes / 60, 4, MidpointRounding.ToEven)
            comando.Parameters.Add("@e_salida", SqlDbType.Int).Value = get_id_edificio(ComboBox.Text.Trim())

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

        Else
            Dim conexion As New SqlConnection(My.Settings.conexion)
            Dim comando As New SqlCommand("UPDATE Registros
                                           SET f_salida = @f_salida, duracion = @duracion , e_salida = @e_salida
                                           FROM Registros
                                           WHERE " + cerrar_a & " = " & id_p + "AND f_salida IS NULL", conexion)

            comando.Parameters.Add("@f_salida", SqlDbType.DateTime).Value = DateTime.Now
            comando.Parameters.Add("@duracion", SqlDbType.Float).Value = Math.Round(DateTime.Now.Subtract(obtener_f_entrada(id_p, cerrar_a)).Days * 24 + DateTime.Now.Subtract(obtener_f_entrada(id_p, cerrar_a)).Hours + DateTime.Now.Subtract(obtener_f_entrada(id_p, cerrar_a)).Minutes / 60, 4, MidpointRounding.ToEven)
            comando.Parameters.Add("@e_salida", SqlDbType.Int).Value = get_id_edificio(Form3.getCombobox2.Trim())

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

        End If


    End Function

    'obtener entrada del registro
    Public Function obtener_f_entrada(id_p As String, buscar_a As String) As DateTime
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim comando As New SqlCommand("SELECT * FROM Registros WHERE " & buscar_a & " = " & id_p & "AND f_salida IS NULL", conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        Dim fecha As DateTime = tabla.Rows(0)(1)
        Return fecha

    End Function

    Public Function extraer_datos_visitas()
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "SELECT f_entrada, Visitantes.dni, Visitantes.organizacion
                             FROM Registros, Visitantes
                             WHERE f_salida IS NULL AND Registros.id_visitante = Visitantes.id"

        Dim comando As New SqlCommand(sql)
        Dim adaptador As New SqlDataAdapter(comando)
        comando.Connection = conexion
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

        Dim tabla As New DataTable()
        adaptador.Fill(tabla)

        Mensaje = Mensaje & "VISITANTES" & vbCr & vbCr
        Mensaje = Mensaje & "Fecha de entrada" & "               " & "DNI" & "                                " & "Organizacion" & vbCr

        tabla_toString(tabla)

    End Function

    Public Function extraer_datos_empleados()
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "SELECT f_entrada, Trabajadores.nombre, Trabajadores.codigo
                             FROM Registros, Trabajadores
                             WHERE f_salida IS NULL AND Registros.id_trabajador = Trabajadores.id"

        Dim comando As New SqlCommand(sql)
        Dim adaptador As New SqlDataAdapter(comando)
        comando.Connection = conexion
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

        Dim tabla As New DataTable()
        adaptador.Fill(tabla)

        Mensaje = Mensaje & "TRABAJADORES" & vbCr & vbCr
        Mensaje = Mensaje & "Fecha de entrada" & "               " & "Nombre" & "                   " & "Codigo interno" & vbCr

        tabla_toString(tabla)

    End Function

    Public Function tabla_toString(tabla As DataTable)
        For i As Integer = 0 To tabla.Rows.Count - 1
            For j As Integer = 0 To tabla.Columns.Count - 1
                Mensaje = Mensaje & Convert.ToString(tabla.Rows(i)(j) & "         ")
            Next
            Mensaje = Mensaje & vbCrLf
        Next
        Mensaje = Mensaje & vbCrLf & vbCrLf

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            ComboBox.Items.Add(tabla.Rows(i)(0))
        Next

    End Sub

    Public Function get_id_edificio(texto As String) As String
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "SELECT id
                             FROM Edificios 
                             WHERE Edificios.nombre = '" & texto & "'"

        Dim comando As New SqlCommand(sql)
        Dim adaptador As New SqlDataAdapter(comando)
        comando.Connection = conexion
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        Return tabla.Rows(0)(0)

    End Function

    Private Sub B_visita_Click(sender As Object, e As EventArgs) Handles B_visita.Click
        Form2.Show()

    End Sub

    Private Sub B_g_visitas_Click(sender As Object, e As EventArgs) Handles B_g_visitas.Click
        Form3.Show()

    End Sub

    Private Sub B_lista_personas_Click(sender As Object, e As EventArgs) Handles B_lista_personas.Click
        Form4.Show()

    End Sub

    Private Sub B_historial_Click(sender As Object, e As EventArgs) Handles B_historial.Click
        Form5.Show()

    End Sub

    Private Sub B_alarma_Click(sender As Object, e As EventArgs) Handles B_alarma.Click
        Mensaje = ""
        extraer_datos_visitas()
        extraer_datos_empleados()

        MessageBox.Show(Mensaje)
        'enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String)
        enviarCorreo("kcorreo19@gmail.com", "alcornoke19", Mensaje, "Alarma activada edificio", "kcorreo19@gmail.com", "")

    End Sub

    Private Sub B_m_edificios_Click(sender As Object, e As EventArgs) Handles b_m_edificios.Click
        Form6.Show()

    End Sub

    Private Sub B_copia_seg_Click(sender As Object, e As EventArgs) Handles B_copia_seg.Click
        Dim conexion As New SqlConnection(My.Settings.conexion)
        Dim nombre_BBDD_copia As String = (Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & "," & Date.Now.Hour.ToString & "-" & Date.Now.Minute.ToString & "-" & Date.Now.Second.ToString)

        Me.FolderBrowserDialog1.ShowDialog()
        Dim ruta As String = Me.FolderBrowserDialog1.SelectedPath

        Dim sql As String = "BACKUP DATABASE [Control_organizacion] TO  DISK = N'" & ruta & "\" & nombre_BBDD_copia & ".bak' 
                             WITH NOFORMAT, NOINIT,  NAME = N'Control_organizacion-Completa Base de datos Copia de seguridad', 
                             SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

        Dim comando As New SqlCommand(sql)
        comando.Connection = conexion

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()

            MessageBox.Show("Copia realizada correctamente")

        Catch ex As Exception
            MessageBox.Show("Error al realizar la copia, directorio incorrecto")

        End Try

    End Sub

    Private Sub B_e_copia_Click(sender As Object, e As EventArgs) Handles B_e_copia.Click
        Form7.Show()

    End Sub
End Class

