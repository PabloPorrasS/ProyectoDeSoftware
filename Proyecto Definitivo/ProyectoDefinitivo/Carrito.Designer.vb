<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carrito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carrito))
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.ButtonTrends = New System.Windows.Forms.Button()
        Me.ButtonDelivery = New System.Windows.Forms.Button()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.ButtonInventory = New System.Windows.Forms.Button()
        Me.ButtonDeleteCart = New System.Windows.Forms.Button()
        Me.ButtonConfirmPurchase = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.ButtonGenerateBill = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonShoppingCart
        '
        Me.ButtonShoppingCart.AllowDrop = True
        Me.ButtonShoppingCart.BackgroundImage = CType(resources.GetObject("ButtonShoppingCart.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShoppingCart.FlatAppearance.BorderSize = 0
        Me.ButtonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShoppingCart.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonShoppingCart.Location = New System.Drawing.Point(193, 534)
        Me.ButtonShoppingCart.Name = "ButtonShoppingCart"
        Me.ButtonShoppingCart.Size = New System.Drawing.Size(74, 37)
        Me.ButtonShoppingCart.TabIndex = 30
        Me.ButtonShoppingCart.UseVisualStyleBackColor = True
        '
        'ButtonTrends
        '
        Me.ButtonTrends.FlatAppearance.BorderSize = 0
        Me.ButtonTrends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrends.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonTrends.Location = New System.Drawing.Point(49, 398)
        Me.ButtonTrends.Name = "ButtonTrends"
        Me.ButtonTrends.Size = New System.Drawing.Size(165, 44)
        Me.ButtonTrends.TabIndex = 29
        Me.ButtonTrends.Text = "Tendencias"
        Me.ButtonTrends.UseVisualStyleBackColor = True
        '
        'ButtonDelivery
        '
        Me.ButtonDelivery.FlatAppearance.BorderSize = 0
        Me.ButtonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelivery.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonDelivery.Location = New System.Drawing.Point(49, 320)
        Me.ButtonDelivery.Name = "ButtonDelivery"
        Me.ButtonDelivery.Size = New System.Drawing.Size(165, 44)
        Me.ButtonDelivery.TabIndex = 28
        Me.ButtonDelivery.Text = "Entregas"
        Me.ButtonDelivery.UseVisualStyleBackColor = True
        '
        'ButtonBill
        '
        Me.ButtonBill.FlatAppearance.BorderSize = 0
        Me.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(49, 232)
        Me.ButtonBill.Name = "ButtonBill"
        Me.ButtonBill.Size = New System.Drawing.Size(165, 44)
        Me.ButtonBill.TabIndex = 27
        Me.ButtonBill.Text = "Facturas"
        Me.ButtonBill.UseVisualStyleBackColor = True
        '
        'ButtonInventory
        '
        Me.ButtonInventory.FlatAppearance.BorderSize = 0
        Me.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventory.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonInventory.Location = New System.Drawing.Point(49, 148)
        Me.ButtonInventory.Name = "ButtonInventory"
        Me.ButtonInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonInventory.TabIndex = 26
        Me.ButtonInventory.Text = "Mi Inventario"
        Me.ButtonInventory.UseVisualStyleBackColor = True
        '
        'ButtonDeleteCart
        '
        Me.ButtonDeleteCart.BackColor = System.Drawing.Color.Red
        Me.ButtonDeleteCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonDeleteCart.Location = New System.Drawing.Point(638, 0)
        Me.ButtonDeleteCart.Name = "ButtonDeleteCart"
        Me.ButtonDeleteCart.Size = New System.Drawing.Size(387, 51)
        Me.ButtonDeleteCart.TabIndex = 25
        Me.ButtonDeleteCart.Text = "Eliminar producto"
        Me.ButtonDeleteCart.UseVisualStyleBackColor = False
        '
        'ButtonConfirmPurchase
        '
        Me.ButtonConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonConfirmPurchase.FlatAppearance.BorderSize = 0
        Me.ButtonConfirmPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConfirmPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonConfirmPurchase.Location = New System.Drawing.Point(273, 534)
        Me.ButtonConfirmPurchase.Name = "ButtonConfirmPurchase"
        Me.ButtonConfirmPurchase.Size = New System.Drawing.Size(367, 49)
        Me.ButtonConfirmPurchase.TabIndex = 24
        Me.ButtonConfirmPurchase.Text = "Confirmar compra de producto"
        Me.ButtonConfirmPurchase.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.GreenYellow
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonEdit.Location = New System.Drawing.Point(273, 0)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(367, 51)
        Me.ButtonEdit.TabIndex = 23
        Me.ButtonEdit.Text = "Editar producto"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(273, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 493)
        Me.DataGridView1.TabIndex = 22
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Green
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(274, 583)
        Me.Splitter1.TabIndex = 21
        Me.Splitter1.TabStop = False
        '
        'ButtonOrders
        '
        Me.ButtonOrders.FlatAppearance.BorderSize = 0
        Me.ButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOrders.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonOrders.Location = New System.Drawing.Point(49, 71)
        Me.ButtonOrders.Name = "ButtonOrders"
        Me.ButtonOrders.Size = New System.Drawing.Size(165, 44)
        Me.ButtonOrders.TabIndex = 31
        Me.ButtonOrders.Text = "Pedidos"
        Me.ButtonOrders.UseVisualStyleBackColor = True
        '
        'ButtonGenerateBill
        '
        Me.ButtonGenerateBill.BackColor = System.Drawing.Color.Salmon
        Me.ButtonGenerateBill.FlatAppearance.BorderSize = 0
        Me.ButtonGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGenerateBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonGenerateBill.Location = New System.Drawing.Point(638, 534)
        Me.ButtonGenerateBill.Name = "ButtonGenerateBill"
        Me.ButtonGenerateBill.Size = New System.Drawing.Size(379, 49)
        Me.ButtonGenerateBill.TabIndex = 32
        Me.ButtonGenerateBill.Text = "Generar factura"
        Me.ButtonGenerateBill.UseVisualStyleBackColor = False
        '
        'Carrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.ButtonGenerateBill)
        Me.Controls.Add(Me.ButtonOrders)
        Me.Controls.Add(Me.ButtonShoppingCart)
        Me.Controls.Add(Me.ButtonTrends)
        Me.Controls.Add(Me.ButtonDelivery)
        Me.Controls.Add(Me.ButtonBill)
        Me.Controls.Add(Me.ButtonInventory)
        Me.Controls.Add(Me.ButtonDeleteCart)
        Me.Controls.Add(Me.ButtonConfirmPurchase)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Splitter1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "Carrito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carrito"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents ButtonTrends As Button
    Friend WithEvents ButtonDelivery As Button
    Friend WithEvents ButtonBill As Button
    Friend WithEvents ButtonInventory As Button
    Friend WithEvents ButtonDeleteCart As Button
    Friend WithEvents ButtonConfirmPurchase As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents ButtonGenerateBill As Button
End Class
