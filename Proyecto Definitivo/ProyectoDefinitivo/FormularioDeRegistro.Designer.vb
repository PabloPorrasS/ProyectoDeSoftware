<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDeRegistro
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
        Me.TextBoxCompleteName = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxUbication = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonSaveRegister = New System.Windows.Forms.Button()
        Me.ComboBoxTypeOfBusiness = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre completo"
        '
        'TextBoxCompleteName
        '
        Me.TextBoxCompleteName.Location = New System.Drawing.Point(228, 48)
        Me.TextBoxCompleteName.Name = "TextBoxCompleteName"
        Me.TextBoxCompleteName.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxCompleteName.TabIndex = 1
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(228, 99)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Correo"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(228, 166)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de negocio"
        '
        'TextBoxUbication
        '
        Me.TextBoxUbication.Location = New System.Drawing.Point(228, 291)
        Me.TextBoxUbication.Name = "TextBoxUbication"
        Me.TextBoxUbication.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxUbication.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ubicaión del negocio"
        '
        'ButtonSaveRegister
        '
        Me.ButtonSaveRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonSaveRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveRegister.Location = New System.Drawing.Point(101, 368)
        Me.ButtonSaveRegister.Name = "ButtonSaveRegister"
        Me.ButtonSaveRegister.Size = New System.Drawing.Size(166, 41)
        Me.ButtonSaveRegister.TabIndex = 10
        Me.ButtonSaveRegister.Text = "Registrarse"
        Me.ButtonSaveRegister.UseVisualStyleBackColor = False
        '
        'ComboBoxTypeOfBusiness
        '
        Me.ComboBoxTypeOfBusiness.FormattingEnabled = True
        Me.ComboBoxTypeOfBusiness.Location = New System.Drawing.Point(228, 218)
        Me.ComboBoxTypeOfBusiness.Name = "ComboBoxTypeOfBusiness"
        Me.ComboBoxTypeOfBusiness.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTypeOfBusiness.TabIndex = 11
        '
        'FormularioDeRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(378, 450)
        Me.Controls.Add(Me.ComboBoxTypeOfBusiness)
        Me.Controls.Add(Me.ButtonSaveRegister)
        Me.Controls.Add(Me.TextBoxUbication)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCompleteName)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(394, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(394, 489)
        Me.Name = "FormularioDeRegistro"
        Me.Text = "Registrarse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCompleteName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxUbication As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonSaveRegister As Button
    Friend WithEvents ComboBoxTypeOfBusiness As ComboBox
End Class
