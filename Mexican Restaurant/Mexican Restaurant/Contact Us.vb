Public Class Contact_Us
    Private Sub HomeButC_Click(sender As Object, e As EventArgs) Handles HomeButC.Click
        Me.Hide()
        Dim f2 As New Home
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MenuButC_Click(sender As Object, e As EventArgs) Handles MenuButC.Click
        Me.Hide()
        Dim f2 As New Menu
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AboutButC_Click(sender As Object, e As EventArgs) Handles AboutButC.Click
        Me.Hide()
        Dim f2 As New About_Us
        f2.ShowDialog()
        Me.Show()
    End Sub
End Class