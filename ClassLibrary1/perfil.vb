<Serializable()> Public Class perfil
    Public nombre As String
    Public codigo As Integer
    Public ldematerial As List(Of material)
    Public parte As Integer
    Public trabajo As Integer

    Public Sub New(ByVal nombre As String, ByVal codigo As Integer)
        Me.nombre = nombre
        Me.codigo = codigo
        ldematerial = New List(Of material)

    End Sub
    Public Function busquedanombre(ByVal bus As String) As material
        Dim producto As material
        producto = Nothing


        For Each buscador As material In ldematerial
            If (buscador.producto.nombre = bus) Then
                producto = buscador

            End If
        Next
        Return producto
    End Function

End Class
