Imports System.Data.SqlClient
Public Class fProducto
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_producto")
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

    Public Function insertar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@Precio", dts.gPrecio)
            cmd.Parameters.AddWithValue("@Categoria", dts.gCategoria)
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

    Public Function editar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID", dts.gIdProducto)
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@Precio", dts.gPrecio)
            cmd.Parameters.AddWithValue("@Categoria", dts.gCategoria)
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

    Public Function eliminar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = dts.gIdProducto
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
End Class
