Imports System.Runtime.InteropServices

Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_affiche.TextChanged

    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        If op = "" Then
            A = "2"
        Else
            B = "2"

        End If
        Txt_affiche.Text = A + op + B
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"

        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        If Not A = "" Then
            op = "+"
        End If
        Txt_affiche.Text = A + op + B
    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As EventArgs) Handles Btn_minus.Click
        If Not A = "" Then
            op = "-"
        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_mult_Click(sender As Object, e As EventArgs) Handles Btn_mult.Click
        If Not A = "" Then
            op = "*"
        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles Btn_div.Click
        If Not A = "" Then
            op = "/"
        End If
        Txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Btn_c_Click(sender As Object, e As EventArgs) Handles Btn_c.Click
        Txt_affiche.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)

            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else
                MessageBox.Show("Aet B doivent etre des entiers")
                test = False

            End If
            If test Then
                Txt_affiche.Text = Txt_affiche.Text + "=" + res.ToString
            End If

        End If

    End Sub
End Class

