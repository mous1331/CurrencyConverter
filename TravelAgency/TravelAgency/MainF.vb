Public Class MainF

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' When Form is loading, These Labels/Buttons/TextBoxes/Comboboxes are hidden
        lbPass.Visible = False
        lbUser.Visible = False
        tbPass.Visible = False
        tbUser.Visible = False
        btLogin.Visible = False
        tbAmount.Visible = False
        btConvert2.Visible = False
        cbCurrency3.Visible = False



    End Sub
    Private Sub MainF_Close(sender As Object, e As EventArgs) Handles MyBase.Closing ' When I close the form, the whole program closes.
        Application.Exit()
    End Sub
    Dim c As Double
    Dim c2 As Double
    Private Sub btConvert2_Click(sender As Object, e As EventArgs) Handles btConvert2.Click ' This handles the Rate Exchanger that the admin has access to

        If cbCurrency3.SelectedIndex = 1 Then
            lbe.Text = tbAmount.Text
            MsgBox("Euro To Pound Rate Has Changed To:  €1 = £" & tbAmount.Text)
        ElseIf cbCurrency3.SelectedIndex = 0 Then

            lbp.Text = tbAmount.Text
            MsgBox("Pound To Euro Rate Has Changed To: £1 = €" & tbAmount.Text)
        End If



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' This handles the Currency Exchange

        c = TextBox1.Text * lbp.Text ' Pound To Euro Rate 
        c2 = TextBox1.Text * lbe.Text ' Euro To Pound Rate


        If cbCurrency1.SelectedIndex = 0 And cbCurrency2.SelectedIndex = 1 Then ' If Euro And Pound Is Selected Then Execute Below 
            MsgBox("The Converted Money Will Be: £" & c2)
        ElseIf cbCurrency1.SelectedIndex = 1 And cbCurrency2.SelectedIndex = 0 Then ' If Pound And Euro Is Selected Then Execute Below
            MsgBox("The Converted Money Will Be: €" & c)
        ElseIf cbCurrency1.SelectedIndex = 1 And cbCurrency2.SelectedIndex = 1 Then ' If Euro And Euro Is Selected Then Execute Below
            MsgBox("Can't Convert Same Currency")
        ElseIf cbCurrency1.SelectedIndex = 0 And cbCurrency2.SelectedIndex = 0 Then ' If Pound And Pound Is Selected Then Execute Below
            MsgBox("Can't Convert Same Currency")

        End If




    End Sub

    Private Sub btAdmin_Click(sender As Object, e As EventArgs) Handles btAdmin.Click 'This handles the Administrator Button that displays the  login boxes.
        btAdmin.Visible = False
        lbPass.Visible = True
        lbUser.Visible = True
        tbPass.Visible = True
        tbUser.Visible = True
        btLogin.Visible = True

    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click ' This is where you can input the admin user & pass so you can then use the Rate Changer.
        Dim User As String = ""
        Dim Pass As String = ""
        User = tbUser.Text
        Pass = tbPass.Text

        If User = "Admin" And Pass = "admin123" Then ' If Inputted User & Pass Is Correct Then Proceed With Below Code.
            MsgBox("Admin Logged In.")
            lbPass.Visible = False
            lbUser.Visible = False
            tbPass.Visible = False
            tbUser.Visible = False
            btLogin.Visible = False
            tbAmount.Visible = True
            btConvert2.Visible = True
            cbCurrency3.Visible = True
        Else
            MsgBox("Incorrect Admin Details, Try Again.")
        End If

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, tbAmount.KeyPress ' This makes it so only numbers can be inputted into the Amounts Textbox

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True


            End If
        End If

    End Sub


    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick ' This puts an icon on the notification bar.
        Me.Activate()
        Me.BringToFront()
        Me.Focus()
        Me.Show()
    End Sub

    Private Sub SimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleToolStripMenuItem.Click ' This is to change the background to black
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.BackgroundImage.Dispose()
        Me.BackgroundImage = Nothing

    End Sub

    Private Sub WallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WallToolStripMenuItem.Click ' This changes the background to a nice walled background.
        Me.BackgroundImage = My.Resources.mfbg
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup ' This is for the Tool Tips

    End Sub


End Class