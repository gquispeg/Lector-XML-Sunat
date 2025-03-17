Namespace Commons
    Public Class Leyenda
        Sub New()
        End Sub
        Sub New(codLeyenda As String, nomLeyenda As String)
            Codigo = codLeyenda
            Descripcion = nomLeyenda
        End Sub

        Property Codigo As String
        Property Descripcion As String
    End Class
End Namespace