Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class DireccionBL
        Inherits Utils

        Friend Function Obtener(addressType As PartyLegalEntityType) As Direccion
            If addressType.RegistrationAddress Is Nothing Then
                Return New Direccion
            Else
                If addressType.RegistrationAddress.ID Is Nothing Then
                    Return New Direccion
                End If
            End If

            Dim direccion As New Direccion With {
                .Direccion = ValidarNothing(addressType.RegistrationAddress.AddressLine(0).Line),
                .Ubigeo = ValidarNothing(addressType.RegistrationAddress.ID),
                .Distrito = ValidarNothing(addressType.RegistrationAddress.District),
                .Provincia = ValidarNothing(addressType.RegistrationAddress.CityName),
                .Departamento = ValidarNothing(addressType.RegistrationAddress.CountrySubentity)
            }

            Return direccion
        End Function
    End Class
End Namespace