Public Class vVenta
    Dim id, idCliente As Integer
    Dim fecha As Date
    Dim total As Double

    Public Property gIdVenta
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property gIdCliente
        Get
            Return idCliente
        End Get
        Set(value)
            idCliente = value
        End Set
    End Property
    Public Property gFecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
    Public Property gTotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal idCliente As Integer, ByVal fecha As Date, ByVal total As Double)
        gIdVenta = id
        gIdCliente = idCliente
        gFecha = fecha
        gTotal = total
    End Sub
End Class
