<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorial
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUserNumber = New System.Windows.Forms.TextBox()
        Me.btnCalculateFactorial = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCalcSteps = New System.Windows.Forms.TextBox()
        Me.lblCalcSteps = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTxtResult = New System.Windows.Forms.Label()
        Me.btnHomePage = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtUserNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 80)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(159, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 100)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Result"
        '
        'txtUserNumber
        '
        Me.txtUserNumber.Location = New System.Drawing.Point(33, 36)
        Me.txtUserNumber.Name = "txtUserNumber"
        Me.txtUserNumber.Size = New System.Drawing.Size(97, 23)
        Me.txtUserNumber.TabIndex = 0
        '
        'btnCalculateFactorial
        '
        Me.btnCalculateFactorial.Location = New System.Drawing.Point(20, 114)
        Me.btnCalculateFactorial.Name = "btnCalculateFactorial"
        Me.btnCalculateFactorial.Size = New System.Drawing.Size(165, 23)
        Me.btnCalculateFactorial.TabIndex = 16
        Me.btnCalculateFactorial.Text = "Calculate Factorial"
        Me.btnCalculateFactorial.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 143)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Quit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(19, 143)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(19, 181)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(258, 15)
        Me.lblInstructions.TabIndex = 20
        Me.lblInstructions.Text = "Insert a number and we will tell you its factorial!"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCalcSteps)
        Me.GroupBox3.Controls.Add(Me.lblCalcSteps)
        Me.GroupBox3.Controls.Add(Me.lblResult)
        Me.GroupBox3.Controls.Add(Me.lblTxtResult)
        Me.GroupBox3.Location = New System.Drawing.Point(223, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 100)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result"
        '
        'txtCalcSteps
        '
        Me.txtCalcSteps.BackColor = System.Drawing.Color.Cornsilk
        Me.txtCalcSteps.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalcSteps.Location = New System.Drawing.Point(10, 47)
        Me.txtCalcSteps.Name = "txtCalcSteps"
        Me.txtCalcSteps.Size = New System.Drawing.Size(167, 16)
        Me.txtCalcSteps.TabIndex = 3
        '
        'lblCalcSteps
        '
        Me.lblCalcSteps.AutoSize = True
        Me.lblCalcSteps.Location = New System.Drawing.Point(10, 50)
        Me.lblCalcSteps.Name = "lblCalcSteps"
        Me.lblCalcSteps.Size = New System.Drawing.Size(10, 15)
        Me.lblCalcSteps.TabIndex = 2
        Me.lblCalcSteps.Text = " "
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(10, 74)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(10, 15)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = " "
        '
        'lblTxtResult
        '
        Me.lblTxtResult.AutoSize = True
        Me.lblTxtResult.Location = New System.Drawing.Point(10, 27)
        Me.lblTxtResult.Name = "lblTxtResult"
        Me.lblTxtResult.Size = New System.Drawing.Size(10, 15)
        Me.lblTxtResult.TabIndex = 0
        Me.lblTxtResult.Text = " "
        '
        'btnHomePage
        '
        Me.btnHomePage.Location = New System.Drawing.Point(223, 143)
        Me.btnHomePage.Name = "btnHomePage"
        Me.btnHomePage.Size = New System.Drawing.Size(183, 23)
        Me.btnHomePage.TabIndex = 22
        Me.btnHomePage.Text = "Home Page"
        Me.btnHomePage.UseVisualStyleBackColor = True
        '
        'frmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(418, 211)
        Me.Controls.Add(Me.btnHomePage)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculateFactorial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFactorial"
        Me.Text = "Factorial  Exercises"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtUserNumber As TextBox
    Friend WithEvents btnCalculateFactorial As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblTxtResult As Label
    Friend WithEvents btnHomePage As Button
    Friend WithEvents lblCalcSteps As Label
    Friend WithEvents txtCalcSteps As TextBox
End Class
