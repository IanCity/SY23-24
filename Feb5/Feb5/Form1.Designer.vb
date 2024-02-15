<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ClickerControl3 = New Feb5.ClickerControl()
        Me.ClickerControl2 = New Feb5.ClickerControl()
        Me.ClickerControl1 = New Feb5.ClickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl3
        '
        Me.ClickerControl3.BackColor = System.Drawing.Color.DarkOrange
        Me.ClickerControl3.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClickerControl3.increment = 1
        Me.ClickerControl3.Location = New System.Drawing.Point(797, 178)
        Me.ClickerControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(233, 206)
        Me.ClickerControl3.TabIndex = 8
        '
        'ClickerControl2
        '
        Me.ClickerControl2.BackColor = System.Drawing.Color.RosyBrown
        Me.ClickerControl2.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClickerControl2.increment = 10
        Me.ClickerControl2.Location = New System.Drawing.Point(441, 114)
        Me.ClickerControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(233, 206)
        Me.ClickerControl2.TabIndex = 7
        '
        'ClickerControl1
        '
        Me.ClickerControl1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClickerControl1.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClickerControl1.increment = 1
        Me.ClickerControl1.Location = New System.Drawing.Point(127, 64)
        Me.ClickerControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(233, 206)
        Me.ClickerControl1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 474)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
End Class
