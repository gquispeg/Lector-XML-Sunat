﻿Imports Entidades.Commons

Namespace Contenido
    Public Interface IEstructura
        Property Ubl As Ubl
        Property Documento As Documento
        Property Emisor As Company
        Property Cliente As Company
        Property Items As List(Of Item)
    End Interface
End Namespace