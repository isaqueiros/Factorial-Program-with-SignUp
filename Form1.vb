Public Class Form1

    'About the program (Part 1):
    ''Creation of a Home Page with main menu so the user can select to go to a page to create an username or go directly to the factorial exercise page.


    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        frmUsername.Show()
        Me.Hide()
    End Sub

    Private Sub FactorialExercisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactorialExercisesToolStripMenuItem.Click
        frmLoginPage.Show()
        Me.Hide()
    End Sub

End Class
