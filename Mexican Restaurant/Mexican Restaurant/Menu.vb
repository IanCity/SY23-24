Public Class Menu
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
End Class