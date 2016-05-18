Imports System.Data
Public Class load


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' Code below is executed while form is loading.
        ProgressBar1.Minimum = 1
        ProgressBar1.Maximum = 10
        Label1.Visible = True
        ProgressBar1.Visible = True
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick ' This is a timer for the progress bar.



        ProgressBar1.Value += 1
        If ProgressBar1.Value = 2 Then
            Label1.Text = "Loading Terry's Travels"
        ElseIf ProgressBar1.Value = 5 Then
            Label1.Text = "Loading Currency Rates"
        ElseIf ProgressBar1.Value = 10 Then
            Label1.Text = "Program Loaded"
            Timer1.Stop()
            Me.Hide()
            MainF.Show()

        End If


    End Sub



End Class
