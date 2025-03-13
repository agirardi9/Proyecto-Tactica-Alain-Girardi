Public Class vVentasItems
    Dim id, idVenta, idProducto As Integer
    Dim precioUnitario, cantidad, precioTotal As Double

    Public Property gIdVentasItems
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property gIdVenta
        Get
            Return idVenta
        End Get
        Set(value)
            idVenta = value
        End Set
    End Property
    Public Property gIdProducto
        Get
            Return idProducto
        End Get
        Set(value)
            idProducto = value
        End Set
    End Property
    Public Property gPrecioUnitario
        Get
            Return precioUnitario
        End Get
        Set(value)
            precioUnitario = value
        End Set
    End Property
    Public Property gCantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property

    Public Property gPrecioTotal
        Get
            Return precioTotal
        End Get
        Set(value)
            precioTotal = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal idVenta As Integer, ByVal idProducto As Integer, ByVal precioUnitario As Double, ByVal cantidad As Double, ByVal precioTotal As Double)
        gIdVentasItems = id
        gIdVenta = idVenta
        gIdProducto = idProducto
        gPrecioUnitario = precioUnitario
        gCantidad = cantidad
        gPrecioTotal = precioTotal
    End Sub

End Class
