Public Class vCliente
    Dim id As Integer
    Dim cliente As String
    Dim telefono As String
    Dim correo As String
    'seeter y geeter

    Public Property gIdCliente
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property gNomCliente
        Get
            Return cliente
        End Get
        Set(value)
            cliente = value
        End Set
    End Property

    Public Property gTelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property gCorreo
        Get
            Return correo
        End Get
        Set(value)
            correo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal cliente As String, ByVal telefono As String, ByVal correo As String)
        'gIdCliente = id
        gNomCliente = cliente
        gTelefono = telefono
        gCorreo = correo

    End Sub
End Class
