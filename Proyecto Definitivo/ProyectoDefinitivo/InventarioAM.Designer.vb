<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioAM
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioAM))
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet2 = New ProyectoDefinitivo.InventoryDataSet2()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.ButtonTrends = New System.Windows.Forms.Button()
        Me.ButtonDelivery = New System.Windows.Forms.Button()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.ButtonInventory = New System.Windows.Forms.Button()
        Me.ButtonAddNewProduct = New System.Windows.Forms.Button()
        Me.ProductsTableAdapter = New ProyectoDefinitivo.InventoryDataSet2TableAdapters.ProductsTableAdapter()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonDeleteProduct = New System.Windows.Forms.Button()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.InventoryDataSet2
        '
        'InventoryDataSet2
        '
        Me.InventoryDataSet2.DataSetName = "InventoryDataSet2"
        Me.InventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Green
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(265, 583)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'ButtonShoppingCart
        '
        Me.ButtonShoppingCart.AllowDrop = True
        Me.ButtonShoppingCart.BackgroundImage = CType(resources.GetObject("ButtonShoppingCart.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShoppingCart.FlatAppearance.BorderSize = 0
        Me.ButtonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShoppingCart.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonShoppingCart.Location = New System.Drawing.Point(181, 534)
        Me.ButtonShoppingCart.Name = "ButtonShoppingCart"
        Me.ButtonShoppingCart.Size = New System.Drawing.Size(74, 37)
        Me.ButtonShoppingCart.TabIndex = 9
        Me.ButtonShoppingCart.UseVisualStyleBackColor = True
        '
        'ButtonTrends
        '
        Me.ButtonTrends.FlatAppearance.BorderSize = 0
        Me.ButtonTrends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrends.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonTrends.Location = New System.Drawing.Point(52, 342)
        Me.ButtonTrends.Name = "ButtonTrends"
        Me.ButtonTrends.Size = New System.Drawing.Size(165, 44)
        Me.ButtonTrends.TabIndex = 8
        Me.ButtonTrends.Text = "Tendencias"
        Me.ButtonTrends.UseVisualStyleBackColor = True
        '
        'ButtonDelivery
        '
        Me.ButtonDelivery.FlatAppearance.BorderSize = 0
        Me.ButtonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelivery.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonDelivery.Location = New System.Drawing.Point(52, 259)
        Me.ButtonDelivery.Name = "ButtonDelivery"
        Me.ButtonDelivery.Size = New System.Drawing.Size(165, 44)
        Me.ButtonDelivery.TabIndex = 7
        Me.ButtonDelivery.Text = "Entregas"
        Me.ButtonDelivery.UseVisualStyleBackColor = True
        '
        'ButtonBill
        '
        Me.ButtonBill.FlatAppearance.BorderSize = 0
        Me.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(52, 180)
        Me.ButtonBill.Name = "ButtonBill"
        Me.ButtonBill.Size = New System.Drawing.Size(165, 44)
        Me.ButtonBill.TabIndex = 6
        Me.ButtonBill.Text = "Facturas"
        Me.ButtonBill.UseVisualStyleBackColor = True
        '
        'ButtonInventory
        '
        Me.ButtonInventory.FlatAppearance.BorderSize = 0
        Me.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventory.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonInventory.Location = New System.Drawing.Point(52, 106)
        Me.ButtonInventory.Name = "ButtonInventory"
        Me.ButtonInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonInventory.TabIndex = 5
        Me.ButtonInventory.Text = "Inventario"
        Me.ButtonInventory.UseVisualStyleBackColor = True
        '
        'ButtonAddNewProduct
        '
        Me.ButtonAddNewProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonAddNewProduct.FlatAppearance.BorderSize = 0
        Me.ButtonAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAddNewProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAddNewProduct.Location = New System.Drawing.Point(271, -3)
        Me.ButtonAddNewProduct.Name = "ButtonAddNewProduct"
        Me.ButtonAddNewProduct.Size = New System.Drawing.Size(266, 47)
        Me.ButtonAddNewProduct.TabIndex = 11
        Me.ButtonAddNewProduct.Text = "Agregar nuevo producto"
        Me.ButtonAddNewProduct.UseVisualStyleBackColor = False
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonEdit.Location = New System.Drawing.Point(536, -3)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(239, 46)
        Me.ButtonEdit.TabIndex = 12
        Me.ButtonEdit.Text = "Editar productos"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(271, 42)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(745, 541)
        Me.DataGridView2.TabIndex = 13
        '
        'ButtonDeleteProduct
        '
        Me.ButtonDeleteProduct.BackColor = System.Drawing.Color.Red
        Me.ButtonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonDeleteProduct.Location = New System.Drawing.Point(773, 0)
        Me.ButtonDeleteProduct.Name = "ButtonDeleteProduct"
        Me.ButtonDeleteProduct.Size = New System.Drawing.Size(243, 44)
        Me.ButtonDeleteProduct.TabIndex = 14
        Me.ButtonDeleteProduct.Text = "Eliminar producto"
        Me.ButtonDeleteProduct.UseVisualStyleBackColor = False
        '
        'InventarioAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.ButtonDeleteProduct)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAddNewProduct)
        Me.Controls.Add(Me.ButtonShoppingCart)
        Me.Controls.Add(Me.ButtonTrends)
        Me.Controls.Add(Me.ButtonDelivery)
        Me.Controls.Add(Me.ButtonBill)
        Me.Controls.Add(Me.ButtonInventory)
        Me.Controls.Add(Me.Splitter1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "InventarioAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents ButtonTrends As Button
    Friend WithEvents ButtonDelivery As Button
    Friend WithEvents ButtonBill As Button
    Friend WithEvents ButtonInventory As Button
    Friend WithEvents ButtonAddNewProduct As Button
    Friend WithEvents InventoryDataSet2 As InventoryDataSet2
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As InventoryDataSet2TableAdapters.ProductsTableAdapter
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ButtonDeleteProduct As Button
End Class
