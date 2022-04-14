<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DNI = New System.Windows.Forms.Label()
        Me.TX_DNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_volver = New System.Windows.Forms.Button()
        Me.B_registro = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'DNI
        '
        Me.DNI.AutoSize = True
        Me.DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNI.Location = New System.Drawing.Point(33, 73)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(126, 16)
        Me.DNI.TabIndex = 5
        Me.DNI.Text = "Inserta DNI visitante"
        '
        'TX_DNI
        '
        Me.TX_DNI.Location = New System.Drawing.Point(179, 73)
        Me.TX_DNI.Name = "TX_DNI"
        Me.TX_DNI.Size = New System.Drawing.Size(143, 20)
        Me.TX_DNI.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Registro de visita"
        '
        'B_volver
        '
        Me.B_volver.Location = New System.Drawing.Point(361, 200)
        Me.B_volver.Name = "B_volver"
        Me.B_volver.Size = New System.Drawing.Size(103, 36)
        Me.B_volver.TabIndex = 14
        Me.B_volver.Text = "Volver"
        Me.B_volver.UseVisualStyleBackColor = True
        '
        'B_registro
        '
        Me.B_registro.Location = New System.Drawing.Point(198, 200)
        Me.B_registro.Name = "B_registro"
        Me.B_registro.Size = New System.Drawing.Size(103, 36)
        Me.B_registro.TabIndex = 15
        Me.B_registro.Text = "Abrir / Cerrar registro"
        Me.B_registro.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(178, 124)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Punto de acceso"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 284)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.B_registro)
        Me.Controls.Add(Me.B_volver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TX_DNI)
        Me.Controls.Add(Me.DNI)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Registro visita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DNI As Label
    Friend WithEvents TX_DNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents B_volver As Button
    Friend WithEvents B_registro As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
End Class
