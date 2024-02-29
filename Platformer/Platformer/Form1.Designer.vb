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
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Gold
        Me.PicPlayer.Location = New System.Drawing.Point(12, 364)
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
        Me.PicAir.Size = New System.Drawing.Size(804, 358)
        Me.PicAir.TabIndex = 1
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PicGround.Location = New System.Drawing.Point(0, 411)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(804, 44)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
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
        Me.PictureBox1.Location = New System.Drawing.Point(288, 330)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(508, 263)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(272, 182)
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
        Me.PictureBox4.Size = New System.Drawing.Size(181, 19)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(804, 414)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'frm2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PicAir)
        Me.Controls.Add(Me.PictureBox5)
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
        Me.ResumeLayout(False)

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
End Class
