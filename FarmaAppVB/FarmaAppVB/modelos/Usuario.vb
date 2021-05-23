Public Class Usuario
    Private _idUser As Integer
    Private _Username As String
    Private _nombres As String
    Private _apellidos As String
    Private _pwd As String
    Private _emailUser As String
    Private _direccion As String
    Private _estado As Integer
    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal Username As String, ByVal nombre As String, ByVal apellido As String, ByVal pwd As String,
                   ByVal email As String, ByVal direccion As String, ByVal estado As Integer)

        Me.IdUser = id
        Me.Username = Username
        Me.Nombres = nombre
        Me.Apellidos = apellido
        Me.Pwd = pwd
        Me.EmailUser = email
        Me.Direccion = direccion
        Me.Estado = estado

    End Sub

    Public Property IdUser As Integer
        Get
            Return _idUser
        End Get
        Set(value As Integer)
            _idUser = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Public Property Nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Pwd As String
        Get
            Return _pwd
        End Get
        Set(value As String)
            _pwd = value
        End Set
    End Property

    Public Property EmailUser As String
        Get
            Return _emailUser
        End Get
        Set(value As String)
            _emailUser = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
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
