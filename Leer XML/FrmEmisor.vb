Public Class FrmEmisor
    Private Emisor As Factura.FacturaEmisor

    Sub New(ByVal datosEmisor As Factura.FacturaEmisor)
        InitializeComponent()
        Emisor = datosEmisor
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTipo.Text = Emisor.TipoDocumentoCatalogo
        TxtNumero.Text = Emisor.Ruc
        TxtRazonSocial.Text = Emisor.RazonSocial
        TxtNombreComercial.Text = Emisor.NombreComercial
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class