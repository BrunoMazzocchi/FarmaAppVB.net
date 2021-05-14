Public Class Presentacion
    Private _idPresentacion As Integer
    Private _nombrePres As String
    Private _viaAdmin As String
    Private _estado As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal viaAdm As String, ByVal estado As Integer)
        Me.IdPresentacion = id
        Me.NombrePres = nombre
        Me.ViaAdmin = viaAdm
        Me.Estado = estado
    End Sub

    Public Property IdPresentacion As Integer
        Get
            Return _idPresentacion
        End Get
        Set(value As Integer)
            _idPresentacion = value
        End Set
    End Property

    Public Property NombrePres As String
        Get
            Return _nombrePres
        End Get
        Set(value As String)
            _nombrePres = value
        End Set
    End Property

    Public Property ViaAdmin As String
        Get
            Return _viaAdmin
        End Get
        Set(value As String)
            _viaAdmin = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property
End Class
