<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        TxtIdentifier = New Label()
        PercentageLabel = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(794, 666)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(260, 10)
        ProgressBar1.TabIndex = 0
        ' 
        ' TxtIdentifier
        ' 
        TxtIdentifier.AutoSize = True
        TxtIdentifier.BackColor = Color.Transparent
        TxtIdentifier.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtIdentifier.ForeColor = Color.White
        TxtIdentifier.Location = New Point(789, 643)
        TxtIdentifier.Name = "TxtIdentifier"
        TxtIdentifier.Size = New Size(118, 19)
        TxtIdentifier.TabIndex = 1
        TxtIdentifier.Text = "Please Wait..."
        ' 
        ' PercentageLabel
        ' 
        PercentageLabel.AutoSize = True
        PercentageLabel.BackColor = Color.Transparent
        PercentageLabel.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        PercentageLabel.ForeColor = Color.White
        PercentageLabel.Location = New Point(1015, 641)
        PercentageLabel.Name = "PercentageLabel"
        PercentageLabel.Size = New Size(35, 22)
        PercentageLabel.TabIndex = 2
        PercentageLabel.Text = "0%"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 714)
        Controls.Add(PercentageLabel)
        Controls.Add(TxtIdentifier)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TxtIdentifier As Label
    Friend WithEvents PercentageLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
