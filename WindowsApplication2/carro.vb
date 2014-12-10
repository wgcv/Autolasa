Imports System.Windows.Forms

Public Class carro
    Public partes As New BC.pcarro
    Dim i1 As Boolean = False
    Dim i2 As Boolean = False
    Dim i3 As Boolean = False
    Dim i4 As Boolean = False
    Dim i5 As Boolean = False
    Dim i6 As Boolean = False
    Dim i7 As Boolean = False
    Dim i8 As Boolean = False
    Dim i9 As Boolean = False
    Dim i10 As Boolean = False
    Dim i11 As Boolean = False
    Dim i12 As Boolean = False
    Dim i13 As Boolean = False


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub carro_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

  

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
       
        If Not i3 Then
            PictureBox3.Image = My.Resources.s_techo
            partes.techo = True
            i3 = True
        Else
            PictureBox3.Image = My.Resources.techo
            i3 = False
            partes.techo = False
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Not i4 Then
            PictureBox4.Image = My.Resources.s_cajuela
            partes.cajuela = True

            i4 = True
        Else
            PictureBox4.Image = My.Resources.cajuela
            i4 = False
            partes.cajuela = False

        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Not i5 Then
            PictureBox5.Image = My.Resources.s_aderecho
            partes.aderecho = True

            i5 = True
        Else
            PictureBox5.Image = My.Resources.aderecho
            partes.aderecho = False
            i5 = False
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Not i6 Then
            PictureBox6.Image = My.Resources.s_aizquierdo
            i6 = True
            partes.aizquierdo = True

        Else
            PictureBox6.Image = My.Resources.aizquierdo
            i6 = False
            partes.aizquierdo = False

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Not i7 Then
            PictureBox7.Image = My.Resources.s_bderecho
            partes.bderecho = True

            i7 = True
        Else
            PictureBox7.Image = My.Resources.bderecho
            i7 = False
            partes.bderecho = False

        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If Not i8 Then
            PictureBox8.Image = My.Resources.s_bizquierdo
            partes.bizquierdo = True
            i8 = True
        Else
            PictureBox8.Image = My.Resources.bizquierdo
            partes.bizquierdo = False

            i8 = False
        End If
    End Sub

  
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If Not i11 Then
            PictureBox11.Image = My.Resources.s_dderecho
            partes.dderecho = True
            i11 = True
        Else
            PictureBox11.Image = My.Resources.dderecho
            partes.dderecho = False

            i11 = False
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If Not i12 Then
            PictureBox12.Image = My.Resources.s_dizquierdo
            i12 = True
            partes.dizqueirdo = True

        Else
            PictureBox12.Image = My.Resources.dizquierdo
            partes.dizqueirdo = False
            i12 = False
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If Not i13 Then
            PictureBox13.Image = My.Resources.s_guardachoque
            i13 = True
            partes.guadachoque = True

        Else
            PictureBox13.Image = My.Resources.guardachoque
            i13 = False
            partes.guadachoque = False

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Not i2 Then
            PictureBox2.Image = My.Resources.s_capo
            i2 = True
            partes.capo = True

        Else
            PictureBox2.Image = My.Resources.capo
            i2 = False
            partes.capo = False

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Not i1 Then
            PictureBox1.Image = My.Resources.s_parachoque
            partes.parachoque = True

            i1 = True
        Else
            PictureBox1.Image = My.Resources.parachoque
            i1 = False
            partes.parachoque = False

        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If Not i9 Then
            PictureBox9.Image = My.Resources.s_cderecho
            partes.cderecho = True

            i9 = True
        Else
            PictureBox9.Image = My.Resources.cderecho
            i9 = False
            partes.cderecho = False

        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If Not i10 Then
            PictureBox10.Image = My.Resources.s_cizquierdo
            partes.cizquierdo = True

            i10 = True
        Else
            PictureBox10.Image = My.Resources.cizquierdo
            i10 = False
            partes.cizquierdo = False

        End If
    End Sub

    Public Sub New(ByRef parte As BC.pcarro)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
