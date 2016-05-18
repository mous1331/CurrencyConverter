<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainF
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        Me.cbCurrency1 = New System.Windows.Forms.ComboBox()
        Me.cbCurrency2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btAdmin = New System.Windows.Forms.Button()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.cbCurrency3 = New System.Windows.Forms.ComboBox()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.btConvert2 = New System.Windows.Forms.Button()
        Me.lbp = New System.Windows.Forms.Label()
        Me.lbe = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCurrency1
        '
        Me.cbCurrency1.FormattingEnabled = True
        Me.cbCurrency1.Items.AddRange(New Object() {"Euro", "Pound"})
        Me.cbCurrency1.Location = New System.Drawing.Point(59, 196)
        Me.cbCurrency1.Name = "cbCurrency1"
        Me.cbCurrency1.Size = New System.Drawing.Size(121, 21)
        Me.cbCurrency1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cbCurrency1, "Choose A Currency ")
        '
        'cbCurrency2
        '
        Me.cbCurrency2.FormattingEnabled = True
        Me.cbCurrency2.Items.AddRange(New Object() {"Euro", "Pound"})
        Me.cbCurrency2.Location = New System.Drawing.Point(288, 196)
        Me.cbCurrency2.Name = "cbCurrency2"
        Me.cbCurrency2.Size = New System.Drawing.Size(121, 21)
        Me.cbCurrency2.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbCurrency2, "Choose a Currency")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Convert"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click To Convert")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 243)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 20)
        Me.TextBox1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Type In Money")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(179, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Convert To"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 6
        '
        'btAdmin
        '
        Me.btAdmin.Location = New System.Drawing.Point(533, 31)
        Me.btAdmin.Name = "btAdmin"
        Me.btAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btAdmin.TabIndex = 7
        Me.btAdmin.Text = "Admin"
        Me.ToolTip1.SetToolTip(Me.btAdmin, "Click To Get To Admin Login")
        Me.btAdmin.UseVisualStyleBackColor = True
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(83, 34)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(107, 20)
        Me.tbUser.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.tbUser, "Type In Username")
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(83, 60)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(107, 20)
        Me.tbPass.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.tbPass, "Type In Password")
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(196, 44)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 11
        Me.btLogin.Text = "Login"
        Me.ToolTip1.SetToolTip(Me.btLogin, "Click To Login")
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.BackColor = System.Drawing.Color.DimGray
        Me.lbUser.Location = New System.Drawing.Point(20, 36)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(29, 13)
        Me.lbUser.TabIndex = 12
        Me.lbUser.Text = "User"
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.BackColor = System.Drawing.Color.DimGray
        Me.lbPass.Location = New System.Drawing.Point(20, 63)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(30, 13)
        Me.lbPass.TabIndex = 13
        Me.lbPass.Text = "Pass"
        '
        'cbCurrency3
        '
        Me.cbCurrency3.FormattingEnabled = True
        Me.cbCurrency3.Items.AddRange(New Object() {"Euro", "Pound"})
        Me.cbCurrency3.Location = New System.Drawing.Point(37, 424)
        Me.cbCurrency3.Name = "cbCurrency3"
        Me.cbCurrency3.Size = New System.Drawing.Size(121, 21)
        Me.cbCurrency3.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.cbCurrency3, "Use To Select Currency To Change")
        '
        'tbAmount
        '
        Me.tbAmount.Location = New System.Drawing.Point(164, 425)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(107, 20)
        Me.tbAmount.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.tbAmount, "Rate Amount")
        '
        'btConvert2
        '
        Me.btConvert2.Location = New System.Drawing.Point(277, 422)
        Me.btConvert2.Name = "btConvert2"
        Me.btConvert2.Size = New System.Drawing.Size(75, 23)
        Me.btConvert2.TabIndex = 16
        Me.btConvert2.Text = "Convert"
        Me.ToolTip1.SetToolTip(Me.btConvert2, "Click To Convert")
        Me.btConvert2.UseVisualStyleBackColor = True
        '
        'lbp
        '
        Me.lbp.AutoSize = True
        Me.lbp.Location = New System.Drawing.Point(370, 88)
        Me.lbp.Name = "lbp"
        Me.lbp.Size = New System.Drawing.Size(46, 13)
        Me.lbp.TabIndex = 17
        Me.lbp.Text = "1.27656"
        Me.lbp.Visible = False
        '
        'lbe
        '
        Me.lbe.AutoSize = True
        Me.lbe.Location = New System.Drawing.Point(415, 88)
        Me.lbe.Name = "lbe"
        Me.lbe.Size = New System.Drawing.Size(52, 13)
        Me.lbe.TabIndex = 18
        Me.lbe.Text = "0.783249"
        Me.lbe.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Hi"
        Me.NotifyIcon1.BalloonTipTitle = "Program"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ToolTip1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplateToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TemplateToolStripMenuItem
        '
        Me.TemplateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleToolStripMenuItem, Me.WallToolStripMenuItem})
        Me.TemplateToolStripMenuItem.Name = "TemplateToolStripMenuItem"
        Me.TemplateToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TemplateToolStripMenuItem.Text = "Template"
        '
        'SimpleToolStripMenuItem
        '
        Me.SimpleToolStripMenuItem.Name = "SimpleToolStripMenuItem"
        Me.SimpleToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SimpleToolStripMenuItem.Text = "Simple"
        '
        'WallToolStripMenuItem
        '
        Me.WallToolStripMenuItem.Name = "WallToolStripMenuItem"
        Me.WallToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.WallToolStripMenuItem.Text = "Wall"
        '
        'MainF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TravelAgency.My.Resources.Resources.mfbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(614, 466)
        Me.Controls.Add(Me.lbe)
        Me.Controls.Add(Me.lbp)
        Me.Controls.Add(Me.btConvert2)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.cbCurrency3)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.btAdmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbCurrency2)
        Me.Controls.Add(Me.cbCurrency1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainF"
        Me.Text = "Tim's Travel Agency"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCurrency1 As ComboBox
    Friend WithEvents cbCurrency2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btAdmin As Button
    Friend WithEvents tbUser As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents btLogin As Button
    Friend WithEvents lbUser As Label
    Friend WithEvents lbPass As Label
    Friend WithEvents cbCurrency3 As ComboBox
    Friend WithEvents tbAmount As TextBox
    Friend WithEvents btConvert2 As Button
    Friend WithEvents lbp As Label
    Friend WithEvents lbe As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemplateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WallToolStripMenuItem As ToolStripMenuItem
End Class
