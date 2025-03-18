Imports Entidades.Commons
Imports Entidades.Contenido

Public Class Form1
    Private Documento As IEstructura

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim f As New FrmCompany(Documento.Cliente)
        f.ShowDialog()
    End Sub

    Private Sub BtnEmisor_Click(sender As Object, e As EventArgs) Handles btnEmisor.Click
        Dim f As New FrmCompany(Documento.Emisor)
        f.ShowDialog()
    End Sub

    Private Sub BtnDetracciones_Click(sender As Object, e As EventArgs) Handles BtnDetracciones.Click
        Dim f As New FrmDetracciones(Documento.Detracciones)
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

            Dim core As New Core.Main

            Try
                core.LoadXmlFile(rutaArchivo)
                Documento = core.Extraer()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            If Documento Is Nothing Then
                MsgBox("Ocurrió un error al cargar el archivo")
            Else
                CargarDetalle(Documento)
            End If
        End If
    End Sub

    Private Sub CargarDetalle(origen As Invoice)
        TxtEmisor.Text = origen.Emisor.NumDocIdentidad & " - " & origen.Emisor.RazonSocial
        TxtCliente.Text = origen.Cliente.NumDocIdentidad & " - " & origen.Cliente.RazonSocial
        TxtFechaEmision.Text = origen.Documento.FechaEmision
        TxtHoraEmision.Text = Format(origen.Documento.HoraEmision, "hh:mm:ss")
        TxtVencimiento.Text = origen.Documento.Vencimiento

        TxtDocumentoTipo.Text = origen.Documento.TipDocumento & " - " & origen.Documento.NomDocumento
        TxtDocumentoNumero.Text = origen.Documento.NumComprobante
        TxtTipoOperacion.Text = origen.Documento.TipOperacion & " - " & origen.Documento.NomOperacion
        TxtMoneda.Text = origen.Documento.TipMoneda & " - " & origen.Documento.NomMoneda

        CargarTotales(origen.Totales)
        CargarItems(origen.Items)
        CargarDetracciones(origen.Detracciones)
        DgvLeyenda.DataSource = origen.Leyendas

    End Sub

    Private Sub CargarTotales(totales As Totales)
        TxtGravada.Text = FormatNumber(totales.SumGravado, 2)
        TxtInafecto.Text = FormatNumber(totales.SumInafecto, 2)
        TxtExonerado.Text = FormatNumber(totales.SumExonerado, 2)
        TxtGratuita.Text = FormatNumber(totales.SumGratuito, 2)
        TxtIgvMonto.Text = FormatNumber(totales.SumIgv, 2)

        TxtOtros.Text = FormatNumber(totales.TotOtrosCargos, 2)
        TxtTotalFactura.Text = FormatNumber(totales.TotComprobante, 2)
    End Sub
    Private Sub CargarItems(items As List(Of Item))
        DgvItems.Rows.Clear()
        For Each item As Item In items
            DgvItems.Rows.Add()
            With DgvItems.Rows(DgvItems.Rows.Count - 1)
                .Cells("colOrden").Value = item.Orden
                .Cells("ColMedida").Value = item.CodMedida
                .Cells("colCantidad").Value = item.Cantidad
                .Cells("colDescripcion").Value = item.Descripcion
                .Cells("ColValorUnitario").Value = item.MtoValorUnitario

                .Cells("ColGravado").Value = item.Gravado
                .Cells("ColInafecto").Value = item.Inafecto
                .Cells("ColExonerado").Value = item.Exonerado
                .Cells("ColGratuito").Value = item.Gratuito
                .Cells("ColIgv").Value = item.Igv
                .Cells("ColTotal").Value = item.Total
            End With
        Next
    End Sub
    Private Sub CargarDetracciones(detracciones As Detraccion)
        If detracciones Is Nothing Then
            TxtDetraccionesPorcentaje.Text = ""
            TxtDetraccionesMonto.Text = ""
            BtnDetracciones.Enabled = False
        Else
            TxtDetraccionesPorcentaje.Text = detracciones.Porcentaje
            TxtDetraccionesMonto.Text = detracciones.Monto
            BtnDetracciones.Enabled = True
        End If
    End Sub
End Class