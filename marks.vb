Imports System.Security.Cryptography.Pkcs

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mark As Integer = TextBox1.Text
        If Mark >= 75 Then
            Label4.Text = "distinction"
        Else
            If Mark >= 50 Then
                Label4.Text = "pass"
            Else
                If Mark >= 45 Then
                    Label4.Text = "supplimentry"
                Else
                    If Mark < 45 Then
                        Label4.Text = "fail"
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
