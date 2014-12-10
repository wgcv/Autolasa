Public Class fperfil

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (ListBox2.SelectedIndex = -1) Then
            ListBox1.Items.Add(ListBox2.Text)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (ListBox1.SelectedIndex = -1) Then
            ListBox2.Items.Add(ListBox1.Text)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim perfil As BC.perfil
        perfil = New BC.perfil(TextBox1.Text, TextBox2.Text)
        BC.lperfiles.add(perfil)
        ComboBox1.Items.Clear()
        For Each buscador As BC.perfil In BC.lperfiles.lperfil
            ComboBox1.Items.Add(buscador.nombre)
        Next

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub fperfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each buscador As BC.perfil In BC.lperfiles.lperfil
            ComboBox1.Items.Add(buscador.nombre)



        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim perf As BC.perfil
        Dim lmaterial As List(Of BC.material)
        Dim mat As BC.material
        perf = BC.lperfiles.busquedanombre(ComboBox1.Text)
        perf.parte = NumericUpDown1.Text
        If (RadioButton1.Checked) Then

            perf.trabajo = 1
        End If
        If (RadioButton2.Checked) Then

            perf.trabajo = 2
        End If
        If (RadioButton3.Checked) Then

            perf.trabajo = 3
        End If

        lmaterial = New List(Of BC.material)
        For Each list As String In ListBox1.Items
            mat = New BC.material

            mat.producto = BC.lproductos.busquedanombre(list)
            lmaterial.Add(mat)
        Next
        perf.ldematerial = lmaterial

        BC.lperfiles.edit(perf)
    End Sub


    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim perf As BC.perfil

        perf = BC.lperfiles.busquedanombre(ComboBox1.Text)


        NumericUpDown1.Text = perf.parte

        If (perf.parte = 0) Then
            NumericUpDown1.Text = 0
        End If
        If (perf.trabajo = 0) Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        End If
        If (perf.trabajo = 1) Then
            RadioButton1.Checked = True

        End If
        If (perf.trabajo = 2) Then
            RadioButton2.Checked = True

        End If
        If (perf.trabajo = 3) Then
            RadioButton3.Checked = True


        End If
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For Each buscador As BC.producto In BC.lproductos.lproductos

            ListBox2.Items.Add(buscador.nombre)




        Next
        For Each buscador As BC.material In perf.ldematerial
            ListBox2.Items.Remove(buscador.producto.nombre)
            ListBox1.Items.Add(buscador.producto.nombre)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        MsgBox(ComboBox1.Text)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim perf As BC.perfil

        perf = BC.lperfiles.busquedanombre(ComboBox1.Text)
        BC.lperfiles.lperfil.Remove(perf)
        BC.guardar_lista_perfiles(BC.lperfiles)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim carro As New percarro



        carro.ShowDialog()


        If carro.DialogResult = 1 Then
            NumericUpDown1.Text = carro.i


        End If
        carro.Dispose()

    End Sub
End Class