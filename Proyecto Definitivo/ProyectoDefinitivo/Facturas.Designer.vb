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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonInventory = New System.Windows.Forms.Button()
        Me.ButtonBill = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id_Profile = New System.Windows.Forms.Label()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.reportDocument2 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonShoppingCart = New System.Windows.Forms.Button()
        Me.Buttonhome = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Green
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(313, 583)
        Me.Splitter1.TabIndex = 15
        Me.Splitter1.TabStop = False
        '
        'ButtonInventory
        '
        Me.ButtonInventory.BackColor = System.Drawing.Color.Green
        Me.ButtonInventory.FlatAppearance.BorderSize = 0
        Me.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventory.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonInventory.Location = New System.Drawing.Point(66, 425)
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
        Me.ButtonBill.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonBill.Location = New System.Drawing.Point(66, 329)
        Me.ButtonBill.Name = "ButtonBill"
        Me.ButtonBill.Size = New System.Drawing.Size(165, 44)
        Me.ButtonBill.TabIndex = 17
        Me.ButtonBill.Text = "Facturas"
        Me.ButtonBill.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(303, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(721, 583)
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
        Me.Id_Profile.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(66, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 44)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Pedidos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonShoppingCart
        '
        Me.ButtonShoppingCart.AllowDrop = True
        Me.ButtonShoppingCart.BackgroundImage = CType(resources.GetObject("ButtonShoppingCart.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShoppingCart.FlatAppearance.BorderSize = 0
        Me.ButtonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShoppingCart.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.ButtonShoppingCart.Location = New System.Drawing.Point(230, 534)
        Me.ButtonShoppingCart.Name = "ButtonShoppingCart"
        Me.ButtonShoppingCart.Size = New System.Drawing.Size(67, 37)
        Me.ButtonShoppingCart.TabIndex = 25
        Me.ButtonShoppingCart.UseVisualStyleBackColor = True
        '
        'Buttonhome
        '
        Me.Buttonhome.BackColor = System.Drawing.Color.Green
        Me.Buttonhome.FlatAppearance.BorderSize = 0
        Me.Buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonhome.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.Buttonhome.Location = New System.Drawing.Point(35, 139)
        Me.Buttonhome.Name = "Buttonhome"
        Me.Buttonhome.Size = New System.Drawing.Size(247, 44)
        Me.Buttonhome.TabIndex = 26
        Me.Buttonhome.Text = "Pagina Principal"
        Me.Buttonhome.UseVisualStyleBackColor = False
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.Buttonhome)
        Me.Controls.Add(Me.ButtonShoppingCart)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Id_Profile)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonBill)
        Me.Controls.Add(Me.ButtonInventory)
        Me.Controls.Add(Me.Splitter1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonInventory As Button
    Friend WithEvents ButtonBill As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id_Profile As Label
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents reportDocument2 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonShoppingCart As Button
    Friend WithEvents Buttonhome As Button
End Class
