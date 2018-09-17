Public Class Form5

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        Form1.Visible = True
        Me.Visible = False
        Form4.TextBox1.Text = ""
        Form4.TextBox2.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class