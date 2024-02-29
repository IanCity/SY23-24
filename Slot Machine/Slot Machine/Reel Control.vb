﻿Imports System.Drawing.Imaging

Public Class Reel_Control
    Public Property ItemValue As Integer
    Public Property SpinTime As Integer = 2000
    Dim Rand As New Random
    Public Sub Spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim R As Integer
        R = Rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(R)
        ItemValue = R
    End Sub

    Private Sub Reel_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = SpinTime
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
End Class
