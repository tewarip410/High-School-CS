Public Class Form4
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Form2.Visible = True
        Form2.Label10.Text = TextBox1.Text + "'s turn"
    End Sub
    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        Form1.Visible = True
        Me.Visible = False
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class