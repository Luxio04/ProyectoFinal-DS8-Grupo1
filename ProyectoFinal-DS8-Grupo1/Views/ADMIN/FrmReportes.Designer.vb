<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Dim Button1 As System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grupoUsuarios = New System.Windows.Forms.GroupBox()
        Me.grupoInventario = New System.Windows.Forms.GroupBox()
        Me.grupoPedidos = New System.Windows.Forms.GroupBox()
        Me.listDatos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Button1 = New System.Windows.Forms.Button()
        Me.grupoUsuarios.SuspendLayout()
        Me.grupoInventario.SuspendLayout()
        Me.grupoPedidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.Location = New System.Drawing.Point(47, 189)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(142, 39)
        Button1.TabIndex = 0
        Button1.Text = "Generar reporte"
        Button1.UseVisualStyleBackColor = True
        AddHandler Button1.Click, AddressOf Me.ButtonGenerarReporteRolesYUsuarios
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(50, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Generar reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(53, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Generar reporte"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(57, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(147, 41)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Reportes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reportes usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reporte inventario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reporte pedidos"
        '
        'grupoUsuarios
        '
        Me.grupoUsuarios.Controls.Add(Me.Label1)
        Me.grupoUsuarios.Controls.Add(Button1)
        Me.grupoUsuarios.Location = New System.Drawing.Point(11, 143)
        Me.grupoUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.grupoUsuarios.Name = "grupoUsuarios"
        Me.grupoUsuarios.Padding = New System.Windows.Forms.Padding(2)
        Me.grupoUsuarios.Size = New System.Drawing.Size(244, 242)
        Me.grupoUsuarios.TabIndex = 7
        Me.grupoUsuarios.TabStop = False
        Me.grupoUsuarios.Text = "USUARIOS"
        '
        'grupoInventario
        '
        Me.grupoInventario.Controls.Add(Me.Label2)
        Me.grupoInventario.Controls.Add(Me.Button2)
        Me.grupoInventario.Location = New System.Drawing.Point(11, 143)
        Me.grupoInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.grupoInventario.Name = "grupoInventario"
        Me.grupoInventario.Padding = New System.Windows.Forms.Padding(2)
        Me.grupoInventario.Size = New System.Drawing.Size(244, 242)
        Me.grupoInventario.TabIndex = 0
        Me.grupoInventario.TabStop = False
        Me.grupoInventario.Text = "INVENTARIO"
        '
        'grupoPedidos
        '
        Me.grupoPedidos.Controls.Add(Me.Label3)
        Me.grupoPedidos.Controls.Add(Me.Button3)
        Me.grupoPedidos.Location = New System.Drawing.Point(11, 143)
        Me.grupoPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.grupoPedidos.Name = "grupoPedidos"
        Me.grupoPedidos.Padding = New System.Windows.Forms.Padding(2)
        Me.grupoPedidos.Size = New System.Drawing.Size(244, 242)
        Me.grupoPedidos.TabIndex = 8
        Me.grupoPedidos.TabStop = False
        Me.grupoPedidos.Text = "PEDIDOS"
        '
        'listDatos
        '
        Me.listDatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.listDatos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listDatos.FullRowSelect = True
        Me.listDatos.GridLines = True
        Me.listDatos.HideSelection = False
        Me.listDatos.Location = New System.Drawing.Point(267, 111)
        Me.listDatos.Name = "listDatos"
        Me.listDatos.Size = New System.Drawing.Size(554, 379)
        Me.listDatos.TabIndex = 9
        Me.listDatos.UseCompatibleStateImageBehavior = False
        Me.listDatos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Usuario"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Correo electronico"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Rol del usuario"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(441, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Previsualizacion de Usuarios y sus roles"
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.listDatos)
        Me.Controls.Add(Me.grupoPedidos)
        Me.Controls.Add(Me.grupoInventario)
        Me.Controls.Add(Me.grupoUsuarios)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmReportes"
        Me.Text = "FrmReportes"
        Me.grupoUsuarios.ResumeLayout(False)
        Me.grupoUsuarios.PerformLayout()
        Me.grupoInventario.ResumeLayout(False)
        Me.grupoInventario.PerformLayout()
        Me.grupoPedidos.ResumeLayout(False)
        Me.grupoPedidos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grupoUsuarios As GroupBox
    Friend WithEvents grupoInventario As GroupBox
    Friend WithEvents grupoPedidos As GroupBox
    Friend WithEvents listDatos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label4 As Label
End Class
