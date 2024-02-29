<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Spin = New System.Windows.Forms.Button()
        Me.Ten = New System.Windows.Forms.Button()
        Me.MoneyLabel = New System.Windows.Forms.Label()
        Me.Reel_Control3 = New Slot_Machine.Reel_Control()
        Me.Reel_Control2 = New Slot_Machine.Reel_Control()
        Me.Reel_Control1 = New Slot_Machine.Reel_Control()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "copper-ore-cartoon-png-removebg-preview.png")
        Me.ImageList1.Images.SetKeyName(1, "silver-bar-icon-cartoon-style-vector-21366010-removebg-preview.png")
        Me.ImageList1.Images.SetKeyName(2, "istockphoto-1185640227-612x612-removebg-preview.png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Spin
        '
        Me.Spin.Location = New System.Drawing.Point(310, 322)
        Me.Spin.Name = "Spin"
        Me.Spin.Size = New System.Drawing.Size(160, 31)
        Me.Spin.TabIndex = 1
        Me.Spin.Text = "Spin"
        Me.Spin.UseVisualStyleBackColor = True
        '
        'Ten
        '
        Me.Ten.BackgroundImage = Global.Slot_Machine.My.Resources.Resources._10
        Me.Ten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Ten.Location = New System.Drawing.Point(634, 251)
        Me.Ten.Name = "Ten"
        Me.Ten.Size = New System.Drawing.Size(154, 86)
        Me.Ten.TabIndex = 14
        Me.Ten.UseVisualStyleBackColor = True
        '
        'MoneyLabel
        '
        Me.MoneyLabel.AutoSize = True
        Me.MoneyLabel.Location = New System.Drawing.Point(691, 210)
        Me.MoneyLabel.Name = "MoneyLabel"
        Me.MoneyLabel.Size = New System.Drawing.Size(21, 16)
        Me.MoneyLabel.TabIndex = 15
        Me.MoneyLabel.Text = "$0"
        '
        'Reel_Control3
        '
        Me.Reel_Control3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Reel_Control3.ItemValue = 0
        Me.Reel_Control3.Location = New System.Drawing.Point(438, 151)
        Me.Reel_Control3.Name = "Reel_Control3"
        Me.Reel_Control3.Size = New System.Drawing.Size(98, 144)
        Me.Reel_Control3.SpinTime = 2000
        Me.Reel_Control3.TabIndex = 12
        '
        'Reel_Control2
        '
        Me.Reel_Control2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Reel_Control2.ItemValue = 0
        Me.Reel_Control2.Location = New System.Drawing.Point(340, 151)
        Me.Reel_Control2.Name = "Reel_Control2"
        Me.Reel_Control2.Size = New System.Drawing.Size(98, 144)
        Me.Reel_Control2.SpinTime = 2000
        Me.Reel_Control2.TabIndex = 11
        '
        'Reel_Control1
        '
        Me.Reel_Control1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Reel_Control1.ItemValue = 0
        Me.Reel_Control1.Location = New System.Drawing.Point(242, 151)
        Me.Reel_Control1.Name = "Reel_Control1"
        Me.Reel_Control1.Size = New System.Drawing.Size(98, 144)
        Me.Reel_Control1.SpinTime = 2000
        Me.Reel_Control1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "     "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(47, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "     "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(92, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "      "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "$20 for a Spin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Papyrus", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(226, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 94)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "You Win!!!!"
        Me.Label5.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Slot_Machine.My.Resources.Resources.Slot_machine
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MoneyLabel)
        Me.Controls.Add(Me.Ten)
        Me.Controls.Add(Me.Reel_Control3)
        Me.Controls.Add(Me.Reel_Control2)
        Me.Controls.Add(Me.Reel_Control1)
        Me.Controls.Add(Me.Spin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Spin As Button
    Friend WithEvents Reel_Control1 As Reel_Control
    Friend WithEvents Reel_Control2 As Reel_Control
    Friend WithEvents Reel_Control3 As Reel_Control
    Friend WithEvents Ten As Button
    Friend WithEvents MoneyLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
