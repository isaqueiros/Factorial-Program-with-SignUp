Public Class frmUsername

    'About the program (Part 2):
    ''The three first Private Subs are responsible for determining the actions of the designed buttons Home Page (return to Home Page), Quit and Clear.
    ''The fourth Private Sub is responsible for capturing the user's inputted name to form an Username.
    ''The if conditions are used to guarantee the user will input the complete first and last name, so the Username follows the correct logic.

    Public Shared strUsername, strPassword As String
    Public Shared lstUsernames As New List(Of String) 'Creation of public list (that can be accesses across forms) to store usernames
    Public Shared lstPasswords As New List(Of String) 'Creation of public list (that can be accessed across forms) to store passwords

    Function createLogIn(ByVal strUsername As String, strPassword As String) As String

        'Dimension space for the variables and determine the data type in which will be stored
        Dim strInitialLetter, strFirstName As String
        Dim spaceCounter As Integer
        Dim strFullName As String = txtFullName.Text

        'Count the spaces on the user input of full name to guarantee there is no middle name
        spaceCounter = 0
        For Each chrLetter As Char In strFullName
            If chrLetter = " " Then
                spaceCounter += 1
            End If
        Next

        'Make sure the user input is following the expected guidelines
        If spaceCounter = 1 Then
            'Split the Full Name text input to get two separated variables, first name and last name
            Dim strSplitName As String() = strFullName.Split(New String() {" "}, 2) 'Split the full name given by the user in two using the blank space as delimiter
            Dim strSurname As String = strSplitName(1) 'Captures the surname by using the index 1, capturing the second item

            'Determine the value of the variables
            strInitialLetter = strFullName.First() 'Captures the first character of the first name
            strFirstName = strSplitName(0) 'Determines the string FirstName as the index number 0 of the splitted variable, therefore, the first item of the list (the first name)
            strUsername = String.Concat(strInitialLetter, strSurname) 'Concatenate the first name letter and the surname to form the username

            'Print results into the labels on the design
            'If the length of the First Name and the length of the Surname is greater than 1 character, and the space counter is less than 2:
            If Len(strFirstName) > 1 And Len(strSurname) > 1 Then
                lblUsername.Text = strUsername 'Display the new username in the designated label
                lblTextUsername.Visible() = True 'Make the label with the text "Your new Username is" visible to the user
                lblPassword.Visible() = True
                birthdayMonth() 'Call function that determines the password as the birth date's Month
                lstUsernames.Add(strUsername) 'Stores the usernames created in a list so it can be used on the login page
                lstPasswords.Add(strPassword) 'Stored the passwords created in a list so it can be used on the login page

            Else 'Otherwise: (if the length of first name and surname are not greater than one character)
                lblError.Text = "Error! Please provide a complete first and last name."

            End If

        Else
            nameChecker(spaceCounter, strFullName)

        End If

    End Function

    Function nameChecker(ByVal spaceCounter As Integer, ByRef strFullName As String) As String

        'The space counter will analyse the string of the text box and count the amount of spaces
        spaceCounter = 0 'Initialises the variable
        For Each chrLetter As Char In strFullName 'Creates a For Loop to go over each character of the string
            If chrLetter = " " Then 'If the character is a space
                spaceCounter += 1 'Add one to the spaceCounter
            End If
        Next

        If spaceCounter < 1 Then 'If there is less than one space in the string
            lblError.Text = "Error! Please provide first AND last name"
        ElseIf spaceCounter > 1 Then 'If there are more than one space in the string:
            lblError.Text = "Error! Please don't include your middle name."
        ElseIf spaceCounter < 1 Then 'If there are no spaces in the string:
            lblError.Text = "Error! Please provide your first AND last name."

        End If

    End Function

    'The following function creates and displays the password based on the users' birthday
    Function birthdayMonth() As String
        'Dimension a space for the variable and determine it as a Date
        Dim dateofBirth As Date

        dateofBirth = dtDOB.Value 'Captures the value of the DateTimePicker box of the design
        strPassword = dateofBirth.ToString("MMMM") 'Captures the month of the date chosen and transform it into string

        lblPassword.Text = "Yours password is: " & strPassword 'Displays the label with the password


    End Function

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        frmLoginPage.Show() 'Redirect the user to the Home Page
        'The below makes sure the page is cleared (so if the user comes back the previous input has been cleared)
        lblTextUsername.Visible = False
        lblPassword.Visible = False
        txtFullName.Clear()
        lblUsername.Text = ""
        dtDOB.Value = Today() 'set the DateTimePicker for today's date
        Me.Hide() 'And hide the current page
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close() 'Closes the currently open application
        Form1.Close() 'Closes the previously hidden page so the entire application stops running
        frmFactorial.Close() 'Also closes the Factorial page in case the user has entered this page before and it is still open in the background (and hidden)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear() 'delete any input from the Full Name text box
        txtFullName.Select() 'Allows the cursor to continue highlighting the text box
        'If any data on it, the below commands change the labels text to blank and the DateTimePicker for current date
        lblError.Text = ""
        lblUsername.Text = ""
        lblTextUsername.Visible = False
        lblPassword.Visible = False
        dtDOB.Value = Today()

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'Call the function to create a Log In whenever the button Sign Up is clicked
        createLogIn(strUsername, strPassword)

    End Sub

End Class