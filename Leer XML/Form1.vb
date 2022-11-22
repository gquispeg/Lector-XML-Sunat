Imports System.Xml

Public Class Form1
    Private Comprobante As Factura
    Private ContenidoXML As String

    Private Sub BtnXml_Click(sender As Object, e As EventArgs) Handles BtnXml.Click
        Dim f As New FrmPreliminar(ContenidoXML)
        f.ShowDialog()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim f As New FrmCliente(Comprobante.Cliente)
        f.ShowDialog()
    End Sub

    Private Sub btnEmisor_Click(sender As Object, e As EventArgs) Handles btnEmisor.Click
        Dim f As New FrmEmisor(Comprobante.Emisor)
        f.ShowDialog()
    End Sub

    Private Sub BtnArchivo_Click(sender As Object, e As EventArgs) Handles BtnArchivoXml.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        Dim lblFilePath As String

        OpenFileDialog1.Filter = "Todos los Archivos|*.*|xml|*.xml|archo xml|*.xml|Text Xml|*.xml"
        OpenFileDialog1.FilterIndex = 4
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lblFilePath = OpenFileDialog1.FileName
            TxtArchivoXml.Text = lblFilePath
            ContenidoXML = LeerContenidoXML(lblFilePath)
            CargarDocumento(lblFilePath)
        End If
    End Sub

    Private Function LeerContenidoXML(ByVal rutaArchivo As String) As String
        Dim rslt As String = ""
        Dim lector As New IO.StreamReader(rutaArchivo, System.Text.Encoding.Default, True)
        Try
            rslt = lector.ReadToEnd
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            lector.Close()
        End Try

        Return rslt
    End Function

    Private Sub CargarDocumento(ByVal rutaXml As String)
        Dim doc As New XmlDocument
        doc.Load(rutaXml)

        Dim tagUserName As String() = {"cac:InvoiceLine"}
        Dim nsMgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
        Dim local_xpath As String() = {"Invoice/cac:InvoiceLine/cbc:InvoicedQuantity"}

        nsMgr.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
        nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
        nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")
        nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        nsMgr.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
        nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
        nsMgr.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
        nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
        nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")
        nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")

        Comprobante = New Factura(doc, nsMgr)
        Try
            If Comprobante.EsCorrecto Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MostrarData()
    End Sub

    Private Sub MostrarData()
        TxtEmisor.Text = Comprobante.Emisor.Ruc & " - " & Comprobante.Emisor.RazonSocial
        TxtCliente.Text = Comprobante.Cliente.Ruc & " - " & Comprobante.Cliente.RazonSocial

        TxtDocumentoTipo.Text = Comprobante.Documento.TipoDocumentoNombre
        TxtDocumentoNumero.Text = Comprobante.Documento.Numero
        TxtTipoOperacion.Text = Comprobante.Documento.TipoOperacionNombre
        TxtEmision.Text = Comprobante.Documento.FechaEmision.ToShortDateString

        TxtSubTotal.Text = Comprobante.Sumas.IgvBase
        TxtGratuita.Text = Comprobante.Sumas.GratuitoBase 
        TxtGravada.Text = Comprobante.Sumas.IgvBase
        LblIgvPorcentaje.Text = Comprobante.IGV.Porcentaje
        TxtIgvMonto.Text = Comprobante.Sumas.IgvMonto
        TxtTotalFactura.Text = Comprobante.Sumas.TotalFactura

        LblPrecio.Text = Comprobante.Sumas.TotalFacturaEnLetra

        DgvItems.AutoGenerateColumns = False
        DgvItems.DataSource = Comprobante.Items
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = Comprobante.CondicionPago

        DgvTributos.AutoGenerateColumns = False
        DgvTributos.DataSource = Comprobante.Impuestos
    End Sub
End Class

