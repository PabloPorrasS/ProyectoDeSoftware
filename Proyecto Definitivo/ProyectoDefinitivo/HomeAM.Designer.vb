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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeAM))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonInventory = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelWelcomeAM = New System.Windows.Forms.Label()
        Me.LabelNameWelcomeAM = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ButtonInventory
        '
        Me.ButtonInventory.BackColor = System.Drawing.Color.Green
        Me.ButtonInventory.FlatAppearance.BorderSize = 0
        Me.ButtonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInventory.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        Me.ButtonInventory.Location = New System.Drawing.Point(55, 142)
        Me.ButtonInventory.Name = "ButtonInventory"
        Me.ButtonInventory.Size = New System.Drawing.Size(165, 44)
        Me.ButtonInventory.TabIndex = 11
        Me.ButtonInventory.Text = "Inventario"
        Me.ButtonInventory.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(494, 255)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 243)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'LabelWelcomeAM
        '
        Me.LabelWelcomeAM.AutoSize = True
        Me.LabelWelcomeAM.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcomeAM.ForeColor = System.Drawing.Color.Green
        Me.LabelWelcomeAM.Location = New System.Drawing.Point(483, 44)
        Me.LabelWelcomeAM.Name = "LabelWelcomeAM"
        Me.LabelWelcomeAM.Size = New System.Drawing.Size(317, 62)
        Me.LabelWelcomeAM.TabIndex = 14
        Me.LabelWelcomeAM.Text = "Bienvenido "
        Me.LabelWelcomeAM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelNameWelcomeAM
        '
        Me.LabelNameWelcomeAM.AutoSize = True
        Me.LabelNameWelcomeAM.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameWelcomeAM.ForeColor = System.Drawing.Color.Green
        Me.LabelNameWelcomeAM.Location = New System.Drawing.Point(489, 159)
        Me.LabelNameWelcomeAM.Name = "LabelNameWelcomeAM"
        Me.LabelNameWelcomeAM.Size = New System.Drawing.Size(51, 27)
        Me.LabelNameWelcomeAM.TabIndex = 15
        Me.LabelNameWelcomeAM.Text = "AM"
        '
        'HomeAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.Controls.Add(Me.LabelNameWelcomeAM)
        Me.Controls.Add(Me.LabelWelcomeAM)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonInventory)
        Me.Controls.Add(Me.Splitter1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1032, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1032, 622)
        Me.Name = "HomeAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonInventory As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelWelcomeAM As Label
    Friend WithEvents LabelNameWelcomeAM As Label
End Class
