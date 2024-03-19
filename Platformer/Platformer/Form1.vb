Public Class frm2DPlatformer
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim score As Integer

    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Start.KeyDown
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

    Private Sub frm2DPlatformer_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Start.KeyUp
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
                        score = score - 1
                        Label1.Text = score
                    End If
                End If
                If b.Tag = "finish" Then
                    If b.Visible And PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        Label3.Visible = True
                        PicPlayer.Visible = False
                        ReButton.Visible = True
                    End If
                End If
                If b.Tag = "coin" Then
                    If b.Visible And PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        score += 1
                        Label1.Text = score
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub tmrGravity_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGravity.Tick
        PicPlayer.Top += moveSpeed
    End Sub

    Private Sub ReButton_Click(sender As Object, e As EventArgs) Handles ReButton.Click
        PicPlayer.Visible = True
        PicPlayer.Location = New Point(12, 300)
        Label3.Visible = False
        ReButton.Visible = False
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox7.Visible = True
        PictureBox16.Visible = True
        score = 0
        Label1.Text = "0"
    End Sub
End Class