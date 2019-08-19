<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarCarrito
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
        Me.ButtonSaveClient = New System.Windows.Forms.Button()
        Me.TextBoxPriceNew = New System.Windows.Forms.TextBox()
        Me.LabelPriceNew = New System.Windows.Forms.Label()
        Me.NumericUpDownQuantityClient = New System.Windows.Forms.NumericUpDown()
        Me.LabelQuantityNew = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownQuantityClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSaveClient
        '
        Me.ButtonSaveClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveClient.Location = New System.Drawing.Point(125, 210)
        Me.ButtonSaveClient.Name = "ButtonSaveClient"
        Me.ButtonSaveClient.Size = New System.Drawing.Size(168, 48)
        Me.ButtonSaveClient.TabIndex = 11
        Me.ButtonSaveClient.Text = "Guardar"
        Me.ButtonSaveClient.UseVisualStyleBackColor = False
        '
        'TextBoxPriceNew
        '
        Me.TextBoxPriceNew.Location = New System.Drawing.Point(225, 141)
        Me.TextBoxPriceNew.Name = "TextBoxPriceNew"
        Me.TextBoxPriceNew.Size = New System.Drawing.Size(127, 20)
        Me.TextBoxPriceNew.TabIndex = 10
        '
        'LabelPriceNew
        '
        Me.LabelPriceNew.AutoSize = True
        Me.LabelPriceNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelPriceNew.Location = New System.Drawing.Point(79, 139)
        Me.LabelPriceNew.Name = "LabelPriceNew"
        Me.LabelPriceNew.Size = New System.Drawing.Size(53, 20)
        Me.LabelPriceNew.TabIndex = 9
        Me.LabelPriceNew.Text = "Precio"
        '
        'NumericUpDownQuantityClient
        '
        Me.NumericUpDownQuantityClient.Location = New System.Drawing.Point(225, 62)
        Me.NumericUpDownQuantityClient.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumericUpDownQuantityClient.Name = "NumericUpDownQuantityClient"
        Me.NumericUpDownQuantityClient.Size = New System.Drawing.Size(126, 20)
        Me.NumericUpDownQuantityClient.TabIndex = 8
        '
        'LabelQuantityNew
        '
        Me.LabelQuantityNew.AutoSize = True
        Me.LabelQuantityNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelQuantityNew.Location = New System.Drawing.Point(79, 62)
        Me.LabelQuantityNew.Name = "LabelQuantityNew"
        Me.LabelQuantityNew.Size = New System.Drawing.Size(73, 20)
        Me.LabelQuantityNew.TabIndex = 7
        Me.LabelQuantityNew.Text = "Cantidad"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelProductName.Location = New System.Drawing.Point(183, 34)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(0, 25)
        Me.LabelProductName.TabIndex = 12
        '
        'EditarCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(398, 317)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.ButtonSaveClient)
        Me.Controls.Add(Me.TextBoxPriceNew)
        Me.Controls.Add(Me.LabelPriceNew)
        Me.Controls.Add(Me.NumericUpDownQuantityClient)
        Me.Controls.Add(Me.LabelQuantityNew)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(414, 356)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(414, 356)
        Me.Name = "EditarCarrito"
        Me.Text = "EditarCarrito"
        CType(Me.NumericUpDownQuantityClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSaveClient As Button
    Friend WithEvents TextBoxPriceNew As TextBox
    Friend WithEvents LabelPriceNew As Label
    Friend WithEvents NumericUpDownQuantityClient As NumericUpDown
    Friend WithEvents LabelQuantityNew As Label
    Friend WithEvents LabelProductName As Label
End Class
