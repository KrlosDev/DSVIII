Public Class Provincia
    Dim obj_BD As New BD()

    Private _codigo As String
    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _provincia As String
    Public Property provincia() As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property

    Public Function sp_listar() As DataTable
        Dim dt As New DataTable

        dt = obj_BD.sp_Select("Provincia")
        Return dt

    End Function
End Class
