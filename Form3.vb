
'About the program: (Part 3)
''Starts by creating the subroutine that calculates the factorial number based on the user input
''The first three Private Subs are responsible for determining the actions of the designed buttons Clear, Quit and Home Page (return to Home Page).
''The fourth Private Sub calls the factorial calculation subroutine when the button Calculate in the design is selected.

Public Class frmFactorial

    'Creation of a function to calculate the factorial of the user input number
    'And pass parameters
    Function calculateFactorial(ByVal factorialResult As Integer) As Integer
        'Dimension the space for the variables as the data type interger (= wholenumber)
        Dim numFactorial As Decimal
        Dim multiplier As Integer

        'Determine an inicial value for the variable:
        factorialResult = 1
        'Attributes to the variable the value of the user input:
        numFactorial = Val(txtUserNumber.Text)

        'If the user input is greater than zero and is a whole number
        ''(using the mod (rest of a division) equals to zero to determine if it's not a decimal):
        If numFactorial > 0 And ((numFactorial Mod 1) = 0) Then

            'Use of a Next Loop to make the factorial calculation
            For multiplier = 2 To numFactorial 'range of the multiplier, from 1 to the user input being the maximum.
                factorialResult = factorialResult * multiplier 'The loop will continue until the multiplier becames 1 (the minimum value of the range).
                txtCalcSteps.Text = txtCalcSteps.Text + " x " + Str(multiplier)
            Next

            'Display the result in the previously designed labels:
            lblTxtResult.Text = "The answer is..."
            txtCalcSteps.Text = txtCalcSteps.Text & " ="
            lblResult.Text = factorialResult

        Else 'Otherwise, call the Error function to go through all possibilities of errors
                msgboxError(numFactorial)
            txtUserNumber.Clear()
            lblTxtResult.Text = ""
            lblResult.Text = ""

        End If

    End Function


    Function msgboxError(numFactorial As Decimal) As String

        txtCalcSteps.Text = ""
        'If the user input is less than zero, open a message box to request a positive number:
        If numFactorial < 0 Then
            MessageBox.Show("Please choose a positive number")
            'If the user input is zero, open a message box to request for a greater number:
        ElseIf numFactorial = 0 Then
            MessageBox.Show("Please choose a number greater than zero")
            'If the input is a decimal number, open a message box to request for a greater number:
        ElseIf (numFactorial Mod 1) <> 0 Then 'the Modulo (Mod) calculates the remaining of a division
            Return MessageBox.Show("Please choose only whole numbers")

        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Sub for the event of user clicking on the Clear button

        'Clear the text box and keep cursor highlighting it:
        txtUserNumber.Clear()
        txtUserNumber.Select()
        txtCalcSteps.Clear()
        'Clear texts from the labels used to display results.
        lblTxtResult.Text = ""
        lblResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Sub for the event of the user clicking on the Exit button

        'Closes all the three windows,
        'to covers in case the others have just be hidden and still be running in the background
        frmUsername.Close()
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub btnHomePage_Click(sender As Object, e As EventArgs) Handles btnHomePage.Click
        'Sub for the event of the user clicking on the Home Page button

        Form1.Show() 'Open back the Home Page tab
        Me.Hide() 'Hide the current page
        'The below clears any content of the current page in case the user comes back to it
        txtUserNumber.Clear()
        txtCalcSteps.Clear()
        lblResult.Text = ""
        lblTxtResult.Text = ""
    End Sub

    Private Sub btnCalculateFactorial_Click(sender As Object, e As EventArgs) Handles btnCalculateFactorial.Click
        'Sub for the event of the user clicking on the Calculate button
        Dim factorialResult As Integer 'Dimension of space for the variable
        txtCalcSteps.Text = "1"
        'Call the previously defined subroutine that calculates the factorial based on the user's input.
        Call calculateFactorial(factorialResult)

    End Sub

End Class