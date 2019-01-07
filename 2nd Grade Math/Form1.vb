Public Class Form1
    Dim value As Integer
    Dim value2 As Integer
    Dim answer As Integer
    Dim input As Integer
    Dim wrong As Integer
    Dim correct As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAdd.Visible = False
        lblSubtract.Visible = False
    End Sub

    Private Sub rdbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdd.CheckedChanged
        lblAdd.Visible = True
        lblSubtract.Visible = False
    End Sub

    Private Sub rdbSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSubtract.CheckedChanged
        lblSubtract.Visible = True
        lblAdd.Visible = False
        If rdbSubtract.Checked = True And value - value2 < 0 Then
            randomnumber1()
        End If
        If rdbSubtract.Checked = True And rdbLevel2.Checked = True And value - value2 < 0 Then
            randomnumber2()
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If rdbLevel1.Checked = False And rdbLevel2.Checked = False Then
            MsgBox("Please select a level", vbExclamation, "Select a level")
            Exit Sub
        End If
        If rdbAdd.Checked = False And rdbSubtract.Checked = False Then
            MsgBox("Please select an option", vbExclamation, "Select an Option")
            Exit Sub
        End If

        If IsNumeric(txtEquals.Text) = False Then
            MsgBox("Please enter a number", vbExclamation, "Enter a number")
            Exit Sub
        End If

        If rdbAdd.Checked = True Then
            answer = value + value2
        End If

        If rdbSubtract.Checked = True Then
            answer = value - value2
        End If

        input = Val(txtEquals.Text)

        If input = answer Then
            correct += 1
            txtEquals.Text = ""
        Else
            wrong += 1
            txtEquals.Text = ""
        End If

        If input = answer And rdbLevel1.Checked = True Then
            randomnumber1()
        End If

        If input = answer And rdbLevel2.Checked = True Then
            randomnumber2()
        End If

        lblCorrect.Text = correct
        lblIncorrect.Text = wrong
    End Sub

    Private Sub rdbLevel1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLevel1.CheckedChanged
        randomnumber1()
        If rdbLevel1.Checked = True Then
            txtBox1.Text = value
            txtBox2.Text = value2
        End If
    End Sub

    Private Sub rdbLevel2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLevel2.CheckedChanged
        randomnumber2()
        If rdbLevel2.Checked = True Then
            txtBox1.Text = value
            txtBox2.Text = value2
        End If
    End Sub
    Private Sub randomnumber1()
        Randomize()
        value = CInt(Int(10 * Rnd() + 1))
        value2 = CInt(Int(10 * Rnd() + 1))
        txtBox1.Text = value
        txtBox2.Text = value2
    End Sub
    Private Sub randomnumber2()
        Randomize()
        value = CInt(Int(100 * Rnd() + 10))
        value2 = CInt(Int(100 * Rnd() + 10))
        txtBox1.Text = value
        txtBox2.Text = value2
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As Byte
        response = MsgBox("Do you want to EXIT?", vbYesNo + vbQuestion, "Exit?")
        If response = vbYes Then
            Close()
        Else
            Show()
        End If
    End Sub
End Class
