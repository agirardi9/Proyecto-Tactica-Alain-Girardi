Imports System.ComponentModel
Imports System.Configuration
Imports System.Linq.Expressions
Imports System.Net.Http.Json
Imports System.Reflection
Imports System.Timers
Imports Microsoft.Win32

Public Class frmClientes
    Private dt As New DataTable
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtCliente.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtId.Text = ""


    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fCliente
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

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged

    End Sub

    Private Sub txtCliente_Validated(sender As Object, e As EventArgs) Handles txtCliente.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del cliente, estre dato es obligatorio")
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefono_Validated(sender As Object, e As EventArgs) Handles txtTelefono.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el Telefono del cliente, estre dato es obligatorio")
        End If
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el correo del cliente, estre dato es obligatorio")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtCliente.Text <> "" And txtTelefono.Text <> "" And txtCorreo.Text <> "" Then
            Try
                Dim dts As New vCliente
                Dim func As New fCliente
                'dts.gIdCliente = txtId.Text
                dts.gNomCliente = txtCliente.Text
                dts.gTelefono = txtTelefono.Text
                dts.gCorreo = txtCorreo.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Cliente registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no registrado, intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtCliente.Text = dataListado.SelectedCells.Item(2).Value
        txtTelefono.Text = dataListado.SelectedCells.Item(3).Value
        txtCorreo.Text = dataListado.SelectedCells.Item(4).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea modificar el cliente seleccionado?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtCliente.Text <> "" And txtTelefono.Text <> "" And txtCorreo.Text <> "" And txtId.Text <> "" Then
                Try
                    Dim dts As New vCliente
                    Dim func As New fCliente
                    dts.gIdCliente = txtId.Text
                    dts.gNomCliente = txtCliente.Text
                    dts.gTelefono = txtTelefono.Text
                    dts.gCorreo = txtCorreo.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Cliente modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("El cliente no fue modificado, intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("¿Realmente quieres eliminar los clientes seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim vdb As New vCliente
                        Dim func As New fCliente
                        vdb.gIdCliente = onekey

                        If func.elimiar(vdb) Then

                        Else
                            MessageBox.Show("Cliente no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub dataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        If txtFlag.Text = "1" Then
            frmVenta.txtIdCliente.Text = dataListado.SelectedCells.Item(1).Value
            frmVenta.txtNombreCliente.Text = dataListado.SelectedCells.Item(2).Value
            Me.Close()

        End If
    End Sub
End Class