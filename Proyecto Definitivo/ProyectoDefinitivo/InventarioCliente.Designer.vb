<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioCliente
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.Buttonhome = New System.Windows.Forms.Button()
        Me.Id_Profile = New System.Windows.Forms.Label()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.ButtonMyInventory = New System.Windows.Forms.Button()
        Me.ButtonDeleteProduct = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet1 = New ProyectoDefinitivo.InventoryDataSet1()
        Me.InventoryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet = New ProyectoDefinitivo.InventoryDataSet()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ProductsTableAdapter = New ProyectoDefinitivo.InventoryDataSet1TableAdapters.ProductsTableAdapter()
        Me.InventoryDataSet5 = New ProyectoDefinitivo.InventoryDataSet5()
        Me.ClientProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientProductsTableAdapter = New ProyectoDefinitivo.InventoryDataSet5TableAdapters.ClientProductsTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Green
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonNew)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Buttonhome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_Profile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOrders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonShoppingCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMyInventory)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonDeleteProduct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 583)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 1
        '
        'ButtonNew
        '
        Me.ButtonNew.FlatAppearance.BorderSize = 0
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNew.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonNew.Location = New System.Drawing.Point(61, 417)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(221, 44)
        Me.ButtonNew.TabIndex = 10
        Me.ButtonNew.Text = "Carrito de compras"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'Buttonhome
        '
        Me.Buttonhome.FlatAppearance.BorderSize = 0
        Me.Buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonhome.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.Buttonhome.Location = New System.Drawing.Point(61, 138)
        Me.Buttonhome.Name = "Buttonhome"
        Me.Buttonhome.Size = New System.Drawing.Size(236, 44)
        Me.Buttonhome.TabIndex = 7
        Me.Buttonhome.Text = "Pagina Principal"
        Me.Buttonhome.UseVisualStyleBackColor = True
        '
        'Id_Profile
        '
        Me.Id_Profile.AutoSize = True
        Me.Id_Profile.Location = New System.Drawing.Point(13, 13)
        Me.Id_Profile.Name = "Id_Profile"
        Me.Id_Profile.Size = New System.Drawing.Size(39, 13)
        Me.Id_Profile.TabIndex = 6
        Me.Id_Profile.Text = "Label1"
        Me.Id_Profile.Visible = False
        '
        'ButtonOrders
        '
        Me.ButtonOrders.FlatAppearance.BorderSize = 0
        Me.ButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOrders.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonOrders.Location = New System.Drawing.Point(89, 239)
        Me.ButtonOrders.Name = "ButtonOrders"
        Me.ButtonOrders.Size = New System.Drawing.Size(165, 44)
        Me.ButtonOrders.TabIndex = 5
        Me.ButtonOrders.Text = "Pedidos"
        Me.ButtonOrders.UseVisualStyleBackColor = True
        '
        'ButtonShoppingCart
        '
        Me.ButtonShoppingCart.AllowDrop = True
        Me.ButtonShoppingCart.FlatAppearance.BorderSize = 0
        Me.ButtonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShoppingCart.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonShoppingCart.Location = New System.Drawing.Point(256, 542)
        Me.ButtonShoppingCart.Name = "ButtonShoppingCart"
        Me.ButtonShoppingCart.Size = New System.Drawing.Size(74, 37)
        Me.ButtonShoppingCart.TabIndex = 4
        Me.ButtonShoppingCart.UseVisualStyleBackColor = True
        '
        'ButtonMyInventory
        '
        Me.ButtonMyInventory.FlatAppearance.BorderSize = 0
        Me.ButtonMyInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMyInventory.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonMyInventory.Location = New System.Drawing.Point(89, 333)
        Me.ButtonMyInventory.Name = "ButtonMyInventory"
        Me.ButtonMyInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonMyInventory.TabIndex = 0
        Me.ButtonMyInventory.Text = "Mi inventario"
        Me.ButtonMyInventory.UseVisualStyleBackColor = True
        '
        'ButtonDeleteProduct
        '
        Me.ButtonDeleteProduct.BackColor = System.Drawing.Color.Red
        Me.ButtonDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonDeleteProduct.Location = New System.Drawing.Point(349, 0)
        Me.ButtonDeleteProduct.Name = "ButtonDeleteProduct"
        Me.ButtonDeleteProduct.Size = New System.Drawing.Size(325, 30)
        Me.ButtonDeleteProduct.TabIndex = 2
        Me.ButtonDeleteProduct.Text = "Eliminar"
        Me.ButtonDeleteProduct.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonEdit.Location = New System.Drawing.Point(-6, 0)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(357, 30)
        Me.ButtonEdit.TabIndex = 1
        Me.ButtonEdit.Text = "Editar"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-6, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(680, 614)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.InventoryDataSet1
        '
        'InventoryDataSet1
        '
        Me.InventoryDataSet1.DataSetName = "InventoryDataSet1"
        Me.InventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryDataSetBindingSource
        '
        Me.InventoryDataSetBindingSource.DataSource = Me.InventoryDataSet
        Me.InventoryDataSetBindingSource.Position = 0
        '
        'InventoryDataSet
        '
        Me.InventoryDataSet.DataSetName = "InventoryDataSet"
        Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'InventoryDataSet5
        '
        Me.InventoryDataSet5.DataSetName = "InventoryDataSet5"
        Me.InventoryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientProductsBindingSource
        '
        Me.ClientProductsBindingSource.DataMember = "ClientProducts"
        Me.ClientProductsBindingSource.DataSource = Me.InventoryDataSet5
        '
        'ClientProductsTableAdapter
        '
        Me.ClientProductsTableAdapter.ClearBeforeFill = True
        '
        'InventarioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "InventarioCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents ButtonMyInventory As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InventoryDataSetBindingSource As BindingSource
    Friend WithEvents InventoryDataSet As InventoryDataSet
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents InventoryDataSet1 As InventoryDataSet1
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As InventoryDataSet1TableAdapters.ProductsTableAdapter
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents Id_Profile As Label
    Friend WithEvents ButtonDeleteProduct As Button
    Friend WithEvents InventoryDataSet5 As InventoryDataSet5
    Friend WithEvents ClientProductsBindingSource As BindingSource
    Friend WithEvents ClientProductsTableAdapter As InventoryDataSet5TableAdapters.ClientProductsTableAdapter
    Friend WithEvents Buttonhome As Button
    Friend WithEvents ButtonNew As Button
End Class
