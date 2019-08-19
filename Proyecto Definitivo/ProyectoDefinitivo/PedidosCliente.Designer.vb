<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PedidosCliente
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.Buttonhome = New System.Windows.Forms.Button()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.Id_Profile = New System.Windows.Forms.Label()
        Me.ButtonMyInventory = New System.Windows.Forms.Button()
        Me.ButtonAddToCart = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet3 = New ProyectoDefinitivo.InventoryDataSet3()
        Me.ProductsTableAdapter = New ProyectoDefinitivo.InventoryDataSet3TableAdapters.ProductsTableAdapter()
        Me.InventoryDataSet4 = New ProyectoDefinitivo.InventoryDataSet4()
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter1 = New ProyectoDefinitivo.InventoryDataSet4TableAdapters.ProductsTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonShoppingCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Buttonhome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOrders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_Profile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMyInventory)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonAddToCart)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 583)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 1
        '
        'ButtonShoppingCart
        '
        Me.ButtonShoppingCart.FlatAppearance.BorderSize = 0
        Me.ButtonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShoppingCart.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonShoppingCart.Location = New System.Drawing.Point(59, 413)
        Me.ButtonShoppingCart.Name = "ButtonShoppingCart"
        Me.ButtonShoppingCart.Size = New System.Drawing.Size(221, 44)
        Me.ButtonShoppingCart.TabIndex = 9
        Me.ButtonShoppingCart.Text = "Carrito de compras"
        Me.ButtonShoppingCart.UseVisualStyleBackColor = True
        '
        'Buttonhome
        '
        Me.Buttonhome.FlatAppearance.BorderSize = 0
        Me.Buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonhome.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.Buttonhome.Location = New System.Drawing.Point(59, 120)
        Me.Buttonhome.Name = "Buttonhome"
        Me.Buttonhome.Size = New System.Drawing.Size(236, 44)
        Me.Buttonhome.TabIndex = 8
        Me.Buttonhome.Text = "Pagina Principal"
        Me.Buttonhome.UseVisualStyleBackColor = True
        '
        'ButtonOrders
        '
        Me.ButtonOrders.FlatAppearance.BorderSize = 0
        Me.ButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOrders.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonOrders.Location = New System.Drawing.Point(84, 205)
        Me.ButtonOrders.Name = "ButtonOrders"
        Me.ButtonOrders.Size = New System.Drawing.Size(165, 44)
        Me.ButtonOrders.TabIndex = 6
        Me.ButtonOrders.Text = "Pedidos"
        Me.ButtonOrders.UseVisualStyleBackColor = True
        '
        'Id_Profile
        '
        Me.Id_Profile.AutoSize = True
        Me.Id_Profile.Location = New System.Drawing.Point(37, 12)
        Me.Id_Profile.Name = "Id_Profile"
        Me.Id_Profile.Size = New System.Drawing.Size(39, 13)
        Me.Id_Profile.TabIndex = 5
        Me.Id_Profile.Text = "Label1"
        Me.Id_Profile.Visible = False
        '
        'ButtonMyInventory
        '
        Me.ButtonMyInventory.FlatAppearance.BorderSize = 0
        Me.ButtonMyInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMyInventory.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonMyInventory.Location = New System.Drawing.Point(84, 310)
        Me.ButtonMyInventory.Name = "ButtonMyInventory"
        Me.ButtonMyInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonMyInventory.TabIndex = 0
        Me.ButtonMyInventory.Text = "Mi inventario"
        Me.ButtonMyInventory.UseVisualStyleBackColor = True
        '
        'ButtonAddToCart
        '
        Me.ButtonAddToCart.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddToCart.Location = New System.Drawing.Point(-1, 0)
        Me.ButtonAddToCart.Name = "ButtonAddToCart"
        Me.ButtonAddToCart.Size = New System.Drawing.Size(672, 34)
        Me.ButtonAddToCart.TabIndex = 7
        Me.ButtonAddToCart.Text = "Agregar al Carrito"
        Me.ButtonAddToCart.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(671, 548)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.InventoryDataSet3
        '
        'InventoryDataSet3
        '
        Me.InventoryDataSet3.DataSetName = "InventoryDataSet3"
        Me.InventoryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'InventoryDataSet4
        '
        Me.InventoryDataSet4.DataSetName = "InventoryDataSet4"
        Me.InventoryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "Products"
        Me.ProductsBindingSource1.DataSource = Me.InventoryDataSet4
        '
        'ProductsTableAdapter1
        '
        Me.ProductsTableAdapter1.ClearBeforeFill = True
        '
        'PedidosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "PedidosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents Id_Profile As Label
    Friend WithEvents ButtonMyInventory As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InventoryDataSet3 As InventoryDataSet3
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As InventoryDataSet3TableAdapters.ProductsTableAdapter
    Friend WithEvents InventoryDataSet4 As InventoryDataSet4
    Friend WithEvents ProductsBindingSource1 As BindingSource
    Friend WithEvents ProductsTableAdapter1 As InventoryDataSet4TableAdapters.ProductsTableAdapter
    Friend WithEvents ButtonAddToCart As Button
    Friend WithEvents Buttonhome As Button
    Friend WithEvents ButtonShoppingCart As Button
End Class
