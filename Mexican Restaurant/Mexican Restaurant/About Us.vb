Public Class About_Us
    Private Sub HomeButA_Click(sender As Object, e As EventArgs) Handles HomeButA.Click
        Me.Hide()
        Dim f2 As New Home
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MenuButA_Click(sender As Object, e As EventArgs) Handles MenuButA.Click
        Me.Hide()
        Dim f2 As New Menu
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ContactButA_Click(sender As Object, e As EventArgs) Handles ContactButA.Click
        Me.Hide()
        Dim f2 As New Contact_Us
        f2.ShowDialog()
        Me.Show()
    End Sub
End Class