﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPerfil
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
        Me.ComboBoxTypeOfBusiness = New System.Windows.Forms.ComboBox()
        Me.ButtonSaveChanges = New System.Windows.Forms.Button()
        Me.TextBoxUbication = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCompleteName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelIdProfile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxTypeOfBusiness
        '
        Me.ComboBoxTypeOfBusiness.FormattingEnabled = True
        Me.ComboBoxTypeOfBusiness.Location = New System.Drawing.Point(230, 195)
        Me.ComboBoxTypeOfBusiness.Name = "ComboBoxTypeOfBusiness"
        Me.ComboBoxTypeOfBusiness.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTypeOfBusiness.TabIndex = 22
        '
        'ButtonSaveChanges
        '
        Me.ButtonSaveChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveChanges.Location = New System.Drawing.Point(107, 351)
        Me.ButtonSaveChanges.Name = "ButtonSaveChanges"
        Me.ButtonSaveChanges.Size = New System.Drawing.Size(166, 41)
        Me.ButtonSaveChanges.TabIndex = 21
        Me.ButtonSaveChanges.Text = "Confirmar cambios"
        Me.ButtonSaveChanges.UseVisualStyleBackColor = False
        '
        'TextBoxUbication
        '
        Me.TextBoxUbication.Location = New System.Drawing.Point(230, 261)
        Me.TextBoxUbication.Name = "TextBoxUbication"
        Me.TextBoxUbication.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUbication.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ubicaión del negocio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tipo de negocio"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(230, 135)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contraseña"
        '
        'TextBoxCompleteName
        '
        Me.TextBoxCompleteName.Location = New System.Drawing.Point(230, 78)
        Me.TextBoxCompleteName.Name = "TextBoxCompleteName"
        Me.TextBoxCompleteName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCompleteName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre completo"
        '
        'LabelIdProfile
        '
        Me.LabelIdProfile.AutoSize = True
        Me.LabelIdProfile.Location = New System.Drawing.Point(13, 13)
        Me.LabelIdProfile.Name = "LabelIdProfile"
        Me.LabelIdProfile.Size = New System.Drawing.Size(39, 13)
        Me.LabelIdProfile.TabIndex = 23
        Me.LabelIdProfile.Text = "Label6"
        Me.LabelIdProfile.Visible = False
        '
        'EditarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(378, 450)
        Me.Controls.Add(Me.LabelIdProfile)
        Me.Controls.Add(Me.ComboBoxTypeOfBusiness)
        Me.Controls.Add(Me.ButtonSaveChanges)
        Me.Controls.Add(Me.TextBoxUbication)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCompleteName)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(394, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(394, 489)
        Me.Name = "EditarPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarPerfil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxTypeOfBusiness As ComboBox
    Friend WithEvents ButtonSaveChanges As Button
    Friend WithEvents TextBoxUbication As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCompleteName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelIdProfile As Label
End Class
