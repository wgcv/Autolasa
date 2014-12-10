Imports System.Windows.Forms

Public Class percarro
    Public i As Integer = 0



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 5

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 8

        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 1

        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 2

        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 3

        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 4

        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 6

        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 6

        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 6

        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 6

        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 7

        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 7

        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 7

        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 7

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        i = 0

        Me.Close()
    End Sub
End Class
