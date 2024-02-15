Public Class CoinSlot
    Public Event CoinReturnEvent(D As Integer, Q As Integer, Di As Integer, N As Integer)
    Public Event BuyEvent(P As Image)
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.05
            Return _Total
        End Get
    End Property
    Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Dimes, Nickels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickels = 0
    End Sub
    Sub InsertQuarter()
        Quarters = Quarters + 1
    End Sub
    Sub InsertNickel()
        Nickels = Nickels + 1
    End Sub
    Sub InsertDime()
        Dimes = Dimes + 1
    End Sub
    Sub InsertDollar()
        Dollars = Dollars + 1
    End Sub
    Sub Buy(P As ProductControl)
        If P.ProductCount > 0 And P.ProductPrice <= _Total Then
            P.Buy()
            _Total = _Total - P.ProductPrice
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickels = _Total / 0.05
            RaiseEvent BuyEvent(P.ProductPicture)
        End If
    End Sub
End Class
