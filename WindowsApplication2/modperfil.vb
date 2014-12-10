Public Class modperfil
    Dim pro As BC.perfil

    Private Sub modperfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()


        For Each buscador As BC.perfil In BC.lperfiles.lperfil

            ListBox1.Items.Add(buscador.nombre)



        Next
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        FlowLayoutPanel1.Controls.Clear()

        pro = BC.lperfiles.busquedanombre(ListBox1.Text)
        If (pro.ldematerial.Count > 0) Then


            For Each buscador As BC.material In pro.ldematerial
                Dim l1 As New Label
                Dim t1 As New TextBox
                l1.Size = New System.Drawing.Size(265, 20)
                t1.Size = New System.Drawing.Size(58, 20)
                l1.Text = buscador.producto.nombre
                t1.Text = buscador.cantidad
                l1.Visible = True
                t1.Visible = True
                FlowLayoutPanel1.Controls.Add(l1)
                FlowLayoutPanel1.Controls.Add(t1)
                FlowLayoutPanel1.Show()



            Next
            FlowLayoutPanel1.Refresh()

        End If
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Boolean
        Dim propin As String
        Dim l_pintura As New List(Of BC.material)
        Dim pro3 As BC.producto

        Dim pint As BC.material
        i = True

        For Each control As System.Windows.Forms.Control In FlowLayoutPanel1.Controls
            If (i) Then
                propin = control.Text

                i = False

            Else

                pro3 = BC.lproductos.busquedanombre(propin)
                pint = New BC.material

                pint.producto = pro3
                If Not Double.TryParse(control.Text, pint.cantidad) Then
                    MsgBox("Hubo un erro al guardar el producto " & propin, MsgBoxStyle.Critical)

                End If
                l_pintura.Add(pint)
                i = True

            End If


        Next
        pro.ldematerial = l_pintura
        BC.lperfiles.edit (pro)


    End Sub
End Class