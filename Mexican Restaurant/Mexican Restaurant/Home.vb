Imports System.Windows

Public Class Home
    Private Sub MenuBut_Click(sender As Object, e As EventArgs) Handles MenuBut.Click
        Me.Hide()
        Dim f2 As New Menu
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AboutBut_Click(sender As Object, e As EventArgs) Handles AboutBut.Click
        Me.Hide()
        Dim f2 As New About_Us
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ContactBut_Click(sender As Object, e As EventArgs) Handles ContactBut.Click
        Me.Hide()
        Dim f2 As New Contact_Us
        f2.ShowDialog()
        Me.Show()
    End Sub
End Class
