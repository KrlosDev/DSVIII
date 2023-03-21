Public Class Parametros
    Private _campo As String
    Public Property campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property
    Private _valor As String

    Public Sub New(c As String, v As String)
        campo = c
        valor = v
    End Sub

    Public Property valor() As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
        End Set
    End Property

End Class
