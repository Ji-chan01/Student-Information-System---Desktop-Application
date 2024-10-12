Imports System.Data.SqlClient
Imports System.IO

Public Class RegistrationForm
    Dim drag As Boolean
    Dim mousex As Integer,
        mousey As Integer

    'OC Background and logos
    Dim OCBackground As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCEnrollmentBG.png")
    Dim OCLogo As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCLogo.png")

    'Establish connection
    Dim con As New SqlConnection("Data Source=Sys1\SQLEXPRESS;Initial Catalog=OsmenaProjects;Integrated Security=True")

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = OCBackground
        SchoolLogoPicturebox.Image = OCLogo
    End Sub

    'Browse Image Button
    Private Sub BrowseImageButton_Click(sender As Object, e As EventArgs) Handles BrowseImageButton.Click
        open_file_dialog(OpenFileDialog1)
    End Sub

    'Profile Picture Clicked
    Private Sub UserNewProfilePicturebox_Click(sender As Object, e As EventArgs) Handles UserNewProfilePicturebox.Click
        open_file_dialog(OpenFileDialog1)
    End Sub

    Private Sub open_file_dialog(ByRef file_dialog As OpenFileDialog)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            UserNewProfilePicturebox.Image = My.Resources.facebook_default_no_profile_pic
            UserNewProfilePicturebox.Image = Image.FromFile(file_dialog.FileName)
        End If
    End Sub

    'Create Account Button
    Private Sub CreateAccountButton_Click(sender As Object, e As EventArgs) Handles CreateAccountButton.Click
        Dim check_credentials As String = UsernameTextbox.Text.Trim()
        If check_credentials <> "" Then
            Try
                IsDataExist(UsernameTextbox)
            Catch ex As Exception
                MessageBox.Show("Error checking data: " & ex.Message)
            End Try
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
            check_username_and_pass_length(UsernameTextbox, PasswordTextbox, ConfirmPasswordTextbox)
        End If
    End Sub

    ' Check if username and password is short or long
    Private Sub check_username_and_pass_length(ByRef username As TextBox, ByRef password As TextBox, ByRef confirm_pass As TextBox)
        If username.TextLength >= 4 And username.TextLength <= 8 Then
            If password.TextLength >= 6 Then
                If password.Text = confirm_pass.Text Then
                    insertNewUser(VerificationForm.FirstNameTextbox, VerificationForm.LastNameTextbox, VerificationForm.DepartmentCombobox, VerificationForm.CourseCombobox, VerificationForm.YearLevelCombobox, UsernameTextbox, PasswordTextbox, VerificationForm.StudentIDTextbox)
                Else
                    MessageBox.Show("Password do not match", "Registration Failed")
                End If
            Else
                MessageBox.Show("Password too short!", "Registration Failed")
            End If
        Else
            MessageBox.Show("Username must be greater than 5 characters and not greater than 10 characters long!", "Registration Failed")
        End If
    End Sub

    ' Inserting new account to the database
    Private Sub insertNewUser(ByRef first_name As TextBox, last_name As TextBox, department As ComboBox, course As ComboBox, year_level As ComboBox, username As TextBox, password As TextBox, student_id As TextBox)
        Dim my_pass As New Password()
        Dim void As String = ""
        Dim command As New SqlCommand("INSERT INTO login_users (display_photo, username, password, student_id, bio) VALUES (@display_photo, @username, @password, @student_id, @bio)", con)

        command.Parameters.Add("username", SqlDbType.VarChar).Value = username.Text
        command.Parameters.Add("password", SqlDbType.VarChar).Value = my_pass.Encrypt(password.Text)
        command.Parameters.Add("student_id", SqlDbType.VarChar).Value = student_id.Text
        command.Parameters.Add("bio", SqlDbType.VarChar).Value = void

        Dim command2 As New SqlCommand("UPDATE student_information SET gwa=@gwa, attendance=@attendance, username=@username WHERE student_id=@student_id", con)
        command2.Parameters.Add("gwa", SqlDbType.VarChar).Value = void
        command2.Parameters.Add("attendance", SqlDbType.VarChar).Value = void
        command2.Parameters.Add("username", SqlDbType.VarChar).Value = username.Text
        command2.Parameters.Add("student_id", SqlDbType.VarChar).Value = student_id.Text

        Dim memory As New MemoryStream()
        Dim image As New Bitmap(UserNewProfilePicturebox.Image)

        image.Save(memory, Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = memory.GetBuffer()
        Dim dp As New SqlParameter("display_photo", SqlDbType.Image) With {
            .Value = data
        }
        command.Parameters.Add(dp)

        If con.State = ConnectionState.Closed Then con.Open()
        If command.ExecuteNonQuery = 1 And command2.ExecuteNonQuery = 1 Then
            MessageBox.Show("You are now registered!", "Registration Complete")
            Me.Dispose()
            VerificationForm.Dispose()
            StudentAccessForm.Show()
        End If
        con.Close()
    End Sub

    'Close Button
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Form1.Close()
    End Sub

    ' Functions for moving unsizable form
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
End Class