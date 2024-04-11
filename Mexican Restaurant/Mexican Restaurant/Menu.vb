<<<<<<< Updated upstream
Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Menu
    Dim total As Integer
=======
﻿Public Class Menu
    Dim total As Integer

>>>>>>> Stashed changes
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HomeButM_Click(sender As Object, e As EventArgs) Handles HomeButM.Click
        Me.Hide()
        Dim f2 As New Home
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ContactButM_Click(sender As Object, e As EventArgs) Handles ContactButM.Click
        Me.Hide()
        Dim f2 As New Contact_Us
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AboutButM_Click(sender As Object, e As EventArgs) Handles AboutButM.Click
        Me.Hide()
        Dim f2 As New About_Us
        f2.ShowDialog()
        Me.Show()
    End Sub

<<<<<<< Updated upstream
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
=======
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total = total + 19.99
        Label3.Text = total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        total = total + 4.99
        Label3.Text = total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        total = total + 15.99
        Label3.Text = total
>>>>>>> Stashed changes
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total = total + 21.99
<<<<<<< Updated upstream
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total = total + 15.99
=======
        Label3.Text = total
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total = 0
        Label3.Text = total
>>>>>>> Stashed changes
    End Sub
End Class