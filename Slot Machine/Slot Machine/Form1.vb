Imports System.Xml.Schema

Public Class Form1
    Dim WithEvents CS As New Money
    Private Sub Spin_Click(sender As Object, e As EventArgs) Handles Spin.Click
        Timer1.Enabled = True
        Reel_Control1.Spin()
        Reel_Control2.Spin()
        Reel_Control3.Spin()
        CS.Spin()
        Label1.Text = Reel_Control1.ItemValue
        Label2.Text = Reel_Control2.ItemValue
        Label3.Text = Reel_Control3.ItemValue
        If Label1.Text = Label2.Text And Label2.Text = Label3.Text Then
            Label5.Visible = True
            CS.Win()
        End If
    End Sub
    Private Sub Ten_Click(sender As Object, e As EventArgs) Handles Ten.Click
        CS.InsertTen()
        MoneyLabel.Text = CS.Total.ToString("C2")
    End Sub
End Class
