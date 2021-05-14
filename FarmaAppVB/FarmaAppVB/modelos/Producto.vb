Public Class Producto

    Private _idProducto As Integer
    Private _nombreProducto As String
    Private _descripProd As String
    Private _precioProd As Double
    Private _exisProd As Integer
    Private _expProd As Date
    Private _dosisProd As String
    Private _permisoProd As String
    Private _estadoProd As Integer



    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String,
                    ByVal precio As Double, ByVal existencia As Integer, ByVal expiracion As Date,
                    ByVal dosis As String, ByVal permiso As String, ByVal estado As Integer)

        Me._idProducto = id
        Me._nombreProducto = nombre
        Me._descripProd = descripcion
        Me._precioProd = precio
        Me._exisProd = existencia
        Me._expProd = expiracion
        Me._dosisProd = dosis
        Me._permisoProd = permiso
        Me._estadoProd = estado

    End Sub

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(value As String)
            _nombreProducto = value
        End Set
    End Property

    Public Property DescripProd As String
        Get
            Return _descripProd
        End Get
        Set(value As String)
            _descripProd = value
        End Set
    End Property

    Public Property PrecioProd As Double
        Get
            Return _precioProd
        End Get
        Set(value As Double)
            _precioProd = value
        End Set
    End Property

    Public Property ExisProd As Integer
        Get
            Return _exisProd
        End Get
        Set(value As Integer)
            _exisProd = value
        End Set
    End Property

    Public Property ExpProd As Date
        Get
            Return _expProd
        End Get
        Set(value As Date)
            _expProd = value
        End Set
    End Property

    Public Property DosisProd As String
        Get
            Return _dosisProd
        End Get
        Set(value As String)
            _dosisProd = value
        End Set
    End Property

    Public Property PermisoProd As String
        Get
            Return _permisoProd
        End Get
        Set(value As String)
            _permisoProd = value
        End Set
    End Property

    Public Property EstadoProd As Integer
        Get
            Return _estadoProd
        End Get
        Set(value As Integer)
            _estadoProd = value
        End Set
    End Property
End Class
