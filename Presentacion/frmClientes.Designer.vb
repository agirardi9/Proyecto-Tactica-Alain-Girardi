<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        GroupBox1 = New GroupBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnEditar = New Button()
        btnNuevo = New Button()
        txtCorreo = New TextBox()
        lblCorreo = New Label()
        txtTelefono = New TextBox()
        txtCliente = New TextBox()
        txtId = New TextBox()
        lblTelefono = New Label()
        lblCLiente = New Label()
        lblID = New Label()
        GroupBox2 = New GroupBox()
        cbEliminar = New CheckBox()
        btnEliminar = New Button()
        linkLabel = New LinkLabel()
        txtBuscar = New TextBox()
        cboCampo = New ComboBox()
        dataListado = New DataGridView()
        Eliminar = New DataGridViewCheckBoxColumn()
        errorIcono = New ErrorProvider(components)
        txtFlag = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dataListado, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorIcono, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnCancelar)
        GroupBox1.Controls.Add(btnEditar)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(txtCorreo)
        GroupBox1.Controls.Add(lblCorreo)
        GroupBox1.Controls.Add(txtTelefono)
        GroupBox1.Controls.Add(txtCliente)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(lblTelefono)
        GroupBox1.Controls.Add(lblCLiente)
        GroupBox1.Controls.Add(lblID)
        GroupBox1.Location = New Point(26, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(406, 441)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mantenimiento"
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
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(128, 257)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(209, 27)
        txtCorreo.TabIndex = 7
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(32, 264)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(54, 20)
        lblCorreo.TabIndex = 6
        lblCorreo.Text = "Correo"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(128, 190)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(209, 27)
        txtTelefono.TabIndex = 5
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(128, 123)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(209, 27)
        txtCliente.TabIndex = 4
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(128, 55)
        txtId.Name = "txtId"
        txtId.Size = New Size(209, 27)
        txtId.TabIndex = 3
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(32, 197)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(67, 20)
        lblTelefono.TabIndex = 2
        lblTelefono.Text = "Telefono"
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbEliminar)
        GroupBox2.Controls.Add(btnEliminar)
        GroupBox2.Controls.Add(linkLabel)
        GroupBox2.Controls.Add(txtBuscar)
        GroupBox2.Controls.Add(cboCampo)
        GroupBox2.Controls.Add(dataListado)
        GroupBox2.Location = New Point(469, 30)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(667, 578)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Clientes"
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
        cboCampo.Items.AddRange(New Object() {"ID", "Nombre Cliente", "Telefono", "Correo"})
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
        ' errorIcono
        ' 
        errorIcono.ContainerControl = Me
        ' 
        ' txtFlag
        ' 
        txtFlag.Location = New Point(293, 12)
        txtFlag.Name = "txtFlag"
        txtFlag.Size = New Size(70, 27)
        txtFlag.TabIndex = 2
        txtFlag.Text = "0"
        txtFlag.Visible = False
        ' 
        ' frmClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 620)
        Controls.Add(txtFlag)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmClientes"
        Text = "Listado de Clientes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dataListado, ComponentModel.ISupportInitialize).EndInit()
        CType(errorIcono, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCLiente As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents linkLabel As LinkLabel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cbEliminar As CheckBox
    Friend WithEvents txtFlag As TextBox
End Class
