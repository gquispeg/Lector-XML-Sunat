Public Class FrmPreliminar
    Private ArchivoXML As String

    Sub New(ByVal contenidoXml As String)
        InitializeComponent()
        Me.WebBrowser1.DocumentText = contenidoXml
    End Sub
End Class