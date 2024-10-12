<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Panel1 = New Panel()
        Label1 = New Label()
        SchoolLogoPicturebox = New PictureBox()
        UserNewProfilePicturebox = New PictureBox()
        BrowseImageButton = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        UsernameTextbox = New TextBox()
        PasswordTextbox = New TextBox()
        ConfirmPasswordTextbox = New TextBox()
        CloseButton = New Button()
        CreateAccountButton = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1.SuspendLayout()
        CType(SchoolLogoPicturebox, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserNewProfilePicturebox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.BackgroundImage = My.Resources.Resources._20240427_182215_0000
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(SchoolLogoPicturebox)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(493, 145)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(131, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 27)
        Label1.TabIndex = 1
        Label1.Text = "CREATE YOUR ACCOUNT"
        ' 
        ' SchoolLogoPicturebox
        ' 
        SchoolLogoPicturebox.BackColor = Color.Transparent
        SchoolLogoPicturebox.Location = New Point(38, 36)
        SchoolLogoPicturebox.Name = "SchoolLogoPicturebox"
        SchoolLogoPicturebox.Size = New Size(80, 75)
        SchoolLogoPicturebox.SizeMode = PictureBoxSizeMode.StretchImage
        SchoolLogoPicturebox.TabIndex = 0
        SchoolLogoPicturebox.TabStop = False
        ' 
        ' UserNewProfilePicturebox
        ' 
        UserNewProfilePicturebox.BackColor = Color.Transparent
        UserNewProfilePicturebox.Image = My.Resources.Resources.facebook_default_no_profile_pic
        UserNewProfilePicturebox.Location = New Point(34, 187)
        UserNewProfilePicturebox.Name = "UserNewProfilePicturebox"
        UserNewProfilePicturebox.Size = New Size(139, 131)
        UserNewProfilePicturebox.SizeMode = PictureBoxSizeMode.StretchImage
        UserNewProfilePicturebox.TabIndex = 2
        UserNewProfilePicturebox.TabStop = False
        ' 
        ' BrowseImageButton
        ' 
        BrowseImageButton.BackColor = Color.WhiteSmoke
        BrowseImageButton.Cursor = Cursors.Hand
        BrowseImageButton.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BrowseImageButton.ForeColor = Color.Maroon
        BrowseImageButton.Location = New Point(34, 323)
        BrowseImageButton.Name = "BrowseImageButton"
        BrowseImageButton.Size = New Size(139, 40)
        BrowseImageButton.TabIndex = 3
        BrowseImageButton.Text = "Browse Image"
        BrowseImageButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(195, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 23)
        Label2.TabIndex = 4
        Label2.Text = "Create username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(195, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 23)
        Label3.TabIndex = 5
        Label3.Text = "Enter new password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(195, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(232, 23)
        Label4.TabIndex = 6
        Label4.Text = "Confirm new password"
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTextbox.Location = New Point(200, 196)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.PlaceholderText = "Username"
        UsernameTextbox.Size = New Size(263, 28)
        UsernameTextbox.TabIndex = 7
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTextbox.Location = New Point(200, 269)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.PasswordChar = "•"c
        PasswordTextbox.PlaceholderText = "Password"
        PasswordTextbox.Size = New Size(263, 28)
        PasswordTextbox.TabIndex = 8
        ' 
        ' ConfirmPasswordTextbox
        ' 
        ConfirmPasswordTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        ConfirmPasswordTextbox.Location = New Point(200, 344)
        ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox"
        ConfirmPasswordTextbox.PasswordChar = "•"c
        ConfirmPasswordTextbox.PlaceholderText = "Confirm new password"
        ConfirmPasswordTextbox.Size = New Size(263, 28)
        ConfirmPasswordTextbox.TabIndex = 9
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Maroon
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CloseButton.ForeColor = Color.WhiteSmoke
        CloseButton.Location = New Point(158, 457)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(191, 46)
        CloseButton.TabIndex = 11
        CloseButton.Text = "CLOSE"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' CreateAccountButton
        ' 
        CreateAccountButton.BackColor = Color.Maroon
        CreateAccountButton.Cursor = Cursors.Hand
        CreateAccountButton.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CreateAccountButton.ForeColor = Color.WhiteSmoke
        CreateAccountButton.Location = New Point(158, 406)
        CreateAccountButton.Name = "CreateAccountButton"
        CreateAccountButton.Size = New Size(191, 46)
        CreateAccountButton.TabIndex = 12
        CreateAccountButton.Text = "CREATE ACCOUNT"
        CreateAccountButton.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Image files |*.jpg;*.jpeg;*.png;"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 536)
        Controls.Add(CreateAccountButton)
        Controls.Add(CloseButton)
        Controls.Add(ConfirmPasswordTextbox)
        Controls.Add(PasswordTextbox)
        Controls.Add(UsernameTextbox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BrowseImageButton)
        Controls.Add(UserNewProfilePicturebox)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistrationForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(SchoolLogoPicturebox, ComponentModel.ISupportInitialize).EndInit()
        CType(UserNewProfilePicturebox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SchoolLogoPicturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UserNewProfilePicturebox As PictureBox
    Friend WithEvents BrowseImageButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents ConfirmPasswordTextbox As TextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents CreateAccountButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
