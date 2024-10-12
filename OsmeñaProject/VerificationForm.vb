Imports System.Data.SqlClient

Public Class VerificationForm
    Dim drag As Boolean
    Dim mousex As Integer,
        mousey As Integer

    'OC Backgrounds                 
    Dim OCBackImage As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCEnrollmentBG.png")
    Dim OCGroupboxBGImage As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCGroupboxBGImage.png")
    Dim OCLogo As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCLogo.png")

    Dim SchoolNameOc As String = "OSMEÑA COLLEGES"
    Dim SchoolAddressOc As String = "Osmeña St. Masbate City, 5400, Philippines"
    Dim SchoolEmailOc As String = "osmenacolleges@yahoo.com.ph"
    Dim SchoolContactNumOc As String = "(056) 333-2778; (056) 333-444"

    'Establish connection
    Dim con As New SqlConnection("Data Source=Sys1\SQLEXPRESS;Initial Catalog=OsmenaProjects;Integrated Security=True")
    Private Sub VerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = OCBackImage
        GroupBox1.BackgroundImage = OCGroupboxBGImage
        SchoolLogoPicturebox.Image = OCLogo

        SchoolName.Text = SchoolNameOc
        SchoolAddress.Text = SchoolAddressOc
        SchoolEmail.Text = SchoolEmailOc
        SchoolContactNumber.Text = SchoolContactNumOc
    End Sub

    'Close Button
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Form1.Close()
    End Sub

    'Back Button
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        StudentAccessForm.Show()
    End Sub

    Private Sub CourseCombobox_DropDown(sender As Object, e As EventArgs) Handles CourseCombobox.DropDown
        CourseCombobox.Items.Clear()
        If DepartmentCombobox.Text = "CABA" Then
            CourseCombobox.Items.Add("BSBA-FM")
            CourseCombobox.Items.Add("BSMA")
        End If
        If DepartmentCombobox.Text = "CSIT" Then CourseCombobox.Items.Add("BSCS")
        If DepartmentCombobox.Text = "CHRM/HM" Then CourseCombobox.Items.Add("HRM")
        If DepartmentCombobox.Text = "CTE" Then
            CourseCombobox.Items.Add("BSED-Eng")
            CourseCombobox.Items.Add("BSED-Math")
            CourseCombobox.Items.Add("BSED-Fil")
            CourseCombobox.Items.Add("BEED")
        End If
        If DepartmentCombobox.Text = "CCJE" Then CourseCombobox.Items.Add("BSCrim")
    End Sub

    ' Next Button
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        'RegistrationForm.PictureBox1.Image = My.Resources.facebook_default_no_profile_pic
        'RegistrationForm.TextBox1.Clear()
        'RegistrationForm.TextBox2.Clear()
        'RegistrationForm.TextBox3.Clear()
        Dim check_credentials As String = StudentIDTextbox.Text.Trim()
        If LastNameTextbox.TextLength > 0 And FirstNameTextbox.TextLength > 0 And GenderCombobox.Text <> "Please Select" And DepartmentCombobox.Text <> "Please Select" And CourseCombobox.Text <> "Please Select" And YearLevelCombobox.Text <> "" And StudentIDTextbox.TextLength > 0 Then
            If check_credentials <> "" Then
                Dim data_exist As Boolean = False
                dataExist(data_exist)
                CheckAccount(data_exist)
            End If
        Else
            MessageBox.Show("All fields are required", "Empty fields")
        End If
    End Sub

    'Query checking for student's account
    Private Sub dataExist(ByRef data_exist As Boolean)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Dim command As New SqlCommand("SELECT COUNT(student_id) FROM login_users WHERE student_id = @student_id", con)
            command.Parameters.Add("student_id", SqlDbType.VarChar).Value = StudentIDTextbox.Text
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            If count > 0 Then
                data_exist = True
            End If
            con.Close()
        Catch ex As Exception
            MsgBox($"Please input your valid student ID!")
        End Try
    End Sub

    Private Sub CheckAccount(ByRef data_exist As Boolean)
        If data_exist Then
            Dim message As DialogResult = MessageBox.Show("You have already an account!", "Oops")
            If message = DialogResult.OK Then
                Me.Close()
                StudentAccessForm.Show()
            End If
        Else
            student_verification(StudentIDTextbox, LastNameTextbox, FirstNameTextbox, MiddleNameTextbox, ExtTextbox, GenderCombobox, DepartmentCombobox, CourseCombobox, YearLevelCombobox, BirthdayDateTimePicker)
        End If
    End Sub

    ' Check if user was enrolled as student
    Private Sub student_verification(ByRef student_id As TextBox, last_name As TextBox, first_name As TextBox, middle_name As TextBox, ext As TextBox, gender As ComboBox, department As ComboBox, course As ComboBox, year_level As ComboBox, birthday As DateTimePicker)
        Try
            Dim query As New SqlCommand("SELECT * FROM student_information WHERE student_id=@student_id AND last_name=@last_name AND first_name=@first_name AND middle_name=@middle_name AND ext=@ext AND gender=@gender AND department=@department AND course=@course AND year_level=@year_level AND birthday=@birthday", con)

            query.Parameters.Add("student_id", SqlDbType.Int).Value = student_id.Text
            query.Parameters.Add("last_name", SqlDbType.VarChar).Value = last_name.Text
            query.Parameters.Add("first_name", SqlDbType.VarChar).Value = first_name.Text
            query.Parameters.Add("middle_name", SqlDbType.VarChar).Value = middle_name.Text
            query.Parameters.Add("ext", SqlDbType.VarChar).Value = ext.Text
            query.Parameters.Add("gender", SqlDbType.VarChar).Value = gender.Text
            query.Parameters.Add("department", SqlDbType.VarChar).Value = department.Text
            query.Parameters.Add("course", SqlDbType.VarChar).Value = course.Text
            query.Parameters.Add("year_level", SqlDbType.Int).Value = year_level.Text
            query.Parameters.Add("birthday", SqlDbType.Date).Value = birthday.Value

            Dim adapter As New SqlDataAdapter(query)
            Dim table As New DataTable()
            adapter.Fill(table)
            If con.State = ConnectionState.Closed Then con.Open()
            NewTable(table)
            con.Close()
        Catch ex As Exception
            MsgBox("No Student ID found")
        End Try
    End Sub

    Private Sub NewTable(ByRef table As DataTable)
        If table.Rows.Count = 0 Then
            MessageBox.Show("Student not found", "Unregistered")
        Else
            MessageBox.Show("Student found", "Verified")
            RegistrationForm.Show()
            Me.Hide()
        End If
        If con.State = ConnectionState.Open Then con.Close()
    End Sub

    'New Student
    Private Sub IsNewStudent_Click(sender As Object, e As EventArgs) Handles IsNewStudent.Click
        MessageBox.Show("Step 1: Go to the MIS section located at the main building
Step 2: Get an enrollment form
Step 3: Fill out the form and pay to the cashier
Step 4: Use this app to verify if you are now ENROLLED!", "Greetings newbie!")
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