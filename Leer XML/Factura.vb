
Imports System.Xml

Public Class Factura
    Private Shared Doc As XmlDocument
    Private Shared NsMgr As XmlNamespaceManager

    Sub New(ByVal documentoXml As XmlDocument, ByVal documentoNameSpaceManager As XmlNamespaceManager)
        doc = documentoXml
        nsMgr = documentoNameSpaceManager

        Dim tipo As String = Doc.SelectSingleNode("/tns:Invoice/cbc:InvoiceTypeCode", NsMgr).InnerText
        If tipo <> "01" Then
            Throw New Exception("El código de documento del XML no corresponde a una factura")
        End If

        Dim TagUserName As String()
        'Items de la factura
        TagUserName = {"cac:InvoiceLine"}
        _Items = New List(Of FacturaItem)
        For Each tagName As String In TagUserName
            Dim UserNameNode As XmlNodeList = Doc.GetElementsByTagName(tagName)
            For i As Integer = 0 To UserNameNode.Count - 1
                _Items.Add(New FacturaItem(Doc, i))
            Next
        Next
        'condiciones de pago
        TagUserName = {"cac:PaymentTerms"}
        _CondicionPago = New List(Of FacturaCondicionPagoItem)
        For Each tagName As String In TagUserName
            Dim UserNameNode As XmlNodeList = Doc.GetElementsByTagName(tagName)
            For i As Integer = 0 To UserNameNode.Count - 1
                _CondicionPago.Add(New FacturaCondicionPagoItem(Doc, i))
            Next
        Next
    End Sub

    ReadOnly Property Estructura As New FacturaEstructura
    ReadOnly Property Documento As New FacturaDocumento
    ReadOnly Property FirmaDigital As New FacturaFirmaDigital
    ReadOnly Property Emisor As New FacturaEmisor
    ReadOnly Property Cliente As New FacturaCliente
    ReadOnly Property IGV As New FacturaIgv
    Private _Items As List(Of FacturaItem)
    ReadOnly Property Items As List(Of FacturaItem)
        Get
            Return _Items
        End Get
    End Property
    Private _CondicionPago As List(Of FacturacondicionPagoItem)
    ReadOnly Property CondicionPago As List(Of FacturaCondicionPagoItem)
        Get
            Return _CondicionPago
        End Get
    End Property


    ReadOnly Property EsCorrecto As Boolean
        Get
            'agregar throw para la validación de info
            Return True
        End Get
    End Property

    Class FacturaEstructura
        ReadOnly Property VersionUbl As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:UBLVersionID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property VersionEstructura As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:CustomizationID", NsMgr).InnerText
            End Get
        End Property
    End Class
    Class FacturaDocumento
        ReadOnly Property Numero As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:ID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property FechaEmision As Date
            Get
                Dim fecha() As String = Doc.SelectSingleNode("/tns:Invoice/cbc:IssueDate", NsMgr).InnerText.Split("-")
                Dim hora() As String = Doc.SelectSingleNode("/tns:Invoice/cbc:IssueTime", NsMgr).InnerText.Split(":")

                Return New DateTime(fecha(0), fecha(1), fecha(2), hora(0), hora(1), hora(2).Split(".")(0))
            End Get
        End Property
        ''' <summary>
        ''' Completar con el catalogo 01 o 51 (confirmar)
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property TipoOperacionCodigo As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:InvoiceTypeCode/@listID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property TipoDocumentoNombre As String
            Get
                Return "FACTURA E."
            End Get
        End Property
        ReadOnly Property TipoVenta As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:InvoiceTypeCode", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Moneda As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:DocumentCurrencyCode", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property IgvPorcentaje As Double
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cbc:TaxAmount", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property SumaItems As Double
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cbc:TaxAmount", NsMgr).InnerText
            End Get
        End Property
        ''' <summary>
        ''' total ventas operaciones gravadas + sumatoria ISC
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property SumaIgv As Double
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cbc:TaxAmount", NsMgr).InnerText
            End Get
        End Property

        ReadOnly Property SumaIsc As Double
            Get
                Return 0
            End Get
        End Property
        ReadOnly Property SumaOtrosTributos As Double
            Get
                Return 0
            End Get
        End Property
        ReadOnly Property SumaOtrosCargos As Double
            Get
                Return 0
            End Get
        End Property
        ReadOnly Property TotalFactura As Double
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property TotalFacturaEnLetra As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:Note", NsMgr).InnerText
            End Get
        End Property
    End Class
    Class FacturaFirmaDigital
        ReadOnly Property Firma As String 'POR CONFIRMAR
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/ext:UBLExtensions/ext:UBLExtension[3]/ext:ExtensionContent/ds:Signature/ds:SignatureValue", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Certificado As String 'POR CONFIRMAR
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/ext:UBLExtensions/ext:UBLExtension[3]/ext:ExtensionContent/ds:Signature/ds:KeyInfo/ds:X509Data/ds:X509Certificate", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Hash As String 'POR CONFIRMAR
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/ext:UBLExtensions/ext:UBLExtension[3]/ext:ExtensionContent/ds:Signature/ds:KeyInfo/ds:KeyValue/ds:RSAKeyValue/ds:Modulus", NsMgr).InnerText
            End Get
        End Property

    End Class
    Class FacturaEmisor
        ReadOnly Property TipoDocumentoCatalogo As String 'TODO DEBERÍA SER RUC
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID/@schemeID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Ruc As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property NombreComercial As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyName/cbc:Name", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property RazonSocial As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cbc:RegistrationName", NsMgr).InnerText
            End Get
        End Property
    End Class
    Class FacturaCliente
        ReadOnly Property TipoDocumentoCatalogo As String 'TODO DEBERÍA SER RUC, verificar el código
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID/@schemeID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Ruc As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property RazonSocial As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cbc:RegistrationName", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Ubigeo As String
            Get
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:ID", NsMgr).InnerText
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
        ReadOnly Property Ciudad As String
            Get
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:CityName", NsMgr).InnerText
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
        ReadOnly Property CountrySubentity As String
            Get
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:CountrySubentity", NsMgr).InnerText
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
        ReadOnly Property Distrito As String
            Get
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:District", NsMgr).InnerText
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
        ReadOnly Property Direccion As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine/cbc:Line", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Pais As String
            Get
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:Country/cbc:IdentificationCode", NsMgr).InnerText
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
    End Class
    Class FacturaIgv
        ReadOnly Property MontoBase As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cbc:TaxableAmount", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Porcentaje As String
            Get
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cbc:Percent", NsMgr).InnerText & "%"
                Catch ex As Exception
                    Return "S/D"
                End Try
            End Get
        End Property
        ReadOnly Property MontoIgv As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cbc:Percent", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Id As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:ID", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property Nombre As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:Name", NsMgr).InnerText
            End Get
        End Property
        ReadOnly Property ISO As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode", NsMgr).InnerText
            End Get
        End Property
    End Class
    Class FacturaItem
        Private XmlItem As XmlDocument
        Private IFila As Integer
        Sub New(ByVal xxml As XmlDocument, ByVal orden As Integer)
            XmlItem = xxml
            IFila = orden
        End Sub

        ReadOnly Property Orden As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cbc:ID", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property UnidadMedida As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cbc:InvoicedQuantity/@unitCode", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property Cantidad As Double
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cbc:InvoicedQuantity", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property CodigoProducto As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification/cbc:ID", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property Descripcion As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:Item/cbc:Description", NsMgr)(IFila).InnerText
            End Get
        End Property
        ''' <summary>
        ''' Monto unitario, no incluye otros tributos (IGV,ISC, otros) ni cargos globales
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property ValorUnitario As Double 'confirmar que valor exactamente
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:Price/cbc:PriceAmount", NsMgr)(IFila).InnerText
            End Get
        End Property
        ''' <summary>
        ''' Cantidad x Valor unitario y la deducción de descuentos aplicados a dicho item. No incluye tributos (IGV, ISC, otros), descuentos globales y cargos
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property ValorVentaPorItem As Double
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cbc:LineExtensionAmount", NsMgr)(IFila).InnerText
            End Get
        End Property
        ''' <summary>
        ''' Precio unitario facturado, es la suma total que se debe pagar, incluye tributos y descuentos
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property ValorReferencialUnitarioPorItemNoOnerosa As Double
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:PricingReference/cac:AlternativeConditionPrice/cbc:PriceAmount", NsMgr)(IFila).InnerText
            End Get
        End Property



        ReadOnly Property IGVId As String
            Get
                Return Doc.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:ID", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property IgvNombre As String
            Get
                Return Doc.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:Name", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property IgvCodigo As String
            Get
                Return Doc.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode", NsMgr)(IFila).InnerText
            End Get
        End Property
        ReadOnly Property IgvPorcentaje As Double
            Get
                Return Doc.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cbc:Percent", NsMgr)(IFila).InnerText
            End Get
        End Property
        ''' <summary>
        ''' Tipo afectacion del IGV catalogo 07
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property IgvTipoAfectacion As String
            Get
                Return Doc.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cbc:TaxExemptionReasonCode", NsMgr)(IFila).InnerText
            End Get
        End Property
    End Class
    Class FacturaCondicionPagoItem
        Private XmlItem As XmlDocument
        Private IFila As Integer
        Sub New(ByVal xxml As XmlDocument, ByVal orden As Integer)
            XmlItem = xxml
            IFila = orden
        End Sub

        ReadOnly Property Id As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:ID", NsMgr)(IFila).InnerText
                'If IFila = 0 Then
                '    Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:ID", NsMgr)(IFila).InnerText
                'Else
                '    Return XmlItem.SelectSingleNode("/tns:Invoice/cac:PaymentTerms[" & IFila + 1 & "]/cbc:ID", NsMgr).InnerText
                'End If
            End Get
        End Property
        ReadOnly Property Nombre As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:PaymentMeansID", NsMgr)(IFila).InnerText
                'If IFila = 0 Then
                '    Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:PaymentMeansID", NsMgr)(IFila).InnerText
                'Else
                '    Return XmlItem.SelectSingleNode("/tns:Invoice/cac:PaymentTerms[" & IFila + 1 & "]/cbc:PaymentMeansID", NsMgr).InnerText
                'End If
            End Get
        End Property
        ReadOnly Property Monto As String
            Get
                Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:Amount", NsMgr)(IFila).InnerText
                'If IFila = 0 Then
                '    Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:Amount", NsMgr)(IFila).InnerText
                'Else
                '    Return XmlItem.SelectSingleNode("/tns:Invoice/cac:PaymentTerms[" & IFila + 1 & "]/cbc:Amount", NsMgr).InnerText
                'End If
            End Get
        End Property
        ReadOnly Property Fecha As String
            Get
                Try
                    Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:PaymentDueDate", NsMgr)(IFila).InnerText
                Catch ex As Exception
                    Return ""
                End Try
                'Try
                '    If IFila = 0 Then
                '        Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:PaymentDueDate", NsMgr)(IFila).InnerText
                '    Else
                '        Return XmlItem.SelectSingleNode("/tns:Invoice/cac:PaymentTerms[" & IFila + 1 & "]/cbc:PaymentDueDate", NsMgr).InnerText
                '    End If
                'Catch ex As Exception
                '    Return ""
                'End Try
            End Get
        End Property
    End Class
End Class
