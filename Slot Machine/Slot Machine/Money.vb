Imports System.Reflection.Emit

Public Class Money
    Public Event CoinReturnEvent(D As Integer, Q As Integer, Di As Integer, N As Integer)
    Public Event BuyEvent(P As Image)
    Public Property Five As Integer
    Public Property Ten As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = Five * 5 + Ten * 10
            Return _Total
        End Get
    End Property

    Sub InsertTen()
        Ten = Ten + 1
    End Sub
    Sub Spin()
        Ten = Ten - 2
    End Sub
    Sub Win()
        Ten = Ten + 10
    End Sub
End Class
