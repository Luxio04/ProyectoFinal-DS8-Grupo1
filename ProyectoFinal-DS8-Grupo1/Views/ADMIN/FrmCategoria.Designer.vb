<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoria))
        Me.TabControlCategoria = New System.Windows.Forms.TabControl()
        Me.TabPageInsertar = New System.Windows.Forms.TabPage()
        Me.TabPageUpdate = New System.Windows.Forms.TabPage()
        Me.PanelSALIR = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TabPageMostrar = New System.Windows.Forms.TabPage()
        Me.TabPageEliminar = New System.Windows.Forms.TabPage()
        Me.TabControlCategoria.SuspendLayout()
        Me.PanelSALIR.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlCategoria
        '
        Me.TabControlCategoria.Controls.Add(Me.TabPageInsertar)
        Me.TabControlCategoria.Controls.Add(Me.TabPageUpdate)
        Me.TabControlCategoria.Controls.Add(Me.TabPageMostrar)
        Me.TabControlCategoria.Controls.Add(Me.TabPageEliminar)
        Me.TabControlCategoria.Location = New System.Drawing.Point(66, 99)
        Me.TabControlCategoria.Name = "TabControlCategoria"
        Me.TabControlCategoria.SelectedIndex = 0
        Me.TabControlCategoria.Size = New System.Drawing.Size(999, 564)
        Me.TabControlCategoria.TabIndex = 0
        '
        'TabPageInsertar
        '
        Me.TabPageInsertar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInsertar.Name = "TabPageInsertar"
        Me.TabPageInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInsertar.Size = New System.Drawing.Size(991, 535)
        Me.TabPageInsertar.TabIndex = 0
        Me.TabPageInsertar.Text = "Insertar Categoria"
        Me.TabPageInsertar.UseVisualStyleBackColor = True
        '
        'TabPageUpdate
        '
        Me.TabPageUpdate.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUpdate.Name = "TabPageUpdate"
        Me.TabPageUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUpdate.Size = New System.Drawing.Size(991, 535)
        Me.TabPageUpdate.TabIndex = 1
        Me.TabPageUpdate.Text = "Actualizar Categoria"
        Me.TabPageUpdate.UseVisualStyleBackColor = True
        '
        'PanelSALIR
        '
        Me.PanelSALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PanelSALIR.Controls.Add(Me.BtnCerrar)
        Me.PanelSALIR.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSALIR.Location = New System.Drawing.Point(0, 0)
        Me.PanelSALIR.Name = "PanelSALIR"
        Me.PanelSALIR.Size = New System.Drawing.Size(1131, 37)
        Me.PanelSALIR.TabIndex = 11
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(120, 37)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'TabPageMostrar
        '
        Me.TabPageMostrar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageMostrar.Name = "TabPageMostrar"
        Me.TabPageMostrar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMostrar.Size = New System.Drawing.Size(991, 535)
        Me.TabPageMostrar.TabIndex = 2
        Me.TabPageMostrar.Text = "Buscar Categoria"
        Me.TabPageMostrar.UseVisualStyleBackColor = True
        '
        'TabPageEliminar
        '
        Me.TabPageEliminar.BackColor = System.Drawing.Color.RosyBrown
        Me.TabPageEliminar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEliminar.Name = "TabPageEliminar"
        Me.TabPageEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEliminar.Size = New System.Drawing.Size(991, 535)
        Me.TabPageEliminar.TabIndex = 3
        Me.TabPageEliminar.Text = "Eliminar Categoria"
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 703)
        Me.Controls.Add(Me.PanelSALIR)
        Me.Controls.Add(Me.TabControlCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCategoria"
        Me.Text = "FrmCategoria"
        Me.TabControlCategoria.ResumeLayout(False)
        Me.PanelSALIR.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlCategoria As TabControl
    Friend WithEvents TabPageInsertar As TabPage
    Friend WithEvents TabPageUpdate As TabPage
    Friend WithEvents PanelSALIR As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TabPageMostrar As TabPage
    Friend WithEvents TabPageEliminar As TabPage
End Class
