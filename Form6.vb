Imports System.Data.SqlClient

Public Class Form6
    Sub New()

        InitializeComponent()
        Form6_sql.Fill()

    End Sub

    Private Sub B_volver_Click(sender As Object, e As EventArgs) Handles B_volver.Click
        Me.Hide()

    End Sub

End Class

