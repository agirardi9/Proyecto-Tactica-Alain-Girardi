﻿Imports System.Data.SqlClient

Public Class conexion
    Protected cnn As New sqlConnection

    Public IdUsuario As Integer

    Protected Function conectado()
        Try
            cnn = New SqlConnection("data source = DESKTOP-OF52SKI\MSSQLSERVER2008;initial catalog=pruebademo;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function
End Class
