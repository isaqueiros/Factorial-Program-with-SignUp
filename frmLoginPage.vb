Public Class frmLoginPage
    'Name: Isabela Queiros
    'Date: 06/11
    'About the Program:
    'This forms is the login page, which will read the user input and check if there is an user with those details previously created.

    'First there is the creation of the function that will check the user input details
    Function LoginCheck()
        'Check if the username/password inputted by the user are stored in the lists created on the Username page code
        If frmUsername.lstUsernames.Contains(txtUser.Text) And frmUsername.lstPasswords.Contains(txtPassword.Text) Then
            'If the details match, take the user to the Factorial Exercises page
            frmFactorial.Show()
            Me.Hide()
            lblErrorLogin.Text = ""
            txtUser.Clear()
            txtPassword.Clear()
        Else 'if the details don't match, display error message
            lblErrorLogin.Text = "Your username or password is incorrect!"

        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblErrorLogin.Text = ""
        txtUser.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        frmUsername.Show()
        Me.Hide()
        lblErrorLogin.Text = ""
        txtUser.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
        Form1.Close()
        frmUsername.Close()
        frmFactorial.Close()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        LoginCheck() 'call the function LoginCheck when the button Log In is clicked
    End Sub
End Class