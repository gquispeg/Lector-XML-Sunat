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

            For Each ele As PaymentTermsType In origen.PaymentTerms
                If ele.PaymentMeansID IsNot Nothing Then
                    If ele.PaymentPercent IsNot Nothing Then
                        Return New Detraccion With {
                            .Codigo = ele.PaymentMeansID(0).Value,
                            .Nombre = (New CatalogoBL).Obtener("54", ele.PaymentMeansID(0).Value),
                            .CuentaBancoNacion = origen.PaymentMeans(0).PayeeFinancialAccount.ID.Value,
                            .Porcentaje = ele.PaymentPercent.Value,
                            .Monto = ele.Amount.Value
                        }
                    End If
                End If
            Next

            Return Nothing
        End Function

    End Class
End Namespace