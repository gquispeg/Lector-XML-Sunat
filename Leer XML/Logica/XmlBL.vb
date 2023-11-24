Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Threading
Imports System.Xml

Namespace LOGICA
    Public Class XmlBL
        Friend Shared Function ObtenerTipoCabecera(ByVal contenidoXml As String) As String()
            Dim tipo As New List(Of String())
            tipo.Add({"urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", "Invoice-2", "Invoice"})
            tipo.Add({"urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", "CreditNote-2", "CreditNote"})

            For Each pregunta() As String In tipo
                If contenidoXml.Contains(pregunta(0)) Then
                    Return pregunta
                End If
            Next

            Throw New Exception("No se reconoce el tipo de documento")
        End Function

        Friend Shared Function ObtenerEstructura(ByVal rutaArchivo As String) As Xml
            'Leer archivo
            Dim c As New IO.StreamReader(rutaArchivo)
            Dim ContenidoXml As String = c.ReadToEnd
            c.Close()

            'Obtener estructura del Xml
            Dim tipo As String() = ObtenerTipoCabecera(ContenidoXml)
            Dim NsMgr As XmlNamespaceManager
            Dim doc As New XmlDocument()
            doc.LoadXml(ContenidoXml)
            NsMgr = LeerXml(tipo(1), doc)

            'Retornar estructura
            Dim xml As New Xml
            With xml
                .Tipo = doc.SelectSingleNode($"/tns:{tipo(2)}/cbc:{tipo(2)}TypeCode", NsMgr).InnerText
                .Ubl = doc.SelectSingleNode($"/tns:{tipo(2)}/cbc:UBLVersionID", NsMgr).InnerText
                .Estructura = doc.SelectSingleNode($"/tns:{tipo(2)}/cbc:CustomizationID", NsMgr).InnerText
                .Hash = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestValue", NsMgr).InnerText
                .Canonical = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignedInfo/ds:CanonicalizationMethod/@Algorithm", NsMgr).InnerText
                .Signature = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignedInfo/ds:SignatureMethod/@Algorithm", NsMgr).InnerText
                .Transform = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignedInfo/ds:Reference/ds:Transforms/ds:Transform/@Algorithm", NsMgr).InnerText
                .MetodoHash = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestMethod/@Algorithm", NsMgr).InnerText
                .EmisorNombre = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:KeyInfo/ds:X509Data/ds:X509SubjectName", NsMgr).InnerText
                .EmisorCertificado = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:KeyInfo/ds:X509Data/ds:X509Certificate", NsMgr).InnerText
                .EmisorFirma = doc.SelectSingleNode($"/tns:{tipo(2)}/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/ds:SignatureValue", NsMgr).InnerText
            End With

            Return xml
        End Function

        Private Shared Function LeerXml(ByVal tipo As String, ByVal doc As XmlDocument) As XmlNamespaceManager
            Dim nsMgr As New XmlNamespaceManager(doc.NameTable)
            nsMgr.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
            nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
            nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")
            nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
            nsMgr.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
            nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
            nsMgr.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
            nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
            nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")
            nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:" & tipo)

            Return nsMgr
        End Function
    End Class
End Namespace