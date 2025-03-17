Imports System.IO
Imports System.Xml.Serialization
Imports Core.Commons
Imports Entidades.Commons
Imports Entidades.Contenido
Imports Entidades.Sunat

Public Class Main
    Inherits Utils
    Private _tipo As Tipo
    Private _catalogos As CatalogoBL

    Public Sub LoadXmlFile(archivoXml As String)
        If Not IO.File.Exists(archivoXml) Then
            Throw New Exception("No existe el archivo")
        End If

        _tipo = ObtenerTipo(archivoXml)
    End Sub

    Private Structure Tipo
        Sub New(_raiz As String, _tipo As String, _nombre As String, _nomVersion As String, _ruta As String)
            Raiz = _raiz
            Tipo = _tipo
            Nombre = _nombre
            NomVersion = _nomVersion
            RutaArchivo = _ruta
        End Sub
        Property Raiz As String
        Property Tipo As String
        Property Nombre As String
        Property NomVersion As String
        Property RutaArchivo As String
    End Structure

    Private Function ObtenerTipo(rutaXml As String) As Tipo
        Dim tipos As New List(Of Tipo) From {
            New Tipo("urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", "01", "Invoice", "Invoice-2", rutaXml)
        }

        Dim xml As String = IO.File.ReadAllText(rutaXml)
        For Each tipo As Tipo In tipos
            If xml.Contains(tipo.Raiz) Then
                Return tipo
            End If
        Next

        Throw New Exception("No se reconoce el tipo de documento")
    End Function

    Public Function Extraer() As IEstructura
        Dim readStream As FileStream = Nothing
        Dim xmlSerializer As XmlSerializer
        Dim invoice As Invoice_2_1

        Try
            readStream = New FileStream(_tipo.RutaArchivo, FileMode.Open)
            xmlSerializer = New XmlSerializer(GetType(Invoice_2_1))
            invoice = CType(xmlSerializer.Deserialize(readStream), Invoice_2_1)
        Catch ex As Exception
            Throw ex
        Finally
            If readStream IsNot Nothing Then
                readStream.Close()
            End If
        End Try
        _catalogos = New CatalogoBL

        Return ExtraeInvoice(invoice)
    End Function

    Private Function ExtraeInvoice(origen As Invoice_2_1) As Invoice
        Dim ubl As New Ubl With {
            .VersionUbl = origen.UBLVersionID.Value,
            .VersionEstructura = origen.CustomizationID.Value,
            .Tipo = origen.InvoiceTypeCode.Value,
            .Hash = origen.UBLExtensions(0).ExtensionContent.FirstChild.InnerText
        }
        ubl.NomTipo = _catalogos.Obtener("01", ubl.Tipo)
        Dim invoice As New Invoice With {
            .Ubl = ubl,
            .Emisor = CompanyBL.Obtener(origen.AccountingSupplierParty.Party),
            .Cliente = CompanyBL.Obtener(origen.AccountingCustomerParty.Party),
            .Documento = DocumentoBL.Obtener(origen),
            .Items = ItemBL.Obtener(origen),
            .Totales = TotalesBL.Obtener(origen),
            .Leyendas = LeyendaBL.Obtener(origen.Note),
            .Detracciones = DetraccionesBL.Obtener(origen)
        }

        Return invoice
    End Function
End Class
