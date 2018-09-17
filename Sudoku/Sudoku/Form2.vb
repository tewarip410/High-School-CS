Public Class Form2
    'Pooja Tewari
    'May 31, 2013
    'Sudoku King

    Dim grid(0 To 8, 0 To 8) As Label
    Dim tempNum As Integer
    Dim theclick As Boolean
    Dim mysender As Label
    Dim myfont As New Font("Verdana", 20, FontStyle.Bold)
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For x = 0 To 8
            For y = 0 To 8
                grid(x, y) = New Label
                grid(x, y).Width = 50
                grid(x, y).Height = 50
                grid(x, y).BackColor = Color.White
                grid(x, y).Left = 50 * x + 25
                grid(x, y).Top = 50 * y + 25
                grid(x, y).BorderStyle = BorderStyle.FixedSingle
                grid(x, y).TextAlign = ContentAlignment.MiddleCenter
                grid(x, y).Font = myfont
                grid(x, y).Text = ""

                Me.Controls.Add(grid(x, y))

                AddHandler grid(x, y).Click, AddressOf gridClick

            Next
        Next

        ''''''''''''''''''''''''''
        'FIRST SUDOKU PUZZLE
        ''''''''''''''''''''''''''

        grid(0, 0).Text = "6"
        grid(0, 0).Enabled = False
        grid(2, 0).Text = "4"
        grid(2, 0).Enabled = False
        grid(3, 0).Text = "1"
        grid(3, 0).Enabled = False
        grid(4, 0).Text = "3"
        grid(4, 0).Enabled = False
        grid(2, 1).Text = "9"
        grid(2, 1).Enabled = False
        grid(3, 1).Text = "5"
        grid(3, 1).Enabled = False
        grid(6, 1).Text = "4"
        grid(6, 1).Enabled = False
        grid(8, 1).Text = "2"
        grid(8, 1).Enabled = False
        grid(1, 2).Text = "7"
        grid(1, 2).Enabled = False
        grid(4, 2).Text = "9"
        grid(4, 2).Enabled = False
        grid(6, 2).Text = "3"
        grid(6, 2).Enabled = False
        grid(7, 2).Text = "8"
        grid(7, 2).Enabled = False
        grid(1, 3).Text = "5"
        grid(1, 3).Enabled = False
        grid(4, 3).Text = "1"
        grid(4, 3).Enabled = False
        grid(5, 3).Text = "9"
        grid(5, 3).Enabled = False
        grid(7, 3).Text = "3"
        grid(7, 3).Enabled = False
        grid(0, 4).Text = "1"
        grid(0, 4).Enabled = False
        grid(3, 4).Text = "2"
        grid(3, 4).Enabled = False
        grid(5, 4).Text = "7"
        grid(5, 4).Enabled = False
        grid(8, 4).Text = "8"
        grid(8, 4).Enabled = False
        grid(0, 5).Text = "8"
        grid(0, 5).Enabled = False
        grid(2, 5).Text = "7"
        grid(2, 5).Enabled = False
        grid(7, 5).Text = "1"
        grid(7, 5).Enabled = False
        grid(8, 5).Text = "5"
        grid(8, 5).Enabled = False
        grid(0, 6).Text = "9"
        grid(0, 6).Enabled = False
        grid(2, 6).Text = "3"
        grid(2, 6).Enabled = False
        grid(3, 6).Text = "7"
        grid(3, 6).Enabled = False
        grid(5, 6).Text = "1"
        grid(5, 6).Enabled = False
        grid(6, 6).Text = "8"
        grid(6, 6).Enabled = False
        grid(1, 7).Text = "4"
        grid(1, 7).Enabled = False
        grid(4, 7).Text = "6"
        grid(4, 7).Enabled = False
        grid(7, 7).Text = "2"
        grid(7, 7).Enabled = False
        grid(0, 8).Text = "5"
        grid(0, 8).Enabled = False
        grid(2, 8).Text = "1"
        grid(2, 8).Enabled = False
        grid(5, 8).Text = "4"
        grid(5, 8).Enabled = False
        grid(6, 8).Text = "6"
        grid(6, 8).Enabled = False
        grid(8, 8).Text = "7"
        grid(8, 8).Enabled = False

        theclick = True

    End Sub
    Private Sub gridClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If theclick = True Then
            sender.backcolor = Color.LightPink
            theclick = False
            mysender = sender
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If mysender.BackColor = Color.LightPink Then
            If TextBox1.Text = "1" Or TextBox1.Text = "2" Or TextBox1.Text = "3" Or TextBox1.Text = "4" Or TextBox1.Text = "5" Or TextBox1.Text = "6" Or TextBox1.Text = "7" Or TextBox1.Text = "8" Or TextBox1.Text = "9" Then
                mysender.Text = TextBox1.Text
                mysender.BackColor = Color.White
                TextBox1.Text = ""
                If mysender.Text <> "" Then
                    theclick = True
                End If
            Else
                MsgBox("Type in a number from 1-9!")
                TextBox1.Text = ""
            End If
        Else
            MsgBox("Select a box!")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Answers: http://www.pdfpad.com/sudoku/pdf/e3648-k.pdf
        'Sudoku Puzzle: http://www.pdfpad.com/sudoku/pdf/e3648.pdf A

        Dim choice As Integer

        choice = MsgBox("Are you sure that you are ready to submit?", MsgBoxStyle.YesNo)

        If choice = vbYes Then
            Dim choice1 As Integer
            Dim choice2 As Integer

            If grid(1, 0).Text = "8" And grid(5, 0).Text = "2" And grid(6, 0).Text = "5" And grid(7, 0).Text = "7" And grid(8, 0).Text = "9" And grid(0, 1).Text = "3" And grid(1, 1).Text = "1" And grid(4, 1).Text = "7" And grid(5, 1).Text = "8" And grid(7, 1).Text = "6" And grid(0, 2).Text = "2" And grid(2, 2).Text = "5" And grid(3, 2).Text = "4" And grid(5, 2).Text = "6" And grid(8, 2).Text = "1" And grid(0, 3).Text = "4" And grid(2, 3).Text = "2" And grid(3, 3).Text = "8" And grid(6, 3).Text = "7" And grid(8, 3).Text = "6" And grid(1, 4).Text = "3" And grid(2, 4).Text = "6" And grid(4, 4).Text = "5" And grid(6, 4).Text = "9" And grid(7, 4).Text = "4" And grid(1, 5).Text = "9" And grid(3, 5).Text = "6" And grid(4, 5).Text = "4" And grid(5, 5).Text = "3" And grid(6, 5).Text = "2" And grid(1, 6).Text = "6" And grid(4, 6).Text = "2" And grid(7, 6).Text = "5" And grid(8, 6).Text = "4" And grid(0, 7).Text = "7" And grid(2, 7).Text = "8" And grid(3, 7).Text = "9" And grid(5, 7).Text = "5" And grid(6, 7).Text = "1" And grid(8, 7).Text = "3" And grid(1, 8).Text = "2" And grid(3, 8).Text = "3" And grid(4, 8).Text = "8" And grid(7, 8).Text = "9" Then
                choice1 = MsgBox("YOU WON! NEXT LEVEL?", MsgBoxStyle.YesNo)
                If choice1 = vbYes Then
                    Me.Hide()
                    Form3.Show()
                    Form3.Location = Me.Location
                Else
                    End
                End If
            Else
                choice2 = MsgBox("INCORRECT. TRY AGAIN?", MsgBoxStyle.YesNo)
                If choice2 = vbYes Then
                Else
                    End
                End If
            End If
        Else
        End If

    End Sub
End Class