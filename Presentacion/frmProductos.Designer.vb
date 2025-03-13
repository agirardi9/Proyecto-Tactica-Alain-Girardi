<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        components = New ComponentModel.Container()
        errorIcono = New ErrorProvider(components)
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnEditar = New Button()
        btnNuevo = New Button()
        txtCategoria = New TextBox()
        lblCategoria = New Label()
        txtPrecio = New TextBox()
        txtProducto = New TextBox()
        txtId = New TextBox()
        btnEliminar = New Button()
        linkLabel = New LinkLabel()
        txtBuscar = New TextBox()
        cboCampo = New ComboBox()
        dataListado = New DataGridView()
        Eliminar = New DataGridViewCheckBoxColumn()
        lblPrecio = New Label()
        GroupBox2 = New GroupBox()
        cbEliminar = New CheckBox()
        lblProducto = New Label()
        lblID = New Label()
        GroupBox1 = New GroupBox()
        CType(errorIcono, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataListado, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' errorIcono
        ' 
        errorIcono.ContainerControl = Me
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(150, 320)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(267, 320)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 10
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(150, 320)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 9
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(32, 320)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(94, 29)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(128, 257)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(209, 27)
        txtCategoria.TabIndex = 7
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(32, 264)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(74, 20)
        lblCategoria.TabIndex = 6
        lblCategoria.Text = "Categoria"
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(128, 190)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(209, 27)
        txtPrecio.TabIndex = 5
        ' 
        ' txtProducto
        ' 
        txtProducto.Location = New Point(128, 123)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(209, 27)
        txtProducto.TabIndex = 4
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(128, 55)
        txtId.Name = "txtId"
        txtId.Size = New Size(209, 27)
        txtId.TabIndex = 3
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(29, 526)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(166, 34)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' linkLabel
        ' 
        linkLabel.AutoSize = True
        linkLabel.Location = New Point(245, 260)
        linkLabel.Name = "linkLabel"
        linkLabel.Size = New Size(68, 20)
        linkLabel.TabIndex = 3
        linkLabel.TabStop = True
        linkLabel.Text = "linkLabel"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(215, 31)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(323, 27)
        txtBuscar.TabIndex = 2
        ' 
        ' cboCampo
        ' 
        cboCampo.FormattingEnabled = True
        cboCampo.Items.AddRange(New Object() {"ID", "Nombre Producto", "Precio", "Categoria"})
        cboCampo.Location = New Point(29, 30)
        cboCampo.Name = "cboCampo"
        cboCampo.Size = New Size(151, 28)
        cboCampo.TabIndex = 1
        cboCampo.Text = "ID"
        ' 
        ' dataListado
        ' 
        dataListado.AllowUserToAddRows = False
        dataListado.AllowUserToDeleteRows = False
        dataListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataListado.Columns.AddRange(New DataGridViewColumn() {Eliminar})
        dataListado.Location = New Point(29, 104)
        dataListado.Name = "dataListado"
        dataListado.ReadOnly = True
        dataListado.RowHeadersWidth = 51
        dataListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataListado.Size = New Size(509, 401)
        dataListado.TabIndex = 0
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Eliminar"
        Eliminar.MinimumWidth = 6
        Eliminar.Name = "Eliminar"
        Eliminar.ReadOnly = True
        Eliminar.Width = 125
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(32, 197)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(50, 20)
        lblPrecio.TabIndex = 2
        lblPrecio.Text = "Precio"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbEliminar)
        GroupBox2.Controls.Add(btnEliminar)
        GroupBox2.Controls.Add(linkLabel)
        GroupBox2.Controls.Add(txtBuscar)
        GroupBox2.Controls.Add(cboCampo)
        GroupBox2.Controls.Add(dataListado)
        GroupBox2.Location = New Point(478, 30)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(667, 578)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Productos"
        ' 
        ' cbEliminar
        ' 
        cbEliminar.AutoSize = True
        cbEliminar.Location = New Point(33, 68)
        cbEliminar.Name = "cbEliminar"
        cbEliminar.Size = New Size(85, 24)
        cbEliminar.TabIndex = 5
        cbEliminar.Text = "Eliminar"
        cbEliminar.UseVisualStyleBackColor = True
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Location = New Point(32, 130)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(69, 20)
        lblProducto.TabIndex = 1
        lblProducto.Text = "Producto"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(32, 62)
        lblID.Name = "lblID"
        lblID.Size = New Size(24, 20)
        lblID.TabIndex = 0
        lblID.Text = "ID"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnCancelar)
        GroupBox1.Controls.Add(btnEditar)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(txtCategoria)
        GroupBox1.Controls.Add(lblCategoria)
        GroupBox1.Controls.Add(txtPrecio)
        GroupBox1.Controls.Add(txtProducto)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(lblPrecio)
        GroupBox1.Controls.Add(lblProducto)
        GroupBox1.Controls.Add(lblID)
        GroupBox1.Location = New Point(35, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(406, 441)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mantenimiento"
        ' 
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1171, 634)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmProductos"
        Text = "Listado de Productos"
        CType(errorIcono, ComponentModel.ISupportInitialize).EndInit()
        CType(dataListado, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbEliminar As CheckBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents linkLabel As LinkLabel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblID As Label
End Class
