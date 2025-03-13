<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleDeVenta
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
        txtFecha = New DateTimePicker()
        txtNombreCliente = New TextBox()
        lblCLiente = New Label()
        lblID = New Label()
        cbEliminar = New CheckBox()
        GroupBox2 = New GroupBox()
        linkLabel = New LinkLabel()
        txtBuscar = New TextBox()
        cboCampo = New ComboBox()
        dataListado = New DataGridView()
        Eliminar = New DataGridViewCheckBoxColumn()
        lblTelefono = New Label()
        btnBuscarCliente = New Button()
        txtIdCliente = New TextBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnEditar = New Button()
        btnNuevo = New Button()
        txtTotal = New TextBox()
        lblCorreo = New Label()
        errorIcono = New ErrorProvider(components)
        txtId = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox2.SuspendLayout()
        CType(dataListado, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorIcono, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtFecha
        ' 
        txtFecha.Format = DateTimePickerFormat.Short
        txtFecha.Location = New Point(128, 192)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(272, 27)
        txtFecha.TabIndex = 14
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(180, 123)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(157, 27)
        txtNombreCliente.TabIndex = 12
        ' 
        ' lblCLiente
        ' 
        lblCLiente.AutoSize = True
        lblCLiente.Location = New Point(32, 130)
        lblCLiente.Name = "lblCLiente"
        lblCLiente.Size = New Size(55, 20)
        lblCLiente.TabIndex = 1
        lblCLiente.Text = "Cliente"
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbEliminar)
        GroupBox2.Controls.Add(linkLabel)
        GroupBox2.Controls.Add(txtBuscar)
        GroupBox2.Controls.Add(cboCampo)
        GroupBox2.Controls.Add(dataListado)
        GroupBox2.Location = New Point(466, 47)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(853, 578)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Ventas"
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
        txtBuscar.Text = "ID Venta"
        ' 
        ' cboCampo
        ' 
        cboCampo.FormattingEnabled = True
        cboCampo.Items.AddRange(New Object() {"ID", "Nombre Cliente", "Fecha"})
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
        dataListado.Size = New Size(818, 401)
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
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(32, 197)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(47, 20)
        lblTelefono.TabIndex = 2
        lblTelefono.Text = "Fecha"
        ' 
        ' btnBuscarCliente
        ' 
        btnBuscarCliente.Location = New Point(343, 121)
        btnBuscarCliente.Name = "btnBuscarCliente"
        btnBuscarCliente.Size = New Size(57, 29)
        btnBuscarCliente.TabIndex = 13
        btnBuscarCliente.Text = "..."
        btnBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' txtIdCliente
        ' 
        txtIdCliente.Location = New Point(128, 123)
        txtIdCliente.Name = "txtIdCliente"
        txtIdCliente.Size = New Size(46, 27)
        txtIdCliente.TabIndex = 4
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
        ' txtTotal
        ' 
        txtTotal.Location = New Point(128, 257)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(272, 27)
        txtTotal.TabIndex = 7
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(32, 264)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(42, 20)
        lblCorreo.TabIndex = 6
        lblCorreo.Text = "Total"
        ' 
        ' errorIcono
        ' 
        errorIcono.ContainerControl = Me
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(128, 55)
        txtId.Name = "txtId"
        txtId.Size = New Size(272, 27)
        txtId.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtFecha)
        GroupBox1.Controls.Add(btnBuscarCliente)
        GroupBox1.Controls.Add(txtNombreCliente)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnCancelar)
        GroupBox1.Controls.Add(btnEditar)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(txtTotal)
        GroupBox1.Controls.Add(lblCorreo)
        GroupBox1.Controls.Add(txtIdCliente)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(lblTelefono)
        GroupBox1.Controls.Add(lblCLiente)
        GroupBox1.Controls.Add(lblID)
        GroupBox1.Location = New Point(21, 47)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(406, 441)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mantenimiento"
        ' 
        ' frmDetalleDeVenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1340, 673)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmDetalleDeVenta"
        Text = "frmDetalleDeVenta"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dataListado, ComponentModel.ISupportInitialize).EndInit()
        CType(errorIcono, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblCLiente As Label
    Friend WithEvents lblID As Label
    Friend WithEvents cbEliminar As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents linkLabel As LinkLabel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents lblTelefono As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtId As TextBox
End Class
