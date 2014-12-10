Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()> Public Class lista_perfiles
    Public lperfil As List(Of perfil)
    Public Function add(ByVal perf As perfil) As Boolean

        Dim perf1 As perfil
        Dim perf2 As perfil
        perf1 = Me.busqueda(perf.codigo)
        perf2 = Me.busquedanombre(perf.nombre)
        If (perf1 IsNot Nothing Or perf2 IsNot Nothing) Then
            MsgBox("Ya existe el perfil con el mismo codigo o nombre")
            Return False
        Else
            lperfil.Add(perf)
            guardar_lista_perfiles(Me)
            MsgBox("Se guardo con éxito")
            Return True


        End If
    End Function
    Public Function busqueda(ByVal bus As String) As perfil
        Dim perf As perfil
        perf = Nothing


        For Each buscador As perfil In lperfil
            If (buscador.codigo = bus) Then
                perf = buscador

            End If
        Next
        Return perf

    End Function
    Public Function busquedanombre(ByVal bus As String) As perfil
        Dim perf As perfil
        perf = Nothing


        For Each buscador As perfil In lperfil
            If (buscador.nombre = bus) Then
                perf = buscador

            End If
        Next
        Return perf

    End Function
    Public Sub edit(ByVal vpro As perfil)
        Dim perf1 As perfil
        perf1 = Me.busquedanombre(vpro.nombre)

        lperfil.Remove(perf1)
        lperfil.Add(vpro)
        guardar_lista_perfiles(Me)
        MsgBox("Se modifico con éxito")


    End Sub

    Public Sub New()
        lperfil = New List(Of perfil)

    End Sub
End Class

