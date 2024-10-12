Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.WebSockets
Imports WebSocketSharp
Public Class MainForm
    Public ws As WebSocket
    Dim drag As Boolean
    Dim mousex As Integer,
        mousey As Integer

    'Global Variable BackgroundImage
    Dim OCBackgroundMainForm As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OcMainBackground.png")
    Dim OCLogo As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCLogo.png")

    'Global Variable for OC Grades Curriculum Credential
    Dim GradesCurriculumCredential As String = "(Not VALID as CREDENTIAL from Osmena Colleges)"

    Dim con As New SqlConnection("Data Source=Sys1\SQLEXPRESS;Initial Catalog=OsmenaProjects;Integrated Security=True")

    Dim column_name As String = "display_photo"
    Dim table_name As String = "login_users"
    Dim condition As String = "username"

    Dim counter As Integer = 0
    Dim count As Integer = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = OCBackgroundMainForm


        CaptionPanel.Visible = False
        MyProfilePanel.Visible = False
        FacultyPanel.Visible = False
        BioPanel.Visible = False
        ChangeUsernamePassPanel.Visible = False

        If StudentAccessForm.TextBox1.Text = "" Then
            My.Settings.username = My.Settings.username
        Else
            My.Settings.username = StudentAccessForm.TextBox1.Text
            My.Settings.Save()
        End If

        ' Hello {user} text
        Dim nameOfUser As String = My.Settings.username
        Dim capitalNameOfUser As String = nameOfUser.Substring(0, 1).ToUpper() + nameOfUser.Substring(1)
        TitleBar.Text = capitalNameOfUser
        GreetingsUserLabel.Text = capitalNameOfUser & "!"

        DisplayInformations()
        UpdateGwa()

        get_display_picture(MainUserPicture, column_name, table_name, condition, My.Settings.username)
        get_display_picture(MyProfilePicture, column_name, table_name, condition, My.Settings.username)
    End Sub

    'Close Button
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Form1.Close()
    End Sub

    'Logout Button
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim message As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logging Out", MessageBoxButtons.YesNo)

        If message = DialogResult.Yes Then
            My.Settings.IsLoggedIn = False
            My.Settings.Save()
            StudentAccessForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub EditUsernamePassword_Click(sender As Object, e As EventArgs) Handles EditUsernamePassword.Click
        ChangeUsernamePassPanel.Visible = True
        ChangeUsernamePanel.Visible = False
        ChangePasswordPanel.Visible = False
    End Sub

    Private Sub UsernameBackButton_Click(sender As Object, e As EventArgs) Handles UsernameBackButton.Click
        ChangeUsernamePanel.Visible = False
        EditUsernamePasswordCloseButton.Visible = True
        ClearTextbox(ChangeUsernameTextbox, ConfirmPasswordTextbox)
    End Sub

    Private Sub ChangePasswordBackButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordBackButton.Click
        ChangeUsernamePanel.Visible = False
        ChangePasswordPanel.Visible = False
        EditUsernamePasswordCloseButton.Visible = True
        CurrentPasswordTextbox.Clear()
        ClearTextbox(NewPasswordTextbox, ConfirmNewPasswordTextbox)
    End Sub

    Private Sub ChangeUsernameButton_Click(sender As Object, e As EventArgs) Handles ChangeUsernameButton.Click
        ChangeUsernamePanel.Visible = True
        EditUsernamePasswordCloseButton.Visible = False
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        ChangePasswordPanel.Visible = True
        EditUsernamePasswordCloseButton.Visible = False
    End Sub

    Private Sub EditUsernamePasswordCloseButton_Click(sender As Object, e As EventArgs) Handles EditUsernamePasswordCloseButton.Click
        ChangeUsernamePassPanel.Visible = False
    End Sub

    Private Sub SaveUsernameButton_Click(sender As Object, e As EventArgs) Handles SaveUsernameButton.Click
        Dim my_pass As New Password()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim query As New SqlCommand("SELECT password FROM login_users WHERE username = @username", con)
        query.Parameters.AddWithValue("username", My.Settings.username)
        Dim reader As SqlDataReader = query.ExecuteReader()
        Dim pass As String
        If reader.HasRows Then
            reader.Read()
            pass = reader.GetString(0)
        End If
        reader.Close()
        If pass.Equals(my_pass.Encrypt(ConfirmPasswordTextbox.Text)) Then
            IsDataExist(ChangeUsernameTextbox)
        Else
            MessageBox.Show("Password is incorrect", "Error")
        End If
        con.Close()
    End Sub

    Private Sub ChangePasswordSaveButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordSaveButton.Click
        Dim my_pass As New Password()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim query As New SqlCommand("SELECT password FROM login_users WHERE student_id = @student_id", con)
        query.Parameters.AddWithValue("student_id", StudentID.Text)
        Dim reader As SqlDataReader = query.ExecuteReader()
        Dim pass As String
        If reader.HasRows Then
            reader.Read()
            pass = reader.GetString(0)
        End If
        reader.Close()

        If NewPasswordTextbox.Text = ConfirmNewPasswordTextbox.Text Then
            If pass = my_pass.Encrypt(CurrentPasswordTextbox.Text) Then
                Dim command As New SqlCommand("UPDATE login_users SET password = @password WHERE student_id = @student_id", con)
                command.Parameters.AddWithValue("password", my_pass.Encrypt(NewPasswordTextbox.Text))
                command.Parameters.AddWithValue("student_id", StudentID.Text)
                If command.ExecuteNonQuery = 1 Then
                    MessageBox.Show("New password has been saved!", "Successfully updated")
                    CurrentPasswordTextbox.Clear()
                    ClearTextbox(NewPasswordTextbox, ConfirmNewPasswordTextbox)

                    ChangePasswordPanel.Visible = False
                    EditUsernamePasswordCloseButton.Visible = True
                Else
                    MessageBox.Show("Error updating password", "Update failed")
                End If
            Else
                MessageBox.Show("Password is incorrect", "Error")
            End If
        Else
            MessageBox.Show("Password do not match", "Error")
        End If
    End Sub

    ' Check username if already exist
    Private Sub IsDataExist(ByRef check_credentials As TextBox)
        Dim data_exist As Boolean = False
        If con.State = ConnectionState.Closed Then con.Open()
        Dim query As New SqlCommand("SELECT COUNT(username) FROM login_users WHERE username = @username", con)
        query.Parameters.Add("username", SqlDbType.VarChar).Value = check_credentials.Text
        Dim count As Integer = Convert.ToInt32(query.ExecuteScalar())
        If count > 0 Then
            data_exist = True
        End If
        con.Close()

        If data_exist Then
            MessageBox.Show("Username already taken!", "Oops")
        Else
            check_username_and_pass_length(ChangeUsernameTextbox)
        End If
    End Sub
    Private Sub check_username_and_pass_length(ByRef username As TextBox)
        If con.State = ConnectionState.Closed Then con.Open()
        If username.TextLength >= 4 And username.TextLength <= 8 Then
            Dim command As New SqlCommand("UPDATE login_users SET username = @username WHERE student_id = @student_id", con)
            command.Parameters.AddWithValue("username", username.Text)
            command.Parameters.AddWithValue("student_id", StudentID.Text)

            Dim command2 As New SqlCommand("UPDATE student_information SET username = @username WHERE student_id = @student_id", con)
            command2.Parameters.AddWithValue("username", username.Text)
            command2.Parameters.AddWithValue("student_id", StudentID.Text)

            If command.ExecuteNonQuery = 1 And command2.ExecuteNonQuery = 1 Then
                My.Settings.username = username.Text
                My.Settings.Save()
                MessageBox.Show("Username updated successfully", "Succesfully Updated")
                ' Hello {user} text
                Dim nameOfUser As String = My.Settings.username
                Dim capitalNameOfUser As String = nameOfUser.Substring(0, 1).ToUpper() + nameOfUser.Substring(1)
                TitleBar.Text = capitalNameOfUser
                GreetingsUserLabel.Text = capitalNameOfUser & "!"
                ClearTextbox(ChangeUsernameTextbox, ConfirmPasswordTextbox)

                ChangeUsernamePanel.Visible = False
                EditUsernamePasswordCloseButton.Visible = True
            Else
                MessageBox.Show("Username not saved", "Error")
            End If
        Else
            MessageBox.Show("Username must be greater than 5 characters and not greater than 10 characters long!", "Registration Failed")
        End If
        con.Close()
    End Sub

    Private Sub ClearTextbox(ByRef textbox1 As TextBox, textbox2 As TextBox)
        textbox1.Clear()
        textbox2.Clear()
    End Sub

    ' Display Student Information
    Private Sub DisplayInformations()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT department, course, year_level, student_information.student_id, first_name, last_name, login_users.bio FROM student_information
