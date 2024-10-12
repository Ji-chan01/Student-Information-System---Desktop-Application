Imports System.Diagnostics.Metrics

Public Class Form1
    Dim OsmenaBackground As Image = Image.FromFile("C:\Users\Asus\source\repos\OsmeñaProject\OsmeñaProject\Resources\WelcomeToOsmeñaBackground.png")
    Dim counter As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = OsmenaBackground
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Counter += 2
        ProgressBar1.Increment(2)
        PercentageLabel.Text = Counter & "%"
        If Counter = 50 Then TxtIdentifier.Text = "Preparing database..."
        If counter = 70 Then TxtIdentifier.Text = "Almost done..."
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            If My.Settings.IsLoggedIn Then
                MainForm.Show()
            Else
                StudentAccessForm.Show()
            End If
            Me.Hide()
        End If
        Timer1.Interval = 70
    End Sub
End Class
