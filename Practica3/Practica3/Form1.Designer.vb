<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.materia1 = New System.Windows.Forms.TextBox()
        Me.materia5 = New System.Windows.Forms.TextBox()
        Me.materia4 = New System.Windows.Forms.TextBox()
        Me.materia3 = New System.Windows.Forms.TextBox()
        Me.materia2 = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad y Cultura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matemáticas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Laboratorio de Medios y Tecnología IV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inglés IV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Orientación Vocacional II"
        '
        'materia1
        '
        Me.materia1.Location = New System.Drawing.Point(309, 23)
        Me.materia1.Name = "materia1"
        Me.materia1.Size = New System.Drawing.Size(100, 20)
        Me.materia1.TabIndex = 5
        '
        'materia5
        '
        Me.materia5.Location = New System.Drawing.Point(309, 157)
        Me.materia5.Name = "materia5"
        Me.materia5.Size = New System.Drawing.Size(100, 20)
        Me.materia5.TabIndex = 6
        '
        'materia4
        '
        Me.materia4.Location = New System.Drawing.Point(309, 124)
        Me.materia4.Name = "materia4"
        Me.materia4.Size = New System.Drawing.Size(100, 20)
        Me.materia4.TabIndex = 7
        '
        'materia3
        '
        Me.materia3.Location = New System.Drawing.Point(309, 90)
        Me.materia3.Name = "materia3"
        Me.materia3.Size = New System.Drawing.Size(100, 20)
        Me.materia3.TabIndex = 8
        '
        'materia2
        '
        Me.materia2.Location = New System.Drawing.Point(309, 55)
        Me.materia2.Name = "materia2"
        Me.materia2.Size = New System.Drawing.Size(100, 20)
        Me.materia2.TabIndex = 9
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(525, 72)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(30, 31)
        Me.resultado.TabIndex = 10
        Me.resultado.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Promedio:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 46)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calcular promedio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.materia2)
        Me.Controls.Add(Me.materia3)
        Me.Controls.Add(Me.materia4)
        Me.Controls.Add(Me.materia5)
        Me.Controls.Add(Me.materia1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents materia1 As TextBox
    Friend WithEvents materia5 As TextBox
    Friend WithEvents materia4 As TextBox
    Friend WithEvents materia3 As TextBox
    Friend WithEvents materia2 As TextBox
    Friend WithEvents resultado As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
