Public Class producto
    Dim producto1 As BC.producto
    Dim l_pintura As List(Of BC.pintura)
    Dim producto2 As BC.producto
    Dim pin As BC.pintura

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        producto1 = New BC.producto

        producto1.nombre = TextBox2.Text
        producto1.codigo = TextBox3.Text

        producto1.stock = TextBox4.Text
        producto1.es_pintura = CheckBox1.Checked
        producto1.com_pintura = CheckBox2.Checked

        producto1.costo = TextBox5.Text
       
        l_pintura = New List(Of BC.pintura)
        For Each list As String In ListBox1.Items
            pin = New BC.pintura

            pin.producto = BC.lproductos.busquedanombre(list)
            l_pintura.Add(pin)
        Next
        producto1.l_pintura = l_pintura

        If TextBox3.Enabled Then

            If (BC.mdf.lproductos.add(producto1)) Then
                Me.Close()


            End If

        Else
            If BC.mdf.lproductos.edit(producto2, producto1) Then
                Me.Close()

            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        For Each buscador As BC.producto In BC.lproductos.lproductos
            ComboBox1.Items.Add(buscador.nombre)


        Next
       
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
      e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TextBox5.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (ListBox2.SelectedIndex = -1) Then
            ListBox1.Items.Add(ListBox2.Text)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
       
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            GroupBox2.Enabled = True

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            For Each buscador As BC.producto In BC.lproductos.lproductos
                If (buscador.com_pintura) Then
                    ListBox2.Items.Add(buscador.nombre)
                End If


            Next
            CheckBox2.Checked = False

        Else
            GroupBox2.Enabled = False

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (ListBox1.SelectedIndex = -1) Then
            ListBox2.Items.Add(ListBox1.Text)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        producto1 = BC.mdf.lproductos.busquedanombre(ComboBox1.Text)
        If (producto1 IsNot Nothing) Then
            TextBox2.Text = producto1.nombre
            TextBox3.Text = producto1.codigo
            TextBox4.Text = producto1.stock
            TextBox5.Text = producto1.costo
            CheckBox1.Checked = producto1.es_pintura
            CheckBox2.Checked = producto1.com_pintura

            TextBox3.Enabled = True
            producto2 = producto1

            ListBox1.Items.Clear()

            For Each buscador As BC.pintura In producto1.l_pintura
                ListBox2.Items.Remove(buscador.producto.nombre)
                ListBox1.Items.Add(buscador.producto.nombre)
            Next
            BC.lproductos.eliminar(producto1)
            MsgBox("Se elimino el producto")
            ComboBox1.Items.Clear()

            For Each buscador As BC.producto In BC.lproductos.lproductos
                ComboBox1.Items.Add(buscador.nombre)


            Next

        Else
            producto1 = New BC.producto
            MsgBox("NO EXISTE EL PRODUCTO")
            TextBox3.Enabled = True

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        producto1 = BC.mdf.lproductos.busquedanombre(ComboBox1.Text)
        If (producto1 IsNot Nothing) Then
            TextBox2.Text = producto1.nombre
            TextBox3.Text = producto1.codigo
            TextBox4.Text = producto1.stock
            TextBox5.Text = producto1.costo
            CheckBox1.Checked = producto1.es_pintura
            CheckBox2.Checked = producto1.com_pintura

            TextBox3.Enabled = False
            producto2 = producto1

            ListBox1.Items.Clear()

            For Each buscador As BC.pintura In producto1.l_pintura
                ListBox2.Items.Remove(buscador.producto.nombre)
                ListBox1.Items.Add(buscador.producto.nombre)
            Next

        Else
            producto1 = New BC.producto
            MsgBox("NO EXISTE EL PRODUCTO")
            TextBox3.Enabled = True

        End If
    End Sub
End Class