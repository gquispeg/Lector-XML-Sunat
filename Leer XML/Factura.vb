
Imports System.Xml

Public Class Factura
    Private Shared Doc As XmlDocument
    Private Shared NsMgr As XmlNamespaceManager
    Private Shared catalogo As New catalogo
    Sub New(ByVal documentoXml As XmlDocument, ByVal documentoNameSpaceManager As XmlNamespaceManager)
        _Impuestos = New List(Of FacturaImpuestoItem)
        _BasesCalculo = New List(Of FacturaImpuestoItem)
        catalogo = New catalogo

        Doc = documentoXml
        NsMgr = documentoNameSpaceManager

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

        'Notas de la factura
        TagUserName = {"cbc:Note"}
        Notas = New List(Of FacturaNota)
        For Each tagName As String In TagUserName
            Dim UserNameNode As XmlNodeList = Doc.GetElementsByTagName(tagName)
            For i As Integer = 1 To UserNameNode.Count-1
                Notas.Add(New FacturaNota(Doc, i))
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

        Sumas = New FacturaSumas
    End Sub

    ReadOnly Property Estructura As New FacturaEstructura
    ReadOnly Property Documento As New FacturaDocumento
    ReadOnly Property Sumas As FacturaSumas
    ReadOnly Property FirmaDigital As New FacturaFirmaDigital
    ReadOnly Property Emisor As New FacturaEmisor
    ReadOnly Property Cliente As New FacturaCliente
    Private Shared _IGV As FacturaIgv
    ReadOnly Property IGV As FacturaIgv
        Get
            Return _IGV
        End Get
    End Property


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

    ReadOnly Property Notas As List(Of FacturaNota)
    Private Shared _Impuestos As List(Of FacturaImpuestoItem)
    ReadOnly Property Impuestos As List(Of FacturaImpuestoItem)
        Get
            Return _Impuestos
        End Get
    End Property

    Private Shared _BasesCalculo As List(Of FacturaImpuestoItem)
    ReadOnly Property BasesCalculo As List(Of FacturaImpuestoItem)
        Get
            Return _BasesCalculo
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
    Class FacturaSumas
        Sub New()

            Dim TagUserName As String() = {"cac:TaxTotal"}
            For Each tagName As String In TagUserName
                Dim UserNameNode As XmlNodeList = Doc.GetElementsByTagName(tagName)
                Dim codigo As String = "xxxx"
                For i As Integer = 0 To UserNameNode.Count - 1
                    Dim XmlItem As XmlDocument = Doc
                    Dim base, monto As Double
                    codigo = "xxxxx"
                    Try
                        codigo = XmlItem.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:ID", NsMgr)(i).InnerText
                        base = XmlItem.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cbc:TaxableAmount", NsMgr)(i).InnerText
                        monto = XmlItem.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount", NsMgr)(i).InnerText
                    Catch ex As Exception
                    End Try
                    Select Case codigo
                        Case "1000"
                            _1000Base = base
                            _1000Monto = monto
                            _IGV = New FacturaIgv(XmlItem, i, base, monto)
                            _Impuestos.Add(New FacturaImpuestoItem("IGV Impuesto General a las Ventas", base, monto))
                            _BasesCalculo.Add(New FacturaImpuestoItem("IGV Impuesto General a las Ventas", base, monto))
                        Case "1016"
                            _1016Base = base
                            _1016Monto = monto
                            _Impuestos.Add(New FacturaImpuestoItem(" a la Venta Arroz Pilado", base, monto))
                            _BasesCalculo.Add(New FacturaImpuestoItem(" a la Venta Arroz Pilado", base, monto))
                        Case "2000"
                            _2000Base = base
                            _2000Monto = monto
                            _Impuestos.Add(New FacturaImpuestoItem("ISC Impuesto Selectivo al Consumo", base, monto))
                            _BasesCalculo.Add(New FacturaImpuestoItem("ISC Impuesto Selectivo al Consumo", base, monto))
                        Case "7152"
                            _7152Base = base
                            _7152Monto = monto
                            _Impuestos.Add(New FacturaImpuestoItem("Impuesto a la bolsa plastica", base, monto))
                            _BasesCalculo.Add(New FacturaImpuestoItem("Impuesto a la bolsa plastica", base, monto))
                        Case "9996"
                            _9996Base = base
                            _9996Monto = monto
                            _BasesCalculo.Add(New FacturaImpuestoItem("Gratuito", base, monto))
                        Case "9997"
                            _9997Base = base
                            _9997Monto = monto
                            _BasesCalculo.Add(New FacturaImpuestoItem("Exonerado", base, monto))
                        Case "9998"
                            _9998Base = base
                            _9998Monto = monto
                        Case "9999"
                            _9999Base = base
                            _9999Monto = monto
                            _Impuestos.Add(New FacturaImpuestoItem("Otros tributos", base, monto))
                            _BasesCalculo.Add(New FacturaImpuestoItem("Otros tributos", base, monto))
                    End Select
                Next
            Next
        End Sub

        Private _1000Base As Double = 0
        Private _1000Monto As Double = 0
        Private _1016Base As Double = 0
        Private _1016Monto As Double = 0
        Private _2000Base As Double = 0
        Private _2000Monto As Double = 0
        Private _7152Base As Double = 0
        Private _7152Monto As Double = 0
        Private _9996Base As Double = 0
        Private _9996Monto As Double = 0
        Private _9997Base As Double = 0
        Private _9997Monto As Double = 0
        Private _9998Base As Double = 0
        Private _9998Monto As Double = 0
        Private _9999Base As Double = 0
        Private _9999Monto As Double = 0

        ReadOnly Property IgvBase As Double
            Get
                Return _1000Base
            End Get
        End Property
        ReadOnly Property IgvMonto As Double
            Get
                Return _1000Monto
            End Get
        End Property
        ReadOnly Property ImpuestoArrozBase As Double
            Get
                Return _1016Base
            End Get
        End Property
        ReadOnly Property ImpuestoArrozMonto As Double
            Get
                Return _1016Monto
            End Get
        End Property
        ReadOnly Property IscBase As Double
            Get
                Return _2000Base
            End Get
        End Property
        ReadOnly Property IscMonto As Double
            Get
                Return _2000Monto
            End Get
        End Property
        ReadOnly Property BolsaPlasticaBase As Double
            Get
                Return _7152Base
            End Get
        End Property
        ReadOnly Property BolsaPlasticaMonto As Double
            Get
                Return _7152Monto
            End Get
        End Property
        ReadOnly Property GratuitoBase As Double
            Get
                Return _9996Base
            End Get
        End Property
        ReadOnly Property GratuitoMonto As Double
            Get
                Return _9996Monto
            End Get
        End Property
        ReadOnly Property ExoneradoBase As Double
            Get
                Return _9997Base
            End Get
        End Property
        ReadOnly Property ExoneradoMonto As Double
            Get
                Return _9997Monto
            End Get
        End Property
        ReadOnly Property InafectoBase As Double
            Get
                Return _9998Base
            End Get
        End Property
        ReadOnly Property InafectoMonto As Double
            Get
                Return _9998Monto
            End Get
        End Property
        ReadOnly Property OtrosTributosBase As Double
            Get
                Return _9999Base
            End Get
        End Property
        ReadOnly Property OtrosTributosMonto As Double
            Get
                Return _9999Monto
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
        ''' Codigo catalogo 51
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property TipoOperacionCodigo As String
            Get
                Return Doc.SelectSingleNode("/tns:Invoice/cbc:InvoiceTypeCode/@listID", NsMgr).InnerText
            End Get
        End Property
        ''' <summary>
        ''' Nombre catálogo 51
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property TipoOperacionNombre As String
            Get
                Return catalogo.Obtener(51, TipoOperacionCodigo)
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
                Try
                    Return Doc.SelectSingleNode("/tns:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine/cbc:Line", NsMgr).InnerText
                Catch ex As Exception
                    Return ""
                End Try
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
        Sub New(ByVal nodo As XmlDocument, ByVal indice As Integer, ByVal base As Double, ByVal impuesto As Double)
            MontoBase = nodo.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cbc:TaxableAmount", NsMgr)(indice).InnerText
            MontoIgv = nodo.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount", NsMgr)(indice).InnerText
            Id = nodo.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:ID", NsMgr)(indice).InnerText
            Nombre = nodo.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:Name", NsMgr)(indice).InnerText
            Iso = nodo.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode", NsMgr)(indice).InnerText

            Try
                Porcentaje = nodo.SelectNodes("/tns:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cbc:Percent", NsMgr)(indice).InnerText & " %"
            Catch ex As Exception
                Porcentaje = FormatNumber(impuesto / base * 100, 0) & " %"
            End Try

        End Sub
        ReadOnly Property MontoBase As Double
        ReadOnly Property Porcentaje As String
        ReadOnly Property MontoIgv As Double
        ReadOnly Property Id As String
        ReadOnly Property Nombre As String
        ReadOnly Property Iso As String


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
                Try
                    Return XmlItem.SelectNodes("/tns:Invoice/cac:InvoiceLine/cac:Item/cac:SellersItemIdentification/cbc:ID", NsMgr)(IFila).InnerText
                Catch ex As Exception
                End Try
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
                Try
                    Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:Amount", NsMgr)(IFila).InnerText
                Catch ex As Exception
                    Return XmlItem.SelectNodes("/tns:Invoice/cac:PaymentTerms/cbc:PaymentMeansID", NsMgr)(IFila).InnerText
                End Try
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
    Class FacturaImpuestoItem
        Sub New(ByVal nomImpuesto As String, ByVal monBase As Double, ByVal impuesto As Double)
            Nombre = nomImpuesto
            Base = monBase
            Monto = impuesto
        End Sub

        Property Nombre As String
        Property Base As Double
        Property Monto As Double
    End Class
    Class FacturaNota
        ReadOnly Property Codigo As String
        ReadOnly Property Nota As String

        Sub New(ByVal xxml As XmlDocument, ByVal orden As Integer)
            Dim XmlItem As XmlDocument = xxml

            Try
                Nota = XmlItem.SelectSingleNode("/tns:Invoice/cbc:Note[" & orden & "]", NsMgr).InnerText
                'Nota = XmlItem.SelectNodes("/tns:Invoice/cbc:Note", NsMgr)(orden).InnerText
                'Codigo = XmlItem.SelectNodes("/tns:Invoice/cbc:Note/@languageLocaleID", NsMgr)(orden).InnerText
                Codigo = XmlItem.SelectSingleNode("/tns:Invoice/cbc:Note[" & orden & "]/@languageLocaleID", NsMgr).InnerText
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Class
