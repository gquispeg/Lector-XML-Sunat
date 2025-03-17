Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class DetraccionesBL
        Inherits Utils

        Friend Shared Function Obtener(origen As Invoice_2_1) As Detraccion
            If origen.PaymentTerms Is Nothing Or origen.PaymentMeans Is Nothing Then
                Return Nothing
            Else
                If origen.PaymentTerms.Count = 0 Or origen.PaymentMeans.Count = 0 Then
                    Return Nothing
                End If
            End If

            Dim terms = origen.PaymentTerms(0)
            Dim means = origen.PaymentMeans(0)

            Dim rspta As New Detraccion With {
                .Codigo = terms.PaymentMeansID(0).Value,
                .Nombre = (New CatalogoBL).Obtener("54", terms.PaymentMeansID(0).Value),
                .CuentaBancoNacion = means.PayeeFinancialAccount.ID.Value,
                .Porcentaje = terms.PaymentPercent.Value,
                .Monto = terms.Amount.Value
            }

            Return rspta
        End Function

    End Class
End Namespace