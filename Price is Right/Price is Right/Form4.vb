
Public Class Form4
    Dim car As Integer
    Dim carnum1 As Integer
    Dim carnum2 As Integer
    Dim carnum3 As Integer
    Dim carnum4 As Integer

    Dim choice As Integer







    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        car = Int(Rnd() * 8) + 1
        If car = 1 Then PictureBox1.Image = My.Resources.Car1
        If car = 2 Then PictureBox1.Image = My.Resources.Car2
        If car = 3 Then PictureBox1.Image = My.Resources.Car3
        If car = 4 Then PictureBox1.Image = My.Resources.Car4
        If car = 5 Then PictureBox1.Image = My.Resources.Car5
        If car = 6 Then PictureBox1.Image = My.Resources.Car6
        If car = 7 Then PictureBox1.Image = My.Resources.Car7
        If car = 8 Then PictureBox1.Image = My.Resources.Car8

        carnum1 = Int(Rnd() * 9) + 1
        carnum2 = Int(Rnd() * 9)
        carnum3 = Int(Rnd() * 9)
        carnum4 = Int(Rnd() * 9)

        Label1.Text = carnum1
        Label1.ForeColor = Color.SaddleBrown

        Label2.Text = carnum2
        Label2.ForeColor = Color.SaddleBrown

        Label3.Text = carnum3
        Label3.ForeColor = Color.SaddleBrown

        Label4.Text = carnum4
        Label4.ForeColor = Color.SaddleBrown


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            TextBox1.Enabled = False
        End If
        If TextBox1.Text = Label1.Text Then
            Label1.BackColor = Color.GreenYellow
            Label1.ForeColor = Color.White
            totalpicks = totalpicks + 1
        Else
            Label1.BackColor = Color.Red
        End If
        If totalpicks >= 1 Then
            Button5.Visible = True
        End If
        If TextBox1.Enabled = False And TextBox2.Enabled = False And TextBox3.Enabled = False And TextBox4.Enabled = False And totalpicks = 0 Then
            choice = MsgBox("Game over! :(", MsgBoxStyle.OkOnly)
            If choice = vbOK Then
                End
            End If
        End If
        If TextBox1.Text > 9 Then
            MsgBox("Enter a number from 0-9")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text <> "" Then
            TextBox2.Enabled = False
        End If
        If TextBox2.Text = Label2.Text Then
            Label2.BackColor = Color.GreenYellow
            Label2.ForeColor = Color.White
            totalpicks = totalpicks + 1
        Else
            Label2.BackColor = Color.Red
        End If
        If totalpicks >= 1 Then
            Button5.Visible = True
        End If
        If TextBox1.Enabled = False And TextBox2.Enabled = False And TextBox3.Enabled = False And TextBox4.Enabled = False And totalpicks = 0 Then
            choice = MsgBox("Game over! :(", MsgBoxStyle.OkOnly)
            If choice = vbOK Then
                End
            End If
        End If
        If TextBox2.Text > 9 Then
            MsgBox("Enter a number from 0-9")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox3.Text <> "" Then
            TextBox3.Enabled = False
        End If
        If TextBox3.Text = Label3.Text Then
            Label3.BackColor = Color.GreenYellow
            Label3.ForeColor = Color.White
            totalpicks = totalpicks + 1
        Else
            Label3.BackColor = Color.Red
        End If
        If totalpicks >= 1 Then
            Button5.Visible = True
        End If
        If TextBox1.Enabled = False And TextBox2.Enabled = False And TextBox3.Enabled = False And TextBox4.Enabled = False And totalpicks = 0 Then
            choice = MsgBox("Game over! :(", MsgBoxStyle.OkOnly)
            If choice = vbOK Then
                End
            End If
        End If
        If TextBox3.Text > 9 Then
            MsgBox("Enter a number from 0-9")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox4.Text <> "" Then
            TextBox4.Enabled = False
        End If
        If TextBox4.Text = Label4.Text Then
            Label4.BackColor = Color.GreenYellow
            Label4.ForeColor = Color.White
            totalpicks = totalpicks + 1
        Else
            Label4.BackColor = Color.Red
        End If
        If totalpicks >= 1 Then
            Button5.Visible = True
        End If
        If TextBox1.Enabled = False And TextBox2.Enabled = False And TextBox3.Enabled = False And TextBox4.Enabled = False And totalpicks = 0 Then
            choice = MsgBox("Game over! :(", MsgBoxStyle.OkOnly)
            If choice = vbOK Then
                End
            End If
        End If
        If TextBox4.Text > 9 Then
            MsgBox("Enter a number from 0-9")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Visible = False
        Form3.Visible = True
        Form3.Location = Me.Location
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class