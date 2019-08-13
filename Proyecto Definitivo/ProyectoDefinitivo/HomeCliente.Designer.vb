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
        Me.LabelId_Profile = New System.Windows.Forms.Label()
        Me.ButtonEditProfile = New System.Windows.Forms.Button()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.LabelTypeOfUser = New System.Windows.Forms.Label()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.ButtonMyInventory = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelId_Profile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEditProfile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonOrders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelTypeOfUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonShoppingCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBill)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMyInventory)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 583)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 0
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
        Me.ButtonOrders.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonOrders.Location = New System.Drawing.Point(91, 138)
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
        'ButtonBill
        '
        Me.ButtonBill.FlatAppearance.BorderSize = 0
        Me.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(91, 394)
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
        Me.ButtonMyInventory.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonMyInventory.Location = New System.Drawing.Point(91, 262)
        Me.ButtonMyInventory.Name = "ButtonMyInventory"
        Me.ButtonMyInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonMyInventory.TabIndex = 0
        Me.ButtonMyInventory.Text = "Mi inventario"
        Me.ButtonMyInventory.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(674, 583)
        Me.CrystalReportViewer1.TabIndex = 0
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
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents ButtonBill As Button
    Friend WithEvents LabelTypeOfUser As Label
    Friend WithEvents ButtonMyInventory As Button
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents ButtonEditProfile As Button
    Friend WithEvents LabelId_Profile As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
