Public Class FrmEmisor
    Private Emisor As PartyType

    Sub New(ByVal datosEmisor As PartyType)
        InitializeComponent()
        Emisor = datosEmisor
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTipo.Text = catalogo.Obtener(6, Emisor.PartyIdentification(0).ID.schemeID)
        TxtNumero.Text = Emisor.PartyIdentification(0).ID.Value
        TxtRazonSocial.Text = Emisor.PartyLegalEntity(0).RegistrationName.Value
        'TxtNombreComercial.Text = Emisor.NombreComercial
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class