﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioEditar
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
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.NumericUpDownQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxBrand = New System.Windows.Forms.TextBox()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelProductCode = New System.Windows.Forms.Label()
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDownQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(106, 451)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(184, 37)
        Me.ButtonSave.TabIndex = 25
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'NumericUpDownQuantity
        '
        Me.NumericUpDownQuantity.Location = New System.Drawing.Point(219, 310)
        Me.NumericUpDownQuantity.Name = "NumericUpDownQuantity"
        Me.NumericUpDownQuantity.Size = New System.Drawing.Size(153, 20)
        Me.NumericUpDownQuantity.TabIndex = 24
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(219, 385)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxPrice.TabIndex = 23
        '
        'TextBoxBrand
        '
        Me.TextBoxBrand.Location = New System.Drawing.Point(219, 110)
        Me.TextBoxBrand.Name = "TextBoxBrand"
        Me.TextBoxBrand.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxBrand.TabIndex = 22
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Location = New System.Drawing.Point(219, 242)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxCode.TabIndex = 21
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Location = New System.Drawing.Point(219, 177)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxCategory.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categoría"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre"
        '
        'LabelProductCode
        '
        Me.LabelProductCode.AutoSize = True
        Me.LabelProductCode.Location = New System.Drawing.Point(37, 9)
        Me.LabelProductCode.Name = "LabelProductCode"
        Me.LabelProductCode.Size = New System.Drawing.Size(55, 13)
        Me.LabelProductCode.TabIndex = 26
        Me.LabelProductCode.Text = "askdkjasd"
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(219, 42)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxName.TabIndex = 27
        '
        'FormularioEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(403, 523)
        Me.Controls.Add(Me.ComboBoxName)
        Me.Controls.Add(Me.LabelProductCode)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.NumericUpDownQuantity)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxBrand)
        Me.Controls.Add(Me.TextBoxCode)
        Me.Controls.Add(Me.TextBoxCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioEditar"
        Me.Text = "FormularioEditar"
        CType(Me.NumericUpDownQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents NumericUpDownQuantity As NumericUpDown
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxBrand As TextBox
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelProductCode As Label
    Friend WithEvents ComboBoxName As ComboBox
End Class
