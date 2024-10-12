Imports System.Data.SqlClient


Public Class GradesSectionForm
    Dim drag As Boolean
    Dim mousex As Integer,
        mousey As Integer

    Dim UserID As String

    'Global Variable Background
    Dim OCBackground As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCEnrollmentBG.png")
    Dim OCLogo As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCLogo.png")

    Dim con As New SqlConnection("Data Source=Sys1\SQLEXPRESS;Initial Catalog=OsmenaProjects;Integrated Security=True")

    Private Async Sub GradesSectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = OCBackground

        Try
            If MainForm.ViewGradesButton.ContainsFocus Then
                TitleBar.Text = My.Settings.username
                CaptionLabel.Text = MainForm.ViewGradesButton.Text
                MySectionPanel.Visible = False
                ProspectusPanel.Visible = False
                CheckBalancePanel.Visible = False

            ElseIf MainForm.MyClassmatesButton.ContainsFocus Then
                TitleBar.Text = My.Settings.username
                CaptionLabel.Text = MainForm.MyClassmatesButton.Text
                MySectionPanel.Visible = True
                ProspectusPanel.Visible = True
                CheckBalancePanel.Visible = True
                ProspectusPanel.Visible = True
                MyClassmatesPanel.Visible = True

                PictureBox4.Image = OCLogo

            ElseIf MainForm.MySectionsButton.ContainsFocus Then
                TitleBar.Text = My.Settings.username
                CaptionLabel.Text = "My Subjects and Sections"
                MySectionPanel.Visible = True
                ProspectusPanel.Visible = False
                CheckBalancePanel.Visible = False

                DisplaySubjectsGrades()
            ElseIf MainForm.ProspectusButton.ContainsFocus Then
                ProspectusYearLevelCombobox.DropDownStyle = ComboBoxStyle.DropDownList
                ProspectusSemesterCombobox.DropDownStyle = ComboBoxStyle.DropDownList

                TitleBar.Text = My.Settings.username
                CaptionLabel.Text = MainForm.ProspectusButton.Text
                ProspectusPanel.Visible = True
                CheckBalancePanel.Visible = False

                displayProspectus()
                summaryProspectus()
            ElseIf MainForm.CheckBalanceButton.ContainsFocus Then
                'Osmena Colleges Logo
                SchoolLogo.Image = OCLogo

                TitleBar.Text = My.Settings.username
                CaptionLabel.Text = MainForm.CheckBalanceButton.Text
                ProspectusPanel.Visible = True
                CheckBalancePanel.Visible = True
                MyClassmatesPanel.Visible = False
                MessageBox.Show("This is the overall transaction you have paid. If you want to know the details, kindly go to the MIS section located at the main building. Thank you!", $"Greetings {My.Settings.username}!")

                MyBalance()
            End If
        Catch ex As Exception
            MessageBox.Show($"Grades Section FormLoad: {ex}")
        End Try
    End Sub

    Private Sub SubjectCodenameCombobox_DropDown(sender As Object, e As EventArgs) Handles SubjectCodenameCombobox.DropDown
        GetSubject(SubjectCodenameCombobox)
    End Sub

    Private Sub GetSubject(ByRef ComboboxName As ComboBox)
        Try
            Dim YearLevel As String = MainForm.StudentsYearLevel.Text
            Dim NewYearLevel As String = YearLevel.Substring(0, 1)

            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As New SqlCommand("SELECT subject_codename FROM subject WHERE department = @department AND course = @course AND year_level = @year_level;", con)
            query.Parameters.AddWithValue("department", MainForm.StudentsDepartment.Text)
            query.Parameters.AddWithValue("course", MainForm.StudentsCourse.Text)
            query.Parameters.AddWithValue("year_level", NewYearLevel)

            Dim reader As SqlDataReader = query.ExecuteReader()
            ComboboxName.Items.Clear()
            If reader.HasRows Then
                While reader.Read()
                    ComboboxName.Items.Add(reader("subject_codename").ToString())
                End While
            Else
                MessageBox.Show("Subjects are currently not available", "Sorry")
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox($"Dropdown: {ex}")
        End Try
        con.Close()
    End Sub

    Private Sub SubjectCodenameCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SubjectCodenameCombobox.SelectedValueChanged
        Try
            ProgressBar1.Value = 0
            GetMyGrades()
            If con.State = ConnectionState.Closed Then con.Open()
            Dim command As New SqlCommand("SELECT teacher_id, teacher_first_name, teacher_middle_name, teacher_last_name, subject_codename, description FROM subject WHERE subject_codename = @subject_codename AND section = @section", con)
            command.Parameters.AddWithValue("subject_codename", SubjectCodenameCombobox.Text)
            command.Parameters.AddWithValue("section", SectionTxtbox.Text)

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()

                Dim TeacherID = reader.GetString(0)
                Dim TeacherFirstName = reader.GetString(1)
                Dim TeacherMiddleName = reader.GetString(2)
                Dim TeacherLastName = reader.GetString(3)
                Dim SubjectCodename = reader.GetString(4)
                Dim SubjectDescription = reader.GetString(5)

                Dim TeachersName = $"{TeacherFirstName} {TeacherMiddleName} {TeacherLastName}"

                ProfessorsGreetings.Text = $"Hi {My.Settings.username}!! I am"
                ProfessorsName.Text = TeachersName
                ProfessorsID.Text = TeacherID
                SubjectCodenameLabel.Text = SubjectCodename
                SubjectDescriptionLabel.Text = SubjectDescription
            Else
                DataGridView1.Rows(0).Cells(0).Value = ""
                DataGridView1.Rows(0).Cells(1).Value = ""
                DataGridView1.Rows(0).Cells(2).Value = ""
                DataGridView1.Rows(0).Cells(3).Value = ""
                DataGridView1.Rows(0).Cells(4).Value = ""
                MessageBox.Show("Grades currently unavailable! Contact your professor for the release of your grade", "Oops")
            End If
            DataGridView1.Columns(0).Width = 78
            DataGridView1.Columns(1).Width = 78
            DataGridView1.Columns(2).Width = 79
            DataGridView1.Columns(3).Width = 78
            DataGridView1.Columns(4).Width = 79

            Dim column_name As String = "display_photo"
            Dim table_name As String = "teachers_login"
            Dim condition As String = "teacher_id"

            MainForm.get_display_picture(PictureBox1, column_name, table_name, condition, ProfessorsID.Text)
            reader.Close()
        Catch ex As Exception
            MsgBox($"Selected Value Changed: {ex}")
        End Try

        con.Close()
    End Sub

    Private Sub GetMyGrades()
        ProgressBar1.Value = 0
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT section_id FROM student_grades
JOIN subject ON student_grades.subject_id = subject.subject_id
WHERE student_id = @student_id AND subject.subject_codename = @subject_codename", con)
        command.Parameters.Add("student_id", SqlDbType.VarChar).Value = MainForm.StudentID.Text
        command.Parameters.Add("subject_codename", SqlDbType.VarChar).Value = SubjectCodenameCombobox.Text
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim Section As String = reader.GetString(0)
            SectionTxtbox.Text = Section
        End If
        reader.Close()

        Dim query As New SqlCommand("SELECT prelim, midterm, pre_final, final, total_average FROM student_grades
JOIN subject ON student_grades.subject_id = subject.subject_id
WHERE student_id = @student_id AND subject.subject_codename = @subject_codename", con)
        query.Parameters.Add("student_id", SqlDbType.VarChar).Value = MainForm.StudentID.Text
        query.Parameters.Add("subject_codename", SqlDbType.VarChar).Value = SubjectCodenameCombobox.Text

        Dim adapter As New SqlDataAdapter(query)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then

            DataGridView1.DataSource = table
            TotalAverageLabel.Text = DataGridView1.Rows(0).Cells(4).Value

            MainForm.ColorTextGwa(TotalAverageLabel, StatusLabel, ProgressBar1, Timer1)
        End If

        Timer1.Start()
        con.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim gwa As Double = TotalAverageLabel.Text
        Dim val As Integer

        If gwa < 1.0 Or gwa > 6 Then val = 0
        If gwa >= 1.0 And gwa <= 1.75 Then val = 100
        If gwa >= 2.0 And gwa <= 2.75 Then val = 70
        If gwa >= 3.0 And gwa <= 4.75 Then val = 40
        If gwa >= 5.0 And gwa <= 6.0 Then val = 10

        ProgressBar1.Increment(2)

        If gwa = 0 Or ProgressBar1.Value = val Then Timer1.Stop()
        Timer1.Interval = (10)
    End Sub

    'Close Button
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    'Refresh Button
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        GetMyGrades()
    End Sub

    ' My Classmates Function
    Private Sub MyClassmatesSubjectCombobox_DropDown(sender As Object, e As EventArgs) Handles MyClassmatesSubjectCombobox.DropDown
        GetSubject(MyClassmatesSubjectCombobox)
    End Sub

    Private Sub MyClassmatesSubjectCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles MyClassmatesSubjectCombobox.SelectedValueChanged
        Try
            DataGridView5.Columns.Clear()
            Dim table_name As String = MyClassmatesSubjectCombobox.Text
            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As New SqlCommand("SELECT section_id FROM student_grades
JOIN subject ON subject.section = student_grades.section_id
WHERE subject.subject_codename = @subject_codename", con)
            query.Parameters.AddWithValue("subject_codename", MyClassmatesSubjectCombobox.Text)
            Dim reader As SqlDataReader = query.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                MyClassmateSectionLabel.Text = reader.GetString(0)
            Else
                MessageBox.Show("Subject unavailable at the moment", "Oops")
            End If


            reader.Close()

            Dim NewColumn As New DataGridViewTextBoxColumn With {
                .HeaderText = "No.",
                .Name = "No",
                .Width = 50
            }
            DataGridView5.Columns.Add(NewColumn)

            Dim command As New SqlCommand($"SELECT CONCAT(student_information.last_name, ', ', student_information.first_name, ', ', SUBSTRING(student_information.middle_name, 1, 1), '.') AS Name, student_information.gender AS Gender, student_grades.student_id AS ID FROM student_information
JOIN student_grades ON student_information.student_id = student_grades.student_id
WHERE section_id = @section_id ORDER BY Name", con)
            command.Parameters.AddWithValue("section_id", MyClassmateSectionLabel.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView5.DataSource = table

            DataGridView5.Columns(1).Width = 335
            DataGridView5.Columns(2).Width = 85
            DataGridView5.Columns(3).Width = 90

            Dim count As Integer = 1
            For i As Integer = 0 To DataGridView5.Rows.Count - 1
                DataGridView5.Rows(i).Cells(0).Value = count
                count += 1
            Next

            DataGridView5.AllowUserToResizeColumns = False
            DataGridView5.AllowUserToResizeRows = False

            con.Close()
        Catch ex As Exception
            MsgBox($"Selected Value Changed: {ex}")
        End Try
    End Sub

    Private Sub DataGridView5_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView5.SelectionChanged
        Dim table_name As String = "login_users"
        Dim condition As String = "student_id"

        For Each i As DataGridViewRow In DataGridView5.SelectedRows
            If i IsNot Nothing AndAlso Not i.IsNewRow Then
                Dim StudentID As String = i.Cells(3).Value
                GetBackground(StudentID, "bio", table_name, condition, StudentDescription)
                MainForm.get_display_picture(PictureBox3, "display_photo", table_name, condition, StudentID)
            End If
        Next
    End Sub


    ' My Subjects and Section Functions
    Private Sub DisplaySubjectsGrades()
        Dim YearLevel As String = MainForm.StudentsYearLevel.Text
        Dim NewYearLevel As String = YearLevel.Substring(0, 1)

        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand($"SELECT subject.section, subject_codename, description, CONCAT(teacher_first_name, ' ',teacher_last_name) AS Instructor FROM subject WHERE department = @department AND course = @course AND year_level = @year_level", con)
        command.Parameters.AddWithValue("department", MainForm.StudentsDepartment.Text)
        command.Parameters.AddWithValue("course", MainForm.StudentsCourse.Text)
        command.Parameters.AddWithValue("year_level", NewYearLevel)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView2.DataSource = table

        DataGridView2.Columns(0).Width = 80
        DataGridView2.Columns(1).Width = 120
        DataGridView2.Columns(2).Width = 280
        DataGridView2.Columns(3).Width = 160

        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False

        con.Close()
    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Dim table_name As String = "subject"
        Dim condition As String = "subject_codename"

        For Each i As DataGridViewRow In DataGridView2.SelectedRows
            If i IsNot Nothing AndAlso Not i.IsNewRow Then
                Dim MySubject As String = i.Cells(1).Value
                GetBackground(MySubject, "background", table_name, condition, SubjectBackgroundLabel)
                MainForm.get_display_picture(PictureBox2, "display_photo", table_name, condition, MySubject)
                CourseCodeLabel.Text = MySubject
            Else
                Dim SubjectPicture As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\Subject icon.png")
                CourseCodeLabel.Text = "Course code"
                SubjectBackgroundLabel.Text = "Subject Background"
                PictureBox2.Image = SubjectPicture
            End If
        Next
    End Sub

    Private Sub GetBackground(ByRef code_name As String, column_name As String, table_name As String, condition As String, bg As Label)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Dim query As New SqlCommand($"SELECT {column_name} FROM {table_name} WHERE {condition} = @{condition};", con)
            query.Parameters.AddWithValue($"{condition}", code_name)
            Dim reader As SqlDataReader = query.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Dim background As String = reader.GetString(0)

                bg.Text = background
            Else
                MessageBox.Show("This student doesn't have an account yet!", "Oops")
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            Console.WriteLine($"Error: {ex}")
        End Try
    End Sub

    'Prospectus Button Functions
    Private Sub displayProspectus()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT year_level, semester, subject_codename, description, units, pre_requisite FROM prospectus WHERE course=@course", con)
        command.Parameters.AddWithValue("course", MainForm.StudentsCourse.Text)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView3.DataSource = table
        con.Close()
    End Sub

    Private Sub summaryProspectus()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT general_education_courses, common_courses, professional_courses, professional_electives, additional_math, pe_nstp FROM summary_prospectus WHERE course=@course", con)
        command.Parameters.AddWithValue("course", MainForm.StudentsCourse.Text)

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim gen_ed As Integer = reader.GetInt32(0)
            Dim common_courses As Integer = reader.GetInt32(1)
            Dim prof_courses As Integer = reader.GetInt32(2)
            Dim prof_electives As Integer = reader.GetInt32(3)
            Dim add_math As Integer = reader.GetInt32(4)
            Dim peNstp As Integer = reader.GetInt32(5)

            Dim total As Integer = gen_ed + common_courses + prof_courses + prof_electives + add_math + peNstp
            gec.Text = gen_ed
            cc.Text = common_courses
            pc.Text = prof_courses
            pe.Text = prof_electives
            am.Text = add_math
            pe_nstp.Text = peNstp
            total_units.Text = total
        Else
            MessageBox.Show("Error finding data on prospectus", "Data Error")
        End If


        reader.Close()
        con.Close()
    End Sub

    Private Sub searchProspectus()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT year_level, semester, subject_codename, description, units, pre_requisite FROM prospectus WHERE course=@course AND year_level=@year_level AND semester=@semester", con)
        command.Parameters.AddWithValue("course", MainForm.StudentsCourse.Text)
        command.Parameters.AddWithValue("year_level", ProspectusYearLevelCombobox.Text)
        command.Parameters.AddWithValue("semester", ProspectusSemesterCombobox.Text)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView3.DataSource = table
        con.Close()
    End Sub

    Private Sub ProspectusYearLevelCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ProspectusYearLevelCombobox.SelectedValueChanged
        searchProspectus()
    End Sub

    Private Sub ProspectusSemesterCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ProspectusSemesterCombobox.SelectedValueChanged
        searchProspectus()
    End Sub

    Private Sub ShowAllButton_Click(sender As Object, e As EventArgs) Handles ShowAllButton.Click
        displayProspectus()
    End Sub

    'Check Balance Button Functions
    Private Sub MyBalance()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT prelim_payment, midterm_payment, pre_final_payment, final_payment, total_payment, tuition_fee, scholarship FROM students_tuition WHERE student_id = @student_id", con)
        command.Parameters.AddWithValue("student_id", MainForm.StudentID.Text)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView4.DataSource = table

        Dim command2 As New SqlCommand("SELECT total_balance, total_fee FROM students_tuition WHERE student_id = @student_id", con)
        command2.Parameters.AddWithValue("student_id", MainForm.StudentID.Text)
        Dim reader As SqlDataReader = command2.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim total_balance As Integer = reader.GetInt32(0)
            Dim total_payment As Integer = reader.GetInt32(1)
            TotalBalance.Text = $"₱ {total_balance}"
            TotalPayment.Text = $"₱ {total_payment}"
        Else
            MessageBox.Show("Error checking data! Please try again later", "Oops")
        End If

        reader.Close()
        con.Close()
    End Sub

    Private Sub CheckBalanceRefreshButton_Click(sender As Object, e As EventArgs) Handles CheckBalanceRefreshButton.Click
        MyBalance()
    End Sub



    ' Functions for moving unsizable form
    Private Sub TitleBarPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TitleBarPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp
        drag = False
    End Sub

    Private Sub TitleBarPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
End Class