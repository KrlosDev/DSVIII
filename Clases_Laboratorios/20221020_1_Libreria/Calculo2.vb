Public Class Calculo2
    Public Function sumar(num1 As String, num2 As String) As String
        Dim res As Integer
        MsgBox("sumar calculo2")
        res = Val(num1) + Val(num2)
        Return res

    End Function
End Class
