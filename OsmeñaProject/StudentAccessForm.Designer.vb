<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAccessForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        CloseButton = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        LoginButton = New Button()
        VerificationLabal = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(175, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.DarkRed
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CloseButton.ForeColor = Color.WhiteSmoke
        CloseButton.Location = New Point(380, 3)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(31, 28)
        CloseButton.TabIndex = 1
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(98, 448)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(237, 28)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(98, 516)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "•"c
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(237, 28)
        TextBox2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(76, 350)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 40)
        Label1.TabIndex = 4
        Label1.Text = "Student Access"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.Font = New Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.ForeColor = SystemColors.ButtonHighlight
        CheckBox1.Location = New Point(208, 552)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(131, 21)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.Maroon
        LoginButton.Cursor = Cursors.Hand
        LoginButton.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LoginButton.ForeColor = Color.FloralWhite
        LoginButton.Location = New Point(76, 622)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(259, 48)
        LoginButton.TabIndex = 6
        LoginButton.Text = "LOGIN"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' VerificationLabal
        ' 
        VerificationLabal.AutoSize = True
        VerificationLabal.BackColor = Color.Transparent
        VerificationLabal.Cursor = Cursors.Hand
        VerificationLabal.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        VerificationLabal.ForeColor = Color.FloralWhite
        VerificationLabal.Location = New Point(104, 675)
        VerificationLabal.Name = "VerificationLabal"
        VerificationLabal.Size = New Size(206, 19)
        VerificationLabal.TabIndex = 7
        VerificationLabal.Text = "Don't have an account?"
        ' 
        ' StudentAccessForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._20240426_195331_0000
        ClientSize = New Size(415, 778)
        Controls.Add(VerificationLabal)
        Controls.Add(LoginButton)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(CloseButton)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentAccessForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentAccessForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents VerificationLabal As Label
End Class
