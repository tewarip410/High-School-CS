Public Class Form1
    'Pooja Tewari
    'May 31, 2013
    'Sudoku King

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
        Form2.Location = Me.Location
    End Sub
End Class
