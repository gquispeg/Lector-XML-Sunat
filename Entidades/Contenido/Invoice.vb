Imports Entidades.Commons

Namespace Contenido
    Public Class Invoice
        Implements IEstructura

        Public Property Ubl As Ubl Implements IEstructura.Ubl
        Public Property Emisor As Company Implements IEstructura.Emisor
        Public Property Cliente As Company Implements IEstructura.Cliente
        Public Property Documento As Documento Implements IEstructura.Documento
        Public Property Items As List(Of Item) Implements IEstructura.Items
        Public Property Totales As Totales
    End Class
End Namespace