<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_volver = New System.Windows.Forms.Button()
        Me.Form6_sql = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnombre = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Lista de puntos de acceso"
        '
        'B_volver
        '
        Me.B_volver.Location = New System.Drawing.Point(185, 311)
        Me.B_volver.Name = "B_volver"
        Me.B_volver.Size = New System.Drawing.Size(103, 36)
        Me.B_volver.TabIndex = 20
        Me.B_volver.Text = "Volver"
        Me.B_volver.UseVisualStyleBackColor = True
        '
        'Form6_sql
        '
        Me.Form6_sql.ConnectionName = "localhost_Control_organizacion_Connection"
        Me.Form6_sql.Name = "Form6_sql"
        CustomSqlQuery2.Name = "Query"
        CustomSqlQuery2.Sql = "SELECT id, nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM Edificios"
        Me.Form6_sql.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery2})
        Me.Form6_sql.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iRm9ybTZfc3FsIj48VmlldyBOYW1lPSJRdWVyeSI+PEZpZWxkIE5hbWU9ImlkI" &
    "iBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0ibm9tYnJlIiBUeXBlPSJTdHJpbmciIC8+PC9WaWV3P" &
    "jwvRGF0YVNldD4="
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Query"
        Me.GridControl1.DataSource = Me.Form6_sql
        Me.GridControl1.Location = New System.Drawing.Point(52, 61)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(385, 234)
        Me.GridControl1.TabIndex = 21
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colnombre})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'colid
        '
        Me.colid.Caption = "Edificio"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        Me.colid.Width = 73
        '
        'colnombre
        '
        Me.colnombre.Caption = "Nombre"
        Me.colnombre.FieldName = "nombre"
        Me.colnombre.Name = "colnombre"
        Me.colnombre.Visible = True
        Me.colnombre.VisibleIndex = 1
        Me.colnombre.Width = 309
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 373)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.B_volver)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form6"
        Me.Text = "Listar edificios"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents B_volver As Button
    Friend WithEvents Form6_sql As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombre As DevExpress.XtraGrid.Columns.GridColumn
End Class
