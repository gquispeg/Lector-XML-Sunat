Imports Entidades.Commons

Public Class FrmDetracciones
    Private _detracciones As Detraccion

    Sub New(detracciones As Detraccion)
        _detracciones = detracciones
        InitializeComponent()
    End Sub

    Private Sub FrmDetracciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodigo.Text = _detracciones.Codigo & " - " & _detracciones.Nombre
        TxtBancoNacion.Text = _detracciones.CuentaBancoNacion
        TxtPorcentaje.Text = _detracciones.Porcentaje
        TxtMonto.Text = _detracciones.Monto
    End Sub
End Class