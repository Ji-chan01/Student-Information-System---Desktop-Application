<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EnrollmentForm))
        LogoPicture = New PictureBox()
        CloseButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label3 = New Label()
        SchoolYearTxtbox = New TextBox()
        StudentIDNumTxtbox = New TextBox()
        DepartmentCombo = New ComboBox()
        CourseCombo = New ComboBox()
        YearLevelCombo = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        LastNameTxtbox = New TextBox()
        FirstNameTxtbox = New TextBox()
        MiddleNameTxtbox = New TextBox()
        ExtTxtbox = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox1 = New GroupBox()
        ConfirmationChkbox = New CheckBox()
        PrintButton = New Button()
        Label21 = New Label()
        PermanentAddressTxtbox = New TextBox()
        MothersPhoneNoTxtbox = New TextBox()
        MothersFbAccountTxtbox = New TextBox()
        MothersNameTxtbox = New TextBox()
        FathersPhoneNo = New TextBox()
        FathersFbAccountTxtbox = New TextBox()
        FathersNameTxtbox = New TextBox()
        Label20 = New Label()
        Label19 = New Label()
        FBAccountTxtbox = New TextBox()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        MCAddress = New TextBox()
        EmailTxtbox = New TextBox()
        PhoneNoTxtBox = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        GenderTxtbox = New TextBox()
        BirthplaceTxtbox = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(LogoPicture, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogoPicture
        ' 
        LogoPicture.BackColor = Color.Transparent
        LogoPicture.Location = New Point(22, 29)
        LogoPicture.Name = "LogoPicture"
        LogoPicture.Size = New Size(122, 122)
        LogoPicture.TabIndex = 0
        LogoPicture.TabStop = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = SystemColors.ActiveCaptionText
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CloseButton.ForeColor = Color.WhiteSmoke
        CloseButton.Location = New Point(582, 53)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(121, 40)
        CloseButton.TabIndex = 1
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(159, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 24)
        Label1.TabIndex = 2
        Label1.Text = "PRE - ENROLLMENT FORM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(195, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 32)
        Label2.TabIndex = 3
        Label2.Text = "CONTINUING:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Cursor = Cursors.Hand
        RadioButton1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(153, 91)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(89, 23)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "1st Sem"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Cursor = Cursors.Hand
        RadioButton2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(248, 91)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(95, 23)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "2nd Sem"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Cursor = Cursors.Hand
        RadioButton3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(348, 91)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(91, 23)
        RadioButton3.TabIndex = 6
        RadioButton3.TabStop = True
        RadioButton3.Text = "Summer"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(170, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 19)
        Label3.TabIndex = 7
        Label3.Text = "School Year:"
        ' 
        ' SchoolYearTxtbox
        ' 
        SchoolYearTxtbox.Enabled = False
        SchoolYearTxtbox.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        SchoolYearTxtbox.Location = New Point(271, 122)
        SchoolYearTxtbox.Name = "SchoolYearTxtbox"
        SchoolYearTxtbox.PlaceholderText = "School Year"
        SchoolYearTxtbox.Size = New Size(113, 30)
        SchoolYearTxtbox.TabIndex = 8
        ' 
        ' StudentIDNumTxtbox
        ' 
        StudentIDNumTxtbox.Enabled = False
        StudentIDNumTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        StudentIDNumTxtbox.Location = New Point(30, 182)
        StudentIDNumTxtbox.Name = "StudentIDNumTxtbox"
        StudentIDNumTxtbox.PlaceholderText = "ID Number"
        StudentIDNumTxtbox.Size = New Size(178, 28)
        StudentIDNumTxtbox.TabIndex = 9
        ' 
        ' DepartmentCombo
        ' 
        DepartmentCombo.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DepartmentCombo.FormattingEnabled = True
        DepartmentCombo.Items.AddRange(New Object() {"CABA", "CSIT", "CTE", "CCJE", "CHRM/HM"})
        DepartmentCombo.Location = New Point(237, 181)
        DepartmentCombo.Name = "DepartmentCombo"
        DepartmentCombo.Size = New Size(151, 29)
        DepartmentCombo.TabIndex = 10
        DepartmentCombo.Text = "Please Select"
        ' 
        ' CourseCombo
        ' 
        CourseCombo.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CourseCombo.FormattingEnabled = True
        CourseCombo.Location = New Point(422, 182)
        CourseCombo.Name = "CourseCombo"
        CourseCombo.Size = New Size(151, 29)
        CourseCombo.TabIndex = 11
        CourseCombo.Text = "Please Select"
        ' 
        ' YearLevelCombo
        ' 
        YearLevelCombo.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        YearLevelCombo.FormattingEnabled = True
        YearLevelCombo.Items.AddRange(New Object() {"1", "2", "3", "4"})
        YearLevelCombo.Location = New Point(607, 182)
        YearLevelCombo.Name = "YearLevelCombo"
        YearLevelCombo.Size = New Size(96, 29)
        YearLevelCombo.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(28, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 16)
        Label4.TabIndex = 13
        Label4.Text = "Student ID Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(235, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 16)
        Label5.TabIndex = 14
        Label5.Text = "Department"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(419, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 16)
        Label6.TabIndex = 15
        Label6.Text = "Course"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(607, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 16)
        Label7.TabIndex = 16
        Label7.Text = "Year Level"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Maroon
        Label8.Location = New Point(26, 271)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 27)
        Label8.TabIndex = 17
        Label8.Text = "Student Name"
        ' 
        ' LastNameTxtbox
        ' 
        LastNameTxtbox.Enabled = False
        LastNameTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LastNameTxtbox.Location = New Point(30, 315)
        LastNameTxtbox.Name = "LastNameTxtbox"
        LastNameTxtbox.PlaceholderText = "Last Name"
        LastNameTxtbox.Size = New Size(178, 28)
        LastNameTxtbox.TabIndex = 18
        ' 
        ' FirstNameTxtbox
        ' 
        FirstNameTxtbox.Enabled = False
        FirstNameTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FirstNameTxtbox.Location = New Point(230, 315)
        FirstNameTxtbox.Name = "FirstNameTxtbox"
        FirstNameTxtbox.PlaceholderText = "First Name"
        FirstNameTxtbox.Size = New Size(178, 28)
        FirstNameTxtbox.TabIndex = 19
        ' 
        ' MiddleNameTxtbox
        ' 
        MiddleNameTxtbox.Enabled = False
        MiddleNameTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MiddleNameTxtbox.Location = New Point(435, 315)
        MiddleNameTxtbox.Name = "MiddleNameTxtbox"
        MiddleNameTxtbox.PlaceholderText = "Middle Name"
        MiddleNameTxtbox.Size = New Size(178, 28)
        MiddleNameTxtbox.TabIndex = 20
        ' 
        ' ExtTxtbox
        ' 
        ExtTxtbox.Enabled = False
        ExtTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        ExtTxtbox.Location = New Point(641, 315)
        ExtTxtbox.Name = "ExtTxtbox"
        ExtTxtbox.PlaceholderText = "Ext."
        ExtTxtbox.Size = New Size(62, 28)
        ExtTxtbox.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(28, 347)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 16)
        Label9.TabIndex = 22
        Label9.Text = "Last Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label10.Location = New Point(228, 347)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 16)
        Label10.TabIndex = 23
        Label10.Text = "First Name"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label11.Location = New Point(433, 347)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 16)
        Label11.TabIndex = 24
        Label11.Text = "Middle Name"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label12.Location = New Point(639, 347)
        Label12.Name = "Label12"
        Label12.Size = New Size(31, 16)
        Label12.TabIndex = 25
        Label12.Text = "Ext."
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Maroon
        GroupBox1.Controls.Add(ConfirmationChkbox)
        GroupBox1.Controls.Add(PrintButton)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Controls.Add(PermanentAddressTxtbox)
        GroupBox1.Controls.Add(MothersPhoneNoTxtbox)
        GroupBox1.Controls.Add(MothersFbAccountTxtbox)
        GroupBox1.Controls.Add(MothersNameTxtbox)
        GroupBox1.Controls.Add(FathersPhoneNo)
        GroupBox1.Controls.Add(FathersFbAccountTxtbox)
        GroupBox1.Controls.Add(FathersNameTxtbox)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(FBAccountTxtbox)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(MCAddress)
        GroupBox1.Controls.Add(EmailTxtbox)
        GroupBox1.Controls.Add(PhoneNoTxtBox)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(GenderTxtbox)
        GroupBox1.Controls.Add(BirthplaceTxtbox)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.WhiteSmoke
        GroupBox1.Location = New Point(31, 398)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(675, 584)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Profile"
        ' 
        ' ConfirmationChkbox
        ' 
        ConfirmationChkbox.Cursor = Cursors.Hand
        ConfirmationChkbox.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        ConfirmationChkbox.Location = New Point(429, 502)
        ConfirmationChkbox.Name = "ConfirmationChkbox"
        ConfirmationChkbox.Size = New Size(231, 74)
        ConfirmationChkbox.TabIndex = 49
        ConfirmationChkbox.Text = "I hereby declare that the information above is true to the best of my knowledge"
        ConfirmationChkbox.UseVisualStyleBackColor = True
        ' 
        ' PrintButton
        ' 
        PrintButton.BackColor = Color.Maroon
        PrintButton.Cursor = Cursors.Hand
        PrintButton.Enabled = False
        PrintButton.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        PrintButton.ForeColor = Color.WhiteSmoke
        PrintButton.Location = New Point(255, 519)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(153, 40)
        PrintButton.TabIndex = 48
        PrintButton.Text = "Print"
        PrintButton.UseVisualStyleBackColor = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label21.Location = New Point(10, 486)
        Label21.Name = "Label21"
        Label21.Size = New Size(136, 16)
        Label21.TabIndex = 47
        Label21.Text = "Permanent Address"
        ' 
        ' PermanentAddressTxtbox
        ' 
        PermanentAddressTxtbox.Enabled = False
        PermanentAddressTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        PermanentAddressTxtbox.Location = New Point(12, 455)
        PermanentAddressTxtbox.Name = "PermanentAddressTxtbox"
        PermanentAddressTxtbox.PlaceholderText = "Permanent Address"
        PermanentAddressTxtbox.Size = New Size(648, 28)
        PermanentAddressTxtbox.TabIndex = 46
        ' 
        ' MothersPhoneNoTxtbox
        ' 
        MothersPhoneNoTxtbox.Enabled = False
        MothersPhoneNoTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MothersPhoneNoTxtbox.Location = New Point(347, 389)
        MothersPhoneNoTxtbox.Name = "MothersPhoneNoTxtbox"
        MothersPhoneNoTxtbox.PlaceholderText = "Mother's Contact Number"
        MothersPhoneNoTxtbox.Size = New Size(313, 28)
        MothersPhoneNoTxtbox.TabIndex = 45
        ' 
        ' MothersFbAccountTxtbox
        ' 
        MothersFbAccountTxtbox.Enabled = False
        MothersFbAccountTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MothersFbAccountTxtbox.Location = New Point(347, 347)
        MothersFbAccountTxtbox.Name = "MothersFbAccountTxtbox"
        MothersFbAccountTxtbox.PlaceholderText = "Mother's FB Account"
        MothersFbAccountTxtbox.Size = New Size(313, 28)
        MothersFbAccountTxtbox.TabIndex = 44
        ' 
        ' MothersNameTxtbox
        ' 
        MothersNameTxtbox.Enabled = False
        MothersNameTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MothersNameTxtbox.Location = New Point(347, 303)
        MothersNameTxtbox.Name = "MothersNameTxtbox"
        MothersNameTxtbox.PlaceholderText = "Mother's Maiden Name"
        MothersNameTxtbox.Size = New Size(313, 28)
        MothersNameTxtbox.TabIndex = 43
        ' 
        ' FathersPhoneNo
        ' 
        FathersPhoneNo.Enabled = False
        FathersPhoneNo.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FathersPhoneNo.Location = New Point(14, 389)
        FathersPhoneNo.Name = "FathersPhoneNo"
        FathersPhoneNo.PlaceholderText = "Father's Contact Number"
        FathersPhoneNo.Size = New Size(313, 28)
        FathersPhoneNo.TabIndex = 42
        ' 
        ' FathersFbAccountTxtbox
        ' 
        FathersFbAccountTxtbox.Enabled = False
        FathersFbAccountTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FathersFbAccountTxtbox.Location = New Point(14, 347)
        FathersFbAccountTxtbox.Name = "FathersFbAccountTxtbox"
        FathersFbAccountTxtbox.PlaceholderText = "Father's FB Account"
        FathersFbAccountTxtbox.Size = New Size(313, 28)
        FathersFbAccountTxtbox.TabIndex = 41
        ' 
        ' FathersNameTxtbox
        ' 
        FathersNameTxtbox.Enabled = False
        FathersNameTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FathersNameTxtbox.Location = New Point(14, 303)
        FathersNameTxtbox.Name = "FathersNameTxtbox"
        FathersNameTxtbox.PlaceholderText = "Father's Name"
        FathersNameTxtbox.Size = New Size(313, 28)
        FathersNameTxtbox.TabIndex = 40
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(7, 253)
        Label20.Name = "Label20"
        Label20.Size = New Size(332, 27)
        Label20.TabIndex = 39
        Label20.Text = "Parent/Guardian Information"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label19.Location = New Point(13, 204)
        Label19.Name = "Label19"
        Label19.Size = New Size(125, 16)
        Label19.TabIndex = 38
        Label19.Text = "Facebook Account"
        ' 
        ' FBAccountTxtbox
        ' 
        FBAccountTxtbox.Enabled = False
        FBAccountTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FBAccountTxtbox.Location = New Point(14, 173)
        FBAccountTxtbox.Name = "FBAccountTxtbox"
        FBAccountTxtbox.PlaceholderText = "Facebook account"
        FBAccountTxtbox.Size = New Size(230, 28)
        FBAccountTxtbox.TabIndex = 37
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label18.Location = New Point(463, 138)
        Label18.Name = "Label18"
        Label18.Size = New Size(150, 16)
        Label18.TabIndex = 36
        Label18.Text = "Masbate City Address"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label17.Location = New Point(215, 138)
        Label17.Name = "Label17"
        Label17.Size = New Size(96, 16)
        Label17.TabIndex = 35
        Label17.Text = "Gmail address"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label16.Location = New Point(12, 138)
        Label16.Name = "Label16"
        Label16.Size = New Size(100, 16)
        Label16.TabIndex = 34
        Label16.Text = "Phone Number"
        ' 
        ' MCAddress
        ' 
        MCAddress.Enabled = False
        MCAddress.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MCAddress.Location = New Point(464, 107)
        MCAddress.Name = "MCAddress"
        MCAddress.PlaceholderText = "City Address"
        MCAddress.Size = New Size(196, 28)
        MCAddress.TabIndex = 33
        ' 
        ' EmailTxtbox
        ' 
        EmailTxtbox.Enabled = False
        EmailTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        EmailTxtbox.Location = New Point(217, 107)
        EmailTxtbox.Name = "EmailTxtbox"
        EmailTxtbox.PlaceholderText = "example@example.com"
        EmailTxtbox.Size = New Size(226, 28)
        EmailTxtbox.TabIndex = 32
        ' 
        ' PhoneNoTxtBox
        ' 
        PhoneNoTxtBox.Enabled = False
        PhoneNoTxtBox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNoTxtBox.Location = New Point(13, 107)
        PhoneNoTxtBox.Name = "PhoneNoTxtBox"
        PhoneNoTxtBox.PlaceholderText = "Phone Number"
        PhoneNoTxtBox.Size = New Size(182, 28)
        PhoneNoTxtBox.TabIndex = 31
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label15.Location = New Point(525, 74)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 16)
        Label15.TabIndex = 30
        Label15.Text = "Gender"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label14.Location = New Point(345, 73)
        Label14.Name = "Label14"
        Label14.Size = New Size(76, 16)
        Label14.TabIndex = 29
        Label14.Text = "Birth Place"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label13.Location = New Point(13, 73)
        Label13.Name = "Label13"
        Label13.Size = New Size(73, 16)
        Label13.TabIndex = 27
        Label13.Text = "Birth Date"
        ' 
        ' GenderTxtbox
        ' 
        GenderTxtbox.Enabled = False
        GenderTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        GenderTxtbox.Location = New Point(527, 43)
        GenderTxtbox.Name = "GenderTxtbox"
        GenderTxtbox.PlaceholderText = "Gender"
        GenderTxtbox.Size = New Size(133, 28)
        GenderTxtbox.TabIndex = 28
        ' 
        ' BirthplaceTxtbox
        ' 
        BirthplaceTxtbox.Enabled = False
        BirthplaceTxtbox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BirthplaceTxtbox.Location = New Point(347, 42)
        BirthplaceTxtbox.Name = "BirthplaceTxtbox"
        BirthplaceTxtbox.PlaceholderText = "Birthplace"
        BirthplaceTxtbox.Size = New Size(161, 28)
        BirthplaceTxtbox.TabIndex = 27
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Enabled = False
        DateTimePicker1.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(14, 42)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(313, 28)
        DateTimePicker1.TabIndex = 0
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' EnrollmentForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 1007)
        Controls.Add(GroupBox1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(ExtTxtbox)
        Controls.Add(MiddleNameTxtbox)
        Controls.Add(FirstNameTxtbox)
        Controls.Add(LastNameTxtbox)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(YearLevelCombo)
        Controls.Add(CourseCombo)
        Controls.Add(DepartmentCombo)
        Controls.Add(StudentIDNumTxtbox)
        Controls.Add(SchoolYearTxtbox)
        Controls.Add(Label3)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CloseButton)
        Controls.Add(LogoPicture)
        FormBorderStyle = FormBorderStyle.None
        Name = "EnrollmentForm"
        Text = " "
        CType(LogoPicture, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LogoPicture As PictureBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents SchoolYearTxtbox As TextBox
    Friend WithEvents StudentIDNumTxtbox As TextBox
    Friend WithEvents DepartmentCombo As ComboBox
    Friend WithEvents CourseCombo As ComboBox
    Friend WithEvents YearLevelCombo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LastNameTxtbox As TextBox
    Friend WithEvents FirstNameTxtbox As TextBox
    Friend WithEvents MiddleNameTxtbox As TextBox
    Friend WithEvents ExtTxtbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BirthplaceTxtbox As TextBox
    Friend WithEvents GenderTxtbox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PhoneNoTxtBox As TextBox
    Friend WithEvents EmailTxtbox As TextBox
    Friend WithEvents MCAddress As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents FBAccountTxtbox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents FathersNameTxtbox As TextBox
    Friend WithEvents FathersPhoneNo As TextBox
    Friend WithEvents FathersFbAccountTxtbox As TextBox
    Friend WithEvents MothersPhoneNoTxtbox As TextBox
    Friend WithEvents MothersFbAccountTxtbox As TextBox
    Friend WithEvents MothersNameTxtbox As TextBox
    Friend WithEvents PermanentAddressTxtbox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PrintButton As Button
    Friend WithEvents ConfirmationChkbox As CheckBox
End Class