JOIN login_users ON login_users.student_id = student_information.student_id WHERE student_information.username = @username", con)
        command.Parameters.Add("username", SqlDbType.VarChar).Value = My.Settings.username
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim department As String = reader.GetString(0)
            Dim course As String = reader.GetString(1)
            Dim currentYearLevel As Integer = reader.GetInt32(2)
            Dim student_id As Integer = reader.GetInt32(3)
            Dim name As String = reader.GetString(4) & " " & reader.GetString(5)
            Dim bio As String = reader.GetString(6)

            course = UCase(course)
            StudentsDepartment.Text = department
            StudentsCourse.Text = course

            If currentYearLevel = 1 Then StudentsYearLevel.Text = currentYearLevel & "ST YEAR"
            If currentYearLevel = 2 Then StudentsYearLevel.Text = currentYearLevel & "ND YEAR"
            If currentYearLevel = 3 Then StudentsYearLevel.Text = currentYearLevel & "RD YEAR"
            If currentYearLevel = 4 Then StudentsYearLevel.Text = currentYearLevel & "TH YEAR"

            StudentID.Text = student_id

            name = StrConv(name, vbProperCase)
            StudentsName.Text = name
            BioTxt.Text = bio
        End If


        reader.Close()
        con.Close()
    End Sub

    'Method for getting picture from the database
    Public Sub get_display_picture(ByRef picture As PictureBox, column_name As String, table_name As String, condition As String, identifier As String)
        Try
            Dim query As New SqlCommand($"SELECT {column_name} FROM {table_name} WHERE {condition} = @{condition}", con)
            Dim adapter As New SqlDataAdapter(query)
            query.Parameters.Add($"{condition}", SqlDbType.VarChar).Value = identifier
            Dim Data As New DataTable

            Dim commandbuild As New SqlCommandBuilder(adapter)
            adapter.Fill(Data)
            Dim picbyte() As Byte = Data.Rows(0).Item($"{column_name}")
            Dim pic As New MemoryStream(picbyte)
            picture.Image = Image.FromStream(pic)
            picture.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Close()
        Catch ex As Exception
            Console.Write($"{ex}")
        Finally
            con.Close()
        End Try
    End Sub

    'My Profile Button
    Private Sub MyProfileButton_Click(sender As Object, e As EventArgs) Handles MyProfileButton.Click
        MyProfileFunctions()
    End Sub

    Private Sub ViewDetailsMyProfile_Click(sender As Object, e As EventArgs) Handles ViewDetailsMyProfile.Click
        MyProfileFunctions()
    End Sub

    Private Sub MyProfilePicturebox_Click(sender As Object, e As EventArgs) Handles MyProfilePicturebox.Click
        MyProfileFunctions()
    End Sub

    Private Sub BioTxt_Click(sender As Object, e As EventArgs) Handles BioTxt.Click
        If count = 0 Then
            BioPanel.Visible = True
            count += 1
        Else
            BioPanel.Visible = False
            BioTxtbox.Clear()
            count -= 1
        End If
    End Sub

    Private Sub MyProfileFunctions()
        CaptionPanel.Visible = True
        MyProfilePanel.Visible = True
        FacultyPanel.Visible = False
        ProfilePicturePanel.Visible = False
        CaptionLabel.Text = MyProfileButton.Text
        Timer1.Start()
        Timer2.Start()
    End Sub

    'Home Button
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        CaptionPanel.Visible = False
        MyProfilePanel.Visible = False
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        counter = 0
        TitleBar.Text = My.Settings.username
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressFuncGwa(ProgressBar1, Timer1, 2, getGwaAttendance(0), 10)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        progressFuncAttendance(ProgressBar2, Timer2, 1, getGwaAttendance(1), 10)
    End Sub

    'Progressbar functions
    Private Sub progressFuncGwa(ByRef prog As ProgressBar, time As Timer, increment As Double, val As Integer, interval As Integer)
        Dim gwa As Double = getGwaAttendance(0)

        If gwa < 1.0 Or gwa > 6 Then val = 0
        If gwa >= 1.0 And gwa <= 1.75 Then val = 100
        If gwa >= 2.0 And gwa <= 2.75 Then val = 70
        If gwa >= 3.0 And gwa <= 4.75 Then val = 40
        If gwa >= 5.0 And gwa <= 6.0 Then val = 10

        prog.Increment(increment)
        If gwa = 0 Or prog.Value = val Then time.Stop()
        time.Interval = (interval)
    End Sub

    Private Sub progressFuncAttendance(ByRef prog As ProgressBar, time As Timer, increment As Double, val As Integer, interval As Integer)
        Dim attendance As Double = getGwaAttendance(1)
        counter += 1
        If attendance <= 10 And attendance > 8 Then
            val = 100
            CurrentAttendance.ForeColor = Color.ForestGreen
        ElseIf attendance <= 8 And attendance > 6 Then
            val = 80
            CurrentAttendance.ForeColor = Color.YellowGreen
        ElseIf attendance <= 6 And attendance > 4 Then
            val = 60
            CurrentAttendance.ForeColor = Color.RosyBrown
        ElseIf attendance <= 4 And attendance > 2 Then
            val = 25
            CurrentAttendance.ForeColor = Color.Maroon
        ElseIf attendance <= 2 Then
            val = 5
            CurrentAttendance.ForeColor = Color.Maroon
        End If

        prog.Increment(increment)
        If prog.Value = val Then time.Stop()
        time.Interval = (interval)
        CurrentAttendance.Text = counter & "%"
    End Sub

    'Get GWA and attendance function
    Private Function getGwaAttendance(ByRef val As Integer)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Dim command As New SqlCommand("SELECT gwa, attendance, status FROM student_information WHERE username=@username", con)
            command.Parameters.Add("username", SqlDbType.VarChar).Value = My.Settings.username

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()
            getGwaAttendance = reader.GetDouble(val)
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox($"Error getting GWA and Attendance {ex}")
        End Try
    End Function

    Public Sub ColorTextGwa(ByRef CurrentGWA As Label, status As Label, progressbar As ProgressBar, timer As Timer)
        If CurrentGWA.Text >= 1.0 And CurrentGWA.Text <= 1.75 Then
            CurrentGWA.ForeColor = Color.ForestGreen
            status.Text = "EXCELLENT!"
            status.ForeColor = Color.Green
        ElseIf CurrentGWA.Text > 1.75 And CurrentGWA.Text <= 2.75 Then
            CurrentGWA.ForeColor = Color.YellowGreen
            status.Text = "GOOD"
            status.ForeColor = Color.YellowGreen
        ElseIf CurrentGWA.Text > 2.75 And CurrentGWA.Text <= 3.75 Then
            CurrentGWA.ForeColor = Color.RosyBrown
            status.Text = "BAD"
            status.ForeColor = Color.RosyBrown
        ElseIf CurrentGWA.Text > 3.75 And CurrentGWA.Text <= 5.0 Then
            CurrentGWA.ForeColor = Color.Maroon
            status.Text = "INC"
            status.ForeColor = Color.Maroon
        ElseIf CurrentGWA.Text > 5.0 And CurrentGWA.Text <= 6.0 Then
            CurrentGWA.ForeColor = Color.Maroon
            status.Text = "DROPPED"
            status.ForeColor = Color.Maroon

            progressbar.Increment(2)
            If progressbar.Value = progressbar.Value Then timer.Stop()
            timer.Interval = (10)
        End If
    End Sub

    'Getting GWA from the database
    Private Sub UpdateGwa()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT gwa FROM student_information WHERE student_id=@student_id", con)
        command.Parameters.Add("student_id", SqlDbType.VarChar).Value = StudentID.Text
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            If reader.GetDouble(0) = 1 Or reader.GetDouble(0) = 2 Or reader.GetDouble(0) = 3 Or reader.GetDouble(0) = 4 Or reader.GetDouble(0) = 5 Or reader.GetDouble(0) = 6 Then
                CurrentGWA.Text = reader.GetDouble(0) & ".0"
            Else
                CurrentGWA.Text = reader.GetDouble(0)
            End If
            ColorTextGwa(CurrentGWA, Status, ProgressBar1, Timer1)
        End If

        reader.Close()
        con.Close()
    End Sub

    'Update Profile Picture
    Private Sub ChangeDPBtn_Click(sender As Object, e As EventArgs) Handles ChangeDPBtn.Click
        openDialog()

        Dim command As New SqlCommand("UPDATE login_users SET display_photo=@display_photo WHERE username=@username", con)
        command.Parameters.Add("username", SqlDbType.VarChar).Value = My.Settings.username
        Dim memory As New MemoryStream()
        Dim image As New Bitmap(MyProfilePicture.Image)

        image.Save(memory, Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = memory.GetBuffer()
        Dim dp As New SqlParameter("display_photo", SqlDbType.Image)
        dp.Value = data
        command.Parameters.Add(dp)

        If con.State = ConnectionState.Closed Then con.Open()
        If command.ExecuteNonQuery = 1 Then
            get_display_picture(ZoomedPicture, column_name, table_name, condition, My.Settings.username)
            get_display_picture(MainUserPicture, column_name, table_name, condition, My.Settings.username)
        Else
            MessageBox.Show("Failed To Update", "Error")
        End If
        con.Close()
    End Sub
    Private Sub ShowGradesSectionForm()
        GradesSectionForm.Close()
        GradesSectionForm.Show()
    End Sub

    'Update bio
    Private Sub UpdateBioButton_Click(sender As Object, e As EventArgs) Handles UpdateBioButton.Click
        Try
            If BioTxtbox.TextLength < 4 Then
                MessageBox.Show("Bio too short!", "Error")
            Else
                If con.State = ConnectionState.Closed Then con.Open()
                Dim command As New SqlCommand("UPDATE login_users SET bio = @bio WHERE username = @username", con)
                command.Parameters.AddWithValue("bio", BioTxtbox.Text)
                command.Parameters.AddWithValue("username", My.Settings.username)

                If command.ExecuteNonQuery = 1 Then
                    MessageBox.Show("Bio updated succesfully!", "Successfully updated")
                    DisplayInformations()
                    BioPanel.Visible = False
                    BioTxtbox.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Update Bio: {ex}")
        End Try
    End Sub

    'Zooming in Profile Picture
    Private Sub MyProfilePicture_Click(sender As Object, e As EventArgs) Handles MyProfilePicture.Click
        ProfilePicturePanel.Visible = True
        get_display_picture(ZoomedPicture, column_name, table_name, condition, My.Settings.username)
    End Sub

    'Zoom out profile picture
    Private Sub ZoomedPicture_Click(sender As Object, e As EventArgs) Handles ZoomedPicture.Click
        ProfilePicturePanel.Visible = False
    End Sub

    'Enroll now button
    Private Sub EnrollNowButton_Click(sender As Object, e As EventArgs) Handles EnrollNowButton.Click
        EnrollmentForm.Show()
    End Sub

    Private Sub openDialog()
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                MyProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show($"{ex}", "File too large")
        End Try
    End Sub

    'View Grades Button
    Private Sub ViewGradesButton_Click(sender As Object, e As EventArgs) Handles ViewGradesButton.Click
        ShowGradesSectionForm()
    End Sub

    'My Classmates Button
    Private Sub MyClassmatesButton_Click(sender As Object, e As EventArgs) Handles MyClassmatesButton.Click
        ShowGradesSectionForm()
    End Sub

    'My Sections Button
    Private Sub MySectionsButton_Click(sender As Object, e As EventArgs) Handles MySectionsButton.Click
        ShowGradesSectionForm()
    End Sub

    'Prospectus Button
    Private Sub ProspectusButton_Click(sender As Object, e As EventArgs) Handles ProspectusButton.Click
        ShowGradesSectionForm()
    End Sub

    'Check Balance Button
    Private Sub CheckBalanceButton_Click(sender As Object, e As EventArgs) Handles CheckBalanceButton.Click
        ShowGradesSectionForm()
    End Sub

    'Faculty Button Functions
    Private Sub FacultyButtonFunction()
        MyProfilePanel.Visible = True
        FacultyPanel.Visible = True
        GradesCurriculumPanel.Visible = False

        CaptionPanel.Visible = True
        CaptionLabel.Text = FacultyButton.Text

        DisplayTeacher()
    End Sub

    Private Sub FacultyButton_Click(sender As Object, e As EventArgs) Handles FacultyButton.Click
        FacultyButtonFunction()
    End Sub

    Private Sub ViewDetailsFaculty_Click(sender As Object, e As EventArgs) Handles ViewDetailsFaculty.Click
        FacultyButtonFunction()
    End Sub

    Private Sub FacultyPicturebox_Click(sender As Object, e As EventArgs) Handles FacultyPicturebox.Click
        FacultyButtonFunction()
    End Sub

    Private Sub DisplayTeacher()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT first_name, middle_name, last_name, department, birthday, gender FROM teachers_information", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub FacultyDepartmentCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles FacultyDepartmentCombobox.SelectedValueChanged
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT first_name, middle_name, last_name, department, birthday, gender FROM teachers_information WHERE department = @department", con)
        command.Parameters.AddWithValue("department", FacultyDepartmentCombobox.Text)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    'Search Button
    Private Sub FacultyShowAllButton_Click_1(sender As Object, e As EventArgs) Handles FacultyShowAllButton.Click
        DisplayTeacher()
    End Sub

    'Search textbox function
    Private Sub FacultySearchTextbox_TextChanged(sender As Object, e As EventArgs) Handles FacultySearchTextbox.TextChanged
        searchTeachersData()
    End Sub

    Private Sub searchTeachersData()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT first_name, middle_name, last_name, department, birthday, gender FROM teachers_information WHERE first_name LIKE @first_name OR middle_name LIKE @middle_name OR last_name LIKE @last_name", con)
        command.Parameters.AddWithValue("first_name", FacultySearchTextbox.Text)
        command.Parameters.AddWithValue("middle_name", FacultySearchTextbox.Text)
        command.Parameters.AddWithValue("last_name", FacultySearchTextbox.Text)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        For Each SelectedRow As DataGridViewRow In DataGridView1.SelectedRows
            If SelectedRow IsNot Nothing AndAlso Not SelectedRow.IsNewRow Then
                Dim FirstName As String = SelectedRow.Cells(0).Value
                Dim LastName As String = SelectedRow.Cells(2).Value

                If con.State = ConnectionState.Closed Then con.Open()
                Dim command As New SqlCommand("SELECT teacher_id, first_name, last_name, birthday, course_college, school_college, background FROM teachers_information WHERE first_name=@first_name AND last_name=@last_name", con)
                command.Parameters.AddWithValue("first_name", FirstName)
                command.Parameters.AddWithValue("last_name", LastName)

                Dim reader As SqlDataReader = command.ExecuteReader()
                reader.Read()

                Dim teacher_id As String = reader.GetString(0)
                Dim first_name As String = reader.GetString(1)
                Dim last_name As String = reader.GetString(2)
                Dim birthday As Integer = reader.GetDateTime(3).Year
                Dim current_year As Integer = DateTime.Now.Year
                Dim course_college As String = reader.GetString(4)
                Dim school_college As String = reader.GetString(5)
                Dim background As String = reader.GetString(6)

                FacultyTeacherId.Text = teacher_id
                FacultyTeacherName.Text = $"My name is {first_name} {last_name}"
                FacultyTeacherAge.Text = $"I am {current_year - birthday} years old"
                FacultyTeacherBackground.Text = $"{course_college}/{school_college}"
                FacultyTeacherLines.Text = background
                Dim column_name As String = "display_photo"
                Dim table_name As String = "teachers_login"
                Dim condition As String = "teacher_id"


                reader.Close()
                get_display_picture(FacultyTeacherPicturebox, column_name, table_name, condition, FacultyTeacherId.Text)
                con.Close()
            End If
        Next
    End Sub

    Private Sub FacultyDepartmentCombobox_DropDown(sender As Object, e As EventArgs) Handles FacultyDepartmentCombobox.DropDown
        FacultyDepartmentCombobox.Items.Clear()
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT DISTINCT(department) FROM teachers_information", con)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                FacultyDepartmentCombobox.Items.Add(reader("department"))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    'Grades Curriculum Button Functions
    Private Sub GradesCurriculumFunctions()
        MyProfilePanel.Visible = True
        FacultyPanel.Visible = True
        GradesCurriculumPanel.Visible = True

        CaptionPanel.Visible = True
        TitleBar.Text = GradesCurriculumButton.Text
        CaptionLabel.Text = GradesCurriculumButton.Text

        GradesCurriculumStudentID.Text = StudentID.Text
        GradesCurriculumStudentName.Text = StudentsName.Text
        GetGradeCurriculum("student_id", "course", StudentID.Text, StudentsCourse.Text)

        GradesCurriculumSchoolLogo.Image = OCLogo
        GradesCurriculumCredentialLabel.Text = GradesCurriculumCredential
    End Sub

    Private Sub GradesCurriculumButton_Click(sender As Object, e As EventArgs) Handles GradesCurriculumButton.Click
        GradesCurriculumFunctions()
    End Sub

    Private Sub ViewDetailsGradesCurriculum_Click(sender As Object, e As EventArgs) Handles ViewDetailsGradesCurriculum.Click
        GradesCurriculumFunctions()
    End Sub

    Private Sub GradesCurriculumPicturebox_Click(sender As Object, e As EventArgs) Handles GradesCurriculumPicturebox.Click
        GradesCurriculumFunctions()
    End Sub

    'Show All Button
    Private Sub GradesCurriculumShowAllButton_Click(sender As Object, e As EventArgs) Handles GradesCurriculumShowAllButton.Click
        GetGradeCurriculum("student_id", "course", StudentID.Text, StudentsCourse.Text)
    End Sub

    Private Sub GetGradeCurriculum(ByRef condition1 As String, condition2 As String, identifier1 As String, identifier2 As String)
        If con.State = ConnectionState.Closed Then con.Open()

        Dim command As New SqlCommand($"SELECT subject_codename, description, total_average FROM students_grade_curicullum WHERE {condition1} = @{condition1} AND {condition2} = @{condition2}", con)
        command.Parameters.AddWithValue(condition1, identifier1)
        command.Parameters.AddWithValue(condition2, identifier2)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView2.DataSource = table
        con.Close()

        GetTotalGwa()
    End Sub

    Private Sub GetTotalGwa()
        Dim total As String = 0
        Dim counter As Integer = 0
        For Each rows As DataGridViewRow In DataGridView2.Rows
            If rows IsNot Nothing AndAlso Not rows.IsNewRow Then
                Dim MyGrades As String = rows.Cells(2).Value.ToString()
                Dim floatMyGrades As Single
                floatMyGrades = Single.Parse(MyGrades)
                total += floatMyGrades
                counter += 1
            End If
        Next
        Dim average As Single = total / counter
        Dim RoundedOffAverage As Single = Math.Round(average, 2)
        Dim StringAverage As String

        If RoundedOffAverage = 1 Or RoundedOffAverage = 2 Or RoundedOffAverage = 3 Or RoundedOffAverage = 4 Or RoundedOffAverage = 5 Or RoundedOffAverage = 6 Then
            RoundedOffAverage = RoundedOffAverage.ToString()
            StringAverage = $"{RoundedOffAverage}.00"
        ElseIf RoundedOffAverage = 1.5 Or RoundedOffAverage = 2.5 Or RoundedOffAverage = 3.5 Or RoundedOffAverage = 4.5 Or RoundedOffAverage = 5.5 Or RoundedOffAverage = 6.5 Then
            RoundedOffAverage = RoundedOffAverage.ToString()
            StringAverage = $"{RoundedOffAverage}0"
        Else
            StringAverage = RoundedOffAverage
        End If
        If Not Single.IsNaN(StringAverage) Then
            GradesCurriculumTotalGwa.Text = StringAverage
        Else
            GradesCurriculumTotalGwa.Text = 0
        End If
    End Sub

    Private Sub GetYearSem(ByRef combobox As ComboBox, column_name As String)
        combobox.Items.Clear()

        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand($"SELECT DISTINCT {column_name} FROM students_grade_curicullum WHERE student_id = @student_id", con)
        command.Parameters.AddWithValue("student_id", StudentID.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                combobox.Items.Add(reader(column_name.ToString()))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub GradesCurriculumYearLevelCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles GradesCurriculumYearLevelCombobox.SelectedValueChanged
        GetGradeCurriculum("year_level", "semester", GradesCurriculumYearLevelCombobox.Text, GradesCurriculumSemesterCombobox.Text)
    End Sub

    Private Sub GradesCurriculumSemesterCombobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles GradesCurriculumSemesterCombobox.SelectedValueChanged
        GetGradeCurriculum("year_level", "semester", GradesCurriculumSemesterCombobox.Text, GradesCurriculumYearLevelCombobox.Text)
    End Sub

    Private Sub GradesCurriculumYearLevelCombobox_DropDown(sender As Object, e As EventArgs) Handles GradesCurriculumYearLevelCombobox.DropDown
        GetYearSem(GradesCurriculumYearLevelCombobox, "year_level")
    End Sub

    Private Sub GradesCurriculumSemesterCombobox_DropDown(sender As Object, e As EventArgs) Handles GradesCurriculumSemesterCombobox.DropDown
        GetYearSem(GradesCurriculumSemesterCombobox, "semester")
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