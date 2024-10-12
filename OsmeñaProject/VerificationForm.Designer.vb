<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificationForm
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
        TitleBarPanel = New Panel()
        TitleBar = New Label()
        CloseButton = New Button()
        GroupBox1 = New GroupBox()
        BackButton = New Label()
        SchoolContactNumber = New Label()
        SchoolEmail = New Label()
        SchoolAddress = New Label()
        SchoolName = New Label()
        SchoolLogoPicturebox = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        LastNameTextbox = New TextBox()
        FirstNameTextbox = New TextBox()
        MiddleNameTextbox = New TextBox()
        ExtTextbox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GenderCombobox = New ComboBox()
        Label9 = New Label()
        DepartmentCombobox = New ComboBox()
        Label10 = New Label()
        CourseCombobox = New ComboBox()
        Label11 = New Label()
        YearLevelCombobox = New ComboBox()
        Label12 = New Label()
        StudentIDTextbox = New TextBox()
        Label13 = New Label()
        BirthdayDateTimePicker = New DateTimePicker()
        NextButton = New Button()
        IsNewStudent = New Label()
        TitleBarPanel.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(SchoolLogoPicturebox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TitleBarPanel
        ' 
        TitleBarPanel.BackColor = SystemColors.GradientInactiveCaption
        TitleBarPanel.Controls.Add(TitleBar)
        TitleBarPanel.Controls.Add(CloseButton)
        TitleBarPanel.Dock = DockStyle.Top
        TitleBarPanel.Location = New Point(0, 0)
        TitleBarPanel.Name = "TitleBarPanel"
        TitleBarPanel.Padding = New Padding(10, 5, 5, 5)
        TitleBarPanel.Size = New Size(704, 38)
        TitleBarPanel.TabIndex = 1
        ' 
        ' TitleBar
        ' 
        TitleBar.AutoSize = True
        TitleBar.Dock = DockStyle.Left
        TitleBar.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TitleBar.Location = New Point(10, 5)
        TitleBar.Name = "TitleBar"
        TitleBar.Size = New Size(155, 25)
        TitleBar.TabIndex = 1
        TitleBar.Text = "Verification Form"
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.DarkRed
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Dock = DockStyle.Right
        CloseButton.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CloseButton.ForeColor = Color.WhiteSmoke
        CloseButton.Location = New Point(668, 5)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(31, 28)
        CloseButton.TabIndex = 0
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Maroon
        GroupBox1.Controls.Add(BackButton)
        GroupBox1.Controls.Add(SchoolContactNumber)
        GroupBox1.Controls.Add(SchoolEmail)
        GroupBox1.Controls.Add(SchoolAddress)
        GroupBox1.Controls.Add(SchoolName)
        GroupBox1.Controls.Add(SchoolLogoPicturebox)
        GroupBox1.Location = New Point(-5, 39)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(710, 151)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' BackButton
        ' 
        BackButton.AutoSize = True
        BackButton.BackColor = Color.WhiteSmoke
        BackButton.Cursor = Cursors.Hand
        BackButton.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.ForeColor = Color.Maroon
        BackButton.Location = New Point(576, 61)
        BackButton.Name = "BackButton"
        BackButton.Padding = New Padding(25, 10, 25, 10)
        BackButton.Size = New Size(108, 43)
        BackButton.TabIndex = 5
        BackButton.Text = "Back"
        ' 
        ' SchoolContactNumber
        ' 
        SchoolContactNumber.BackColor = Color.Transparent
        SchoolContactNumber.Font = New Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        SchoolContactNumber.ForeColor = Color.WhiteSmoke
        SchoolContactNumber.Location = New Point(149, 103)
        SchoolContactNumber.Name = "SchoolContactNumber"
        SchoolContactNumber.Size = New Size(331, 23)
        SchoolContactNumber.TabIndex = 4
        ' 
        ' SchoolEmail
        ' 
        SchoolEmail.BackColor = Color.Transparent
        SchoolEmail.Font = New Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        SchoolEmail.ForeColor = Color.WhiteSmoke
        SchoolEmail.Location = New Point(149, 83)
        SchoolEmail.Name = "SchoolEmail"
        SchoolEmail.Size = New Size(331, 23)
        SchoolEmail.TabIndex = 3
        ' 
        ' SchoolAddress
        ' 
        SchoolAddress.BackColor = Color.Transparent
        SchoolAddress.Font = New Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        SchoolAddress.ForeColor = Color.WhiteSmoke
        SchoolAddress.Location = New Point(149, 66)
        SchoolAddress.Name = "SchoolAddress"
        SchoolAddress.Size = New Size(331, 23)
        SchoolAddress.TabIndex = 2
        ' 
        ' SchoolName
        ' 
        SchoolName.BackColor = Color.Transparent
        SchoolName.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SchoolName.ForeColor = Color.WhiteSmoke
        SchoolName.Location = New Point(146, 42)
        SchoolName.Name = "SchoolName"
        SchoolName.Size = New Size(334, 29)
        SchoolName.TabIndex = 1
        ' 
        ' SchoolLogoPicturebox
        ' 
        SchoolLogoPicturebox.BackColor = Color.Transparent
        SchoolLogoPicturebox.Location = New Point(33, 29)
        SchoolLogoPicturebox.Name = "SchoolLogoPicturebox"
        SchoolLogoPicturebox.Size = New Size(107, 100)
        SchoolLogoPicturebox.SizeMode = PictureBoxSizeMode.StretchImage
        SchoolLogoPicturebox.TabIndex = 0
        SchoolLogoPicturebox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowFrame
        Label1.Location = New Point(274, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(410, 34)
        Label1.TabIndex = 3
        Label1.Text = "STUDENT VERIFICATION FORM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(20, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 20)
        Label3.TabIndex = 4
        Label3.Text = "Student Name"
        ' 
        ' LastNameTextbox
        ' 
        LastNameTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LastNameTextbox.Location = New Point(24, 320)
        LastNameTextbox.Name = "LastNameTextbox"
        LastNameTextbox.PlaceholderText = "Last Name"
        LastNameTextbox.Size = New Size(178, 28)
        LastNameTextbox.TabIndex = 5
        ' 
        ' FirstNameTextbox
        ' 
        FirstNameTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FirstNameTextbox.Location = New Point(225, 320)
        FirstNameTextbox.Name = "FirstNameTextbox"
        FirstNameTextbox.PlaceholderText = "First Name"
        FirstNameTextbox.Size = New Size(178, 28)
        FirstNameTextbox.TabIndex = 6
        ' 
        ' MiddleNameTextbox
        ' 
        MiddleNameTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MiddleNameTextbox.Location = New Point(427, 320)
        MiddleNameTextbox.Name = "MiddleNameTextbox"
        MiddleNameTextbox.PlaceholderText = "Middle Name"
        MiddleNameTextbox.Size = New Size(178, 28)
        MiddleNameTextbox.TabIndex = 7
        ' 
        ' ExtTextbox
        ' 
        ExtTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        ExtTextbox.Location = New Point(629, 320)
        ExtTextbox.Name = "ExtTextbox"
        ExtTextbox.PlaceholderText = "Ext"
        ExtTextbox.Size = New Size(50, 28)
        ExtTextbox.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(22, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 18)
        Label4.TabIndex = 9
        Label4.Text = "Last Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(224, 351)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 18)
        Label5.TabIndex = 10
        Label5.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(425, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 18)
        Label6.TabIndex = 11
        Label6.Text = "Middle Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(628, 351)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 18)
        Label7.TabIndex = 12
        Label7.Text = "Ext."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(20, 403)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 20)
        Label8.TabIndex = 13
        Label8.Text = "Gender"
        ' 
        ' GenderCombobox
        ' 
        GenderCombobox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        GenderCombobox.ForeColor = SystemColors.WindowFrame
        GenderCombobox.FormattingEnabled = True
        GenderCombobox.Items.AddRange(New Object() {"Male", "Female"})
        GenderCombobox.Location = New Point(24, 426)
        GenderCombobox.Name = "GenderCombobox"
        GenderCombobox.Size = New Size(151, 29)
        GenderCombobox.TabIndex = 14
        GenderCombobox.Text = "Please Select"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(220, 403)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 20)
        Label9.TabIndex = 15
        Label9.Text = "Department"
        ' 
        ' DepartmentCombobox
        ' 
        DepartmentCombobox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DepartmentCombobox.ForeColor = SystemColors.WindowFrame
        DepartmentCombobox.FormattingEnabled = True
        DepartmentCombobox.Items.AddRange(New Object() {"CABA", "CSIT", "CTE", "CCJE", "CHRM/HM", "Senior High School", "Junior High School", "Elementary"})
        DepartmentCombobox.Location = New Point(225, 426)
        DepartmentCombobox.Name = "DepartmentCombobox"
        DepartmentCombobox.Size = New Size(151, 29)
        DepartmentCombobox.TabIndex = 16
        DepartmentCombobox.Text = "Please Select"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(406, 403)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 20)
        Label10.TabIndex = 17
        Label10.Text = "Course"
        ' 
        ' CourseCombobox
        ' 
        CourseCombobox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CourseCombobox.ForeColor = SystemColors.WindowFrame
        CourseCombobox.FormattingEnabled = True
        CourseCombobox.Location = New Point(411, 426)
        CourseCombobox.Name = "CourseCombobox"
        CourseCombobox.Size = New Size(144, 29)
        CourseCombobox.TabIndex = 18
        CourseCombobox.Text = "Please Select"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(589, 403)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 20)
        Label11.TabIndex = 19
        Label11.Text = "Year Level"
        ' 
        ' YearLevelCombobox
        ' 
        YearLevelCombobox.DropDownStyle = ComboBoxStyle.DropDownList
        YearLevelCombobox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        YearLevelCombobox.ForeColor = SystemColors.WindowFrame
        YearLevelCombobox.FormattingEnabled = True
        YearLevelCombobox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        YearLevelCombobox.Location = New Point(593, 426)
        YearLevelCombobox.Name = "YearLevelCombobox"
        YearLevelCombobox.Size = New Size(86, 29)
        YearLevelCombobox.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(20, 495)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 20)
        Label12.TabIndex = 21
        Label12.Text = "Student ID"
        ' 
        ' StudentIDTextbox
        ' 
        StudentIDTextbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        StudentIDTextbox.Location = New Point(24, 518)
        StudentIDTextbox.Name = "StudentIDTextbox"
        StudentIDTextbox.PlaceholderText = "xxxxx-xxx-xxxx"
        StudentIDTextbox.Size = New Size(235, 28)
        StudentIDTextbox.TabIndex = 22
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(383, 495)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 20)
        Label13.TabIndex = 23
        Label13.Text = "Birthday"
        ' 
        ' BirthdayDateTimePicker
        ' 
        BirthdayDateTimePicker.Location = New Point(387, 517)
        BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        BirthdayDateTimePicker.Size = New Size(292, 30)
        BirthdayDateTimePicker.TabIndex = 24
        ' 
        ' NextButton
        ' 
        NextButton.BackColor = Color.Maroon
        NextButton.Cursor = Cursors.Hand
        NextButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NextButton.ForeColor = Color.WhiteSmoke
        NextButton.Location = New Point(24, 608)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(655, 48)
        NextButton.TabIndex = 25
        NextButton.Text = "NEXT"
        NextButton.UseVisualStyleBackColor = False
        ' 
        ' IsNewStudent
        ' 
        IsNewStudent.AutoSize = True
        IsNewStudent.Cursor = Cursors.Hand
        IsNewStudent.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        IsNewStudent.ForeColor = Color.Maroon
        IsNewStudent.Location = New Point(20, 585)
        IsNewStudent.Name = "IsNewStudent"
        IsNewStudent.Size = New Size(292, 20)
        IsNewStudent.TabIndex = 26
        IsNewStudent.Text = "Click here if you are a new Student"
        ' 
        ' VerificationForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(704, 683)
        Controls.Add(IsNewStudent)
        Controls.Add(NextButton)
        Controls.Add(BirthdayDateTimePicker)
        Controls.Add(Label13)
        Controls.Add(StudentIDTextbox)
        Controls.Add(Label12)
        Controls.Add(YearLevelCombobox)
        Controls.Add(Label11)
        Controls.Add(CourseCombobox)
        Controls.Add(Label10)
        Controls.Add(DepartmentCombobox)
        Controls.Add(Label9)
        Controls.Add(GenderCombobox)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ExtTextbox)
        Controls.Add(MiddleNameTextbox)
        Controls.Add(FirstNameTextbox)
        Controls.Add(LastNameTextbox)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(TitleBarPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerificationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VerificationForm"
        TitleBarPanel.ResumeLayout(False)
        TitleBarPanel.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(SchoolLogoPicturebox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents TitleBar As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolName As Label
    Friend WithEvents SchoolAddress As Label
    Friend WithEvents SchoolEmail As Label
    Friend WithEvents SchoolLogoPicturebox As PictureBox
    Friend WithEvents SchoolContactNumber As Label
    Friend WithEvents BackButton As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LastNameTextbox As TextBox
    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents MiddleNameTextbox As TextBox
    Friend WithEvents ExtTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GenderCombobox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DepartmentCombobox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CourseCombobox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents YearLevelCombobox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents StudentIDTextbox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents NextButton As Button
    Friend WithEvents IsNewStudent As Label
End Class
