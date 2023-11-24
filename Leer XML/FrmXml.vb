Imports System.Xml

Public Class FrmXml
    Private Info As Xml
    Private VersionUbl, VersionCustomization As String

    'Sub New(ByVal extension As UBLExtensionsType, ByVal vUbl As String, ByVal vCustomization As String)
    Sub New(ByVal xml As Xml)
        'Info = extension
        'VersionUbl = vUbl
        'VersionCustomization = vCustomization
        Info = xml
        InitializeComponent()
    End Sub
    Private Sub FrmXml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUbl.Text = Info.Ubl
        TxtTipo.Text = Info.Tipo
        TxtEstructura.Text = Info.Estructura
        TxtHash.Text = Info.Hash

        TxtCanonical.Text = Info.Canonical
        TxtSignature.Text = Info.Signature
        TxtTransform.Text = Info.Transform
        TxtMetodoHash.Text = Info.MetodoHash

        TxtEmisor.Text = Info.EmisorNombre
        TxtCertificadoEmisor.Text = Info.EmisorCertificado
        TxtFirmaEmisor.Text = Info.EmisorFirma
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class