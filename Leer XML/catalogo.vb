Public Class catalogo
    Sub New()
        Catalogo05 = New List(Of String())
        Catalogo05.Add({"1000", "IGV Impuesto General a las Ventas"})
        Catalogo05.Add({"1016", "Impuesto a la Venta Arroz Pilado"})
        Catalogo05.Add({"2000", "ISC Impuesto Selectivo al Consumo"})
        Catalogo05.Add({"7152", "Impuesto a la bolsa plastica"})
        'Catalogo05.Add({"9995", "Exportación"})
        Catalogo05.Add({"9996", "Gratuito"})
        Catalogo05.Add({"9997", "Exonerado"})
        Catalogo05.Add({"9998", "Inafecto"})
        Catalogo05.Add({"9999", "Otros tributos"})

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
            Case 5
                listado = Catalogo05
            Case 51
                listado = Catalogo51
        End Select

        For Each ele As String() In listado
            If ele(0) = codigo Then
                Return ele(1)
            End If
        Next

        Return "No se encontró en catálogo " & catalogo
    End Function

    Private Catalogo05 As List(Of String())
    Private Catalogo51 As List(Of String())

End Class
