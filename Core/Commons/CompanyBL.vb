Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class CompanyBL
        Inherits Utils

        Friend Shared Function Obtener(Party As PartyType) As Company
            Dim emisor As New Company With {
                .TipDocIdentidad = Party.PartyIdentification(0).ID.schemeID,
                .NumDocIdentidad = Party.PartyIdentification(0).ID.Value,
                .RazonSocial = Party.PartyLegalEntity(0).RegistrationName.Value,
                .Direccion = (New DireccionBL).Obtener(Party.PartyLegalEntity(0)),
                .Local = ""
}
            emisor.NomDocIdentidad = (New CatalogoBL).Obtener("06", emisor.TipDocIdentidad)
            If Party.PartyLegalEntity(0).RegistrationAddress IsNot Nothing Then
                emisor.Local = ValidarNothing(Party.PartyLegalEntity(0).RegistrationAddress.AddressTypeCode)
            End If
            If Party.PartyName IsNot Nothing Then
                emisor.NombreComercial = ValidarNothing(Party.PartyName(0).Name)
            End If

            Return emisor
        End Function
    End Class
End Namespace