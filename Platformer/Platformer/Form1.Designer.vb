<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2DPlatformer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Enemy = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.Enemy4 = New System.Windows.Forms.PictureBox()
        Me.Start = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReButton = New System.Windows.Forms.Button()
        Me.Mover3 = New Platformer.mover()
        Me.Mover4 = New Platformer.mover()
        Me.Mover2 = New Platformer.mover()
        Me.Mover1 = New Platformer.mover()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Gold
        Me.PicPlayer.Location = New System.Drawing.Point(31, 494)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(52, 50)
        Me.PicPlayer.TabIndex = 0
        Me.PicPlayer.TabStop = False
        '
        'PicAir
        '
        Me.PicAir.BackColor = System.Drawing.Color.SkyBlue
        Me.PicAir.Location = New System.Drawing.Point(0, 0)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(1109, 496)
        Me.PicAir.TabIndex = 1
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PicGround.Location = New System.Drawing.Point(0, 553)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(1109, 69)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 35
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 35
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 35
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(860, 437)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(589, 325)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(317, 183)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(31, 131)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(225, 19)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1109, 563)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Red
        Me.PictureBox6.Location = New System.Drawing.Point(14748, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "restart"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(920, 389)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "coin"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Red
        Me.PictureBox8.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 627)
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "restart"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Red
        Me.PictureBox9.Location = New System.Drawing.Point(1099, 0)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(10, 622)
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "restart"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox10.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(52, 113)
        Me.PictureBox10.TabIndex = 12
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "finish"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox11.Location = New System.Drawing.Point(949, 116)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "coin"
        '
        'Enemy
        '
        Me.Enemy.BackColor = System.Drawing.Color.Red
        Me.Enemy.Location = New System.Drawing.Point(279, 103)
        Me.Enemy.Name = "Enemy"
        Me.Enemy.Size = New System.Drawing.Size(57, 50)
        Me.Enemy.TabIndex = 15
        Me.Enemy.TabStop = False
        Me.Enemy.Tag = "restart"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox12.Location = New System.Drawing.Point(302, 494)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox12.TabIndex = 17
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "bound"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox13.Location = New System.Drawing.Point(832, 167)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox13.TabIndex = 18
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "bound"
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Red
        Me.Enemy2.Location = New System.Drawing.Point(605, 55)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(57, 50)
        Me.Enemy2.TabIndex = 20
        Me.Enemy2.TabStop = False
        Me.Enemy2.Tag = "restart"
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.Color.Red
        Me.Enemy3.Location = New System.Drawing.Point(484, 265)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(57, 50)
        Me.Enemy3.TabIndex = 22
        Me.Enemy3.TabStop = False
        Me.Enemy3.Tag = "restart"
        '
        'Enemy4
        '
        Me.Enemy4.BackColor = System.Drawing.Color.Red
        Me.Enemy4.Location = New System.Drawing.Point(797, 443)
        Me.Enemy4.Name = "Enemy4"
        Me.Enemy4.Size = New System.Drawing.Size(57, 50)
        Me.Enemy4.TabIndex = 24
        Me.Enemy4.TabStop = False
        Me.Enemy4.Tag = "restart"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(53, 417)
        Me.Start.Name = "Start"
        Me.Start.ReadOnly = True
        Me.Start.Size = New System.Drawing.Size(100, 22)
        Me.Start.TabIndex = 25
        Me.Start.Text = "Press to Start"
        Me.Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 40)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Score:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 40)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(617, 128)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "You Win!!!"
        Me.Label3.Visible = False
        '
        'ReButton
        '
        Me.ReButton.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReButton.Location = New System.Drawing.Point(507, 387)
        Me.ReButton.Name = "ReButton"
        Me.ReButton.Size = New System.Drawing.Size(94, 47)
        Me.ReButton.TabIndex = 30
        Me.ReButton.Text = "Restart?"
        Me.ReButton.UseVisualStyleBackColor = True
        Me.ReButton.Visible = False
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.SkyBlue
        Me.Mover3.interval = 100
        Me.Mover3.Location = New System.Drawing.Point(302, 244)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(181, 190)
        Me.Mover3.speed = 7
        Me.Mover3.sprite = Me.Enemy3
        Me.Mover3.TabIndex = 21
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.SkyBlue
        Me.Mover4.interval = 100
        Me.Mover4.Location = New System.Drawing.Point(589, 355)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(207, 141)
        Me.Mover4.speed = 8
        Me.Mover4.sprite = Me.Enemy4
        Me.Mover4.TabIndex = 23
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.SkyBlue
        Me.Mover2.interval = 100
        Me.Mover2.Location = New System.Drawing.Point(589, 63)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(170, 199)
        Me.Mover2.speed = 8
        Me.Mover2.sprite = Me.Enemy2
        Me.Mover2.TabIndex = 19
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.SkyBlue
        Me.Mover1.interval = 100
        Me.Mover1.Location = New System.Drawing.Point(288, 31)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(150, 90)
        Me.Mover1.speed = 9
        Me.Mover1.sprite = Me.Enemy
        Me.Mover1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 31)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Finish Line"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox15.Location = New System.Drawing.Point(89, 9)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(10, 125)
        Me.PictureBox15.TabIndex = 33
        Me.PictureBox15.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox14.Location = New System.Drawing.Point(246, 9)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(10, 125)
        Me.PictureBox14.TabIndex = 34
        Me.PictureBox14.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox16.Location = New System.Drawing.Point(377, 77)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox16.TabIndex = 35
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Tag = "coin"
        '
        'frm2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 621)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.ReButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Enemy4)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Enemy)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PicAir)
        Me.Name = "frm2DPlatformer"
        Me.Text = "Form1"
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Mover2 As mover
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Mover3 As mover
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Mover4 As mover
    Friend WithEvents Enemy4 As PictureBox
    Friend WithEvents Start As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ReButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
End Class
