Public Class catalogo
    Friend Shared Function Obtener(ByVal catalogo As Integer, ByVal codigo As String)
        Dim listado As List(Of String()) = Nothing
        Select Case catalogo
            Case 5 : listado = CargarCatalogo05()
            Case 51 : listado = CargarCatalogo51()
            Case 6 : listado = CargarCatalogo06()
        End Select

        For Each ele As String() In listado
            If ele(0) = codigo Then
                Return ele(1)
            End If
        Next

        Return "No se encontró en catálogo " & catalogo
    End Function

    Private Shared Function CargarCatalogo05() As List(Of String())
        Dim catalogo As New List(Of String())
        catalogo.Add({"1000", "IGV Impuesto General a las Ventas"})
        catalogo.Add({"1016", "Impuesto a la Venta Arroz Pilado"})
        catalogo.Add({"2000", "ISC Impuesto Selectivo al Consumo"})
        catalogo.Add({"7152", "Impuesto a la bolsa plastica"})
        'Catalogo.Add({"9995", "Exportación"})
        catalogo.Add({"9996", "Gratuito"})
        catalogo.Add({"9997", "Exonerado"})
        catalogo.Add({"9998", "Inafecto"})
        catalogo.Add({"9999", "Otros tributos"})

        Return catalogo
    End Function

    Private Shared Function CargarCatalogo51() As List(Of String())
        Dim catalogo As New List(Of String())
        catalogo = New List(Of String())
        catalogo.Add({"0101", "Venta interna"})
        catalogo.Add({"0102", "Venta Interna – Anticipos"})
        catalogo.Add({"0103", "Venta interna - Itinerante"})
        catalogo.Add({"0110", "Venta Interna - Sustenta Traslado de Mercadería - Remitente"})
        catalogo.Add({"0111", "Venta Interna - Sustenta Traslado de Mercadería - Transportista"})
        catalogo.Add({"0112", "Venta Interna - Sustenta Gastos Deducibles Persona Natural "})
        catalogo.Add({"0120", "Venta Interna - Sujeta al IVAP"})
        catalogo.Add({"0121", "Venta Interna - Sujeta al FISE"})
        catalogo.Add({"0122", "Venta Interna - Sujeta a otros impuestos"})
        catalogo.Add({"0130", "Venta Interna - Realizadas al Estado "})
        catalogo.Add({"1001", "Operación Sujeta a Detracción"})
        Return catalogo
    End Function

    Private Shared Function CargarCatalogo06() As List(Of String())
        Dim catalogo As New List(Of String())
        catalogo = New List(Of String())
        catalogo.Add({"6", "RUC"})
        Return catalogo
    End Function

End Class
