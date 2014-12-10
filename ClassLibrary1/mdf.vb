Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Globalization

Public Module mdf
    Public lproductos As lista_producto = New lista_producto
    Public lperfiles As lista_perfiles = New lista_perfiles

    Sub cargar()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        cargar_lista_productos(lproductos)
        cargar_lista_perfiles(lperfiles)

    End Sub
    Function cargar_lista_productos(ByRef listaproducto As lista_producto) As lista_producto
        If File.Exists("lista_productos.bin") Then
            Dim myFileStream As Stream = File.OpenRead("lista_productos.bin")
            Dim deserializer As New BinaryFormatter()
            listaproducto = CType(deserializer.Deserialize(myFileStream), lista_producto)
            myFileStream.Close()

        End If
        Return listaproducto

    End Function
    Sub guardar_lista_productos(ByRef lista_producto As lista_producto)
        Dim myFileStream As Stream = File.Create("lista_productos.bin")
        Dim serializer As New BinaryFormatter()
        serializer.Serialize(myFileStream, lista_producto)
        myFileStream.Close()
    End Sub

    Function cargar_lista_perfiles(ByRef listaperfiles As lista_perfiles) As lista_perfiles
        If File.Exists("lista_perfiles.bin") Then
            Dim myFileStream As Stream = File.OpenRead("lista_perfiles.bin")
            Dim deserializer As New BinaryFormatter()
            listaperfiles = CType(deserializer.Deserialize(myFileStream), lista_perfiles)
            myFileStream.Close()

        End If
        Return listaperfiles

    End Function
    Sub guardar_lista_perfiles(ByRef listaperfiles As lista_perfiles)
        Dim myFileStream As Stream = File.Create("lista_perfiles.bin")
        Dim serializer As New BinaryFormatter()
        serializer.Serialize(myFileStream, listaperfiles)
        myFileStream.Close()
    End Sub
End Module
