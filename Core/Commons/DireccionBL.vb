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

            Dim address As AddressType = addressType.RegistrationAddress
            Dim direccion As New Direccion With {
                .Ubigeo = ValidarNothing(address.ID),
                .Distrito = ValidarNothing(address.District),
                .Provincia = ValidarNothing(address.CityName),
                .Departamento = ValidarNothing(address.CountrySubentity)
            }

            If address.AddressLine IsNot Nothing Then
                If address.AddressLine.Length > 0 Then
                    direccion.Direccion = ValidarNothing(address.AddressLine(0).Line)
                End If
            End If

            Return direccion
        End Function
    End Class
End Namespace