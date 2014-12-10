Public Class peciiapp

    Private Sub peciiapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BC.cargar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dproducto As New producto
        dproducto.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dmodcolor As New modcolor
        dmodcolor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dfperfil As New fperfil
        dfperfil.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim modper As New modperfil
        modper.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim carro As New carro(New BC.pcarro)


        carro.ShowDialog()


        If carro.DialogResult = 1 Then
            MsgBox(carro.partes)

        End If


    End Sub
End Class
