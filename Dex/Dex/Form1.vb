Imports System.IO


Public Class Form1
    Dim Records(50) As String
    Dim Count As Integer
    Dim Current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("Data.txt")
        outFile.Write(Field1.Text)
        outFile.Write("|")
        outFile.Write(Field2.Text)
        outFile.Write("|")
        outFile.Write(Field3.Text)
        outFile.Write("|")
        outFile.Write(Field4.Text)
        outFile.Write("|")
        outFile.Write(Field5.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim inFile As New IO.StreamReader("Data.txt")
            While Not inFile.EndOfStream
                Records(Count) = inFile.ReadLine
                Count = Count + 1
            End While
            inFile.Close()
            ShowRecord(0)
        End If
    End Sub
    Public Sub ShowRecord(index As Integer)
        Dim fields() As String
        If Records(index) <> Nothing Then
            fields = Records(index).Split("|")
            Field1.Text = fields(0)
            Field2.Text = fields(1)
            Field3.Text = fields(2)
            Field4.Text = fields(3)
            Field5.Text = fields(4)
            If File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Current = 0
        ShowRecord(Current)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Current = Count - 1
        ShowRecord(Current)
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If Current > 0 Then
            Current = Current - 1
            ShowRecord(Current)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Current < Count - 1 Then
            Current = Current + 1
            ShowRecord(Current)
        End If
    End Sub
End Class
