Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class DireccionBL
        Inherits Utils

        Friend Function Obtener(addressType As AddressType) As Direccion
            If addressType.ID Is Nothing Then
                Return New Direccion
            End If
            Dim direccion As New Direccion With {
                .Direccion = ValidarNothing(addressType.AddressLine(0).Line),
                .Ubigeo = ValidarNothing(addressType.ID),
                .Distrito = ValidarNothing(addressType.District),
                .Provincia = ValidarNothing(addressType.CityName),
                .Departamento = ValidarNothing(addressType.CountrySubentity)
            }

            Return direccion
        End Function
    End Class
End Namespace