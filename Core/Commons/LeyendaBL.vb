Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class LeyendaBL
        Friend Shared Function Obtener(leyendas As NoteType()) As List(Of Leyenda)
            Dim rspta As New List(Of Leyenda)
            If leyendas Is Nothing Then
                Return rspta
            End If

            For Each leyenda As NoteType In leyendas
                rspta.Add(New Leyenda(leyenda.languageLocaleID, leyenda.Value))
            Next

            Return rspta
        End Function
    End Class
End Namespace