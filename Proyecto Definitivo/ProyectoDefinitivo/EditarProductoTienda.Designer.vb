<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarProductoTienda
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
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.ButtonSaveClient = New System.Windows.Forms.Button()
        Me.TextBoxPriceNew = New System.Windows.Forms.TextBox()
        Me.LabelPriceNew = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelProductName.Location = New System.Drawing.Point(139, 33)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(0, 25)
        Me.LabelProductName.TabIndex = 18
        '
        'ButtonSaveClient
        '
        Me.ButtonSaveClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveClient.Location = New System.Drawing.Point(112, 219)
        Me.ButtonSaveClient.Name = "ButtonSaveClient"
        Me.ButtonSaveClient.Size = New System.Drawing.Size(168, 48)
        Me.ButtonSaveClient.TabIndex = 17
        Me.ButtonSaveClient.Text = "Guardar"
        Me.ButtonSaveClient.UseVisualStyleBackColor = False
        '
        'TextBoxPriceNew
        '
        Me.TextBoxPriceNew.Location = New System.Drawing.Point(220, 98)
        Me.TextBoxPriceNew.Name = "TextBoxPriceNew"
        Me.TextBoxPriceNew.Size = New System.Drawing.Size(106, 20)
        Me.TextBoxPriceNew.TabIndex = 16
        '
        'LabelPriceNew
        '
        Me.LabelPriceNew.AutoSize = True
        Me.LabelPriceNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelPriceNew.Location = New System.Drawing.Point(74, 96)
        Me.LabelPriceNew.Name = "LabelPriceNew"
        Me.LabelPriceNew.Size = New System.Drawing.Size(53, 20)
        Me.LabelPriceNew.TabIndex = 15
        Me.LabelPriceNew.Text = "Precio"
        '
        'EditarProductoTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(398, 317)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.ButtonSaveClient)
        Me.Controls.Add(Me.TextBoxPriceNew)
        Me.Controls.Add(Me.LabelPriceNew)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(414, 356)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(414, 356)
        Me.Name = "EditarProductoTienda"
        Me.Text = "EditarProductoTienda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProductName As Label
    Friend WithEvents ButtonSaveClient As Button
    Friend WithEvents TextBoxPriceNew As TextBox
    Friend WithEvents LabelPriceNew As Label
End Class
