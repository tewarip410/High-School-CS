
Public Class Form2
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label1.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label1.Enabled = False
        Else
            Label1.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label1.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label2.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label2.Enabled = False
        Else
            Label2.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label2.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label3.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label3.Enabled = False
        Else
            Label3.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label3.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label4.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label4.Enabled = False
        Else
            Label4.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label4.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label5.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label5.Enabled = False
        Else
            Label5.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label5.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label6.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label6.Enabled = False
        Else
            Label6.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label6.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label7.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label7.Enabled = False
        Else
            Label7.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label7.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label8.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label8.Enabled = False
        Else
            Label8.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label8.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        If Label10.Text = Form4.TextBox1.Text + "'s turn" Then
            Label9.Text = "O"
            Label10.Text = Form4.TextBox2.Text + "'s turn"
            Label9.Enabled = False
        Else
            Label9.Text = "X"
            Label10.Text = Form4.TextBox1.Text + "'s turn"
            Label9.Enabled = False
        End If

        CheckForWinnerO()
        CheckForWinnerX()
        NoWinner()
    End Sub
    Private Sub CheckForWinnerO()

        If Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "O" Then
            Label1.BackColor = Color.GreenYellow
            Label2.BackColor = Color.GreenYellow
            Label3.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "O" Then
            Label4.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label6.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "O" Then
            Label7.BackColor = Color.GreenYellow
            Label8.BackColor = Color.GreenYellow
            Label9.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "O" Then
            Label1.BackColor = Color.GreenYellow
            Label4.BackColor = Color.GreenYellow
            Label7.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "O" Then
            Label2.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label8.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "O" Then
            Label3.BackColor = Color.GreenYellow
            Label6.BackColor = Color.GreenYellow
            Label9.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "O" Then
            Label1.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label9.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label3.Text = "O" And Label5.Text = "O" And Label7.Text = "O" Then
            Label3.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label7.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox1.Text + " WON!"
        End If

        If Label10.Text = Form4.TextBox1.Text + " WON!" Then
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
        End If
    End Sub
    Private Sub CheckForWinnerX()

        If Label1.Text = "X" And Label2.Text = "X" And Label3.Text = "X" Then
            Label1.BackColor = Color.GreenYellow
            Label2.BackColor = Color.GreenYellow
            Label3.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label4.Text = "X" And Label5.Text = "X" And Label6.Text = "X" Then
            Label4.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label6.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label7.Text = "X" And Label8.Text = "X" And Label9.Text = "X" Then
            Label7.BackColor = Color.GreenYellow
            Label8.BackColor = Color.GreenYellow
            Label9.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label1.Text = "X" And Label4.Text = "X" And Label7.Text = "X" Then
            Label1.BackColor = Color.GreenYellow
            Label4.BackColor = Color.GreenYellow
            Label7.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label2.Text = "X" And Label5.Text = "X" And Label8.Text = "X" Then
            Label2.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label8.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label3.Text = "X" And Label6.Text = "X" And Label9.Text = "X" Then
            Label3.BackColor = Color.GreenYellow
            Label6.BackColor = Color.GreenYellow
            Label9.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label1.Text = "X" And Label5.Text = "X" And Label9.Text = "X" Then
            Label1.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label9.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label3.Text = "X" And Label5.Text = "X" And Label7.Text = "X" Then
            Label3.BackColor = Color.GreenYellow
            Label5.BackColor = Color.GreenYellow
            Label7.BackColor = Color.GreenYellow

            Label10.Text = Form4.TextBox2.Text + " WON!"
        End If

        If Label10.Text = Form4.TextBox2.Text + " WON!" Then
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
        End If
    End Sub
    Private Sub NoWinner()

        If Label1.Text <> "" And
            Label2.Text <> "" And
            Label3.Text <> "" And
            Label4.Text <> "" And
            Label5.Text <> "" And
            Label6.Text <> "" And
            Label7.Text <> "" And
            Label8.Text <> "" And
            Label9.Text <> "" And
            Label10.Text <> Form4.TextBox1.Text + " WON!" Or
            Label1.Text <> "" And
            Label2.Text <> "" And
            Label3.Text <> "" And
            Label4.Text <> "" And
            Label5.Text <> "" And
            Label6.Text <> "" And
            Label7.Text <> "" And
            Label8.Text <> "" And
            Label9.Text <> "" And
            Label10.Text <> Form4.TextBox2.Text + " WON!" Then
            Label10.Text = "GAME OVER"
        Else
            CheckForWinnerO()
            CheckForWinnerX()
        End If
    End Sub
    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click

        Form1.Visible = True
        Me.Visible = False
        Form4.TextBox1.Text = ""
        Form4.TextBox2.Text = ""

        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""

        Form4.TextBox1.Enabled = True
        Form4.TextBox2.Enabled = True

        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        Label4.Enabled = True
        Label5.Enabled = True
        Label6.Enabled = True
        Label7.Enabled = True
        Label8.Enabled = True
        Label9.Enabled = True

        Label1.BackColor = Color.DarkTurquoise
        Label2.BackColor = Color.DarkTurquoise
        Label3.BackColor = Color.DarkTurquoise
        Label4.BackColor = Color.DarkTurquoise
        Label5.BackColor = Color.DarkTurquoise
        Label6.BackColor = Color.DarkTurquoise
        Label7.BackColor = Color.DarkTurquoise
        Label8.BackColor = Color.DarkTurquoise
        Label9.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click

        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""

        Label10.Text = Form4.TextBox1.Text + "'s turn"

        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        Label4.Enabled = True
        Label5.Enabled = True
        Label6.Enabled = True
        Label7.Enabled = True
        Label8.Enabled = True
        Label9.Enabled = True

        Form4.TextBox1.Enabled = True
        Form4.TextBox2.Enabled = True

        Label1.BackColor = Color.DarkTurquoise
        Label2.BackColor = Color.DarkTurquoise
        Label3.BackColor = Color.DarkTurquoise
        Label4.BackColor = Color.DarkTurquoise
        Label5.BackColor = Color.DarkTurquoise
        Label6.BackColor = Color.DarkTurquoise
        Label7.BackColor = Color.DarkTurquoise
        Label8.BackColor = Color.DarkTurquoise
        Label9.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class