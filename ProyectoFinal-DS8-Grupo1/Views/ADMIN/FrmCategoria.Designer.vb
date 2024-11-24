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
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtCategoriaNew = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPageUpdate = New System.Windows.Forms.TabPage()
        Me.BtnBusAct = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPageMostrar = New System.Windows.Forms.TabPage()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnBusqueda = New System.Windows.Forms.Button()
        Me.DgbCategoria = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPageEliminar = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DgvCategorias = New System.Windows.Forms.DataGridView()
        Me.txtCateElimar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelSALIR = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControlCategoria.SuspendLayout()
        Me.TabPageInsertar.SuspendLayout()
        Me.TabPageUpdate.SuspendLayout()
        Me.TabPageMostrar.SuspendLayout()
        CType(Me.DgbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEliminar.SuspendLayout()
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSALIR.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlCategoria
        '
        Me.TabControlCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlCategoria.Controls.Add(Me.TabPageInsertar)
        Me.TabControlCategoria.Controls.Add(Me.TabPageUpdate)
        Me.TabControlCategoria.Controls.Add(Me.TabPageMostrar)
        Me.TabControlCategoria.Controls.Add(Me.TabPageEliminar)
        Me.TabControlCategoria.Location = New System.Drawing.Point(178, 155)
        Me.TabControlCategoria.Name = "TabControlCategoria"
        Me.TabControlCategoria.SelectedIndex = 0
        Me.TabControlCategoria.Size = New System.Drawing.Size(775, 438)
        Me.TabControlCategoria.TabIndex = 0
        '
        'TabPageInsertar
        '
        Me.TabPageInsertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.TabPageInsertar.Controls.Add(Me.BtnAgregar)
        Me.TabPageInsertar.Controls.Add(Me.txtCategoriaNew)
        Me.TabPageInsertar.Controls.Add(Me.Label2)
        Me.TabPageInsertar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInsertar.Name = "TabPageInsertar"
        Me.TabPageInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInsertar.Size = New System.Drawing.Size(767, 409)
        Me.TabPageInsertar.TabIndex = 0
        Me.TabPageInsertar.Text = "Insertar Categoria"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(192, 294)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(382, 62)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar Categoria"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtCategoriaNew
        '
        Me.txtCategoriaNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoriaNew.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoriaNew.Location = New System.Drawing.Point(231, 173)
        Me.txtCategoriaNew.Name = "txtCategoriaNew"
        Me.txtCategoriaNew.Size = New System.Drawing.Size(284, 27)
        Me.txtCategoriaNew.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ingrese La Nueva Categoria"
        '
        'TabPageUpdate
        '
        Me.TabPageUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.TabPageUpdate.Controls.Add(Me.BtnBusAct)
        Me.TabPageUpdate.Controls.Add(Me.txtCategoria)
        Me.TabPageUpdate.Controls.Add(Me.BtnActualizar)
        Me.TabPageUpdate.Controls.Add(Me.txtNombre)
        Me.TabPageUpdate.Controls.Add(Me.txtId)
        Me.TabPageUpdate.Controls.Add(Me.Label5)
        Me.TabPageUpdate.Controls.Add(Me.Label4)
        Me.TabPageUpdate.Controls.Add(Me.Label3)
        Me.TabPageUpdate.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUpdate.Name = "TabPageUpdate"
        Me.TabPageUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUpdate.Size = New System.Drawing.Size(767, 409)
        Me.TabPageUpdate.TabIndex = 1
        Me.TabPageUpdate.Text = "Actualizar Categoria"
        '
        'BtnBusAct
        '
        Me.BtnBusAct.FlatAppearance.BorderSize = 0
        Me.BtnBusAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBusAct.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusAct.Location = New System.Drawing.Point(461, 290)
        Me.BtnBusAct.Name = "BtnBusAct"
        Me.BtnBusAct.Size = New System.Drawing.Size(181, 45)
        Me.BtnBusAct.TabIndex = 9
        Me.BtnBusAct.Text = "Buscar Categoria"
        Me.BtnBusAct.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(225, 93)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(316, 27)
        Me.txtCategoria.TabIndex = 8
        '
        'BtnActualizar
        '
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(125, 290)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(237, 45)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar Categoria"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(427, 192)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(249, 27)
        Me.txtNombre.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(91, 192)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(249, 27)
        Me.txtId.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(473, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Seleccione La Categoria A Actualizar"
        '
        'TabPageMostrar
        '
        Me.TabPageMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.TabPageMostrar.Controls.Add(Me.BtnMostrar)
        Me.TabPageMostrar.Controls.Add(Me.BtnBusqueda)
        Me.TabPageMostrar.Controls.Add(Me.DgbCategoria)
        Me.TabPageMostrar.Controls.Add(Me.txtBusqueda)
        Me.TabPageMostrar.Controls.Add(Me.Label7)
        Me.TabPageMostrar.Controls.Add(Me.Label6)
        Me.TabPageMostrar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageMostrar.Name = "TabPageMostrar"
        Me.TabPageMostrar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMostrar.Size = New System.Drawing.Size(767, 409)
        Me.TabPageMostrar.TabIndex = 2
        Me.TabPageMostrar.Text = "Buscar Categoria"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.Location = New System.Drawing.Point(561, 296)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(187, 49)
        Me.BtnMostrar.TabIndex = 5
        Me.BtnMostrar.Text = "Mostrar Categorias"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.FlatAppearance.BorderSize = 0
        Me.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBusqueda.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusqueda.Location = New System.Drawing.Point(561, 206)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(181, 50)
        Me.BtnBusqueda.TabIndex = 4
        Me.BtnBusqueda.Text = "Buscar Categoria"
        Me.BtnBusqueda.UseVisualStyleBackColor = True
        '
        'DgbCategoria
        '
        Me.DgbCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbCategoria.Location = New System.Drawing.Point(37, 179)
        Me.DgbCategoria.Name = "DgbCategoria"
        Me.DgbCategoria.RowHeadersWidth = 51
        Me.DgbCategoria.RowTemplate.Height = 24
        Me.DgbCategoria.Size = New System.Drawing.Size(481, 203)
        Me.DgbCategoria.TabIndex = 3
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(414, 105)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(265, 27)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Ingrese el nombre de la categoria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(352, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Buscar Y Mostrar Categorias"
        '
        'TabPageEliminar
        '
        Me.TabPageEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.TabPageEliminar.Controls.Add(Me.BtnEliminar)
        Me.TabPageEliminar.Controls.Add(Me.DgvCategorias)
        Me.TabPageEliminar.Controls.Add(Me.txtCateElimar)
        Me.TabPageEliminar.Controls.Add(Me.Label9)
        Me.TabPageEliminar.Controls.Add(Me.Label8)
        Me.TabPageEliminar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEliminar.Name = "TabPageEliminar"
        Me.TabPageEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEliminar.Size = New System.Drawing.Size(767, 409)
        Me.TabPageEliminar.TabIndex = 3
        Me.TabPageEliminar.Text = "Eliminar Categoria"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(517, 256)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(244, 53)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar Categoria"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DgvCategorias
        '
        Me.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategorias.Location = New System.Drawing.Point(36, 195)
        Me.DgvCategorias.Name = "DgvCategorias"
        Me.DgvCategorias.RowHeadersWidth = 51
        Me.DgvCategorias.RowTemplate.Height = 24
        Me.DgvCategorias.Size = New System.Drawing.Size(469, 183)
        Me.DgvCategorias.TabIndex = 3
        '
        'txtCateElimar
        '
        Me.txtCateElimar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCateElimar.Location = New System.Drawing.Point(437, 123)
        Me.txtCateElimar.Name = "txtCateElimar"
        Me.txtCateElimar.Size = New System.Drawing.Size(238, 27)
        Me.txtCateElimar.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(92, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Ingrese la categoria a eliminar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Eliminar Categoria"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(438, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 43)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CATEGORIAS"
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 703)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelSALIR)
        Me.Controls.Add(Me.TabControlCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCategoria"
        Me.Text = "FrmCategoria"
        Me.TabControlCategoria.ResumeLayout(False)
        Me.TabPageInsertar.ResumeLayout(False)
        Me.TabPageInsertar.PerformLayout()
        Me.TabPageUpdate.ResumeLayout(False)
        Me.TabPageUpdate.PerformLayout()
        Me.TabPageMostrar.ResumeLayout(False)
        Me.TabPageMostrar.PerformLayout()
        CType(Me.DgbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEliminar.ResumeLayout(False)
        Me.TabPageEliminar.PerformLayout()
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSALIR.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlCategoria As TabControl
    Friend WithEvents TabPageInsertar As TabPage
    Friend WithEvents TabPageUpdate As TabPage
    Friend WithEvents PanelSALIR As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TabPageMostrar As TabPage
    Friend WithEvents TabPageEliminar As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents txtCategoriaNew As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnBusqueda As Button
    Friend WithEvents DgbCategoria As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DgvCategorias As DataGridView
    Friend WithEvents txtCateElimar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents BtnBusAct As Button
End Class
