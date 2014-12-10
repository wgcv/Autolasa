Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary


<Serializable()> Public Class lista_producto
    Public lproductos As List(Of producto)

    Public Sub New()
        lproductos = New List(Of producto)

    End Sub
    Public Function add(ByVal pro As producto) As Boolean

        Dim producto As producto
        Dim producto1 As producto
        producto = Me.busqueda(pro.codigo)
        producto1 = Me.busquedanombre(pro.nombre)
        If (producto IsNot Nothing Or producto1 IsNot Nothing) Then
            MsgBox("Ya existe ese producto con el mismo codigo o nombre")
            Return False
        Else
            lproductos.Add(pro)
            guardar_lista_productos(Me)
            MsgBox("Se guardo con éxito")
            Return True


        End If
    End Function
    Public Function busqueda(ByVal bus As String) As producto
        Dim producto As producto
        producto = Nothing


        For Each buscador As producto In lproductos
            If (buscador.codigo = bus) Then
                producto = buscador

            End If
        Next
        Return producto

    End Function
    Public Function busquedanombre(ByVal bus As String) As producto
        Dim producto As producto
        producto = Nothing


        For Each buscador As producto In lproductos
            If (buscador.nombre = bus) Then
                producto = buscador

            End If
        Next
        Return producto

    End Function
    Public Function edit(ByVal vpro As producto, ByVal pro As producto) As Boolean
        Dim producto1 As producto
        producto1 = Me.busquedanombre(pro.nombre)
        If (producto1 IsNot Nothing And Not (vpro.nombre = pro.nombre)) Then
            MsgBox("Ya existe ese producto con el mismo nombre", MsgBoxStyle.Critical)
            Return False

        Else
            lproductos.Remove(vpro)
            lproductos.Add(pro)
            guardar_lista_productos(Me)
            MsgBox("Se modifico con éxito")
            Return True

        End If

    End Function
    Public Sub eliminar(ByVal pro As producto)
        lproductos.Remove(Me.busqueda(pro.codigo))
        guardar_lista_productos(Me)
    End Sub
End Class
