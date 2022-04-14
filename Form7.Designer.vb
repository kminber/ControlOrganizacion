<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.TX_emisor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TX_para = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_pwd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TX_asunto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TX_adjuntar = New System.Windows.Forms.TextBox()
        Me.B_adjuntar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TX_texto = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.B_enviar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TX_emisor
        '
        Me.TX_emisor.Location = New System.Drawing.Point(102, 47)
        Me.TX_emisor.Name = "TX_emisor"
        Me.TX_emisor.Size = New System.Drawing.Size(144, 20)
        Me.TX_emisor.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Emisor"
        '
        'TX_para
        '
        Me.TX_para.Location = New System.Drawing.Point(102, 94)
        Me.TX_para.Name = "TX_para"
        Me.TX_para.Size = New System.Drawing.Size(144, 20)
        Me.TX_para.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Para"
        '
        'TX_pwd
        '
        Me.TX_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_pwd.Location = New System.Drawing.Point(428, 47)
        Me.TX_pwd.Name = "TX_pwd"
        Me.TX_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TX_pwd.Size = New System.Drawing.Size(144, 20)
        Me.TX_pwd.TabIndex = 15
        Me.TX_pwd.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Asunto"
        '
        'TX_asunto
        '
        Me.TX_asunto.Location = New System.Drawing.Point(428, 94)
        Me.TX_asunto.Name = "TX_asunto"
        Me.TX_asunto.Size = New System.Drawing.Size(144, 20)
        Me.TX_asunto.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Adjuntar"
        '
        'TX_adjuntar
        '
        Me.TX_adjuntar.Location = New System.Drawing.Point(102, 150)
        Me.TX_adjuntar.Name = "TX_adjuntar"
        Me.TX_adjuntar.Size = New System.Drawing.Size(470, 20)
        Me.TX_adjuntar.TabIndex = 20
        '
        'B_adjuntar
        '
        Me.B_adjuntar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_adjuntar.Location = New System.Drawing.Point(608, 151)
        Me.B_adjuntar.Name = "B_adjuntar"
        Me.B_adjuntar.Size = New System.Drawing.Size(42, 19)
        Me.B_adjuntar.TabIndex = 21
        Me.B_adjuntar.Text = "..."
        Me.B_adjuntar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Texto"
        '
        'TX_texto
        '
        Me.TX_texto.Location = New System.Drawing.Point(102, 208)
        Me.TX_texto.Multiline = True
        Me.TX_texto.Name = "TX_texto"
        Me.TX_texto.Size = New System.Drawing.Size(470, 76)
        Me.TX_texto.TabIndex = 23
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'B_enviar
        '
        Me.B_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_enviar.Location = New System.Drawing.Point(195, 305)
        Me.B_enviar.Name = "B_enviar"
        Me.B_enviar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.B_enviar.Size = New System.Drawing.Size(102, 31)
        Me.B_enviar.TabIndex = 24
        Me.B_enviar.Text = "Enviar"
        Me.B_enviar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(379, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 364)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B_enviar)
        Me.Controls.Add(Me.TX_texto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.B_adjuntar)
        Me.Controls.Add(Me.TX_adjuntar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TX_asunto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TX_pwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_para)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TX_emisor)
        Me.Name = "Form7"
        Me.Text = "Enviar base de datos por correo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TX_emisor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TX_para As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TX_pwd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TX_asunto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TX_adjuntar As TextBox
    Friend WithEvents B_adjuntar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TX_texto As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents B_enviar As Button
    Friend WithEvents Button1 As Button
End Class
