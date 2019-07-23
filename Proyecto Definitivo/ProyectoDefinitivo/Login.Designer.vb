<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.LabelAutoMerch = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(90, 237)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(99, 30)
        Me.ButtonLogin.TabIndex = 11
        Me.ButtonLogin.Text = "Inciar sesión"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'LabelAutoMerch
        '
        Me.LabelAutoMerch.AutoSize = True
        Me.LabelAutoMerch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoMerch.Location = New System.Drawing.Point(140, 55)
        Me.LabelAutoMerch.Name = "LabelAutoMerch"
        Me.LabelAutoMerch.Size = New System.Drawing.Size(125, 25)
        Me.LabelAutoMerch.TabIndex = 10
        Me.LabelAutoMerch.Text = "AutoMerch"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(174, 155)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword.TabIndex = 9
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(174, 108)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmail.TabIndex = 8
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelPassword.Location = New System.Drawing.Point(87, 158)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(81, 17)
        Me.LabelPassword.TabIndex = 7
        Me.LabelPassword.Text = "Contraseña"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelEmail.Location = New System.Drawing.Point(101, 111)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(51, 17)
        Me.LabelEmail.TabIndex = 6
        Me.LabelEmail.Text = "Correo"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.Location = New System.Drawing.Point(224, 237)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(99, 30)
        Me.ButtonRegister.TabIndex = 12
        Me.ButtonRegister.Text = "Registrarse"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(398, 317)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.LabelAutoMerch)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelEmail)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(414, 356)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(414, 356)
        Me.Name = "Login"
        Me.Text = "Ingreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelAutoMerch As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents ButtonRegister As Button
End Class
