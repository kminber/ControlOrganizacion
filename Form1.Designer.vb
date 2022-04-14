<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBox_insertar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_insertar = New System.Windows.Forms.Button()
        Me.B_visita = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_g_visitas = New System.Windows.Forms.Button()
        Me.B_lista_personas = New System.Windows.Forms.Button()
        Me.B_historial = New System.Windows.Forms.Button()
        Me.B_alarma = New System.Windows.Forms.Button()
        Me.DNI = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.b_m_edificios = New System.Windows.Forms.Button()
        Me.B_copia_seg = New System.Windows.Forms.Button()
        Me.B_e_copia = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'TextBox_insertar
        '
        Me.TextBox_insertar.Location = New System.Drawing.Point(188, 59)
        Me.TextBox_insertar.Name = "TextBox_insertar"
        Me.TextBox_insertar.Size = New System.Drawing.Size(144, 20)
        Me.TextBox_insertar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'B_insertar
        '
        Me.B_insertar.Location = New System.Drawing.Point(213, 149)
        Me.B_insertar.Name = "B_insertar"
        Me.B_insertar.Size = New System.Drawing.Size(98, 31)
        Me.B_insertar.TabIndex = 3
        Me.B_insertar.Text = "Insertar código"
        Me.B_insertar.UseVisualStyleBackColor = True
        '
        'B_visita
        '
        Me.B_visita.Location = New System.Drawing.Point(51, 209)
        Me.B_visita.Name = "B_visita"
        Me.B_visita.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_visita.Size = New System.Drawing.Size(102, 31)
        Me.B_visita.TabIndex = 4
        Me.B_visita.Text = "Registrar visitante"
        Me.B_visita.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lector de códigos de barras"
        '
        'B_g_visitas
        '
        Me.B_g_visitas.Location = New System.Drawing.Point(51, 269)
        Me.B_g_visitas.Name = "B_g_visitas"
        Me.B_g_visitas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_g_visitas.Size = New System.Drawing.Size(102, 31)
        Me.B_g_visitas.TabIndex = 6
        Me.B_g_visitas.Text = "Gestionar visitas"
        Me.B_g_visitas.UseVisualStyleBackColor = True
        '
        'B_lista_personas
        '
        Me.B_lista_personas.Location = New System.Drawing.Point(366, 209)
        Me.B_lista_personas.Name = "B_lista_personas"
        Me.B_lista_personas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_lista_personas.Size = New System.Drawing.Size(149, 31)
        Me.B_lista_personas.TabIndex = 7
        Me.B_lista_personas.Text = "Mostrar personas presentes"
        Me.B_lista_personas.UseVisualStyleBackColor = True
        '
        'B_historial
        '
        Me.B_historial.Location = New System.Drawing.Point(366, 269)
        Me.B_historial.Name = "B_historial"
        Me.B_historial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_historial.Size = New System.Drawing.Size(149, 31)
        Me.B_historial.TabIndex = 8
        Me.B_historial.Text = "Mostrar historial de registros"
        Me.B_historial.UseVisualStyleBackColor = True
        '
        'B_alarma
        '
        Me.B_alarma.BackColor = System.Drawing.Color.Red
        Me.B_alarma.ForeColor = System.Drawing.Color.Black
        Me.B_alarma.Location = New System.Drawing.Point(213, 269)
        Me.B_alarma.Name = "B_alarma"
        Me.B_alarma.Size = New System.Drawing.Size(98, 31)
        Me.B_alarma.TabIndex = 9
        Me.B_alarma.Text = "Alarma"
        Me.B_alarma.UseVisualStyleBackColor = False
        '
        'DNI
        '
        Me.DNI.AutoSize = True
        Me.DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNI.Location = New System.Drawing.Point(48, 60)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(92, 16)
        Me.DNI.TabIndex = 10
        Me.DNI.Text = "Código tarjeta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Punto de acceso"
        '
        'ComboBox
        '
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(188, 100)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox.TabIndex = 12
        '
        'b_m_edificios
        '
        Me.b_m_edificios.Location = New System.Drawing.Point(188, 209)
        Me.b_m_edificios.Name = "b_m_edificios"
        Me.b_m_edificios.Size = New System.Drawing.Size(144, 31)
        Me.b_m_edificios.TabIndex = 13
        Me.b_m_edificios.Text = "Mostrar puntos de acceso"
        Me.b_m_edificios.UseVisualStyleBackColor = True
        '
        'B_copia_seg
        '
        Me.B_copia_seg.Location = New System.Drawing.Point(51, 329)
        Me.B_copia_seg.Name = "B_copia_seg"
        Me.B_copia_seg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_copia_seg.Size = New System.Drawing.Size(102, 41)
        Me.B_copia_seg.TabIndex = 14
        Me.B_copia_seg.Text = "Realizar copia de seguridad"
        Me.B_copia_seg.UseVisualStyleBackColor = True
        '
        'B_e_copia
        '
        Me.B_e_copia.Location = New System.Drawing.Point(366, 329)
        Me.B_e_copia.Name = "B_e_copia"
        Me.B_e_copia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_e_copia.Size = New System.Drawing.Size(149, 31)
        Me.B_e_copia.TabIndex = 15
        Me.B_e_copia.Text = "Enviar copia de seguridad"
        Me.B_e_copia.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 395)
        Me.Controls.Add(Me.B_e_copia)
        Me.Controls.Add(Me.B_copia_seg)
        Me.Controls.Add(Me.b_m_edificios)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DNI)
        Me.Controls.Add(Me.B_alarma)
        Me.Controls.Add(Me.B_historial)
        Me.Controls.Add(Me.B_lista_personas)
        Me.Controls.Add(Me.B_g_visitas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_visita)
        Me.Controls.Add(Me.B_insertar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_insertar)
        Me.Name = "Form1"
        Me.Text = "Lector de códigos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_insertar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents B_insertar As Button
    Friend WithEvents B_visita As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents B_g_visitas As Button
    Friend WithEvents B_lista_personas As Button
    Friend WithEvents B_historial As Button
    Friend WithEvents B_alarma As Button
    Friend WithEvents DNI As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents b_m_edificios As Button
    Friend WithEvents B_copia_seg As Button
    Friend WithEvents B_e_copia As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
