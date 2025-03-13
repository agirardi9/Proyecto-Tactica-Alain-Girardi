Public Class frmVenta
    Private dt As New DataTable
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub


    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtIdCliente.Text = ""
        txtFecha.Text = ""
        txtTotal.Text = ""
        txtId.Text = ""


    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fVenta
            dt = func.mostrar
            dataListado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                txtBuscar.Enabled = True
                dataListado.ColumnHeadersVisible = True
                linkLabel.Visible = False
            Else
                dataListado.DataSource = Nothing
                txtBuscar.Enabled = False
                dataListado.ColumnHeadersVisible = False
                linkLabel.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True
        btnEditar.Visible = False

        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cboCampo.Text & " like '" & txtBuscar.Text & "%'"
            If dv.Count <> 0 Then
                linkLabel.Visible = False
                dataListado.DataSource = dv
                ocultarColumnas()

            End If
            linkLabel.Visible = True
            dataListado.DataSource = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultarColumnas()
        dataListado.Columns(1).Visible = False
        dataListado.Columns(2).Visible = False
    End Sub



    'Private Sub txtId_Validating(sender As Object, e As CancelEventArgs) Handles txtId.Validating
    '   If DirectCast(sender, TextBox).Text.Length > 0 Then
    '   Me.errorIcono.SetError(sender, "")
    '   Else
    '   Me.errorIcono.SetError(sender, "Ingrese el ID del cliente, estre dato es obligatorio")
    '   End If
    '   End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub txtIdCliente_Validated(sender As Object, e As EventArgs) Handles txtIdCliente.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            errorIcono.SetError(sender, "")
        Else
            errorIcono.SetError(sender, "Ingrese el nombre del cliente, estre dato es obligatorio")
        End If
    End Sub



    ' Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
    ' If DirectCast(sender, TextBox).Text.Length > 0 Then
    '         errorIcono.SetError(sender, "")
    '     Else
    '        errorIcono.SetError(sender, "Ingrese el Telefono del cliente, estre dato es obligatorio")
    'End If
    'End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el correo del cliente, estre dato es obligatorio")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtIdCliente.Text <> "" And txtFecha.Text <> "" And txtTotal.Text <> "" Then
            Try
                Dim dts As New vVenta
                Dim func As New fVenta
                'dts.gIdCliente = txtId.Text
                dts.gIdCliente = txtIdCliente.Text
                dts.gFecha = txtFecha.Text
                dts.gTotal = txtTotal.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Venta registrada correctamente, vamos a añadir los productos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargarDetalle()
                Else
                    MessageBox.Show("Venta no registrada, intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos, intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value

        End If
    End Sub

    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        txtIdCliente.Text = dataListado.SelectedCells.Item(2).Value
        txtFecha.Text = dataListado.SelectedCells.Item(3).Value
        txtTotal.Text = dataListado.SelectedCells.Item(4).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea modificar la venta seleccionada?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtIdCliente.Text <> "" And txtFecha.Text <> "" And txtTotal.Text <> "" And txtId.Text <> "" Then
                Try
                    Dim dts As New vVenta
                    Dim func As New fVenta
                    dts.gIdVenta = txtId.Text
                    dts.gIdCliente = txtIdCliente.Text
                    dts.gFecha = txtFecha.Text
                    dts.gTotal = txtTotal.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Venta modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("La venta no fue modificada, intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos, intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    '   Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
    '  Dim result As DialogResult
    '     result = MessageBox.Show("¿Realmente quieres eliminar las ventas seleccionadas?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    'If result = DialogResult.OK Then
    'Try
    'For Each row As DataGridViewRow In dataListado.Rows
    'Dim marcado = Convert.ToBoolean(row.Cells("Eliminar").Value)
    '
    'If marcado Then
    'Dim onekey = Convert.ToInt32(row.Cells("ID").Value)
    'Dim vdb As New vCliente
    'Dim func As New fCliente
    '                   vdb.gIdCliente = onekey
    '
    'If func.elimiar(vdb) Then
    '
    'Else
    '                       MessageBox.Show("Cliente no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '   End If
    '  End If


    '  Next
    '             mostrar()

    ' Catch ex As Exception
    '            MsgBox(ex.Message)
    'End Try
    'Else
    '       MessageBox.Show("Cancelando la eliminancion del registro", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '      mostrar()
    'End If

    '   limpiar()
    'End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()

    End Sub

    Private Sub lblCLiente_Click(sender As Object, e As EventArgs) Handles lblCLiente.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles txtFecha.ValueChanged

    End Sub

    Private Sub cargarDetalle()
        frmDetalleDeVenta.txtId.Text = dataListado.SelectedCells.Item(1).Value
        frmDetalleDeVenta.txtIdCliente.Text = dataListado.SelectedCells.Item(2).Value
        frmDetalleDeVenta.txtNombreCliente.Text = dataListado.SelectedCells.Item(3).Value
        frmDetalleDeVenta.txtFecha.Text = dataListado.SelectedCells.Item(4).Value
        frmDetalleDeVenta.txtTotal.Text = dataListado.SelectedCells.Item(5).Value

        frmDetalleDeVenta.ShowDialog()
    End Sub

    Private Sub dataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        cargarDetalle()

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmClientes.txtFlag.Text = "1"
        frmClientes.ShowDialog()
    End Sub
End Class