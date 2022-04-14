<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery7 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim CustomSqlQuery8 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_volver = New System.Windows.Forms.Button()
        Me.B_i_ventana = New System.Windows.Forms.Button()
        Me.B_actualizar = New System.Windows.Forms.Button()
        Me.Form4_sql = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DashboardDesigner1 = New DevExpress.DashboardWin.DashboardDesigner()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colf_entrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colorganizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmotivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colf_entrada1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DashboardDesigner1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Lista de trabajadores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Lista de visitantes"
        '
        'B_volver
        '
        Me.B_volver.Location = New System.Drawing.Point(218, 303)
        Me.B_volver.Name = "B_volver"
        Me.B_volver.Size = New System.Drawing.Size(103, 36)
        Me.B_volver.TabIndex = 15
        Me.B_volver.Text = "Volver"
        Me.B_volver.UseVisualStyleBackColor = True
        '
        'B_i_ventana
        '
        Me.B_i_ventana.Location = New System.Drawing.Point(560, 303)
        Me.B_i_ventana.Name = "B_i_ventana"
        Me.B_i_ventana.Size = New System.Drawing.Size(103, 36)
        Me.B_i_ventana.TabIndex = 20
        Me.B_i_ventana.Text = "Imprimir ventana"
        Me.B_i_ventana.UseVisualStyleBackColor = True
        '
        'B_actualizar
        '
        Me.B_actualizar.Location = New System.Drawing.Point(387, 303)
        Me.B_actualizar.Name = "B_actualizar"
        Me.B_actualizar.Size = New System.Drawing.Size(103, 36)
        Me.B_actualizar.TabIndex = 21
        Me.B_actualizar.Text = "Actualizar"
        Me.B_actualizar.UseVisualStyleBackColor = True
        '
        'Form4_sql
        '
        Me.Form4_sql.ConnectionName = "Control_organizacion.My.MySettings.Conexion"
        Me.Form4_sql.Name = "Form4_sql"
        CustomSqlQuery7.Name = "Trabajadores"
        CustomSqlQuery7.Sql = "SELECT f_entrada, Trabajadores.nombre, Trabajadores.codigo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM Registros, Trab" &
    "ajadores WHERE f_salida IS NULL AND Registros.id_trabajador = Trabajadores.id"
        CustomSqlQuery8.Name = "Visitantes"
        CustomSqlQuery8.Sql = "SELECT f_entrada, Visitantes.dni, Visitantes.organizacion, Visitantes.motivo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FRO" &
    "M Registros, Visitantes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE f_salida IS NULL AND Registros.id_visitante = Vis" &
    "itantes.id" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Form4_sql.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery7, CustomSqlQuery8})
        Me.Form4_sql.ResultSchemaSerializable = resources.GetString("Form4_sql.ResultSchemaSerializable")
        '
        'DashboardDesigner1
        '
        Me.DashboardDesigner1.AllowMaximizeAnimation = True
        Me.DashboardDesigner1.AllowMaximizeDashboardItems = True
        Me.DashboardDesigner1.AllowPrintDashboard = True
        Me.DashboardDesigner1.AllowPrintDashboardItems = True
        Me.DashboardDesigner1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardDesigner1.Name = "DashboardDesigner1"
        Me.DashboardDesigner1.Size = New System.Drawing.Size(744, 522)
        Me.DashboardDesigner1.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Visitantes"
        Me.GridControl2.DataSource = Me.Form4_sql
        Me.GridControl2.Location = New System.Drawing.Point(450, 49)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(400, 224)
        Me.GridControl2.TabIndex = 23
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colf_entrada, Me.coldni, Me.colorganizacion, Me.colmotivo})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colf_entrada
        '
        Me.colf_entrada.Caption = "Fecha de entrada"
        Me.colf_entrada.FieldName = "f_entrada"
        Me.colf_entrada.Name = "colf_entrada"
        Me.colf_entrada.Visible = True
        Me.colf_entrada.VisibleIndex = 0
        '
        'coldni
        '
        Me.coldni.Caption = "DNI"
        Me.coldni.FieldName = "dni"
        Me.coldni.Name = "coldni"
        Me.coldni.Visible = True
        Me.coldni.VisibleIndex = 1
        '
        'colorganizacion
        '
        Me.colorganizacion.Caption = "Organización"
        Me.colorganizacion.FieldName = "organizacion"
        Me.colorganizacion.Name = "colorganizacion"
        Me.colorganizacion.Visible = True
        Me.colorganizacion.VisibleIndex = 2
        '
        'colmotivo
        '
        Me.colmotivo.Caption = "Motivo"
        Me.colmotivo.FieldName = "motivo"
        Me.colmotivo.Name = "colmotivo"
        Me.colmotivo.Visible = True
        Me.colmotivo.VisibleIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Trabajadores"
        Me.GridControl1.DataSource = Me.Form4_sql
        Me.GridControl1.Location = New System.Drawing.Point(26, 49)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(400, 224)
        Me.GridControl1.TabIndex = 24
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colf_entrada1, Me.colnombre, Me.colcodigo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colf_entrada1
        '
        Me.colf_entrada1.Caption = "Fecha de entrada"
        Me.colf_entrada1.FieldName = "f_entrada"
        Me.colf_entrada1.Name = "colf_entrada1"
        Me.colf_entrada1.Visible = True
        Me.colf_entrada1.VisibleIndex = 0
        '
        'colnombre
        '
        Me.colnombre.Caption = "Nombre"
        Me.colnombre.FieldName = "nombre"
        Me.colnombre.Name = "colnombre"
        Me.colnombre.Visible = True
        Me.colnombre.VisibleIndex = 1
        '
        'colcodigo
        '
        Me.colcodigo.Caption = "Código"
        Me.colcodigo.FieldName = "codigo"
        Me.colcodigo.Name = "colcodigo"
        Me.colcodigo.Visible = True
        Me.colcodigo.VisibleIndex = 2
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "f_entrada"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "organizacion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 362)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.B_actualizar)
        Me.Controls.Add(Me.B_i_ventana)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_volver)
        Me.Name = "Form4"
        Me.Text = "Lista de presonas presentes en la organización"
        CType(Me.DashboardDesigner1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents B_volver As Button
    Friend WithEvents B_i_ventana As Button
    Friend WithEvents B_actualizar As Button
    Friend WithEvents Form4_sql As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents DashboardDesigner1 As DevExpress.DashboardWin.DashboardDesigner
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colf_entrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorganizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colf_entrada1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
