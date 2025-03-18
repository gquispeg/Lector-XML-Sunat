Imports System.IO

Namespace Commons
    Public Class Documento
        ''' <summary>
        ''' Serie y correlativo del documento
        ''' </summary>
        ''' <param name="codTipo">Tipo de documento</param>
        ''' <param name="documento">Serie</param>
        Sub New(codTipo As String, documento As String)
            TipDocumento = codTipo
            NumComprobante = documento
        End Sub

        Property TipDocumento As String
        Property NomDocumento As String
        ReadOnly Property Serie As String
            Get
                Return _Correlativo.Split("-")(0)
            End Get
        End Property
        ReadOnly Property Correlativo As String
            Get
                Return _Correlativo.Split("-")(1)
            End Get
        End Property

        Private _Correlativo As String
        Property NumComprobante As String
            Get
                Return _Correlativo
            End Get
            Set(value As String)
                If value.Split("-").Length <> 2 Then
                    Throw New Exception("El formato del documento no es correcto, debe ser 'serie-correlativo'")
                End If
                _Correlativo = value
            End Set
        End Property
        Property FechaEmision As String
        Property HoraEmision As String
        Property Vencimiento As String

        Property TipOperacion As String
        Property NomOperacion As String
        Property TipMoneda As String
        Property NomMoneda As String
    End Class
End Namespace