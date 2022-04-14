<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DNI = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TX_DNI = New System.Windows.Forms.TextBox()
        Me.TX_organizacion = New System.Windows.Forms.TextBox()
        Me.TX_visita_a = New System.Windows.Forms.TextBox()
        Me.TX_motivo = New System.Windows.Forms.TextBox()
        Me.B_registrar = New System.Windows.Forms.Button()
        Me.B_volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registro de visitantes"
        '
        'DNI
        '
        Me.DNI.AutoSize = True
        Me.DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNI.Location = New System.Drawing.Point(28, 88)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(31, 16)
        Me.DNI.TabIndex = 4
        Me.DNI.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Organización"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Visita a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Motivo"
        '
        'TX_DNI
        '
        Me.TX_DNI.Location = New System.Drawing.Point(122, 84)
        Me.TX_DNI.Name = "TX_DNI"
        Me.TX_DNI.Size = New System.Drawing.Size(100, 20)
        Me.TX_DNI.TabIndex = 8
        '
        'TX_organizacion
        '
        Me.TX_organizacion.Location = New System.Drawing.Point(428, 84)
        Me.TX_organizacion.Name = "TX_organizacion"
        Me.TX_organizacion.Size = New System.Drawing.Size(100, 20)
        Me.TX_organizacion.TabIndex = 9
        '
        'TX_visita_a
        '
        Me.TX_visita_a.Location = New System.Drawing.Point(122, 123)
        Me.TX_visita_a.Name = "TX_visita_a"
        Me.TX_visita_a.Size = New System.Drawing.Size(100, 20)
        Me.TX_visita_a.TabIndex = 10
        '
        'TX_motivo
        '
        Me.TX_motivo.Location = New System.Drawing.Point(428, 123)
        Me.TX_motivo.Name = "TX_motivo"
        Me.TX_motivo.Size = New System.Drawing.Size(100, 20)
        Me.TX_motivo.TabIndex = 11
        '
        'B_registrar
        '
        Me.B_registrar.Location = New System.Drawing.Point(122, 179)
        Me.B_registrar.Name = "B_registrar"
        Me.B_registrar.Size = New System.Drawing.Size(103, 36)
        Me.B_registrar.TabIndex = 12
        Me.B_registrar.Text = "Registrar"
        Me.B_registrar.UseVisualStyleBackColor = True
        '
        'B_volver
        '
        Me.B_volver.Location = New System.Drawing.Point(425, 179)
        Me.B_volver.Name = "B_volver"
        Me.B_volver.Size = New System.Drawing.Size(103, 36)
        Me.B_volver.TabIndex = 13
        Me.B_volver.Text = "Volver"
        Me.B_volver.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 258)
        Me.Controls.Add(Me.B_volver)
        Me.Controls.Add(Me.B_registrar)
        Me.Controls.Add(Me.TX_motivo)
        Me.Controls.Add(Me.TX_visita_a)
        Me.Controls.Add(Me.TX_organizacion)
        Me.Controls.Add(Me.TX_DNI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DNI)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Reistro de visita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DNI As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TX_DNI As TextBox
    Friend WithEvents TX_organizacion As TextBox
    Friend WithEvents TX_visita_a As TextBox
    Friend WithEvents TX_motivo As TextBox
    Friend WithEvents B_registrar As Button
    Friend WithEvents B_volver As Button
End Class
