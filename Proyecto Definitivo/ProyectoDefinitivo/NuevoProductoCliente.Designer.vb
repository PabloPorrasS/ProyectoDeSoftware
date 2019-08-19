<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProductoCliente
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
        Me.LabelQuantityNew = New System.Windows.Forms.Label()
        Me.NumericUpDownQuantityClient = New System.Windows.Forms.NumericUpDown()
        Me.ButtonSaveClient = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownQuantityClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelQuantityNew
        '
        Me.LabelQuantityNew.AutoSize = True
        Me.LabelQuantityNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelQuantityNew.Location = New System.Drawing.Point(60, 107)
        Me.LabelQuantityNew.Name = "LabelQuantityNew"
        Me.LabelQuantityNew.Size = New System.Drawing.Size(73, 20)
        Me.LabelQuantityNew.TabIndex = 2
        Me.LabelQuantityNew.Text = "Cantidad"
        '
        'NumericUpDownQuantityClient
        '
        Me.NumericUpDownQuantityClient.Location = New System.Drawing.Point(232, 107)
        Me.NumericUpDownQuantityClient.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownQuantityClient.Name = "NumericUpDownQuantityClient"
        Me.NumericUpDownQuantityClient.Size = New System.Drawing.Size(126, 20)
        Me.NumericUpDownQuantityClient.TabIndex = 3
        '
        'ButtonSaveClient
        '
        Me.ButtonSaveClient.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveClient.Location = New System.Drawing.Point(114, 218)
        Me.ButtonSaveClient.Name = "ButtonSaveClient"
        Me.ButtonSaveClient.Size = New System.Drawing.Size(168, 48)
        Me.ButtonSaveClient.TabIndex = 6
        Me.ButtonSaveClient.Text = "Guardar"
        Me.ButtonSaveClient.UseVisualStyleBackColor = False
        '
        'NuevoProductoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(398, 317)
        Me.Controls.Add(Me.ButtonSaveClient)
        Me.Controls.Add(Me.NumericUpDownQuantityClient)
        Me.Controls.Add(Me.LabelQuantityNew)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(414, 356)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(414, 356)
        Me.Name = "NuevoProductoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto "
        CType(Me.NumericUpDownQuantityClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelQuantityNew As Label
    Friend WithEvents NumericUpDownQuantityClient As NumericUpDown
    Friend WithEvents ButtonSaveClient As Button
End Class
