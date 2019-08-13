<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeAM
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.ButtonInventory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Green
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(274, 583)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'ButtonBill
        '
        Me.ButtonBill.BackColor = System.Drawing.Color.Green
        Me.ButtonBill.FlatAppearance.BorderSize = 0
        Me.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(62, 159)
        Me.ButtonBill.Name = "ButtonBill"
        Me.ButtonBill.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonBill.Size = New System.Drawing.Size(165, 44)
        Me.ButtonBill.TabIndex = 12
        Me.ButtonBill.Text = "Facturas"
        Me.ButtonBill.UseVisualStyleBackColor = False
        '
        'ButtonInventory
        '
        Me.ButtonInventory.BackColor = System.Drawing.Color.Green
        Me.ButtonInventory.FlatAppearance.BorderSize = 0
        Me.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventory.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonInventory.Location = New System.Drawing.Point(62, 89)
        Me.ButtonInventory.Name = "ButtonInventory"
        Me.ButtonInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonInventory.TabIndex = 11
        Me.ButtonInventory.Text = "Inventario"
        Me.ButtonInventory.UseVisualStyleBackColor = False
        '
        'HomeAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.ButtonBill)
        Me.Controls.Add(Me.ButtonInventory)
        Me.Controls.Add(Me.Splitter1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "HomeAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonBill As Button
    Friend WithEvents ButtonInventory As Button
End Class
