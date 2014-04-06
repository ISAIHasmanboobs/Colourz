<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatescomingSoonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerColour = New System.Windows.Forms.Timer(Me.components)
        Me.tabNew = New System.Windows.Forms.TabPage()
        Me.txtWhatsNew = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.tabCustomise = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbMil = New System.Windows.Forms.RadioButton()
        Me.nudTime = New System.Windows.Forms.NumericUpDown()
        Me.rdbSeconds = New System.Windows.Forms.RadioButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.tabControlHelp = New System.Windows.Forms.TabControl()
        Me.tabRGB = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.cmdNextTrackers = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabColours = New System.Windows.Forms.TabPage()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.cmdPrevPal = New System.Windows.Forms.Button()
        Me.cmdNextPal = New System.Windows.Forms.Button()
        Me.tabRandom = New System.Windows.Forms.TabPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.tabRGBHEX = New System.Windows.Forms.TabPage()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tabSaveColours = New System.Windows.Forms.TabPage()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.rtbSaved = New System.Windows.Forms.RichTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tabColourPage = New System.Windows.Forms.TabPage()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.picOutput = New System.Windows.Forms.PictureBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLoopCount = New System.Windows.Forms.Label()
        Me.cmdCustomise = New System.Windows.Forms.Button()
        Me.cmdRandom = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trackRed = New System.Windows.Forms.TrackBar()
        Me.trackGreen = New System.Windows.Forms.TrackBar()
        Me.trackBlue = New System.Windows.Forms.TrackBar()
        Me.cmdCopyHex = New System.Windows.Forms.Button()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.txtRGB = New System.Windows.Forms.TextBox()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabDonate = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdWhite = New System.Windows.Forms.Button()
        Me.cmdBlack = New System.Windows.Forms.Button()
        Me.chbSaveAsGo = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.tabNew.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustomise.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHelp.SuspendLayout()
        Me.tabControlHelp.SuspendLayout()
        Me.tabRGB.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabColours.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRandom.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRGBHEX.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSaveColours.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabColourPage.SuspendLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.trackRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.tabDonate.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(752, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem, Me.UpdatescomingSoonToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem1, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem2})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'UpdatescomingSoonToolStripMenuItem
        '
        Me.UpdatescomingSoonToolStripMenuItem.Name = "UpdatescomingSoonToolStripMenuItem"
        Me.UpdatescomingSoonToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UpdatescomingSoonToolStripMenuItem.Text = "Check For Updates"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem1.Text = "Website"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ExitToolStripMenuItem1.Text = "Credits"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'timerColour
        '
        Me.timerColour.Interval = 1000
        '
        'tabNew
        '
        Me.tabNew.Controls.Add(Me.txtWhatsNew)
        Me.tabNew.Controls.Add(Me.Label3)
        Me.tabNew.Controls.Add(Me.PictureBox13)
        Me.tabNew.Location = New System.Drawing.Point(4, 22)
        Me.tabNew.Name = "tabNew"
        Me.tabNew.Size = New System.Drawing.Size(748, 359)
        Me.tabNew.TabIndex = 6
        Me.tabNew.Text = "Whats new"
        Me.tabNew.UseVisualStyleBackColor = True
        '
        'txtWhatsNew
        '
        Me.txtWhatsNew.BackColor = System.Drawing.Color.White
        Me.txtWhatsNew.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWhatsNew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhatsNew.Location = New System.Drawing.Point(166, 64)
        Me.txtWhatsNew.Multiline = True
        Me.txtWhatsNew.Name = "txtWhatsNew"
        Me.txtWhatsNew.ReadOnly = True
        Me.txtWhatsNew.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWhatsNew.Size = New System.Drawing.Size(580, 292)
        Me.txtWhatsNew.TabIndex = 25
        Me.txtWhatsNew.Text = resources.GetString("txtWhatsNew.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-4, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Whats new list"
        '
        'PictureBox13
        '
        Me.PictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox13.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox13.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(746, 63)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 24
        Me.PictureBox13.TabStop = False
        '
        'tabCustomise
        '
        Me.tabCustomise.BackColor = System.Drawing.Color.White
        Me.tabCustomise.Controls.Add(Me.GroupBox1)
        Me.tabCustomise.Controls.Add(Me.PictureBox5)
        Me.tabCustomise.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomise.Name = "tabCustomise"
        Me.tabCustomise.Size = New System.Drawing.Size(748, 359)
        Me.tabCustomise.TabIndex = 5
        Me.tabCustomise.Text = "Customise"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbSaveAsGo)
        Me.GroupBox1.Controls.Add(Me.rdbMil)
        Me.GroupBox1.Controls.Add(Me.nudTime)
        Me.GroupBox1.Controls.Add(Me.rdbSeconds)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 73)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Random Colour generator speed"
        '
        'rdbMil
        '
        Me.rdbMil.AutoSize = True
        Me.rdbMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.rdbMil.Location = New System.Drawing.Point(101, 19)
        Me.rdbMil.Name = "rdbMil"
        Me.rdbMil.Size = New System.Drawing.Size(110, 21)
        Me.rdbMil.TabIndex = 25
        Me.rdbMil.Text = "Millieseconds"
        Me.rdbMil.UseVisualStyleBackColor = True
        '
        'nudTime
        '
        Me.nudTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.nudTime.Location = New System.Drawing.Point(217, 19)
        Me.nudTime.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.nudTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTime.Name = "nudTime"
        Me.nudTime.Size = New System.Drawing.Size(75, 23)
        Me.nudTime.TabIndex = 27
        Me.nudTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdbSeconds
        '
        Me.rdbSeconds.AutoSize = True
        Me.rdbSeconds.Checked = True
        Me.rdbSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.rdbSeconds.Location = New System.Drawing.Point(6, 19)
        Me.rdbSeconds.Name = "rdbSeconds"
        Me.rdbSeconds.Size = New System.Drawing.Size(81, 21)
        Me.rdbSeconds.TabIndex = 26
        Me.rdbSeconds.TabStop = True
        Me.rdbSeconds.Text = "Seconds"
        Me.rdbSeconds.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(746, 63)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.tabControlHelp)
        Me.tabHelp.Location = New System.Drawing.Point(4, 22)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelp.Size = New System.Drawing.Size(748, 359)
        Me.tabHelp.TabIndex = 4
        Me.tabHelp.Text = "Help"
        Me.tabHelp.UseVisualStyleBackColor = True
        '
        'tabControlHelp
        '
        Me.tabControlHelp.Controls.Add(Me.tabRGB)
        Me.tabControlHelp.Controls.Add(Me.tabColours)
        Me.tabControlHelp.Controls.Add(Me.tabRandom)
        Me.tabControlHelp.Controls.Add(Me.tabRGBHEX)
        Me.tabControlHelp.Controls.Add(Me.TabPage1)
        Me.tabControlHelp.Location = New System.Drawing.Point(-4, 0)
        Me.tabControlHelp.Name = "tabControlHelp"
        Me.tabControlHelp.SelectedIndex = 0
        Me.tabControlHelp.Size = New System.Drawing.Size(756, 393)
        Me.tabControlHelp.TabIndex = 0
        '
        'tabRGB
        '
        Me.tabRGB.BackColor = System.Drawing.Color.White
        Me.tabRGB.Controls.Add(Me.PictureBox6)
        Me.tabRGB.Controls.Add(Me.cmdNextTrackers)
        Me.tabRGB.Controls.Add(Me.PictureBox3)
        Me.tabRGB.Controls.Add(Me.Label18)
        Me.tabRGB.Location = New System.Drawing.Point(4, 22)
        Me.tabRGB.Name = "tabRGB"
        Me.tabRGB.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRGB.Size = New System.Drawing.Size(748, 367)
        Me.tabRGB.TabIndex = 0
        Me.tabRGB.Text = "RGB Trackers"
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox6.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(744, 63)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'cmdNextTrackers
        '
        Me.cmdNextTrackers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdNextTrackers.Location = New System.Drawing.Point(642, 302)
        Me.cmdNextTrackers.Name = "cmdNextTrackers"
        Me.cmdNextTrackers.Size = New System.Drawing.Size(95, 29)
        Me.cmdNextTrackers.TabIndex = 2
        Me.cmdNextTrackers.Text = "Next Page"
        Me.cmdNextTrackers.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.Colourz.My.Resources.Resources.HelpSliders
        Me.PictureBox3.Location = New System.Drawing.Point(1, 62)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(744, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label18.Location = New System.Drawing.Point(6, 193)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(712, 100)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = resources.GetString("Label18.Text")
        '
        'tabColours
        '
        Me.tabColours.Controls.Add(Me.PictureBox7)
        Me.tabColours.Controls.Add(Me.cmdPrevPal)
        Me.tabColours.Controls.Add(Me.cmdNextPal)
        Me.tabColours.Location = New System.Drawing.Point(4, 22)
        Me.tabColours.Name = "tabColours"
        Me.tabColours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColours.Size = New System.Drawing.Size(748, 367)
        Me.tabColours.TabIndex = 1
        Me.tabColours.Text = "Saving Colours"
        Me.tabColours.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox7.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(744, 63)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = False
        '
        'cmdPrevPal
        '
        Me.cmdPrevPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdPrevPal.Location = New System.Drawing.Point(10, 302)
        Me.cmdPrevPal.Name = "cmdPrevPal"
        Me.cmdPrevPal.Size = New System.Drawing.Size(127, 29)
        Me.cmdPrevPal.TabIndex = 4
        Me.cmdPrevPal.Text = "Previous Page"
        Me.cmdPrevPal.UseVisualStyleBackColor = True
        '
        'cmdNextPal
        '
        Me.cmdNextPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdNextPal.Location = New System.Drawing.Point(642, 302)
        Me.cmdNextPal.Name = "cmdNextPal"
        Me.cmdNextPal.Size = New System.Drawing.Size(95, 29)
        Me.cmdNextPal.TabIndex = 3
        Me.cmdNextPal.Text = "Next Page"
        Me.cmdNextPal.UseVisualStyleBackColor = True
        '
        'tabRandom
        '
        Me.tabRandom.Controls.Add(Me.PictureBox8)
        Me.tabRandom.Location = New System.Drawing.Point(4, 22)
        Me.tabRandom.Name = "tabRandom"
        Me.tabRandom.Size = New System.Drawing.Size(748, 367)
        Me.tabRandom.TabIndex = 2
        Me.tabRandom.Text = "Randomizing"
        Me.tabRandom.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox8.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(744, 63)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'tabRGBHEX
        '
        Me.tabRGBHEX.Controls.Add(Me.PictureBox9)
        Me.tabRGBHEX.Location = New System.Drawing.Point(4, 22)
        Me.tabRGBHEX.Name = "tabRGBHEX"
        Me.tabRGBHEX.Size = New System.Drawing.Size(748, 367)
        Me.tabRGBHEX.TabIndex = 3
        Me.tabRGBHEX.Text = "RGB/HEX Codes"
        Me.tabRGBHEX.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox9.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(744, 63)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 28
        Me.PictureBox9.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(748, 367)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Customise"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox4.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(744, 63)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'tabSaveColours
        '
        Me.tabSaveColours.Controls.Add(Me.cmdBlack)
        Me.tabSaveColours.Controls.Add(Me.cmdWhite)
        Me.tabSaveColours.Controls.Add(Me.cmdReset)
        Me.tabSaveColours.Controls.Add(Me.rtbSaved)
        Me.tabSaveColours.Controls.Add(Me.PictureBox2)
        Me.tabSaveColours.Location = New System.Drawing.Point(4, 22)
        Me.tabSaveColours.Name = "tabSaveColours"
        Me.tabSaveColours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSaveColours.Size = New System.Drawing.Size(748, 359)
        Me.tabSaveColours.TabIndex = 2
        Me.tabSaveColours.Text = "Saved Colours"
        Me.tabSaveColours.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdReset.Location = New System.Drawing.Point(621, 69)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 25)
        Me.cmdReset.TabIndex = 26
        Me.cmdReset.Text = "Reset Text"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'rtbSaved
        '
        Me.rtbSaved.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSaved.Location = New System.Drawing.Point(0, 63)
        Me.rtbSaved.Name = "rtbSaved"
        Me.rtbSaved.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbSaved.Size = New System.Drawing.Size(575, 300)
        Me.rtbSaved.TabIndex = 25
        Me.rtbSaved.Text = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(746, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'tabColourPage
        '
        Me.tabColourPage.BackColor = System.Drawing.Color.White
        Me.tabColourPage.Controls.Add(Me.txtBlue)
        Me.tabColourPage.Controls.Add(Me.txtGreen)
        Me.tabColourPage.Controls.Add(Me.txtRed)
        Me.tabColourPage.Controls.Add(Me.picOutput)
        Me.tabColourPage.Controls.Add(Me.cmdSave)
        Me.tabColourPage.Controls.Add(Me.GroupBox2)
        Me.tabColourPage.Controls.Add(Me.Label6)
        Me.tabColourPage.Controls.Add(Me.Label2)
        Me.tabColourPage.Controls.Add(Me.Label1)
        Me.tabColourPage.Controls.Add(Me.trackRed)
        Me.tabColourPage.Controls.Add(Me.trackGreen)
        Me.tabColourPage.Controls.Add(Me.trackBlue)
        Me.tabColourPage.Controls.Add(Me.cmdCopyHex)
        Me.tabColourPage.Controls.Add(Me.txtHex)
        Me.tabColourPage.Controls.Add(Me.txtRGB)
        Me.tabColourPage.Controls.Add(Me.cmdCopy)
        Me.tabColourPage.Controls.Add(Me.PictureBox1)
        Me.tabColourPage.Location = New System.Drawing.Point(4, 22)
        Me.tabColourPage.Name = "tabColourPage"
        Me.tabColourPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColourPage.Size = New System.Drawing.Size(748, 359)
        Me.tabColourPage.TabIndex = 1
        Me.tabColourPage.Text = "Colour Generator"
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtBlue.Location = New System.Drawing.Point(710, 174)
        Me.txtBlue.MaxLength = 4
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(35, 23)
        Me.txtBlue.TabIndex = 36
        Me.txtBlue.Text = "0"
        '
        'txtGreen
        '
        Me.txtGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtGreen.Location = New System.Drawing.Point(710, 123)
        Me.txtGreen.MaxLength = 4
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(35, 23)
        Me.txtGreen.TabIndex = 35
        Me.txtGreen.Text = "0"
        '
        'txtRed
        '
        Me.txtRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtRed.Location = New System.Drawing.Point(710, 69)
        Me.txtRed.MaxLength = 4
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(35, 23)
        Me.txtRed.TabIndex = 34
        Me.txtRed.Text = "0"
        '
        'picOutput
        '
        Me.picOutput.BackColor = System.Drawing.Color.Black
        Me.picOutput.Location = New System.Drawing.Point(2, 199)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(406, 117)
        Me.picOutput.TabIndex = 6
        Me.picOutput.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdSave.Location = New System.Drawing.Point(535, 210)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(101, 29)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Save colour"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLoopCount)
        Me.GroupBox2.Controls.Add(Me.cmdCustomise)
        Me.GroupBox2.Controls.Add(Me.cmdRandom)
        Me.GroupBox2.Controls.Add(Me.cmdStop)
        Me.GroupBox2.Controls.Add(Me.cmdStart)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 71)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Random Colours"
        '
        'lblLoopCount
        '
        Me.lblLoopCount.AutoSize = True
        Me.lblLoopCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblLoopCount.Location = New System.Drawing.Point(6, 16)
        Me.lblLoopCount.Name = "lblLoopCount"
        Me.lblLoopCount.Size = New System.Drawing.Size(105, 17)
        Me.lblLoopCount.TabIndex = 31
        Me.lblLoopCount.Text = "Looped 0 times"
        '
        'cmdCustomise
        '
        Me.cmdCustomise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdCustomise.Location = New System.Drawing.Point(110, 36)
        Me.cmdCustomise.Name = "cmdCustomise"
        Me.cmdCustomise.Size = New System.Drawing.Size(81, 29)
        Me.cmdCustomise.TabIndex = 32
        Me.cmdCustomise.Text = "Customise"
        Me.cmdCustomise.UseVisualStyleBackColor = True
        '
        'cmdRandom
        '
        Me.cmdRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdRandom.Location = New System.Drawing.Point(197, 36)
        Me.cmdRandom.Name = "cmdRandom"
        Me.cmdRandom.Size = New System.Drawing.Size(121, 29)
        Me.cmdRandom.TabIndex = 28
        Me.cmdRandom.Text = "Random colour"
        Me.cmdRandom.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Enabled = False
        Me.cmdStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdStop.Location = New System.Drawing.Point(59, 36)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(45, 29)
        Me.cmdStop.TabIndex = 29
        Me.cmdStop.Text = "Stop Random colour"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdStart.Location = New System.Drawing.Point(7, 36)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(46, 29)
        Me.cmdStart.TabIndex = 30
        Me.cmdStart.Text = "Start Random colour"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(1, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Blue:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(1, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Green:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(1, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Red:"
        '
        'trackRed
        '
        Me.trackRed.BackColor = System.Drawing.Color.White
        Me.trackRed.Location = New System.Drawing.Point(84, 69)
        Me.trackRed.Maximum = 255
        Me.trackRed.Name = "trackRed"
        Me.trackRed.Size = New System.Drawing.Size(620, 45)
        Me.trackRed.TabIndex = 0
        Me.trackRed.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'trackGreen
        '
        Me.trackGreen.BackColor = System.Drawing.Color.White
        Me.trackGreen.Location = New System.Drawing.Point(84, 120)
        Me.trackGreen.Maximum = 255
        Me.trackGreen.Name = "trackGreen"
        Me.trackGreen.Size = New System.Drawing.Size(620, 45)
        Me.trackGreen.TabIndex = 1
        Me.trackGreen.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'trackBlue
        '
        Me.trackBlue.BackColor = System.Drawing.Color.White
        Me.trackBlue.Location = New System.Drawing.Point(84, 171)
        Me.trackBlue.Maximum = 255
        Me.trackBlue.Name = "trackBlue"
        Me.trackBlue.Size = New System.Drawing.Size(620, 45)
        Me.trackBlue.TabIndex = 2
        Me.trackBlue.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cmdCopyHex
        '
        Me.cmdCopyHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdCopyHex.Location = New System.Drawing.Point(605, 322)
        Me.cmdCopyHex.Name = "cmdCopyHex"
        Me.cmdCopyHex.Size = New System.Drawing.Size(135, 35)
        Me.cmdCopyHex.TabIndex = 10
        Me.cmdCopyHex.Text = "Copy to Clipboard"
        Me.cmdCopyHex.UseVisualStyleBackColor = True
        '
        'txtHex
        '
        Me.txtHex.Enabled = False
        Me.txtHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.txtHex.Location = New System.Drawing.Point(374, 322)
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(225, 35)
        Me.txtHex.TabIndex = 9
        Me.txtHex.Text = "#000000"
        Me.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRGB
        '
        Me.txtRGB.Enabled = False
        Me.txtRGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.txtRGB.Location = New System.Drawing.Point(2, 322)
        Me.txtRGB.Name = "txtRGB"
        Me.txtRGB.Size = New System.Drawing.Size(225, 35)
        Me.txtRGB.TabIndex = 7
        Me.txtRGB.Text = "0, 0, 0"
        Me.txtRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCopy
        '
        Me.cmdCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdCopy.Location = New System.Drawing.Point(233, 322)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(135, 35)
        Me.cmdCopy.TabIndex = 8
        Me.cmdCopy.Text = "Copy to Clipboard"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Colourz.My.Resources.Resources.colourz
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(746, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabColourPage)
        Me.TabControl.Controls.Add(Me.tabSaveColours)
        Me.TabControl.Controls.Add(Me.tabCustomise)
        Me.TabControl.Controls.Add(Me.tabDonate)
        Me.TabControl.Controls.Add(Me.tabHelp)
        Me.TabControl.Controls.Add(Me.tabNew)
        Me.TabControl.Location = New System.Drawing.Point(-1, 25)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(756, 385)
        Me.TabControl.TabIndex = 14
        '
        'tabDonate
        '
        Me.tabDonate.Controls.Add(Me.TextBox3)
        Me.tabDonate.Controls.Add(Me.Label8)
        Me.tabDonate.Controls.Add(Me.PictureBox10)
        Me.tabDonate.Controls.Add(Me.Label5)
        Me.tabDonate.ForeColor = System.Drawing.Color.Black
        Me.tabDonate.Location = New System.Drawing.Point(4, 22)
        Me.tabDonate.Name = "tabDonate"
        Me.tabDonate.Size = New System.Drawing.Size(748, 359)
        Me.tabDonate.TabIndex = 7
        Me.tabDonate.Text = "Donate"
        Me.tabDonate.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TextBox3.Location = New System.Drawing.Point(213, 117)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(304, 135)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "Jordan woods - £12.40"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Donators"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(280, 32)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(163, 50)
        Me.PictureBox10.TabIndex = 2
        Me.PictureBox10.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(126, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(458, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "To Donate, Please click the donate button"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(674, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Version 0.8.0.0"
        '
        'cmdWhite
        '
        Me.cmdWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdWhite.Location = New System.Drawing.Point(581, 100)
        Me.cmdWhite.Name = "cmdWhite"
        Me.cmdWhite.Size = New System.Drawing.Size(156, 27)
        Me.cmdWhite.TabIndex = 31
        Me.cmdWhite.Text = "White Background"
        Me.cmdWhite.UseVisualStyleBackColor = True
        '
        'cmdBlack
        '
        Me.cmdBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdBlack.Location = New System.Drawing.Point(581, 133)
        Me.cmdBlack.Name = "cmdBlack"
        Me.cmdBlack.Size = New System.Drawing.Size(156, 27)
        Me.cmdBlack.TabIndex = 32
        Me.cmdBlack.Text = "Black Background"
        Me.cmdBlack.UseVisualStyleBackColor = True
        '
        'chbSaveAsGo
        '
        Me.chbSaveAsGo.AutoSize = True
        Me.chbSaveAsGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.chbSaveAsGo.Location = New System.Drawing.Point(6, 48)
        Me.chbSaveAsGo.Name = "chbSaveAsGo"
        Me.chbSaveAsGo.Size = New System.Drawing.Size(215, 21)
        Me.chbSaveAsGo.TabIndex = 28
        Me.chbSaveAsGo.Text = "Save colours when generated"
        Me.chbSaveAsGo.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 406)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Colourz"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabNew.ResumeLayout(False)
        Me.tabNew.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustomise.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHelp.ResumeLayout(False)
        Me.tabControlHelp.ResumeLayout(False)
        Me.tabRGB.ResumeLayout(False)
        Me.tabRGB.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabColours.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRandom.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRGBHEX.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSaveColours.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabColourPage.ResumeLayout(False)
        Me.tabColourPage.PerformLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.trackRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.tabDonate.ResumeLayout(False)
        Me.tabDonate.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatescomingSoonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timerColour As System.Windows.Forms.Timer
    Friend WithEvents tabNew As System.Windows.Forms.TabPage
    Friend WithEvents txtWhatsNew As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabCustomise As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMil As System.Windows.Forms.RadioButton
    Friend WithEvents nudTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdbSeconds As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents tabHelp As System.Windows.Forms.TabPage
    Friend WithEvents tabControlHelp As System.Windows.Forms.TabControl
    Friend WithEvents tabRGB As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdNextTrackers As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tabColours As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPrevPal As System.Windows.Forms.Button
    Friend WithEvents cmdNextPal As System.Windows.Forms.Button
    Friend WithEvents tabRandom As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents tabRGBHEX As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabSaveColours As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tabColourPage As System.Windows.Forms.TabPage
    Friend WithEvents cmdCustomise As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdRandom As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents trackRed As System.Windows.Forms.TrackBar
    Friend WithEvents trackGreen As System.Windows.Forms.TrackBar
    Friend WithEvents trackBlue As System.Windows.Forms.TrackBar
    Friend WithEvents cmdCopyHex As System.Windows.Forms.Button
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents txtRGB As System.Windows.Forms.TextBox
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents picOutput As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents rtbSaved As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents lblLoopCount As System.Windows.Forms.Label
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabDonate As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdBlack As System.Windows.Forms.Button
    Friend WithEvents cmdWhite As System.Windows.Forms.Button
    Friend WithEvents chbSaveAsGo As System.Windows.Forms.CheckBox

End Class
