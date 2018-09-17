Public Class Form2
    Dim dx As Integer
    Dim dy As Integer


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim choice As Integer
        Label9.Text = Val(Label9.Text) + 1
        If Label6.Text = "GO!" Then

            PictureBox1.Enabled = True
            PictureBox1.Left = PictureBox1.Left + dx
            PictureBox1.Top = PictureBox1.Top + dy
        Else
            PictureBox1.Left = PictureBox1.Left
            PictureBox1.Top = PictureBox1.Top
        End If

        If PictureBox1.Bounds.IntersectsWith(Label8.Bounds) Then
            Label8.Visible = False
        End If

        If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) And Label8.Visible = False Then
            Label8.Visible = True
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If

        Label6.Text = "GO!"
        Dim win As Integer
        If PictureBox1.Bounds.IntersectsWith(Label1.Bounds) Or PictureBox1.Bounds.IntersectsWith(Label3.Bounds) Or PictureBox1.Bounds.IntersectsWith(Label4.Bounds) Or PictureBox1.Bounds.IntersectsWith(Label2.Bounds) Or PictureBox1.Bounds.IntersectsWith(Label5.Bounds) Then
            Timer1.Enabled = False

            choice = MsgBox("You crashed! Play again?", MsgBoxStyle.YesNo)

            If choice = vbYes Then
                Application.Restart()
            Else
                End
            End If
        End If
        If ProgressBar1.Value = 3 Then
            Timer1.Enabled = False
            win = MsgBox("You won! Play again?", MsgBoxStyle.YesNo)
            If win = vbYes Then
                Application.Restart()
            Else
                End
            End If
        End If



    End Sub



    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            PictureBox1.Image = My.Resources.Right
            dx = 5
            dy = 0
        End If
        If e.KeyCode = Keys.Left Then
            PictureBox1.Image = My.Resources.Left
            dx = -5
            dy = 0
        End If
        If e.KeyCode = Keys.Up Then
            PictureBox1.Image = My.Resources.Up
            dy = -5
            dx = 0
        End If
        If e.KeyCode = Keys.Down Then
            PictureBox1.Image = My.Resources.Down
            dy = 5
            dx = 0
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Enabled = False
        Me.Hide()
        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Visible = False
        Button1.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
