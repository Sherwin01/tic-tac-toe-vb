Public Class Form1
    Dim XorO As Boolean = False
    Sub ButtonsEnableFalse()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Sub check()
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            btn1.BackColor = Color.Blue
            btn2.BackColor = Color.Blue
            btn3.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            btn4.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn6.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            btn7.BackColor = Color.Blue
            btn8.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            btn1.BackColor = Color.Blue
            btn4.BackColor = Color.Blue
            btn7.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            btn1.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            btn3.BackColor = Color.Blue
            btn6.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            btn3.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn7.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            btn2.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn8.BackColor = Color.Blue
            MessageBox.Show("X is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If

        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            btn1.BackColor = Color.Blue
            btn2.BackColor = Color.Blue
            btn3.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            btn4.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn6.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            btn7.BackColor = Color.Blue
            btn8.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            btn1.BackColor = Color.Blue
            btn4.BackColor = Color.Blue
            btn7.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            btn1.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            btn3.BackColor = Color.Blue
            btn6.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            btn3.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn7.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            btn2.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn8.BackColor = Color.Blue
            MessageBox.Show("O is the Winner", "Good Game!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonsEnableFalse()
        End If

    End Sub

    Private Sub btn_click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click
        Dim a As Button = sender
        If XorO = False Then
            a.Text = "X"
            XorO = True
        Else
            a.Text = "O"
            XorO = False
        End If
        check()
        a.Enabled = False
    End Sub
End Class
