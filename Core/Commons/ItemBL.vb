Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class ItemBL
        Inherits Utils

        Friend Shared Function Obtener(origen As Invoice_2_1) As List(Of Item)
            Dim rspta As New List(Of Item)
            Dim item As Item
            For Each ele As InvoiceLineType In origen.InvoiceLine
                item = New Item With {
                    .Orden = ele.ID.Value,
                    .CodMedida = ele.InvoicedQuantity.unitCode,
                    .Cantidad = ele.InvoicedQuantity.Value,
                    .Descripcion = ele.Item.Description(0).Value,
                    .MtoValorUnitario = ele.Price.PriceAmount.Value,
                    .MtoPrecioVentaUnitario = ele.PricingReference.AlternativeConditionPrice(0).PriceAmount.Value,
                    .SumTributos = ele.TaxTotal(0).TaxAmount.Value
                }
                item.NomMedida = (New CatalogoBL).Obtener("03", item.CodMedida)
                item.Afectacion = (New TributoBL).Obtener(ele.TaxTotal(0).TaxSubtotal(0))
                If item.Afectacion.CodTributo = "9996" Then
                    item.MtoValorUnitario = ele.PricingReference.AlternativeConditionPrice(0).PriceAmount.Value
                    item.MtoPrecioVentaUnitario = 0
                End If
                rspta.Add(item)
            Next

            Return rspta
        End Function
    End Class
End Namespace