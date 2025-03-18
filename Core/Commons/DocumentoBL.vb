Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class DocumentoBL
        Inherits Utils

        Friend Shared Function Obtener(origen As Invoice_2_1) As Documento
            Dim catalogoBL As New CatalogoBL

            Dim rspta As New Documento(
                    origen.InvoiceTypeCode.Value,
                    origen.ID.Value) With {
                .FechaEmision = origen.IssueDate.Value,
                .HoraEmision = ValidarNothing(origen.IssueTime),
                .TipOperacion = origen.InvoiceTypeCode.listID,
                .TipMoneda = origen.DocumentCurrencyCode.Value,
                .Vencimiento = ValidarNothing(origen.DueDate)
}
            rspta.NomDocumento = catalogoBL.Obtener("01", rspta.TipDocumento)
            rspta.NomOperacion = catalogoBL.Obtener("51", rspta.TipOperacion)
            rspta.NomMoneda = catalogoBL.Obtener("02", rspta.TipMoneda)

            Return rspta
        End Function
    End Class
End Namespace