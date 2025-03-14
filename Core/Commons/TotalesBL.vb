Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class TotalesBL
        Inherits Utils

        Friend Shared Function Obtener(origen As Invoice_2_1) As Totales
            Dim rspta As New Totales
            Dim subTotals() As TaxSubtotalType = origen.TaxTotal(0).TaxSubtotal
            For Each subTotal As TaxSubtotalType In subTotals
                Select Case subTotal.TaxCategory.TaxScheme.ID.Value
                    Case "1000"
                        rspta.SumIgv = subTotal.TaxAmount.Value
                        rspta.SumGravado = subTotal.TaxableAmount.Value
                    Case "9998"
                        rspta.SumInafecto = subTotal.TaxableAmount.Value
                    Case "9997"
                        rspta.SumExonerado = subTotal.TaxableAmount.Value
                    Case "9996"
                        rspta.SumGratuito = subTotal.TaxableAmount.Value
                End Select

                rspta.SumTributos = origen.TaxTotal(0).TaxAmount.Value
                rspta.TotOtrosCargos = ValidarNothingPersonalizado(origen.LegalMonetaryTotal.ChargeTotalAmount, 0)
                rspta.TotComprobante = origen.LegalMonetaryTotal.PayableAmount.Value
            Next

            Return rspta
        End Function
    End Class
End Namespace