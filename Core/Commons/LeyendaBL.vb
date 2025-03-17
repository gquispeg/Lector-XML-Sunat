Imports Entidades.Commons
Imports Entidades.Sunat

Namespace Commons
    Public Class LeyendaBL
        Friend Shared Function Obtener(leyendas As NoteType()) As List(Of Leyenda)
            Dim rspta As New List(Of Leyenda)
            For Each leyenda As NoteType In leyendas
                rspta.Add(New Entidades.Commons.Leyenda(leyenda.languageLocaleID, leyenda.Value))
            Next

            Return rspta
        End Function
    End Class
End Namespace