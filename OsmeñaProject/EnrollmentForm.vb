Imports System.Data.SqlClient

Public Class EnrollmentForm
    Dim drag As Boolean
    Dim mousex As Integer,
        mousey As Integer

    'Global Variable Background
    Dim OCBackground As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCEnrollmentBG.png")
    Dim OCLogo As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCLogo.png")

    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Dim con As New SqlConnection("Data Source=Sys1\SQLEXPRESS;Initial Catalog=OsmenaProjects;Integrated Security=True")

    Private Sub EnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = OCBackground
        LogoPicture.Image = OCLogo
        LogoPicture.SizeMode = PictureBoxSizeMode.StretchImage

        YearLevelCombo.DropDownStyle = ComboBoxStyle.DropDownList
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("SELECT student_id, last_name, first_name, middle_name, ext, gender, department, course, year_level, student_email, phone_number, address, permanent_address, birthday, birth_place, fb_account, fathers_name, fathers_fb_account, fathers_contact_num, mother_maiden_name, mother_fb_account, mother_contact_num, year FROM student_information WHERE student_id = @student_id", con)
        command.Parameters.AddWithValue("student_id", MainForm.StudentID.Text)

        Dim reader As SqlDataReader = command.ExecuteReader()
        reader.Read()

        Dim student_id As Integer = reader.GetInt32(0)
        Dim last_name As String = reader.GetString(1)
        Dim first_name As String = reader.GetString(2)
        Dim middle_name As String = reader.GetString(3)
        Dim ext As String = reader.GetString(4)
        Dim gender As String = reader.GetString(5)
        Dim department As String = reader.GetString(6)
        Dim course As String = reader.GetString(7)
        Dim year_level As Integer = reader.GetInt32(8)
        Dim student_email As String = reader.GetString(9)
        Dim phone_number As String = reader.GetString(10)
        Dim address As String = reader.GetString(11)
        Dim permanent_address As String = reader.GetString(12)
        Dim birthday As Date = reader.GetDateTime(13)
        Dim birth_place As String = reader.GetString(14)
        Dim fb_account As String = reader.GetString(15)
        Dim fathers_name As String = reader.GetString(16)
        Dim fathers_fb_account As String = reader.GetString(17)
        Dim fathers_contact_num As String = reader.GetString(18)
        Dim mother_maiden As String = reader.GetString(19)
        Dim mother_fb_account As String = reader.GetString(20)
        Dim mother_contact_num As String = reader.GetString(21)
        Dim year As Integer = reader.GetInt32(22)

        SchoolYearTxtbox.Text = year & " - " & year + 1
        StudentIDNumTxtbox.Text = student_id
        LastNameTxtbox.Text = last_name
        FirstNameTxtbox.Text = first_name
        MiddleNameTxtbox.Text = middle_name
        ExtTxtbox.Text = ext
        DepartmentCombo.Text = department
        CourseCombo.Text = course
        YearLevelCombo.Text = year_level
        DateTimePicker1.Text = birthday
        BirthplaceTxtbox.Text = birth_place
        GenderTxtbox.Text = gender
        PhoneNoTxtBox.Text = phone_number
        EmailTxtbox.Text = student_email
        MCAddress.Text = address
        FBAccountTxtbox.Text = fb_account
        FathersNameTxtbox.Text = fathers_name
        FathersFbAccountTxtbox.Text = fathers_fb_account
        FathersPhoneNo.Text = fathers_contact_num
        MothersNameTxtbox.Text = mother_maiden
        MothersFbAccountTxtbox.Text = mother_fb_account
        MothersPhoneNoTxtbox.Text = mother_contact_num
        PermanentAddressTxtbox.Text = permanent_address
        reader.Close()
        con.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If GenderTxtbox.Text <> "" And EmailTxtbox.TextLength > 0 And MCAddress.TextLength > 0 And FBAccountTxtbox.TextLength > 0 And FathersFbAccountTxtbox.TextLength > 0 And MothersFbAccountTxtbox.TextLength > 0 And PermanentAddressTxtbox.TextLength > 0 Then
            If PhoneNoTxtBox.TextLength = 11 And FathersPhoneNo.TextLength = 11 And MothersPhoneNoTxtbox.TextLength = 11 Then
                If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton1.Checked Then

                    g = CreateGraphics()
                    bmp = New Bitmap(Size.Width, Size.Height, g)
                    mg = Graphics.FromImage(bmp)
                    mg.CopyFromScreen(Location.X, Location.Y, 1, 0, Size)
                    PrintPreviewDialog1.ShowDialog()
                    UpdateStudentInfo()
                    Me.Dispose()
                Else
                    MessageBox.Show("Choose semester!", "Invalid Input")
                End If
            Else
                MessageBox.Show("Phone number is not valid!", "Invalid Input")
            End If
        Else
            MessageBox.Show("All fields are required!", "Error")
        End If
    End Sub

    Sub UpdateStudentInfo()
        Dim status As String = "PENDING"
        If con.State = ConnectionState.Closed Then con.Open()
        Dim command As New SqlCommand("UPDATE student_information SET department=@department, course=@course, year_level=@year_level, phone_number=@phone_number, student_email=@student_email, address=@address, fb_account=@fb_account, fathers_fb_account=@fathers_fb_account, fathers_contact_num=@fathers_contact_num, mother_fb_account=@mother_fb_account, mother_contact_num=@mother_contact_num, status=@status WHERE student_id=@student_id", con)
        command.Parameters.AddWithValue("student_id", MainForm.StudentID.Text)
        command.Parameters.AddWithValue("department", DepartmentCombo.Text)
        command.Parameters.AddWithValue("course", CourseCombo.Text)
        command.Parameters.AddWithValue("year_level", YearLevelCombo.Text)
        command.Parameters.AddWithValue("phone_number", PhoneNoTxtBox.Text)
        command.Parameters.AddWithValue("student_email", EmailTxtbox.Text)
        command.Parameters.AddWithValue("address", MCAddress.Text)
        command.Parameters.AddWithValue("fb_account", FBAccountTxtbox.Text)
        command.Parameters.AddWithValue("fathers_fb_account", FathersFbAccountTxtbox.Text)
        command.Parameters.AddWithValue("fathers_contact_num", FathersPhoneNo.Text)
        command.Parameters.AddWithValue("mother_fb_account", MothersFbAccountTxtbox.Text)
        command.Parameters.AddWithValue("mother_contact_num", MothersPhoneNoTxtbox.Text)
        command.Parameters.AddWithValue("status", status)

        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show("Step 1: Print this form
Step 2: Pay directly to the cashier
Step 3: Submit this form to the MIS section and show your receipt
Step 4: Wait for the text confirmation and You're now officially ENROLLED!", "Enrollment steps")
        End If
    End Sub

    Private Sub ConfirmationChkbox_CheckedChanged(sender As Object, e As EventArgs) Handles ConfirmationChkbox.CheckedChanged
        If ConfirmationChkbox.Checked Then
            PrintButton.Enabled = True
        Else
            PrintButton.Enabled = False
        End If
    End Sub

    Private Sub DepartmentCombo_SelectedValueChanged(sender As Object, e As EventArgs) Handles DepartmentCombo.SelectedValueChanged
        CourseCombo.Items.Clear()
        If DepartmentCombo.Text = "CABA" Then
            CourseCombo.Items.Add("BSBA-FM")
            CourseCombo.Items.Add("BSMA")
        End If
        If DepartmentCombo.Text = "CSIT" Then CourseCombo.Items.Add("BSCS")
        If DepartmentCombo.Text = "CHRM/HM" Then CourseCombo.Items.Add("HRM")
        If DepartmentCombo.Text = "CTE" Then
            CourseCombo.Items.Add("BSED-Eng")
            CourseCombo.Items.Add("BSED-Math")
            CourseCombo.Items.Add("BSED-Fil")
            CourseCombo.Items.Add("BEED")
        End If
        If DepartmentCombo.Text = "CCJE" Then CourseCombo.Items.Add("BSCrim")
    End Sub

    Private Sub DepartmentCombo_DropDown(sender As Object, e As EventArgs) Handles DepartmentCombo.DropDown
        DepartmentCombo.Text = ""
    End Sub

    Private Sub CourseCombo_DropDown(sender As Object, e As EventArgs) Handles CourseCombo.DropDown
        CourseCombo.Text = ""
    End Sub

    'Close this Form
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    ' Functions for moving unsizable form
    Private Sub EnrollmentForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub EnrollmentForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub EnrollmentForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
End Class