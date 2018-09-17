Public Class Form7
    'Pooja Tewari
    'May 31, 2013
    'Sudoku King

    Dim time As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        time = time + 1

        If time = 60 Then
            Timer1.Enabled = False
            Button1.Visible = True
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.Show()
        Form6.Location = Me.Location
    End Sub
    Private Sub Form7_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class