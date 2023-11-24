Public Class FrmCliente
    Private Cliente As PartyType

    Sub New(ByVal datosCliente As PartyType)
        InitializeComponent()
        Cliente = datosCliente
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTipo.Text = catalogo.Obtener(6, Cliente.PartyIdentification(0).ID.schemeID)
        TxtNumero.Text = Cliente.PartyIdentification(0).ID.Value
        TxtRazonSocial.Text = Cliente.PartyLegalEntity(0).RegistrationName.Value
        'TxtDireccion.Text = Cliente.PartyLegalEntity(0).RegistrationAddress.AddressLine(0).Line.Value
        'TxtUbigeo.Text = Cliente.Ubigeo
        'TxtDistrito.Text = Cliente.Distrito
        'TxtCiudad.Text = Cliente.Ciudad
        'TxtSubEntity.Text = Cliente.CountrySubentity
        'TxtPais.Text = Cliente.Pais
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class