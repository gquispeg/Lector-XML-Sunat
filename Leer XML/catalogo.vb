Public Class catalogo
    Sub New()
        Catalogo51 = New List(Of String())
        Catalogo51.Add({"0101", "Venta interna"})
        Catalogo51.Add({"0102", "Venta Interna – Anticipos"})
        Catalogo51.Add({"0103", "Venta interna - Itinerante"})
        Catalogo51.Add({"0110", "Venta Interna - Sustenta Traslado de Mercadería - Remitente"})
        Catalogo51.Add({"0111", "Venta Interna - Sustenta Traslado de Mercadería - Transportista"})
        Catalogo51.Add({"0112", "Venta Interna - Sustenta Gastos Deducibles Persona Natural "})
        Catalogo51.Add({"0120", "Venta Interna - Sujeta al IVAP"})
        Catalogo51.Add({"0121", "Venta Interna - Sujeta al FISE"})
        Catalogo51.Add({"0122", "Venta Interna - Sujeta a otros impuestos"})
        Catalogo51.Add({"0130", "Venta Interna - Realizadas al Estado "})
        Catalogo51.Add({"1001", "Operación Sujeta a Detracción"})
    End Sub

    Function Obtener(ByVal catalogo As Integer, ByVal codigo As String)
        Dim listado As List(Of String()) = Nothing
        Select Case catalogo
            Case 51
                listado = Catalogo51
        End Select

        For Each ele As String() In listado
            If ele(0) = codigo Then
                Return ele(1)
            End If
        Next

        Return "No se encontró en catálogo 51"
    End Function

    Private Catalogo51 As List(Of String())

End Class
