Module TotalCost
    Public Const dblConfRegis As Double = 895.0
    Public dblTotal As Decimal = 0.0

    Public Function TotalRegisCost(ByVal dblInroEcommerce As Double, ByVal dblFutureWeb As Double, ByVal dblAdvanceBasic As Double, ByVal dblNetworkSecurity As Double, ByVal dblNightDinner As Double) As Double
        dblTotal = dblConfRegis + dblInroEcommerce + dblFutureWeb + dblAdvanceBasic + dblNetworkSecurity + dblNightDinner
        Return dblTotal
    End Function

End Module
