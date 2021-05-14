Public Class Laboratorio
    Private _idLaboratorio As Integer
    Private _nombreLab As String
    Private _estado As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal estado As Integer)
        Me.IdLaboratorio = id
        Me.NombreLab = nombre
        Me.Estado = estado
    End Sub

    Public Property IdLaboratorio As Integer
        Get
            Return _idLaboratorio
        End Get
        Set(value As Integer)
            _idLaboratorio = value
        End Set
    End Property

    Public Property NombreLab As String
        Get
            Return _nombreLab
        End Get
        Set(value As String)
            _nombreLab = value
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
