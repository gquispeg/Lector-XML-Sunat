Imports System.IO
Imports System.Xml.Serialization
Imports Leer_XML.LOGICA

Public Class Form1
    Private Factura As Invoice
    Private Estructura As Xml

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim f As New FrmCliente(Factura.AccountingCustomerParty.Party)
        f.ShowDialog()
    End Sub

    Private Sub BtnEmisor_Click(sender As Object, e As EventArgs) Handles btnEmisor.Click
        Dim f As New FrmEmisor(Factura.AccountingSupplierParty.Party)
        f.ShowDialog()
    End Sub

    Private Sub BtnArchivo_Click(sender As Object, e As EventArgs) Handles BtnArchivoXml.Click
        Dim OpenFileDialog1 As New OpenFileDialog With {
            .Filter = "Todos los Archivos|*.*|xml|*.xml|archo xml|*.xml|Text Xml|*.xml",
            .FilterIndex = 4
        }

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim rutaArchivo As String = OpenFileDialog1.FileName
            TxtArchivoXml.Text = rutaArchivo

            Try
                Estructura = XmlBL.ObtenerEstructura(rutaArchivo)
                If Estructura.Tipo = "01" Then
                    LeerContenidoXML(rutaArchivo)
                    CargarFactura()
                Else
                    MsgBox("Documento no soportado, pero si se puede ver la info del XML")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LeerContenidoXML(ByVal rutaArchivo As String)
        Dim readStream As New FileStream(rutaArchivo, FileMode.Open)
        Dim xmlSerializer As New XmlSerializer(GetType(Invoice))
        Factura = CType(xmlSerializer.Deserialize(readStream), Invoice)
        readStream.Close()
    End Sub

    Private Sub BtnXml_Click(sender As Object, e As EventArgs) Handles BtnXml.Click
        Dim f As New FrmXml(Estructura)
        f.ShowDialog()
    End Sub

    Private Sub CargarFactura()
        TxtEmisor.Text = factura.AccountingSupplierParty.Party.PartyIdentification(0).ID.Value & " - " & factura.AccountingSupplierParty.Party.PartyLegalEntity(0).RegistrationName.Value
        TxtCliente.Text = factura.AccountingCustomerParty.Party.PartyIdentification(0).ID.Value & " - " & factura.AccountingCustomerParty.Party.PartyLegalEntity(0).RegistrationName.Value

        TxtDocumentoTipo.Text = "FACTURA"
        TxtDocumentoNumero.Text = factura.ID.Value
        TxtTipoOperacion.Text = catalogo.Obtener(51, factura.InvoiceTypeCode.listID)
        TxtEmision.Text = factura.IssueDate.Value.ToShortDateString

        TxtSubTotal.Text = factura.LegalMonetaryTotal.LineExtensionAmount.Value
        TxtGratuita.Text = 0 'factura.TaxTotal(0).TaxAmount.Value
        TxtGravada.Text = factura.TaxTotal(0).TaxSubtotal(0).TaxableAmount.Value
        LblIgvPorcentaje.Text = "" 'Factura.TaxTotal(0).TaxSubtotal(0).TaxCategory.Percent.Value
        TxtIgvMonto.Text = factura.TaxTotal(0).TaxSubtotal(0).TaxAmount.Value
        TxtTotalFactura.Text = factura.LegalMonetaryTotal.PayableAmount.Value

        'Carga de notas
        dgvNotas.Rows.Clear()
        For Each nota As NoteType In factura.Note
            dgvNotas.Rows.Add({nota.languageLocaleID, nota.Value})
            If nota.languageLocaleID = "1000" Then
                LblPrecio.Text = nota.Value
            End If
        Next

        'Carga de tributos
        DgvTributos.Rows.Clear()
        For Each impuesto As TaxTotalType In Factura.TaxTotal
            DgvTributos.Rows.Add({impuesto.TaxSubtotal(0).TaxCategory.TaxScheme.Name.Value,
                                 impuesto.TaxSubtotal(0).TaxCategory.TaxScheme.ID.Value,
                                 impuesto.TaxSubtotal(0).TaxableAmount.Value,
                                 impuesto.TaxSubtotal(0).TaxAmount.Value})
        Next

        'Carga de formas de pago
        DgvCondicion.Rows.Clear()
        For Each condicion As PaymentTermsType In factura.PaymentTerms
            Select Case condicion.ID.Value.ToString.ToUpper
                Case "FORMAPAGO"
                    Try
                        DgvCondicion.Rows.Add({condicion.PaymentMeansID(0).Value,
                                condicion.Amount.Value,
                                condicion.PaymentDueDate.Value.ToShortDateString
                              })
                    Catch ex As Exception
                        DgvCondicion.Rows.Add({condicion.PaymentMeansID(0).Value,
                                "",
                                condicion.Amount.Value
                              })
                    End Try
                Case Else
                    DgvTributos.Rows.Add({condicion.ID.Value,
                                          condicion.PaymentMeansID(0).Value,
                                          "",
                                          condicion.Amount.Value})
            End Select
        Next

        DgvItems.Rows.Clear()
        For Each item As InvoiceLineType In factura.InvoiceLine
            DgvItems.Rows.Add({item.ID.Value,
                item.InvoicedQuantity.Value,
                "",
                item.Item.Description(0).Value,
                item.Price.PriceAmount.Value,'unitario
                item.TaxTotal(0).TaxSubtotal(0).TaxableAmount.Value,'unitario x cantidad
                item.PricingReference.AlternativeConditionPrice(0).PriceAmount.Value,'unitario+igv
                item.TaxTotal(0).TaxSubtotal(0).TaxableAmount.Value * item.TaxTotal(0).TaxSubtotal(0).TaxCategory.Percent.Value / 100
                              })
        Next
    End Sub
End Class