Imports Entidades.Commons

Namespace Contenido
    Public Class Invoice
        Implements IEstructura

        Public Property Ubl As Ubl Implements IEstructura.Ubl
        Public Property Emisor As Company Implements IEstructura.Emisor
        Public Property Cliente As Company Implements IEstructura.Cliente
        Public Property Documento As Documento Implements IEstructura.Documento
        Public Property Items As List(Of Item) Implements IEstructura.Items
        Public Property Leyendas As List(Of Leyenda) Implements IEstructura.Leyendas
        Public Property Totales As Totales
        Public Property Detracciones As Detraccion Implements IEstructura.Detracciones
    End Class
End Namespace