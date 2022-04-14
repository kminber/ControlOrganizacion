Imports System.Data.SqlClient

Public Class Form5
    Sub New()
        InitializeComponent()
        Form5_sql.Fill()

    End Sub

    Private Sub B_volver_Click(sender As Object, e As EventArgs) Handles B_volver.Click
        Me.Hide()

    End Sub

    Private Sub B_actualizar_Click(sender As Object, e As EventArgs) Handles B_actualizar.Click
        Form5_sql.Fill()

    End Sub
End Class

