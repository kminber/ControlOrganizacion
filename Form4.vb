Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Form4
    Sub New()

        InitializeComponent()
        Form4_sql.Fill()
        Form4_sql.Fill()

    End Sub

    Private Sub B_actualizar_Click(sender As Object, e As EventArgs) Handles B_actualizar.Click
        Form4_sql.Fill()

    End Sub

    Private Sub B_volver_Click(sender As Object, e As EventArgs) Handles B_volver.Click
        Me.Hide()

    End Sub

    Private Sub B_i_ventana_Click(sender As Object, e As EventArgs) Handles B_i_ventana.Click
        Dim vista_documento As New PrintPreviewDialog
        Dim captura As New PrintDocument
        captura.DefaultPageSettings.Landscape = True
        captura.DocumentName = "Lista de personas"
        AddHandler captura.PrintPage, AddressOf OnPrintPage
        vista_documento.Document = captura
        vista_documento.ShowDialog()

    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        'Crea el mapa de bits
        Dim mb As Bitmap = New Bitmap(Me.Width, Me.Height)

        'Dibuja el formulario en mapa de bits
        DrawToBitmap(mb, New Rectangle(0, 0, Me.Width, Me.Width))

        'Dibuja la imagen especificada en las coordenadas
        e.Graphics.DrawImage(mb, 0, 0, Me.Width, Me.Height)

    End Sub

End Class

'Public Function lista_trabajadores()
'Dim conexion As New SqlConnection(My.Settings.Conexion)
'im sql As String = "use Control_organizacion
'                             SELECT f_entrada, Trabajadores.nombre, Trabajadores.codigo
'                             FROM Registros, Trabajadores
'                             WHERE f_salida IS NULL AND Registros.id_trabajador = Trabajadores.id"
'
'Dim comando As New SqlCommand(sql)

'comando.Connection = conexion
'conexion.Open()
'comando.ExecuteNonQuery()
'conexion.Close()

'Dim tabla As New SqlDataAdapter(comando)
'Dim ds As New DataSet
'bla.Fill(ds, "Trabajadores")

'Me.DataGridView_Trabajadores.DataSource = ds.Tables("Trabajadores")

'End Function

'Public Function lista_visitantes()
'Dim conexion As New SqlConnection(My.Settings.Conexion)
'Dim sql As String = "use Control_organizacion
'                            SELECT f_entrada, Visitantes.dni, Visitantes.organizacion, Visitantes.motivo
'                            FROM Registros, Visitantes
'                            WHERE f_salida IS NULL AND Registros.id_visitante = Visitantes.id"

'Dim comando As New SqlCommand(sql, conexion)
'Dim tabla As New SqlDataAdapter(comando)
'Dim ds As New DataSet
'tabla.Fill(ds, "Visitantes")
'Me.DataGridView_Visitantes.DataSource = ds.Tables("Visitantes")

'End Function