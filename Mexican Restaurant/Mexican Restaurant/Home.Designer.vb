<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuBut = New System.Windows.Forms.Button()
        Me.AboutBut = New System.Windows.Forms.Button()
        Me.ContactBut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MenuBut
        '
        Me.MenuBut.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBut.Location = New System.Drawing.Point(21, 128)
        Me.MenuBut.Name = "MenuBut"
        Me.MenuBut.Size = New System.Drawing.Size(53, 23)
        Me.MenuBut.TabIndex = 0
        Me.MenuBut.Text = "Menu"
        Me.MenuBut.UseVisualStyleBackColor = True
        '
        'AboutBut
        '
        Me.AboutBut.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutBut.Location = New System.Drawing.Point(95, 130)
        Me.AboutBut.Name = "AboutBut"
        Me.AboutBut.Size = New System.Drawing.Size(75, 23)
        Me.AboutBut.TabIndex = 1
        Me.AboutBut.Text = "About Us"
        Me.AboutBut.UseVisualStyleBackColor = True
        '
        'ContactBut
        '
        Me.ContactBut.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactBut.Location = New System.Drawing.Point(191, 130)
        Me.ContactBut.Name = "ContactBut"
        Me.ContactBut.Size = New System.Drawing.Size(84, 23)
        Me.ContactBut.TabIndex = 2
        Me.ContactBut.Text = "Contact Us"
        Me.ContactBut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magneto", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(605, 122)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Taco Casa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(408, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "40404 N Gavilan Peak Pkwy, Anthem, AZ 85086"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContactBut)
        Me.Controls.Add(Me.AboutBut)
        Me.Controls.Add(Me.MenuBut)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuBut As Button
    Friend WithEvents AboutBut As Button
    Friend WithEvents ContactBut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
