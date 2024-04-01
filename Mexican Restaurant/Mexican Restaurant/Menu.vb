Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Menu
    Dim total As Integer
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutBut_Click(sender As Object, e As EventArgs) Handles AboutBut.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f2 As New About_Us
        f2.ShowDialog()

        Me.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = total

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        total = total + 19.99

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        total = total + 4.99
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total = total + 21.99
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total = total + 15.99
    End Sub
End Class