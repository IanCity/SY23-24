Public Class frm2DPlatformer
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean

    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        PicPlayer.Left += moveSpeed
    End Sub

    Private Sub frm2DPlatformer_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        PicPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        PicPlayer.Top -= moveSpeed
    End Sub

    Private Sub frm2DPlatformer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        If PicPlayer.Bounds.IntersectsWith(PicAir.Bounds) Then
            If isJumping = False Then
                tmrGravity.Start()
            End If
        ElseIf PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            tmrGravity.Stop()
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "restart" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        PicPlayer.Location = New Point(12, 300)
                    End If
                End If
                If b.Tag = "coin" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub tmrGravity_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGravity.Tick
        PicPlayer.Top += moveSpeed
    End Sub
End Class