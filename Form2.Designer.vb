<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsername
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblTextUsername = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtDOB)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About You"
        '
        'dtDOB
        '
        Me.dtDOB.Location = New System.Drawing.Point(94, 67)
        Me.dtDOB.Name = "dtDOB"
        Me.dtDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtDOB.TabIndex = 7
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(15, 67)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(76, 15)
        Me.lblDOB.TabIndex = 2
        Me.lblDOB.Text = "Date of Birth:"
        '
        'txtFullName
        '
        Me.txtFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFullName.Location = New System.Drawing.Point(94, 28)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(168, 23)
        Me.txtFullName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 31)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name:"
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(22, 137)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(88, 23)
        Me.btnSignUp.TabIndex = 1
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(116, 137)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(210, 137)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(88, 23)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(22, 166)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(276, 23)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPassword)
        Me.GroupBox2.Controls.Add(Me.lblTextUsername)
        Me.GroupBox2.Controls.Add(Me.lblUsername)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 118)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login Info"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(7, 95)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(10, 15)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = " "
        Me.lblPassword.Visible = False
        '
        'lblTextUsername
        '
        Me.lblTextUsername.AutoSize = True
        Me.lblTextUsername.Location = New System.Drawing.Point(7, 36)
        Me.lblTextUsername.Name = "lblTextUsername"
        Me.lblTextUsername.Size = New System.Drawing.Size(129, 15)
        Me.lblTextUsername.TabIndex = 7
        Me.lblTextUsername.Text = "Your new Username is: "
        Me.lblTextUsername.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(7, 67)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(10, 15)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = " "
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(317, 151)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(10, 15)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = " "
        '
        'frmUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(654, 201)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUsername"
        Me.Text = "Create Your Username"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTextUsername As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents dtDOB As DateTimePicker
    Friend WithEvents lblPassword As Label
End Class
