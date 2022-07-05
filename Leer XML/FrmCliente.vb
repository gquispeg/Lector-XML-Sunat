Public Class FrmCliente
    Private Cliente As Factura.FacturaCliente

    Sub New(ByVal datosCliente As Factura.FacturaCliente)
        InitializeComponent()
        Cliente = datosCliente
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTipo.Text = Cliente.TipoDocumentoCatalogo
        TxtNumero.Text = Cliente.Ruc
        TxtRazonSocial.Text = Cliente.RazonSocial
        TxtDireccion.Text = Cliente.Direccion
        TxtUbigeo.Text = Cliente.Ubigeo
        TxtDistrito.Text = Cliente.Distrito
        TxtCiudad.Text = Cliente.Ciudad
        TxtSubEntity.Text = Cliente.CountrySubentity
        TxtPais.Text = Cliente.Pais
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class