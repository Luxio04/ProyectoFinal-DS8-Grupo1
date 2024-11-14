<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.BtnInvetario = New System.Windows.Forms.Button()
        Me.BtnPedidos = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.PanelReportes = New System.Windows.Forms.Panel()
        Me.BtnReporteRoles = New System.Windows.Forms.Button()
        Me.BtnMovimientoInv = New System.Windows.Forms.Button()
        Me.BtnProcesadosNot = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelReportes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMenu.Controls.Add(Me.BtnRegresar)
        Me.PanelMenu.Controls.Add(Me.PanelReportes)
        Me.PanelMenu.Controls.Add(Me.BtnReportes)
        Me.PanelMenu.Controls.Add(Me.BtnPedidos)
        Me.PanelMenu.Controls.Add(Me.BtnInvetario)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 594)
        Me.PanelMenu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Smart Inventory"
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 138)
        Me.PanelLogo.TabIndex = 0
        '
        'BtnInvetario
        '
        Me.BtnInvetario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInvetario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvetario.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnInvetario.Location = New System.Drawing.Point(0, 138)
        Me.BtnInvetario.Name = "BtnInvetario"
        Me.BtnInvetario.Size = New System.Drawing.Size(250, 44)
        Me.BtnInvetario.TabIndex = 1
        Me.BtnInvetario.Text = "Administracion Investario"
        Me.BtnInvetario.UseVisualStyleBackColor = True
        '
        'BtnPedidos
        '
        Me.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPedidos.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnPedidos.Location = New System.Drawing.Point(0, 182)
        Me.BtnPedidos.Name = "BtnPedidos"
        Me.BtnPedidos.Size = New System.Drawing.Size(250, 44)
        Me.BtnPedidos.TabIndex = 2
        Me.BtnPedidos.Text = "Pedidos"
        Me.BtnPedidos.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnReportes.Location = New System.Drawing.Point(0, 226)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(250, 50)
        Me.BtnReportes.TabIndex = 3
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'PanelReportes
        '
        Me.PanelReportes.Controls.Add(Me.BtnProcesadosNot)
        Me.PanelReportes.Controls.Add(Me.BtnMovimientoInv)
        Me.PanelReportes.Controls.Add(Me.BtnReporteRoles)
        Me.PanelReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReportes.Location = New System.Drawing.Point(0, 276)
        Me.PanelReportes.Name = "PanelReportes"
        Me.PanelReportes.Size = New System.Drawing.Size(250, 188)
        Me.PanelReportes.TabIndex = 4
        '
        'BtnReporteRoles
        '
        Me.BtnReporteRoles.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteRoles.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnReporteRoles.Location = New System.Drawing.Point(0, 0)
        Me.BtnReporteRoles.Name = "BtnReporteRoles"
        Me.BtnReporteRoles.Size = New System.Drawing.Size(250, 44)
        Me.BtnReporteRoles.TabIndex = 0
        Me.BtnReporteRoles.Text = "Roles y Usuarios"
        Me.BtnReporteRoles.UseVisualStyleBackColor = True
        '
        'BtnMovimientoInv
        '
        Me.BtnMovimientoInv.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMovimientoInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMovimientoInv.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnMovimientoInv.Location = New System.Drawing.Point(0, 44)
        Me.BtnMovimientoInv.Name = "BtnMovimientoInv"
        Me.BtnMovimientoInv.Size = New System.Drawing.Size(250, 44)
        Me.BtnMovimientoInv.TabIndex = 1
        Me.BtnMovimientoInv.Text = "Movimiento De Inventario"
        Me.BtnMovimientoInv.UseVisualStyleBackColor = True
        '
        'BtnProcesadosNot
        '
        Me.BtnProcesadosNot.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProcesadosNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcesadosNot.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnProcesadosNot.Location = New System.Drawing.Point(0, 88)
        Me.BtnProcesadosNot.Name = "BtnProcesadosNot"
        Me.BtnProcesadosNot.Size = New System.Drawing.Size(250, 44)
        Me.BtnProcesadosNot.TabIndex = 2
        Me.BtnProcesadosNot.Text = "Pedidos Procesados y no procesados"
        Me.BtnProcesadosNot.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 119)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BtnRegresar.Location = New System.Drawing.Point(0, 550)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(250, 44)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 594)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FrmAdmin"
        Me.Text = "FrmAdmin"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelReportes.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInvetario As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelReportes As Panel
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnPedidos As Button
    Friend WithEvents BtnMovimientoInv As Button
    Friend WithEvents BtnReporteRoles As Button
    Friend WithEvents BtnProcesadosNot As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnRegresar As Button
End Class
