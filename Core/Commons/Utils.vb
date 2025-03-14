Imports Entidades.Sunat

Namespace Commons
    Public Class Utils
        Shared Function ValidarNothing(Obj As Object) As String
            If Obj IsNot Nothing Then
                Return Obj.value
            End If

            Return ""
        End Function

        Shared Function ValidarNothing(valida As Object, responder As Object) As String
            If valida IsNot Nothing Then
                Return responder.value
            End If

            Return ""
        End Function

        Shared Function ValidarNothingPersonalizado(valida As Object, retorna As Object) As Object
            If valida IsNot Nothing Then
                Return valida.value
            End If

            Return retorna
        End Function
    End Class
End Namespace