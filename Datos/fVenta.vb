Imports System.Data.SqlClient
Imports System.Diagnostics.CodeAnalysis

Public Class fVenta
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_venta")
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

    Public Function insertar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@ID", dts.gIdCliente)
            cmd.Parameters.AddWithValue("@idCliente", dts.gIdCliente)
            cmd.Parameters.AddWithValue("@fecha", dts.gFecha)
            cmd.Parameters.AddWithValue("@total", dts.gTotal)
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

    Public Function editar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@idCliente", dts.gIdCliente)
            cmd.Parameters.AddWithValue("@fecha", dts.gFecha)
            cmd.Parameters.AddWithValue("@total", dts.gTotal)
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

    Public Function elimiar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = dts.gIdVenta
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
