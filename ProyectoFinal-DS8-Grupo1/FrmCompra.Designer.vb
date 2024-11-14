<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompra
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BntQuitar = New System.Windows.Forms.Button()
        Me.BntCompra = New System.Windows.Forms.Button()
        Me.BntFactura = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VOLVERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VOLVERToolStripMenuItem
        '
        Me.VOLVERToolStripMenuItem.Name = "VOLVERToolStripMenuItem"
        Me.VOLVERToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.VOLVERToolStripMenuItem.Text = "VOLVER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Smart Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccione los productos y cantidad"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(526, 210)
        Me.DataGridView1.TabIndex = 5
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(604, 198)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(142, 39)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar Producto"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BntQuitar
        '
        Me.BntQuitar.Location = New System.Drawing.Point(604, 254)
        Me.BntQuitar.Name = "BntQuitar"
        Me.BntQuitar.Size = New System.Drawing.Size(142, 36)
        Me.BntQuitar.TabIndex = 7
        Me.BntQuitar.Text = "Quitar Producto"
        Me.BntQuitar.UseVisualStyleBackColor = True
        '
        'BntCompra
        '
        Me.BntCompra.Location = New System.Drawing.Point(604, 305)
        Me.BntCompra.Name = "BntCompra"
        Me.BntCompra.Size = New System.Drawing.Size(142, 41)
        Me.BntCompra.TabIndex = 8
        Me.BntCompra.Text = "Compra"
        Me.BntCompra.UseVisualStyleBackColor = True
        '
        'BntFactura
        '
        Me.BntFactura.Location = New System.Drawing.Point(604, 368)
        Me.BntFactura.Name = "BntFactura"
        Me.BntFactura.Size = New System.Drawing.Size(142, 40)
        Me.BntFactura.TabIndex = 9
        Me.BntFactura.Text = "Ver Factura"
        Me.BntFactura.UseVisualStyleBackColor = True
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BntFactura)
        Me.Controls.Add(Me.BntCompra)
        Me.Controls.Add(Me.BntQuitar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmCompra"
        Me.Text = "FrmCompra"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VOLVERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BntQuitar As Button
    Friend WithEvents BntCompra As Button
    Friend WithEvents BntFactura As Button
End Class
