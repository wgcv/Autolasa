<Serializable()> Public Class producto
    Public nombre As String
    Public codigo As String
    Public stock As Double
    Public costo As Decimal
    Public es_pintura As Boolean
    Public com_pintura As Boolean
    Public l_pintura As List(Of pintura)



    Public Sub New()
        l_pintura = New List(Of pintura)

    End Sub
    Public Function busquedanombre(ByVal bus As String) As pintura
        Dim producto As pintura
        producto = Nothing


        For Each buscador As pintura In l_pintura
            If (buscador.producto.nombre = bus) Then
                producto = buscador

            End If
        Next
        Return producto
    End Function

End Class
