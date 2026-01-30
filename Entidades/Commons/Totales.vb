Namespace Commons
    Public Class Totales
        Property SumGravado As Double
        Property SumInafecto As Double
        Property SumExonerado As Double
        Property SumGratuito As Double
        ReadOnly Property SumBase As Double
            Get
                Return SumGravado + SumInafecto + SumExonerado + SumGratuito
            End Get
        End Property
        Property SumTributos As Double
        Property SumIgv As Double
        Property TotOtrosCargos As Double
        Property TotComprobante As Double
    End Class
End Namespace