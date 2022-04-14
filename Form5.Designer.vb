<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.B_volver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Form5_sql = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Control_organizacionDataSet1 = New Control_organizacion.Control_organizacionDataSet()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.listarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colf_entrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colf_salida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTrabajador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisitante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.B_actualizar = New System.Windows.Forms.Button()
        CType(Me.Control_organizacionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_volver
        '
        Me.B_volver.Location = New System.Drawing.Point(323, 343)
        Me.B_volver.Name = "B_volver"
        Me.B_volver.Size = New System.Drawing.Size(103, 36)
        Me.B_volver.TabIndex = 16
        Me.B_volver.Text = "Volver"
        Me.B_volver.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Lista de registros"
        '
        'Form5_sql
        '
        Me.Form5_sql.ConnectionName = "Control_organizacion.My.MySettings.Conexion"
        Me.Form5_sql.Name = "Form5_sql"
        CustomSqlQuery1.Name = "Listar"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.Form5_sql.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.Form5_sql.ResultSchemaSerializable = resources.GetString("Form5_sql.ResultSchemaSerializable")
        '
        'Control_organizacionDataSet1
        '
        Me.Control_organizacionDataSet1.DataSetName = "Control_organizacionDataSet"
        Me.Control_organizacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.listarBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(30, 49)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(857, 277)
        Me.GridControl1.TabIndex = 29
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'listarBindingSource
        '
        Me.listarBindingSource.DataMember = "Listar"
        Me.listarBindingSource.DataSource = Me.Form5_sql
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.BorderColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.Options.UseBorderColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colf_entrada, Me.colEntrada, Me.colf_salida, Me.colSalida, Me.colHoras, Me.colMotivo, Me.colTrabajador, Me.colVisitante})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'colf_entrada
        '
        Me.colf_entrada.FieldName = "f_entrada"
        Me.colf_entrada.Name = "colf_entrada"
        Me.colf_entrada.Visible = True
        Me.colf_entrada.VisibleIndex = 0
        '
        'colEntrada
        '
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.Visible = True
        Me.colEntrada.VisibleIndex = 1
        '
        'colf_salida
        '
        Me.colf_salida.FieldName = "f_salida"
        Me.colf_salida.Name = "colf_salida"
        Me.colf_salida.Visible = True
        Me.colf_salida.VisibleIndex = 2
        '
        'colSalida
        '
        Me.colSalida.FieldName = "Salida"
        Me.colSalida.Name = "colSalida"
        Me.colSalida.Visible = True
        Me.colSalida.VisibleIndex = 3
        '
        'colHoras
        '
        Me.colHoras.FieldName = "Horas"
        Me.colHoras.Name = "colHoras"
        Me.colHoras.Visible = True
        Me.colHoras.VisibleIndex = 4
        '
        'colMotivo
        '
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 5
        '
        'colTrabajador
        '
        Me.colTrabajador.FieldName = "Trabajador"
        Me.colTrabajador.Name = "colTrabajador"
        Me.colTrabajador.Visible = True
        Me.colTrabajador.VisibleIndex = 6
        '
        'colVisitante
        '
        Me.colVisitante.FieldName = "Visitante"
        Me.colVisitante.Name = "colVisitante"
        Me.colVisitante.Visible = True
        Me.colVisitante.VisibleIndex = 7
        '
        'B_actualizar
        '
        Me.B_actualizar.Location = New System.Drawing.Point(508, 343)
        Me.B_actualizar.Name = "B_actualizar"
        Me.B_actualizar.Size = New System.Drawing.Size(103, 36)
        Me.B_actualizar.TabIndex = 30
        Me.B_actualizar.Text = "Actualizar"
        Me.B_actualizar.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 397)
        Me.Controls.Add(Me.B_actualizar)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_volver)
        Me.Name = "Form5"
        Me.Text = "Historial de registros"
        CType(Me.Control_organizacionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_volver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Form5_sql As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Control_organizacionDataSet1 As Control_organizacionDataSet
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents listarBindingSource As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colf_entrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colf_salida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrabajador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisitante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_actualizar As Button
End Class
