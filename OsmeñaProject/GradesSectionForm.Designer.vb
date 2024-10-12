<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradesSectionForm
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GradesSectionForm))
        TitleBarPanel = New Panel()
        TitleBar = New Label()
        CloseButton = New Button()
        CaptionPanel = New Panel()
        CaptionLabel = New Label()
        Label13 = New Label()
        ProgressBar1 = New ProgressBar()
        Panel1 = New Panel()
        SectionTxtbox = New TextBox()
        Label5 = New Label()
        SubjectCodenameCombobox = New ComboBox()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        RefreshButton = New Button()
        Panel2 = New Panel()
        SubjectDescriptionLabel = New Label()
        SubjectCodenameLabel = New Label()
        ProfessorsID = New Label()
        ProfessorsName = New Label()
        ProfessorsGreetings = New Label()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label1 = New Label()
        TotalAverageLabel = New Label()
        StatusLabel = New Label()
        Timer1 = New Timer(components)
        MySectionPanel = New Panel()
        ProspectusPanel = New Panel()
        CheckBalancePanel = New Panel()
        MyClassmatesPanel = New Panel()
        Label23 = New Label()
        MyClassmateSectionLabel = New Label()
        Label22 = New Label()
        StudentDescription = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label21 = New Label()
        MyClassmatesSubjectCombobox = New ComboBox()
        DataGridView5 = New DataGridView()
        SchoolLogo = New PictureBox()
        Panel3 = New Panel()
        TotalBalance = New Label()
        TotalPayment = New Label()
        CheckBalanceRefreshButton = New Button()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        DataGridView4 = New DataGridView()
        ShowAllButton = New Button()
        Label7 = New Label()
        Label3 = New Label()
        ProspectusSemesterCombobox = New ComboBox()
        ProspectusYearLevelCombobox = New ComboBox()
        GroupBox1 = New GroupBox()
        gec = New Label()
        cc = New Label()
        pc = New Label()
        pe = New Label()
        am = New Label()
        pe_nstp = New Label()
        total_units = New Label()
        Label15 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        DataGridView3 = New DataGridView()
        PictureBox2 = New PictureBox()
        SubjectBackgroundLabel = New Label()
        CourseCodeLabel = New Label()
        DataGridView2 = New DataGridView()
        TitleBarPanel.SuspendLayout()
        CaptionPanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MySectionPanel.SuspendLayout()
        ProspectusPanel.SuspendLayout()
        CheckBalancePanel.SuspendLayout()
        MyClassmatesPanel.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView5, ComponentModel.ISupportInitialize).BeginInit()
        CType(SchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
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
        TitleBarPanel.Size = New Size(733, 38)
        TitleBarPanel.TabIndex = 1
        ' 
        ' TitleBar
        ' 
        TitleBar.AutoSize = True
        TitleBar.Dock = DockStyle.Left
        TitleBar.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TitleBar.Location = New Point(10, 5)
        TitleBar.Name = "TitleBar"
        TitleBar.Size = New Size(81, 25)
        TitleBar.TabIndex = 1
        TitleBar.Text = "Title bar"
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.DarkRed
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Dock = DockStyle.Right
        CloseButton.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CloseButton.ForeColor = Color.WhiteSmoke
        CloseButton.Location = New Point(697, 5)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(31, 28)
        CloseButton.TabIndex = 0
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' CaptionPanel
        ' 
        CaptionPanel.BackColor = Color.Maroon
        CaptionPanel.Controls.Add(CaptionLabel)
        CaptionPanel.Dock = DockStyle.Top
        CaptionPanel.Location = New Point(0, 38)
        CaptionPanel.Name = "CaptionPanel"
        CaptionPanel.Padding = New Padding(20, 19, 0, 0)
        CaptionPanel.Size = New Size(733, 92)
        CaptionPanel.TabIndex = 6
        ' 
        ' CaptionLabel
        ' 
        CaptionLabel.AutoSize = True
        CaptionLabel.Dock = DockStyle.Left
        CaptionLabel.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        CaptionLabel.ForeColor = Color.WhiteSmoke
        CaptionLabel.Location = New Point(20, 19)
        CaptionLabel.Name = "CaptionLabel"
        CaptionLabel.Size = New Size(145, 46)
        CaptionLabel.TabIndex = 0
        CaptionLabel.Text = "Caption"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Maroon
        Label13.Location = New Point(19, 255)
        Label13.Name = "Label13"
        Label13.Size = New Size(112, 40)
        Label13.TabIndex = 8
        Label13.Text = "Status"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(25, 302)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(212, 29)
        ProgressBar1.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(SectionTxtbox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(SubjectCodenameCombobox)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(RefreshButton)
        Panel1.Location = New Point(260, 135)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(469, 272)
        Panel1.TabIndex = 1
        ' 
        ' SectionTxtbox
        ' 
        SectionTxtbox.Enabled = False
        SectionTxtbox.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SectionTxtbox.Location = New Point(401, 130)
        SectionTxtbox.Name = "SectionTxtbox"
        SectionTxtbox.Size = New Size(55, 28)
        SectionTxtbox.TabIndex = 5
        SectionTxtbox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(326, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 21)
        Label5.TabIndex = 4
        Label5.Text = "Section:"
        ' 
        ' SubjectCodenameCombobox
        ' 
        SubjectCodenameCombobox.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        SubjectCodenameCombobox.ForeColor = SystemColors.WindowFrame
        SubjectCodenameCombobox.FormattingEnabled = True
        SubjectCodenameCombobox.Location = New Point(12, 129)
        SubjectCodenameCombobox.Name = "SubjectCodenameCombobox"
        SubjectCodenameCombobox.Size = New Size(151, 29)
        SubjectCodenameCombobox.TabIndex = 3
        SubjectCodenameCombobox.Text = "Please Select"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 32
        DataGridView1.Size = New Size(445, 88)
        DataGridView1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(15, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(436, 37)
        Label4.TabIndex = 1
        Label4.Text = "Your Grades Will Shows Here!"
        ' 
        ' RefreshButton
        ' 
        RefreshButton.BackColor = Color.Maroon
        RefreshButton.Cursor = Cursors.Hand
        RefreshButton.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RefreshButton.ForeColor = Color.WhiteSmoke
        RefreshButton.Location = New Point(363, 9)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(98, 32)
        RefreshButton.TabIndex = 0
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(SubjectDescriptionLabel)
        Panel2.Controls.Add(SubjectCodenameLabel)
        Panel2.Controls.Add(ProfessorsID)
        Panel2.Controls.Add(ProfessorsName)
        Panel2.Controls.Add(ProfessorsGreetings)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(260, 404)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(469, 242)
        Panel2.TabIndex = 2
        ' 
        ' SubjectDescriptionLabel
        ' 
        SubjectDescriptionLabel.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SubjectDescriptionLabel.ForeColor = Color.Black
        SubjectDescriptionLabel.Location = New Point(178, 198)
        SubjectDescriptionLabel.Name = "SubjectDescriptionLabel"
        SubjectDescriptionLabel.Size = New Size(274, 22)
        SubjectDescriptionLabel.TabIndex = 12
        ' 
        ' SubjectCodenameLabel
        ' 
        SubjectCodenameLabel.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        SubjectCodenameLabel.ForeColor = Color.Black
        SubjectCodenameLabel.Location = New Point(178, 176)
        SubjectCodenameLabel.Name = "SubjectCodenameLabel"
        SubjectCodenameLabel.Size = New Size(286, 22)
        SubjectCodenameLabel.TabIndex = 11
        SubjectCodenameLabel.Text = "I am currently your professor at"
        ' 
        ' ProfessorsID
        ' 
        ProfessorsID.Font = New Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point)
        ProfessorsID.ForeColor = Color.Black
        ProfessorsID.Location = New Point(178, 143)
        ProfessorsID.Name = "ProfessorsID"
        ProfessorsID.Size = New Size(274, 22)
        ProfessorsID.TabIndex = 10
        ProfessorsID.Text = "My Teacher's ID is"
        ' 
        ' ProfessorsName
        ' 
        ProfessorsName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ProfessorsName.ForeColor = Color.ForestGreen
        ProfessorsName.Location = New Point(177, 121)
        ProfessorsName.Name = "ProfessorsName"
        ProfessorsName.Size = New Size(274, 22)
        ProfessorsName.TabIndex = 9
        ProfessorsName.Text = "Hi! My name is"
        ' 
        ' ProfessorsGreetings
        ' 
        ProfessorsGreetings.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ProfessorsGreetings.ForeColor = Color.Maroon
        ProfessorsGreetings.Location = New Point(174, 75)
        ProfessorsGreetings.Name = "ProfessorsGreetings"
        ProfessorsGreetings.Size = New Size(274, 37)
        ProfessorsGreetings.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.Untitled
        PictureBox1.Location = New Point(13, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 147)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Maroon
        Label6.Location = New Point(12, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(260, 37)
        Label6.TabIndex = 6
        Label6.Text = "Professor's Profile"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(68, 341)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 10
        Label1.Text = "TOTAL AVERAGE"
        ' 
        ' TotalAverageLabel
        ' 
        TotalAverageLabel.BackColor = Color.Transparent
        TotalAverageLabel.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalAverageLabel.ForeColor = Color.DarkGray
        TotalAverageLabel.Location = New Point(25, 368)
        TotalAverageLabel.Name = "TotalAverageLabel"
        TotalAverageLabel.Size = New Size(212, 73)
        TotalAverageLabel.TabIndex = 11
        TotalAverageLabel.Text = "0"
        TotalAverageLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StatusLabel
        ' 
        StatusLabel.BackColor = Color.Transparent
        StatusLabel.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        StatusLabel.ForeColor = Color.DarkGray
        StatusLabel.Location = New Point(25, 441)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(212, 40)
        StatusLabel.TabIndex = 12
        StatusLabel.Text = "Status"
        StatusLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        ' 
        ' MySectionPanel
        ' 
        MySectionPanel.BackColor = Color.Black
        MySectionPanel.Controls.Add(ProspectusPanel)
        MySectionPanel.Controls.Add(PictureBox2)
        MySectionPanel.Controls.Add(SubjectBackgroundLabel)
        MySectionPanel.Controls.Add(CourseCodeLabel)
        MySectionPanel.Controls.Add(DataGridView2)
        MySectionPanel.Location = New Point(0, 130)
        MySectionPanel.Name = "MySectionPanel"
        MySectionPanel.Size = New Size(734, 521)
        MySectionPanel.TabIndex = 13
        ' 
        ' ProspectusPanel
        ' 
        ProspectusPanel.Controls.Add(CheckBalancePanel)
        ProspectusPanel.Controls.Add(ShowAllButton)
        ProspectusPanel.Controls.Add(Label7)
        ProspectusPanel.Controls.Add(Label3)
        ProspectusPanel.Controls.Add(ProspectusSemesterCombobox)
        ProspectusPanel.Controls.Add(ProspectusYearLevelCombobox)
        ProspectusPanel.Controls.Add(GroupBox1)
        ProspectusPanel.Controls.Add(Label2)
        ProspectusPanel.Controls.Add(DataGridView3)
        ProspectusPanel.Location = New Point(0, 0)
        ProspectusPanel.Name = "ProspectusPanel"
        ProspectusPanel.Size = New Size(734, 521)
        ProspectusPanel.TabIndex = 4
        ' 
        ' CheckBalancePanel
        ' 
        CheckBalancePanel.Controls.Add(MyClassmatesPanel)
        CheckBalancePanel.Controls.Add(SchoolLogo)
        CheckBalancePanel.Controls.Add(Panel3)
        CheckBalancePanel.Controls.Add(Label16)
        CheckBalancePanel.Controls.Add(DataGridView4)
        CheckBalancePanel.Location = New Point(1, 0)
        CheckBalancePanel.Name = "CheckBalancePanel"
        CheckBalancePanel.Size = New Size(733, 517)
        CheckBalancePanel.TabIndex = 8
        ' 
        ' MyClassmatesPanel
        ' 
        MyClassmatesPanel.BackColor = Color.Transparent
        MyClassmatesPanel.Controls.Add(Label23)
        MyClassmatesPanel.Controls.Add(MyClassmateSectionLabel)
        MyClassmatesPanel.Controls.Add(Label22)
        MyClassmatesPanel.Controls.Add(StudentDescription)
        MyClassmatesPanel.Controls.Add(PictureBox4)
        MyClassmatesPanel.Controls.Add(PictureBox3)
        MyClassmatesPanel.Controls.Add(Label21)
        MyClassmatesPanel.Controls.Add(MyClassmatesSubjectCombobox)
        MyClassmatesPanel.Controls.Add(DataGridView5)
        MyClassmatesPanel.Location = New Point(1, -2)
        MyClassmatesPanel.Name = "MyClassmatesPanel"
        MyClassmatesPanel.Size = New Size(730, 520)
        MyClassmatesPanel.TabIndex = 11
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.ForeColor = Color.SpringGreen
        Label23.Location = New Point(183, 300)
        Label23.Name = "Label23"
        Label23.Size = New Size(78, 42)
        Label23.TabIndex = 8
        Label23.Text = "BIO"
        ' 
        ' MyClassmateSectionLabel
        ' 
        MyClassmateSectionLabel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MyClassmateSectionLabel.ForeColor = Color.White
        MyClassmateSectionLabel.Location = New Point(652, 307)
        MyClassmateSectionLabel.Name = "MyClassmateSectionLabel"
        MyClassmateSectionLabel.Size = New Size(65, 23)
        MyClassmateSectionLabel.TabIndex = 7
        MyClassmateSectionLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.ForeColor = Color.White
        Label22.Location = New Point(567, 306)
        Label22.Name = "Label22"
        Label22.Size = New Size(88, 23)
        Label22.TabIndex = 6
        Label22.Text = "Section:"
        ' 
        ' StudentDescription
        ' 
        StudentDescription.BorderStyle = BorderStyle.Fixed3D
        StudentDescription.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        StudentDescription.ForeColor = Color.WhiteSmoke
        StudentDescription.Location = New Point(189, 350)
        StudentDescription.Name = "StudentDescription"
        StudentDescription.Size = New Size(528, 144)
        StudentDescription.TabIndex = 5
        StudentDescription.Text = "Student Description"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(11, 14)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(170, 169)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(19, 329)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(151, 149)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label21.ForeColor = Color.WhiteSmoke
        Label21.Location = New Point(16, 268)
        Label21.Name = "Label21"
        Label21.Size = New Size(75, 21)
        Label21.TabIndex = 2
        Label21.Text = "Subject"
        ' 
        ' MyClassmatesSubjectCombobox
        ' 
        MyClassmatesSubjectCombobox.FormattingEnabled = True
        MyClassmatesSubjectCombobox.Location = New Point(19, 231)
        MyClassmatesSubjectCombobox.Name = "MyClassmatesSubjectCombobox"
        MyClassmatesSubjectCombobox.Size = New Size(151, 31)
        MyClassmatesSubjectCombobox.TabIndex = 1
        ' 
        ' DataGridView5
        ' 
        DataGridView5.AllowUserToAddRows = False
        DataGridView5.AllowUserToDeleteRows = False
        DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView5.Location = New Point(193, 14)
        DataGridView5.Name = "DataGridView5"
        DataGridView5.ReadOnly = True
        DataGridView5.RowHeadersWidth = 51
        DataGridView5.RowTemplate.Height = 32
        DataGridView5.Size = New Size(524, 275)
        DataGridView5.TabIndex = 0
        ' 
        ' SchoolLogo
        ' 
        SchoolLogo.BackColor = Color.Transparent
        SchoolLogo.Location = New Point(526, 85)
        SchoolLogo.Name = "SchoolLogo"
        SchoolLogo.Size = New Size(178, 179)
        SchoolLogo.SizeMode = PictureBoxSizeMode.StretchImage
        SchoolLogo.TabIndex = 3
        SchoolLogo.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Controls.Add(TotalBalance)
        Panel3.Controls.Add(TotalPayment)
        Panel3.Controls.Add(CheckBalanceRefreshButton)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label17)
        Panel3.Location = New Point(24, 129)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(471, 215)
        Panel3.TabIndex = 2
        ' 
        ' TotalBalance
        ' 
        TotalBalance.BackColor = Color.Transparent
        TotalBalance.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TotalBalance.ForeColor = Color.Gainsboro
        TotalBalance.Location = New Point(183, 101)
        TotalBalance.Name = "TotalBalance"
        TotalBalance.Size = New Size(162, 31)
        TotalBalance.TabIndex = 7
        TotalBalance.Text = "0"
        TotalBalance.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TotalPayment
        ' 
        TotalPayment.BackColor = Color.Transparent
        TotalPayment.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TotalPayment.ForeColor = Color.Gainsboro
        TotalPayment.Location = New Point(183, 148)
        TotalPayment.Name = "TotalPayment"
        TotalPayment.Size = New Size(162, 31)
        TotalPayment.TabIndex = 6
        TotalPayment.Text = "0"
        TotalPayment.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CheckBalanceRefreshButton
        ' 
        CheckBalanceRefreshButton.BackColor = Color.WhiteSmoke
        CheckBalanceRefreshButton.Cursor = Cursors.Hand
        CheckBalanceRefreshButton.FlatAppearance.BorderColor = Color.DarkRed
        CheckBalanceRefreshButton.FlatAppearance.BorderSize = 2
        CheckBalanceRefreshButton.FlatStyle = FlatStyle.Flat
        CheckBalanceRefreshButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBalanceRefreshButton.ForeColor = Color.Maroon
        CheckBalanceRefreshButton.Location = New Point(370, 16)
        CheckBalanceRefreshButton.Name = "CheckBalanceRefreshButton"
        CheckBalanceRefreshButton.Size = New Size(84, 38)
        CheckBalanceRefreshButton.TabIndex = 4
        CheckBalanceRefreshButton.Text = "Refresh"
        CheckBalanceRefreshButton.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Gainsboro
        Label19.Location = New Point(4, 148)
        Label19.Name = "Label19"
        Label19.Size = New Size(172, 31)
        Label19.TabIndex = 4
        Label19.Text = "Total Payment:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.Gainsboro
        Label18.Location = New Point(4, 101)
        Label18.Name = "Label18"
        Label18.Size = New Size(162, 31)
        Label18.TabIndex = 3
        Label18.Text = "Total Balance:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = Color.Gainsboro
        Label17.Location = New Point(4, 12)
        Label17.Name = "Label17"
        Label17.Size = New Size(344, 38)
        Label17.TabIndex = 2
        Label17.Text = "SUMMARY OF PAYMENT"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.SeaShell
        Label16.Location = New Point(20, 44)
        Label16.Name = "Label16"
        Label16.Size = New Size(372, 46)
        Label16.TabIndex = 1
        Label16.Text = "TOTAL TRANSACTION"
        ' 
        ' DataGridView4
        ' 
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(24, 386)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.RowTemplate.Height = 32
        DataGridView4.Size = New Size(696, 83)
        DataGridView4.TabIndex = 0
        ' 
        ' ShowAllButton
        ' 
        ShowAllButton.BackColor = Color.Maroon
        ShowAllButton.Cursor = Cursors.Hand
        ShowAllButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ShowAllButton.ForeColor = Color.WhiteSmoke
        ShowAllButton.Location = New Point(25, 450)
        ShowAllButton.Name = "ShowAllButton"
        ShowAllButton.Size = New Size(435, 49)
        ShowAllButton.TabIndex = 7
        ShowAllButton.Text = "SHOW ALL"
        ShowAllButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.ForeColor = Color.Gainsboro
        Label7.Location = New Point(183, 414)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 21)
        Label7.TabIndex = 6
        Label7.Text = "Semester"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(21, 414)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 21)
        Label3.TabIndex = 5
        Label3.Text = "Year Level"
        ' 
        ' ProspectusSemesterCombobox
        ' 
        ProspectusSemesterCombobox.FormattingEnabled = True
        ProspectusSemesterCombobox.Items.AddRange(New Object() {"1", "2"})
        ProspectusSemesterCombobox.Location = New Point(188, 380)
        ProspectusSemesterCombobox.Name = "ProspectusSemesterCombobox"
        ProspectusSemesterCombobox.Size = New Size(140, 31)
        ProspectusSemesterCombobox.TabIndex = 4
        ' 
        ' ProspectusYearLevelCombobox
        ' 
        ProspectusYearLevelCombobox.FormattingEnabled = True
        ProspectusYearLevelCombobox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ProspectusYearLevelCombobox.Location = New Point(25, 380)
        ProspectusYearLevelCombobox.Name = "ProspectusYearLevelCombobox"
        ProspectusYearLevelCombobox.Size = New Size(140, 31)
        ProspectusYearLevelCombobox.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(gec)
        GroupBox1.Controls.Add(cc)
        GroupBox1.Controls.Add(pc)
        GroupBox1.Controls.Add(pe)
        GroupBox1.Controls.Add(am)
        GroupBox1.Controls.Add(pe_nstp)
        GroupBox1.Controls.Add(total_units)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.WhiteSmoke
        GroupBox1.Location = New Point(481, 278)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(240, 231)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "SUMMARY"
        ' 
        ' gec
        ' 
        gec.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        gec.Location = New Point(175, 37)
        gec.Name = "gec"
        gec.Size = New Size(42, 21)
        gec.TabIndex = 17
        gec.Text = "0"
        gec.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cc
        ' 
        cc.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        cc.Location = New Point(175, 60)
        cc.Name = "cc"
        cc.Size = New Size(42, 21)
        cc.TabIndex = 15
        cc.Text = "0"
        cc.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pc
        ' 
        pc.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        pc.Location = New Point(175, 82)
        pc.Name = "pc"
        pc.Size = New Size(42, 21)
        pc.TabIndex = 15
        pc.Text = "0"
        pc.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pe
        ' 
        pe.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        pe.Location = New Point(175, 106)
        pe.Name = "pe"
        pe.Size = New Size(42, 21)
        pe.TabIndex = 16
        pe.Text = "0"
        pe.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' am
        ' 
        am.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        am.Location = New Point(175, 128)
        am.Name = "am"
        am.Size = New Size(42, 21)
        am.TabIndex = 15
        am.Text = "0"
        am.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pe_nstp
        ' 
        pe_nstp.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        pe_nstp.Location = New Point(175, 151)
        pe_nstp.Name = "pe_nstp"
        pe_nstp.Size = New Size(42, 21)
        pe_nstp.TabIndex = 14
        pe_nstp.Text = "0"
        pe_nstp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' total_units
        ' 
        total_units.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        total_units.Location = New Point(175, 189)
        total_units.Name = "total_units"
        total_units.Size = New Size(42, 21)
        total_units.TabIndex = 13
        total_units.Text = "0"
        total_units.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(11, 193)
        Label15.Name = "Label15"
        Label15.Size = New Size(111, 18)
        Label15.TabIndex = 6
        Label15.Text = "TOTAL UNITS:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(11, 154)
        Label12.Name = "Label12"
        Label12.Size = New Size(67, 16)
        Label12.TabIndex = 5
        Label12.Text = "PE/NSTP:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(11, 130)
        Label14.Name = "Label14"
        Label14.Size = New Size(101, 16)
        Label14.TabIndex = 4
        Label14.Text = "Additional Math:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(11, 106)
        Label10.Name = "Label10"
        Label10.Size = New Size(138, 16)
        Label10.TabIndex = 3
        Label10.Text = "Professional Electives:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(11, 83)
        Label11.Name = "Label11"
        Label11.Size = New Size(134, 16)
        Label11.TabIndex = 2
        Label11.Text = "Professional Courses:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(11, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 16)
        Label9.TabIndex = 1
        Label9.Text = "Common Courses:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(11, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 16)
        Label8.TabIndex = 0
        Label8.Text = "General Education Courses:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.RosyBrown
        Label2.Location = New Point(15, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(445, 42)
        Label2.TabIndex = 1
        Label2.Text = "Search your Subjects Here!"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(13, 10)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.RowTemplate.Height = 32
        DataGridView3.Size = New Size(709, 248)
        DataGridView3.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Subject_icon
        PictureBox2.Location = New Point(513, 323)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(187, 176)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' SubjectBackgroundLabel
        ' 
        SubjectBackgroundLabel.BorderStyle = BorderStyle.Fixed3D
        SubjectBackgroundLabel.FlatStyle = FlatStyle.Flat
        SubjectBackgroundLabel.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        SubjectBackgroundLabel.ForeColor = SystemColors.ButtonFace
        SubjectBackgroundLabel.Location = New Point(55, 323)
        SubjectBackgroundLabel.Name = "SubjectBackgroundLabel"
        SubjectBackgroundLabel.Size = New Size(441, 180)
        SubjectBackgroundLabel.TabIndex = 2
        SubjectBackgroundLabel.Text = "Subject Background"
        ' 
        ' CourseCodeLabel
        ' 
        CourseCodeLabel.AutoSize = True
        CourseCodeLabel.Font = New Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        CourseCodeLabel.ForeColor = Color.LimeGreen
        CourseCodeLabel.Location = New Point(47, 275)
        CourseCodeLabel.Name = "CourseCodeLabel"
        CourseCodeLabel.Size = New Size(258, 48)
        CourseCodeLabel.TabIndex = 1
        CourseCodeLabel.Text = "Course Code"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(22, 9)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 32
        DataGridView2.Size = New Size(690, 259)
        DataGridView2.TabIndex = 0
        ' 
        ' GradesSectionForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(733, 651)
        Controls.Add(MySectionPanel)
        Controls.Add(StatusLabel)
        Controls.Add(TotalAverageLabel)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ProgressBar1)
        Controls.Add(Label13)
        Controls.Add(CaptionPanel)
        Controls.Add(TitleBarPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "GradesSectionForm"
        Text = "GradesSectionForm"
        TitleBarPanel.ResumeLayout(False)
        TitleBarPanel.PerformLayout()
        CaptionPanel.ResumeLayout(False)
        CaptionPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MySectionPanel.ResumeLayout(False)
        MySectionPanel.PerformLayout()
        ProspectusPanel.ResumeLayout(False)
        ProspectusPanel.PerformLayout()
        CheckBalancePanel.ResumeLayout(False)
        CheckBalancePanel.PerformLayout()
        MyClassmatesPanel.ResumeLayout(False)
        MyClassmatesPanel.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView5, ComponentModel.ISupportInitialize).EndInit()
        CType(SchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents TitleBar As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents CaptionPanel As Panel
    Friend WithEvents CaptionLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalAverageLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SubjectCodenameCombobox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SectionTxtbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProfessorsGreetings As Label
    Friend WithEvents ProfessorsName As Label
    Friend WithEvents ProfessorsID As Label
    Friend WithEvents SubjectCodenameLabel As Label
    Friend WithEvents SubjectDescriptionLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MySectionPanel As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CourseCodeLabel As Label
    Friend WithEvents SubjectBackgroundLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProspectusPanel As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProspectusYearLevelCombobox As ComboBox
    Friend WithEvents ProspectusSemesterCombobox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowAllButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents total_units As Label
    Friend WithEvents pe_nstp As Label
    Friend WithEvents am As Label
    Friend WithEvents pe As Label
    Friend WithEvents gec As Label
    Friend WithEvents cc As Label
    Friend WithEvents pc As Label
    Friend WithEvents CheckBalancePanel As Panel
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SchoolLogo As PictureBox
    Friend WithEvents CheckBalanceRefreshButton As Button
    Friend WithEvents TotalBalance As Label
    Friend WithEvents TotalPayment As Label
    Friend WithEvents MyClassmatesPanel As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents MyClassmateSectionLabel As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents StudentDescription As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents MyClassmatesSubjectCombobox As ComboBox
    Friend WithEvents DataGridView5 As DataGridView
End Class
