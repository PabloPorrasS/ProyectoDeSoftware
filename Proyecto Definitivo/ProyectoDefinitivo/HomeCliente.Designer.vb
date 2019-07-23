<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeCliente))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonEditProfile = New System.Windows.Forms.Button()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.LabelTypeOfUser = New System.Windows.Forms.Label()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.ButtonTrends = New System.Windows.Forms.Button()
        Me.ButtonDelivery = New System.Windows.Forms.Button()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.ButtonMyInventory = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEditProfile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOrders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelTypeOfUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonShoppingCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonTrends)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonDelivery)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBill)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMyInventory)
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 583)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 0
        '
        'ButtonEditProfile
        '
        Me.ButtonEditProfile.AllowDrop = True
        Me.ButtonEditProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEditProfile.FlatAppearance.BorderSize = 0
        Me.ButtonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditProfile.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.ButtonEditProfile.Location = New System.Drawing.Point(217, 3)
        Me.ButtonEditProfile.Name = "ButtonEditProfile"
        Me.ButtonEditProfile.Size = New System.Drawing.Size(118, 37)
        Me.ButtonEditProfile.TabIndex = 7
        Me.ButtonEditProfile.Text = "Editar Perfil"
        Me.ButtonEditProfile.UseVisualStyleBackColor = False
        '
        'ButtonOrders
        '
        Me.ButtonOrders.FlatAppearance.BorderSize = 0
        Me.ButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOrders.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonOrders.Location = New System.Drawing.Point(91, 116)
        Me.ButtonOrders.Name = "ButtonOrders"
        Me.ButtonOrders.Size = New System.Drawing.Size(165, 44)
        Me.ButtonOrders.TabIndex = 6
        Me.ButtonOrders.Text = "Pedidos"
        Me.ButtonOrders.UseVisualStyleBackColor = True
        '
        'LabelTypeOfUser
        '
        Me.LabelTypeOfUser.AutoSize = True
        Me.LabelTypeOfUser.Location = New System.Drawing.Point(13, 13)
        Me.LabelTypeOfUser.Name = "LabelTypeOfUser"
        Me.LabelTypeOfUser.Size = New System.Drawing.Size(39, 13)
        Me.LabelTypeOfUser.TabIndex = 5
        Me.LabelTypeOfUser.Text = "Label1"
        Me.LabelTypeOfUser.Visible = False
        '
        'ButtonShoppingCart
        '
        Me.ButtonShoppingCart.AllowDrop = True
        Me.ButtonShoppingCart.BackgroundImage = CType(resources.GetObject("ButtonShoppingCart.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShoppingCart.FlatAppearance.BorderSize = 0
        Me.ButtonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShoppingCart.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonShoppingCart.Location = New System.Drawing.Point(256, 542)
        Me.ButtonShoppingCart.Name = "ButtonShoppingCart"
        Me.ButtonShoppingCart.Size = New System.Drawing.Size(74, 37)
        Me.ButtonShoppingCart.TabIndex = 4
        Me.ButtonShoppingCart.UseVisualStyleBackColor = True
        '
        'ButtonTrends
        '
        Me.ButtonTrends.FlatAppearance.BorderSize = 0
        Me.ButtonTrends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrends.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonTrends.Location = New System.Drawing.Point(91, 434)
        Me.ButtonTrends.Name = "ButtonTrends"
        Me.ButtonTrends.Size = New System.Drawing.Size(165, 44)
        Me.ButtonTrends.TabIndex = 3
        Me.ButtonTrends.Text = "Tendencias"
        Me.ButtonTrends.UseVisualStyleBackColor = True
        '
        'ButtonDelivery
        '
        Me.ButtonDelivery.FlatAppearance.BorderSize = 0
        Me.ButtonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelivery.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonDelivery.Location = New System.Drawing.Point(91, 357)
        Me.ButtonDelivery.Name = "ButtonDelivery"
        Me.ButtonDelivery.Size = New System.Drawing.Size(165, 44)
        Me.ButtonDelivery.TabIndex = 2
        Me.ButtonDelivery.Text = "Entregas"
        Me.ButtonDelivery.UseVisualStyleBackColor = True
        '
        'ButtonBill
        '
        Me.ButtonBill.FlatAppearance.BorderSize = 0
        Me.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(91, 278)
        Me.ButtonBill.Name = "ButtonBill"
        Me.ButtonBill.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonBill.Size = New System.Drawing.Size(165, 44)
        Me.ButtonBill.TabIndex = 1
        Me.ButtonBill.Text = "Facturas"
        Me.ButtonBill.UseVisualStyleBackColor = True
        '
        'ButtonMyInventory
        '
        Me.ButtonMyInventory.FlatAppearance.BorderSize = 0
        Me.ButtonMyInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMyInventory.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonMyInventory.Location = New System.Drawing.Point(91, 196)
        Me.ButtonMyInventory.Name = "ButtonMyInventory"
        Me.ButtonMyInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonMyInventory.TabIndex = 0
        Me.ButtonMyInventory.Text = "Mi inventario"
        Me.ButtonMyInventory.UseVisualStyleBackColor = True
        '
        'HomeCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "HomeCliente"
        Me.Text = "Home"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents ButtonTrends As Button
    Friend WithEvents ButtonDelivery As Button
    Friend WithEvents ButtonBill As Button
    Friend WithEvents LabelTypeOfUser As Label
    Friend WithEvents ButtonMyInventory As Button
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents ButtonEditProfile As Button
End Class
