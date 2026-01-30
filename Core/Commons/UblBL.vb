Imports System.IO
Imports System.Security.Cryptography
Imports System.Xml.Serialization
Imports Entidades
Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class UblBL
        Inherits Utils

        Friend Shared Function Obtener(origen As Invoice_2_1, _catalogos As CatalogoBL) As Ubl
            Dim ubl As New Ubl With {
                .VersionUbl = origen.UBLVersionID.Value,
                .VersionEstructura = origen.CustomizationID.Value,
                .Tipo = origen.InvoiceTypeCode.Value,
                .NomTipo = _catalogos.Obtener("01", origen.InvoiceTypeCode.Value),
                .Hash = "",
                .Firma = "",
                .Certificado = ""
            }

            For Each linea As UBLExtensionType In origen.UBLExtensions
                If linea IsNot Nothing Then
                    If linea.ExtensionContent IsNot Nothing Then
                        Dim datos As Signature = Firma(linea.ExtensionContent.OuterXml)
                        ubl.Hash = datos.SignedInfo.Reference.DigestValue
                        ubl.Firma = datos.SignatureValue
                        ubl.Certificado = datos.KeyInfo.X509Data.X509Certificate
                        Exit For
                    End If
                End If
            Next

            Return ubl
        End Function

        Private Shared Function Firma(cadenaXml As String) As Signature
            Dim serializer As New XmlSerializer(GetType(Signature))
            Dim rspta As Signature

            Using reader As New StringReader(cadenaXml)
                rspta = CType(serializer.Deserialize(reader), Signature)
            End Using

            Return rspta
        End Function
    End Class
End Namespace