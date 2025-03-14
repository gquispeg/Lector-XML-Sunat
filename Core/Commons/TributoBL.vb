﻿Imports Core.Commons
Imports Entidades.Commons
Imports Entidades.Sunat

Public Class TributoBL
    Inherits Utils

    Friend Shared Function Obtener(afecta As TaxSubtotalType) As Tributo
        Dim rspta As New Tributo
        With rspta
            .CodInternacional = afecta.TaxCategory.TaxScheme.TaxTypeCode.Value
            .CodTributo = afecta.TaxCategory.TaxScheme.ID.Value
            .NomTributo = afecta.TaxCategory.TaxScheme.Name.Value
            .Base = afecta.TaxableAmount.Value
            .Tasa = afecta.TaxCategory.Percent.Value
            .Afectacion = (New AfectacionIgvBL).Obtener(afecta.TaxCategory)
        End With

        Return rspta
    End Function
End Class
