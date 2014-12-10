Public Class pcarro
    Public parachoque As Boolean
    Public capo As Boolean
    Public techo As Boolean
    Public cajuela As Boolean
    Public guadachoque As Boolean
    Public aderecho As Boolean
    Public bderecho As Boolean
    Public cderecho As Boolean
    Public dderecho As Boolean
    Public aizquierdo As Boolean
    Public bizquierdo As Boolean
    Public cizquierdo As Boolean
    Public dizqueirdo As Boolean
    '1 parachoque 
    '2 capo
    '3 techo
    '4 cajuela
    '5 guardachoque
    '6 laterales
    '7 puertas
    '8 todo
    '0 generico


    Public Sub New()
        parachoque = False
        capo = False
        techo = False
        cajuela = False
        guadachoque = False
        aderecho = False
        bderecho = False
        cderecho = False
        dderecho = False
        aizquierdo = False
        bizquierdo = False
        cizquierdo = False
        dizqueirdo = False
    End Sub

    Public Function num_puertas() As Integer
        Dim i As Integer = 0
        If Me.bderecho Then
            i = i + 1
        End If
        If Me.cderecho Then
            i = i + 1
        End If
        If Me.bizquierdo Then
            i = i + 1
        End If
        If Me.cizquierdo Then
            i = i + 1
        End If
        Return (i)

    End Function
    Public Function num_partes() As Integer
        Dim i As Integer
        If Me.bderecho Then
            i = i + 1
        End If
        If Me.cderecho Then
            i = i + 1
        End If
        If Me.bizquierdo Then
            i = i + 1
        End If
        If Me.cizquierdo Then
            i = i + 1
        End If
        If Me.parachoque Then
            i = i + 1
        End If
        If Me.capo Then
            i = i + 1
        End If
        If Me.techo Then
            i = i + 1
        End If
        If Me.cajuela Then
            i = i + 1
        End If
        If Me.guadachoque Then
            i = i + 1
        End If
        If Me.aderecho Then
            i = i + 1
        End If
        If Me.dderecho Then
            i = i + 1
        End If
        If Me.aizquierdo Then
            i = i + 1
        End If
        If Me.dizqueirdo Then
            i = i + 1
        End If
        Return (i)

    End Function
    Public Function num_laterales() As Integer
        Dim i As Integer = 0
        If Me.aderecho Then
            i = i + 1
        End If
        If Me.dderecho Then
            i = i + 1
        End If
        If Me.aizquierdo Then
            i = i + 1
        End If
        If Me.dizqueirdo Then
            i = i + 1
        End If
        Return (i)

    End Function
End Class
