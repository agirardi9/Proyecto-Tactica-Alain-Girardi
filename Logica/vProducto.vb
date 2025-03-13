Public Class vProducto
    Dim ID As Integer
    Dim Nombre, Categoria As String
    Dim Precio As Double



    Public Property gIdProducto
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    Public Property gNombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property

    Public Property gPrecio
        Get
            Return Precio
        End Get
        Set(value)
            Precio = value
        End Set
    End Property

    Public Property gCategoria
        Get
            Return Categoria
        End Get
        Set(value)
            Categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal Nombre As String, ByVal Precio As Double, ByVal Categoria As String)
        gIdProducto = ID
        gNombre = Nombre
        gPrecio = Precio
        gCategoria = Categoria


    End Sub
End Class

