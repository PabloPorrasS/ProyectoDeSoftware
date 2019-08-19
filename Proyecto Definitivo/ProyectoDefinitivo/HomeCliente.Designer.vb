<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeCliente))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonEditProfile = New System.Windows.Forms.Button()
        Me.LabelId_Profile = New System.Windows.Forms.Label()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.LabelTypeOfUser = New System.Windows.Forms.Label()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.ButtonMyInventory = New System.Windows.Forms.Button()
        Me.LabelNameWelcome = New System.Windows.Forms.Label()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEditProfile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelId_Profile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOrders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelTypeOfUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonShoppingCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMyInventory)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelNameWelcome)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelWelcome)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 583)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.Button2.Location = New System.Drawing.Point(170, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 44)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cerrar sesion"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(58, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 44)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Carrito de compras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonEditProfile
        '
        Me.ButtonEditProfile.FlatAppearance.BorderSize = 0
        Me.ButtonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditProfile.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonEditProfile.Location = New System.Drawing.Point(88, 341)
        Me.ButtonEditProfile.Name = "ButtonEditProfile"
        Me.ButtonEditProfile.Size = New System.Drawing.Size(165, 44)
        Me.ButtonEditProfile.TabIndex = 9
        Me.ButtonEditProfile.Text = "Editar Perfil"
        Me.ButtonEditProfile.UseVisualStyleBackColor = True
        '
        'LabelId_Profile
        '
        Me.LabelId_Profile.AutoSize = True
        Me.LabelId_Profile.Location = New System.Drawing.Point(58, 13)
        Me.LabelId_Profile.Name = "LabelId_Profile"
        Me.LabelId_Profile.Size = New System.Drawing.Size(39, 13)
        Me.LabelId_Profile.TabIndex = 8
        Me.LabelId_Profile.Text = "Label1"
        Me.LabelId_Profile.Visible = False
        '
        'ButtonOrders
        '
        Me.ButtonOrders.FlatAppearance.BorderSize = 0
        Me.ButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOrders.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonOrders.Location = New System.Drawing.Point(88, 138)
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
        Me.ButtonMyInventory.Location = New System.Drawing.Point(88, 232)
        Me.ButtonMyInventory.Name = "ButtonMyInventory"
        Me.ButtonMyInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonMyInventory.TabIndex = 0
        Me.ButtonMyInventory.Text = "Mi inventario"
        Me.ButtonMyInventory.UseVisualStyleBackColor = True
        '
        'LabelNameWelcome
        '
        Me.LabelNameWelcome.AutoSize = True
        Me.LabelNameWelcome.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameWelcome.ForeColor = System.Drawing.Color.Green
        Me.LabelNameWelcome.Location = New System.Drawing.Point(238, 123)
        Me.LabelNameWelcome.Name = "LabelNameWelcome"
        Me.LabelNameWelcome.Size = New System.Drawing.Size(0, 27)
        Me.LabelNameWelcome.TabIndex = 2
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.ForeColor = System.Drawing.Color.Green
        Me.LabelWelcome.Location = New System.Drawing.Point(202, 23)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(317, 62)
        Me.LabelWelcome.TabIndex = 1
        Me.LabelWelcome.Text = "Bienvenido "
        Me.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(182, 222)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 244)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents LabelTypeOfUser As Label
    Friend WithEvents ButtonMyInventory As Button
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents LabelId_Profile As Label
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelNameWelcome As Label
    Friend WithEvents ButtonEditProfile As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
