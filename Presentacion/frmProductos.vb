Public Class frmProductos
    Private dt As New DataTable
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtProducto.Text = ""
        txtPrecio.Text = ""
        txtCategoria.Text = ""
        txtId.Text = ""


    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fProducto
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
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    'Private Sub txtId_Validating(sender As Object, e As CancelEventArgs) Handles txtId.Validating
    '   If DirectCast(sender, TextBox).Text.Length > 0 Then
    '   Me.errorIcono.SetError(sender, "")
    '   Else
    '   Me.errorIcono.SetError(sender, "Ingrese el ID del cliente, estre dato es obligatorio")
    '   End If
    '   End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged

    End Sub

    Private Sub txtProducto_Validated(sender As Object, e As EventArgs) Handles txtProducto.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del producto, estre dato es obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtPrecio_Validated(sender As Object, e As EventArgs) Handles txtPrecio.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el Precio del producto, estre dato es obligatorio")
        End If
    End Sub

    Private Sub txtCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtCategoria.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el correo del cliente, estre dato es obligatorio")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtProducto.Text <> "" And txtPrecio.Text <> "" And txtCategoria.Text <> "" Then
            Try
                Dim dts As New vProducto
                Dim func As New fProducto
                'dts.gIdCliente = txtId.Text
                dts.gNombre = txtProducto.Text
                dts.gPrecio = txtPrecio.Text
                dts.gCategoria = txtCategoria.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Producto no registrado, intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtProducto.Text = dataListado.SelectedCells.Item(2).Value
        txtPrecio.Text = dataListado.SelectedCells.Item(3).Value
        txtCategoria.Text = dataListado.SelectedCells.Item(4).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea modificar el producto seleccionado?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtProducto.Text <> "" And txtPrecio.Text <> "" And txtCategoria.Text <> "" And txtId.Text <> "" Then
                Try
                    Dim dts As New vProducto
                    Dim func As New fProducto
                    dts.gIdProducto = txtId.Text
                    dts.gNombre = txtProducto.Text
                    dts.gPrecio = txtPrecio.Text
                    dts.gCategoria = txtCategoria.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Producto modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("El producto no fue modificado, intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente quieres eliminar los productos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim vdb As New vProducto
                        Dim func As New fProducto
                        vdb.gIdProducto = onekey

                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("Producto no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If


                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando la eliminancion del registro", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

        Call limpiar()
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCampo.SelectedIndexChanged

    End Sub
End Class