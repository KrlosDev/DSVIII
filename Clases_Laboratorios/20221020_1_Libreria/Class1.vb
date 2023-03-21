Public Class Calculo
    Public Function sumar(num1 As Integer, num2 As Integer) As Integer
        Dim res As Integer
        MsgBox("sumar calculo")
        res = num1 + num2
        Return res

    End Function
    Public Function restar(num1 As Integer, num2 As Integer) As Integer
        Dim res As Integer
        MsgBox("restar calculo")
        res = num1 - num2
        Return res
    End Function

End Class
