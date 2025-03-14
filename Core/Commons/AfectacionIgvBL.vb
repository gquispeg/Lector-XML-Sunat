Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Friend Class AfectacionIgvBL
        Friend Shared Function Obtener(origen As TaxCategoryType) As AfectacionIgv
            Return New AfectacionIgv With {
            .Codigo = origen.TaxExemptionReasonCode.Value,
            .Nombre = (New CatalogoBL).Obtener("07", origen.TaxExemptionReasonCode.Value)
        }
        End Function
    End Class
End Namespace