Namespace Commons
    Public Class Item
        Property Orden As Integer
        Property CodMedida As String
        Property NomMedida As String

        Property Cantidad As String
        Property Descripcion As String
        Property MtoValorUnitario As Double
        Property MtoPrecioVentaUnitario As Double
        Property SumTributos As Double
        Property Afectacion As Tributo

        ReadOnly Property SubTotal As Double
            Get
                Return Cantidad * MtoValorUnitario
            End Get
        End Property
        ReadOnly Property Gravado As Double
            Get
                If Afectacion.CodTributo = "1000" Then
                    Return SubTotal
                End If
                Return 0
            End Get
        End Property

        ReadOnly Property Inafecto As Double
            Get
                If Afectacion.CodTributo = "9998" Then
                    Return SubTotal
                End If
                Return 0
            End Get
        End Property

        ReadOnly Property Exonerado As Double
            Get
                If Afectacion.CodTributo = "9997" Then
                    Return SubTotal
                End If
                Return 0
            End Get
        End Property

        ReadOnly Property Gratuito As Double
            Get
                If Afectacion.CodTributo = "9996" Then
                    Return SubTotal
                End If
                Return 0
            End Get
        End Property

        ReadOnly Property Igv As Double
            Get
                If Afectacion.CodTributo = "1000" Then
                    Return SubTotal * Afectacion.Tasa / 100
                End If
                Return 0
            End Get
        End Property

        ReadOnly Property Total As Double
            Get
                Return MtoPrecioVentaUnitario * Cantidad
            End Get
        End Property
    End Class
End Namespace