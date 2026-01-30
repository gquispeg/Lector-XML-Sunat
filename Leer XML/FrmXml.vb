Imports Entidades.Commons

Public Class FrmXml
    Dim estructura As Ubl
    Sub New(ubl As Ubl)
        estructura = ubl
        InitializeComponent()
    End Sub
    Private Sub FrmXml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUbl.Text = estructura.VersionUbl
        TxtTipo.Text = estructura.Tipo
        TxtNombreTipo.Text = estructura.NomTipo
        TxtEstructura.Text = estructura.VersionEstructura
        TxtHash.Text = estructura.Hash

        TxtSignature.Text = estructura.Firma
        TxtCertificado.Text = estructura.Certificado
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class