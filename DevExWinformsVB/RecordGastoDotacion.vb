Public Class RecordGastoDotacion
    Dim _id, _usuario As Integer
    Dim _cantidad As String
    Dim _fecha, _hora As String
    Dim _desc As String

    Public Sub New(ByVal id As Integer, ByVal fecha As Date, ByVal hora As Date, ByVal cantidad As String, ByVal descripcion As String, ByVal usuario As Integer)
        Me._id = id
        Me._fecha = fecha.ToString("dd/MM/yyyy")
        Me._hora = hora.ToString("hh:mm:ss")
        Me._cantidad = cantidad
        Me._desc = descripcion
        Me._usuario = usuario
    End Sub

    Public Property idgasto() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property fef() As String
        Get
            Return _fecha
        End Get
        Set(ByVal Value As String)
            _fecha = Value
        End Set
    End Property

    Public Property feh() As String
        Get
            Return _hora
        End Get
        Set(ByVal Value As String)
            _hora = Value
        End Set
    End Property

    Public Property cant() As String
        Get
            Return _cantidad
        End Get
        Set(ByVal Value As String)
            _cantidad = Value
        End Set
    End Property

    Public Property descr() As String
        Get
            Return _desc
        End Get
        Set(ByVal Value As String)
            _desc = Value
        End Set
    End Property

    Public Property usuario() As Integer
        Get
            Return _usuario
        End Get
        Set(ByVal Value As Integer)
            _usuario = Value
        End Set
    End Property
End Class