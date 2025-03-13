Imports System.Data.SqlClient
Imports System.Diagnostics.CodeAnalysis
Public Class fVentasItems
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ventas_items")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function

    Public Function insertar(ByVal dts As vVentasItems) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_ventasItems")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@idProducto", dts.gIdProducto)
            cmd.Parameters.AddWithValue("@precioUnitario", dts.gPrecioUnitario)
            cmd.Parameters.AddWithValue("@cantidad", dts.gCantidad)
            cmd.Parameters.AddWithValue("@precioTotal", dts.gPrecioTotal)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vVentasItems) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_ventas_items")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id", dts.gIdVentasItems)
            cmd.Parameters.AddWithValue("@idVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@idProducto", dts.gIdProducto)
            cmd.Parameters.AddWithValue("@precioUnitario", dts.gPrecioUnitario)
            cmd.Parameters.AddWithValue("@cantidad", dts.gCantidad)
            cmd.Parameters.AddWithValue("@precioTotal", dts.gPrecioTotal)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function elimiar(ByVal dts As vVentasItems) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_ventas_items")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idVentasItems", SqlDbType.Int).Value = dts.gIdVentasItems
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
