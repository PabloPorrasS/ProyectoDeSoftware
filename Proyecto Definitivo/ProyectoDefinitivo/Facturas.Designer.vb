<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonInventory = New System.Windows.Forms.Button()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.ButtonDelivery = New System.Windows.Forms.Button()
        Me.ButtonTrends = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id_Profile = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Green
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(265, 450)
        Me.Splitter1.TabIndex = 15
        Me.Splitter1.TabStop = False
        '
        'ButtonInventory
        '
        Me.ButtonInventory.BackColor = System.Drawing.Color.Green
        Me.ButtonInventory.FlatAppearance.BorderSize = 0
        Me.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventory.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonInventory.Location = New System.Drawing.Point(38, 88)
        Me.ButtonInventory.Name = "ButtonInventory"
        Me.ButtonInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonInventory.TabIndex = 16
        Me.ButtonInventory.Text = "Inventario"
        Me.ButtonInventory.UseVisualStyleBackColor = False
        '
        'ButtonBill
        '
        Me.ButtonBill.BackColor = System.Drawing.Color.Green
        Me.ButtonBill.FlatAppearance.BorderSize = 0
        Me.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(38, 169)
        Me.ButtonBill.Name = "ButtonBill"
        Me.ButtonBill.Size = New System.Drawing.Size(165, 44)
        Me.ButtonBill.TabIndex = 17
        Me.ButtonBill.Text = "Facturas"
        Me.ButtonBill.UseVisualStyleBackColor = False
        '
        'ButtonDelivery
        '
        Me.ButtonDelivery.BackColor = System.Drawing.Color.Green
        Me.ButtonDelivery.FlatAppearance.BorderSize = 0
        Me.ButtonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelivery.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonDelivery.Location = New System.Drawing.Point(38, 262)
        Me.ButtonDelivery.Name = "ButtonDelivery"
        Me.ButtonDelivery.Size = New System.Drawing.Size(165, 44)
        Me.ButtonDelivery.TabIndex = 18
        Me.ButtonDelivery.Text = "Entregas"
        Me.ButtonDelivery.UseVisualStyleBackColor = False
        '
        'ButtonTrends
        '
        Me.ButtonTrends.BackColor = System.Drawing.Color.Green
        Me.ButtonTrends.FlatAppearance.BorderSize = 0
        Me.ButtonTrends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrends.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonTrends.Location = New System.Drawing.Point(38, 350)
        Me.ButtonTrends.Name = "ButtonTrends"
        Me.ButtonTrends.Size = New System.Drawing.Size(165, 44)
        Me.ButtonTrends.TabIndex = 19
        Me.ButtonTrends.Text = "Tendencias"
        Me.ButtonTrends.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(271, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(528, 450)
        Me.DataGridView1.TabIndex = 22
        '
        'Id_Profile
        '
        Me.Id_Profile.AutoSize = True
        Me.Id_Profile.BackColor = System.Drawing.Color.Green
        Me.Id_Profile.Location = New System.Drawing.Point(12, 9)
        Me.Id_Profile.Name = "Id_Profile"
        Me.Id_Profile.Size = New System.Drawing.Size(39, 13)
        Me.Id_Profile.TabIndex = 23
        Me.Id_Profile.Text = "Label1"
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Id_Profile)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonTrends)
        Me.Controls.Add(Me.ButtonDelivery)
        Me.Controls.Add(Me.ButtonBill)
        Me.Controls.Add(Me.ButtonInventory)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonInventory As Button
    Friend WithEvents ButtonBill As Button
    Friend WithEvents ButtonDelivery As Button
    Friend WithEvents ButtonTrends As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id_Profile As Label
End Class
