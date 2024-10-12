Imports System.Data.SqlClient

Public Class StudentAccessForm
    Dim drag As Boolean
    Dim mousex As Integer,
        mousey As Integer

    'Global Variable OC Logo
    Dim ÒsmenaLogo As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\OCLogo.png")

    'Establish Connection
    Dim con As New SqlConnection("Data Source=Sys1\SQLEXPRESS;Initial Catalog=OsmenaProjects;Integrated Security=True")

    Private Sub StudentAccessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ÒsmenaLogo
    End Sub

    'Close Button
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Form1.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "•"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub

    'Login Button
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim my_pass As New Password()
            If con.State = ConnectionState.Closed Then con.Open()
            Dim query As New SqlCommand("SELECT * FROM login_users WHERE username=@username AND password = @password", con)
            query.Parameters.Add("username", SqlDbType.VarChar).Value = TextBox1.Text
            query.Parameters.Add("password", SqlDbType.VarChar).Value = my_pass.Encrypt(TextBox2.Text)

            Dim adapter As New SqlDataAdapter(query)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                UserNotFound()
            Else
                Dim reader As SqlDataReader = query.ExecuteReader()
                reader.Read()

                Dim user As Boolean = reader.GetString(1).Equals(TextBox1.Text)
                Dim pass As Boolean = reader.GetString(2).Equals(my_pass.Encrypt(TextBox2.Text))
                If user And pass Then
                    MessageBox.Show($"Welcome {TextBox1.Text.Trim()}!", "Hello User!")
                    My.Settings.IsLoggedIn = True
                    My.Settings.Save()
                    MainForm.Show()
                    Me.Dispose()
                Else
                    UserNotFound()
                End If
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show($"All fields are required", "Invalid input")
        End Try
    End Sub

    Private Sub UserNotFound()
        MessageBox.Show("Username or password is incorrect", "Login Failed")
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    'Verification
    Private Sub VerificationLabal_Click(sender As Object, e As EventArgs) Handles VerificationLabal.Click
        Me.Close()
        VerificationForm.Show()
    End Sub

    ' Functions for moving unsizable form
    Private Sub StudentAccessForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub StudentAccessForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub StudentAccessForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
End Class