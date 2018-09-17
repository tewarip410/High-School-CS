Public Class Form3
    Dim num As Integer
    Dim cashamount As Integer
    Dim fifty As Integer
    Dim hundred As Integer
    Dim twofifty As Integer
    Dim fivehundred As Integer
    Dim thousand As Integer
    Dim fivethousand As Integer
    Dim tenthousand As Integer
    Dim game As Integer

  
    

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000

        PictureBox2.Tag = Int(Rnd() * 7) + 1
        PictureBox3.Tag = Int(Rnd() * 7) + 1
        PictureBox4.Tag = Int(Rnd() * 7) + 1
        PictureBox5.Tag = Int(Rnd() * 7) + 1
        PictureBox6.Tag = Int(Rnd() * 7) + 1
        PictureBox7.Tag = Int(Rnd() * 7) + 1
        PictureBox11.Tag = Int(Rnd() * 7) + 1
        PictureBox12.Tag = Int(Rnd() * 7) + 1
        PictureBox13.Tag = Int(Rnd() * 7) + 1
        PictureBox14.Tag = Int(Rnd() * 7) + 1
        PictureBox15.Tag = Int(Rnd() * 7) + 1
        PictureBox16.Tag = Int(Rnd() * 7) + 1
        PictureBox22.Tag = Int(Rnd() * 7) + 1
        PictureBox23.Tag = Int(Rnd() * 7) + 1
        PictureBox24.Tag = Int(Rnd() * 7) + 1
        PictureBox25.Tag = Int(Rnd() * 7) + 1
        PictureBox26.Tag = Int(Rnd() * 7) + 1
        PictureBox27.Tag = Int(Rnd() * 7) + 1
        PictureBox30.Tag = Int(Rnd() * 7) + 1
        PictureBox31.Tag = Int(Rnd() * 7) + 1
        PictureBox32.Tag = Int(Rnd() * 7) + 1
        PictureBox33.Tag = Int(Rnd() * 7) + 1
        PictureBox34.Tag = Int(Rnd() * 7) + 1
        PictureBox35.Tag = Int(Rnd() * 7) + 1
        PictureBox36.Tag = Int(Rnd() * 7) + 1
        PictureBox37.Tag = Int(Rnd() * 7) + 1
        PictureBox38.Tag = Int(Rnd() * 7) + 1
        PictureBox39.Tag = Int(Rnd() * 7) + 1
        PictureBox40.Tag = Int(Rnd() * 7) + 1
        PictureBox41.Tag = Int(Rnd() * 7) + 1
    End Sub

   
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        totalpicks = totalpicks - 1
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
        Label3.Text = totalpicks
        If PictureBox2.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox2.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox2.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox2.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox2.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox2.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox2.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        PictureBox2.Visible = False
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
        End If



    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If PictureBox3.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox3.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox3.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox3.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox3.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox3.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox3.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
        End If
        Label3.Text = totalpicks
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox4.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox4.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox4.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox4.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox4.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox4.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox4.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
        End If
        Label3.Text = totalpicks
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If PictureBox5.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox5.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox5.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox5.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox5.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox5.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox5.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If PictureBox6.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox6.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox6.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox6.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox6.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox6.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox6.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If PictureBox7.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox7.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox7.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox7.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox7.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox7.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox7.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        If PictureBox11.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox11.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox11.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox11.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox11.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox11.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox11.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        If PictureBox12.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox12.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox12.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox12.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox12.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox12.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox12.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        If PictureBox13.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox13.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox13.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox13.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox13.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox13.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox13.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If PictureBox14.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox14.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox14.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox14.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox14.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox14.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox14.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        If PictureBox15.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox15.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox15.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox15.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox15.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox15.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox15.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        If PictureBox16.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox16.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox16.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox16.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox16.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox16.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox16.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        If PictureBox22.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox22.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox22.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox22.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox22.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox22.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox22.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        If PictureBox23.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox23.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox23.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox23.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox23.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox23.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox23.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        If PictureBox24.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox24.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox24.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox24.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox24.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox24.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox24.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        If PictureBox25.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox25.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox25.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox25.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox25.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox25.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox25.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        If PictureBox26.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox26.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox26.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox26.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox26.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox26.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox26.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        If PictureBox27.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox27.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox27.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox27.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox27.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox27.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox27.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        If PictureBox32.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox32.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox32.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox32.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox32.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox32.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox32.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        If PictureBox33.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox33.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox33.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox33.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox33.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox33.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox33.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        If PictureBox34.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox34.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox34.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox34.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox34.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox34.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox34.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click
        If PictureBox35.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox35.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox35.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox35.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox35.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox35.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox35.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        If PictureBox36.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox36.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox36.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox36.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox36.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox36.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox36.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click
        If PictureBox37.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox37.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox37.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox37.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox37.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox37.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox37.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        If PictureBox38.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox38.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox38.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox38.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox38.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox38.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox38.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click
        If PictureBox39.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox39.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox39.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox39.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox39.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox39.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox39.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click
        If PictureBox40.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox40.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox40.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox40.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox40.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox40.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox40.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.Click
        If PictureBox41.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox41.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox41.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox41.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox41.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox41.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox41.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        If PictureBox30.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox30.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox30.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox30.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox30.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox30.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox30.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        If PictureBox31.Tag = 1 Then
            Label1.Text = "You won " + Str(fifty)
            Label5.Text = Val(Label5.Text) + fifty
        ElseIf PictureBox31.Tag = 2 Then
            Label1.Text = "You won " + Str(hundred)
            Label5.Text = Val(Label5.Text) + hundred
        ElseIf PictureBox31.Tag = 3 Then
            Label1.Text = "You won " + Str(twofifty)
            Label5.Text = Val(Label5.Text) + twofifty
        ElseIf PictureBox31.Tag = 4 Then
            Label1.Text = "You won " + Str(fivehundred)
            Label5.Text = Val(Label5.Text) + fivehundred
        ElseIf PictureBox31.Tag = 5 Then
            Label1.Text = "You won " + Str(thousand)
            Label5.Text = Val(Label5.Text) + thousand
        ElseIf PictureBox31.Tag = 6 Then
            Label1.Text = "You won " + Str(fivethousand)
            Label5.Text = Val(Label5.Text) + fivethousand
        ElseIf PictureBox31.Tag = 7 Then
            Label1.Text = "You won " + Str(tenthousand)
            Label5.Text = Val(Label5.Text) + tenthousand
        End If
        totalpicks = totalpicks - 1
        If totalpicks = 0 Then
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox11.Enabled = False
            PictureBox12.Enabled = False
            PictureBox13.Enabled = False
            PictureBox14.Enabled = False
            PictureBox15.Enabled = False
            PictureBox16.Enabled = False
            PictureBox22.Enabled = False
            PictureBox23.Enabled = False
            PictureBox24.Enabled = False
            game = MsgBox("You won " + Label5.Text, MsgBoxStyle.OkOnly)
            If game = vbOK Then
                End
            End If
            PictureBox25.Enabled = False
            PictureBox26.Enabled = False
            PictureBox27.Enabled = False
            PictureBox30.Enabled = False
            PictureBox31.Enabled = False
            PictureBox32.Enabled = False
            PictureBox33.Enabled = False
            PictureBox34.Enabled = False
            PictureBox35.Enabled = False
            PictureBox36.Enabled = False
            PictureBox37.Enabled = False
            PictureBox38.Enabled = False
            PictureBox39.Enabled = False
            PictureBox40.Enabled = False
            PictureBox41.Enabled = False
           
        End If
        Label3.Text = totalpicks
        fifty = 50
        hundred = 100
        twofifty = 250
        fivehundred = 500
        thousand = 1000
        fivehundred = 5000
        tenthousand = 10000
    End Sub
End Class