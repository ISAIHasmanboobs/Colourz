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
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerColour = New System.Windows.Forms.Timer(Me.components)
        Me.tabNew = New System.Windows.Forms.TabPage()
        Me.txtWhatsNew = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.tabControlHelp = New System.Windows.Forms.TabControl()
        Me.tabRGB = New System.Windows.Forms.TabPage()
        Me.cmdNextTrackers = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabColours = New System.Windows.Forms.TabPage()
        Me.cmdPrevPal = New System.Windows.Forms.Button()
        Me.cmdNextPal = New System.Windows.Forms.Button()
        Me.tabRandom = New System.Windows.Forms.TabPage()
        Me.tabRGBHEX = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabSaveColours = New System.Windows.Forms.TabPage()
        Me.cmdBlack = New System.Windows.Forms.Button()
        Me.cmdWhite = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.rtbSaved = New System.Windows.Forms.RichTextBox()
        Me.tabColourPage = New System.Windows.Forms.TabPage()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.picOutput = New System.Windows.Forms.PictureBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLoopCount = New System.Windows.Forms.Label()
        Me.cmdRandom = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.trackRed = New System.Windows.Forms.TrackBar()
        Me.trackGreen = New System.Windows.Forms.TrackBar()
        Me.trackBlue = New System.Windows.Forms.TrackBar()
        Me.cmdCopyHex = New System.Windows.Forms.Button()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.txtRGB = New System.Windows.Forms.TextBox()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbSaveAsGo = New System.Windows.Forms.CheckBox()
        Me.rdbMil = New System.Windows.Forms.RadioButton()
        Me.nudTime = New System.Windows.Forms.NumericUpDown()
        Me.rdbSeconds = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.tabNew.SuspendLayout()
        Me.tabHelp.SuspendLayout()
        Me.tabControlHelp.SuspendLayout()
        Me.tabRGB.SuspendLayout()
        Me.tabColours.SuspendLayout()
        Me.tabSaveColours.SuspendLayout()
        Me.tabColourPage.SuspendLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.trackRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(752, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem, Me.UpdatescomingSoonToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem1, Me.ToolStripSeparator2, Me.DonateToolStripMenuItem, Me.ExitToolStripMenuItem2})
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
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'timerColour
        '
        Me.timerColour.Interval = 1000
        '
        'tabNew
        '
        Me.tabNew.Controls.Add(Me.txtWhatsNew)
        Me.tabNew.Controls.Add(Me.Label3)
        Me.tabNew.Location = New System.Drawing.Point(4, 22)
        Me.tabNew.Name = "tabNew"
        Me.tabNew.Size = New System.Drawing.Size(748, 296)
        Me.tabNew.TabIndex = 6
        Me.tabNew.Text = "Whats new"
        Me.tabNew.UseVisualStyleBackColor = True
        '
        'txtWhatsNew
        '
        Me.txtWhatsNew.BackColor = System.Drawing.Color.White
        Me.txtWhatsNew.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWhatsNew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhatsNew.Location = New System.Drawing.Point(166, 3)
        Me.txtWhatsNew.Multiline = True
        Me.txtWhatsNew.Name = "txtWhatsNew"
        Me.txtWhatsNew.ReadOnly = True
        Me.txtWhatsNew.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWhatsNew.Size = New System.Drawing.Size(580, 290)
        Me.txtWhatsNew.TabIndex = 25
        Me.txtWhatsNew.Text = resources.GetString("txtWhatsNew.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Whats new list"
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.tabControlHelp)
        Me.tabHelp.Location = New System.Drawing.Point(4, 22)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelp.Size = New System.Drawing.Size(748, 296)
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
        Me.tabControlHelp.Size = New System.Drawing.Size(756, 296)
        Me.tabControlHelp.TabIndex = 0
        '
        'tabRGB
        '
        Me.tabRGB.BackColor = System.Drawing.Color.White
        Me.tabRGB.Controls.Add(Me.cmdNextTrackers)
        Me.tabRGB.Controls.Add(Me.Label18)
        Me.tabRGB.Location = New System.Drawing.Point(4, 22)
        Me.tabRGB.Name = "tabRGB"
        Me.tabRGB.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRGB.Size = New System.Drawing.Size(748, 270)
        Me.tabRGB.TabIndex = 0
        Me.tabRGB.Text = "RGB Trackers"
        '
        'cmdNextTrackers
        '
        Me.cmdNextTrackers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdNextTrackers.Location = New System.Drawing.Point(642, 235)
        Me.cmdNextTrackers.Name = "cmdNextTrackers"
        Me.cmdNextTrackers.Size = New System.Drawing.Size(95, 29)
        Me.cmdNextTrackers.TabIndex = 2
        Me.cmdNextTrackers.Text = "Next Page"
        Me.cmdNextTrackers.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label18.Location = New System.Drawing.Point(6, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(712, 100)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = resources.GetString("Label18.Text")
        Me.Label18.Visible = False
        '
        'tabColours
        '
        Me.tabColours.Controls.Add(Me.cmdPrevPal)
        Me.tabColours.Controls.Add(Me.cmdNextPal)
        Me.tabColours.Location = New System.Drawing.Point(4, 22)
        Me.tabColours.Name = "tabColours"
        Me.tabColours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColours.Size = New System.Drawing.Size(748, 270)
        Me.tabColours.TabIndex = 1
        Me.tabColours.Text = "Saving Colours"
        Me.tabColours.UseVisualStyleBackColor = True
        '
        'cmdPrevPal
        '
        Me.cmdPrevPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdPrevPal.Location = New System.Drawing.Point(9, 235)
        Me.cmdPrevPal.Name = "cmdPrevPal"
        Me.cmdPrevPal.Size = New System.Drawing.Size(127, 29)
        Me.cmdPrevPal.TabIndex = 4
        Me.cmdPrevPal.Text = "Previous Page"
        Me.cmdPrevPal.UseVisualStyleBackColor = True
        '
        'cmdNextPal
        '
        Me.cmdNextPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdNextPal.Location = New System.Drawing.Point(642, 235)
        Me.cmdNextPal.Name = "cmdNextPal"
        Me.cmdNextPal.Size = New System.Drawing.Size(95, 29)
        Me.cmdNextPal.TabIndex = 3
        Me.cmdNextPal.Text = "Next Page"
        Me.cmdNextPal.UseVisualStyleBackColor = True
        '
        'tabRandom
        '
        Me.tabRandom.Location = New System.Drawing.Point(4, 22)
        Me.tabRandom.Name = "tabRandom"
        Me.tabRandom.Size = New System.Drawing.Size(748, 270)
        Me.tabRandom.TabIndex = 2
        Me.tabRandom.Text = "Randomizing"
        Me.tabRandom.UseVisualStyleBackColor = True
        '
        'tabRGBHEX
        '
        Me.tabRGBHEX.Location = New System.Drawing.Point(4, 22)
        Me.tabRGBHEX.Name = "tabRGBHEX"
        Me.tabRGBHEX.Size = New System.Drawing.Size(748, 270)
        Me.tabRGBHEX.TabIndex = 3
        Me.tabRGBHEX.Text = "RGB/HEX Codes"
        Me.tabRGBHEX.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(748, 270)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Customise"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tabSaveColours
        '
        Me.tabSaveColours.Controls.Add(Me.cmdBlack)
        Me.tabSaveColours.Controls.Add(Me.cmdWhite)
        Me.tabSaveColours.Controls.Add(Me.cmdReset)
        Me.tabSaveColours.Controls.Add(Me.rtbSaved)
        Me.tabSaveColours.Location = New System.Drawing.Point(4, 22)
        Me.tabSaveColours.Name = "tabSaveColours"
        Me.tabSaveColours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSaveColours.Size = New System.Drawing.Size(748, 296)
        Me.tabSaveColours.TabIndex = 2
        Me.tabSaveColours.Text = "Saved Colours"
        Me.tabSaveColours.UseVisualStyleBackColor = True
        '
        'cmdBlack
        '
        Me.cmdBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdBlack.Location = New System.Drawing.Point(584, 70)
        Me.cmdBlack.Name = "cmdBlack"
        Me.cmdBlack.Size = New System.Drawing.Size(156, 27)
        Me.cmdBlack.TabIndex = 32
        Me.cmdBlack.Text = "Black Background"
        Me.cmdBlack.UseVisualStyleBackColor = True
        '
        'cmdWhite
        '
        Me.cmdWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdWhite.Location = New System.Drawing.Point(584, 37)
        Me.cmdWhite.Name = "cmdWhite"
        Me.cmdWhite.Size = New System.Drawing.Size(156, 27)
        Me.cmdWhite.TabIndex = 31
        Me.cmdWhite.Text = "White Background"
        Me.cmdWhite.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdReset.Location = New System.Drawing.Point(624, 6)
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
        Me.rtbSaved.Location = New System.Drawing.Point(0, -1)
        Me.rtbSaved.Name = "rtbSaved"
        Me.rtbSaved.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbSaved.Size = New System.Drawing.Size(575, 300)
        Me.rtbSaved.TabIndex = 25
        Me.rtbSaved.Text = ""
        '
        'tabColourPage
        '
        Me.tabColourPage.BackColor = System.Drawing.Color.White
        Me.tabColourPage.Controls.Add(Me.picOutput)
        Me.tabColourPage.Controls.Add(Me.GroupBox1)
        Me.tabColourPage.Controls.Add(Me.txtBlue)
        Me.tabColourPage.Controls.Add(Me.txtGreen)
        Me.tabColourPage.Controls.Add(Me.txtRed)
        Me.tabColourPage.Controls.Add(Me.cmdSave)
        Me.tabColourPage.Controls.Add(Me.GroupBox2)
        Me.tabColourPage.Controls.Add(Me.lblBlue)
        Me.tabColourPage.Controls.Add(Me.lblGreen)
        Me.tabColourPage.Controls.Add(Me.lblRed)
        Me.tabColourPage.Controls.Add(Me.trackRed)
        Me.tabColourPage.Controls.Add(Me.trackGreen)
        Me.tabColourPage.Controls.Add(Me.trackBlue)
        Me.tabColourPage.Controls.Add(Me.cmdCopyHex)
        Me.tabColourPage.Controls.Add(Me.txtHex)
        Me.tabColourPage.Controls.Add(Me.txtRGB)
        Me.tabColourPage.Controls.Add(Me.cmdCopy)
        Me.tabColourPage.Location = New System.Drawing.Point(4, 22)
        Me.tabColourPage.Name = "tabColourPage"
        Me.tabColourPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColourPage.Size = New System.Drawing.Size(748, 296)
        Me.tabColourPage.TabIndex = 1
        Me.tabColourPage.Text = "Colour Generator"
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtBlue.Location = New System.Drawing.Point(710, 111)
        Me.txtBlue.MaxLength = 4
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(35, 23)
        Me.txtBlue.TabIndex = 36
        Me.txtBlue.Text = "0"
        '
        'txtGreen
        '
        Me.txtGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtGreen.Location = New System.Drawing.Point(710, 60)
        Me.txtGreen.MaxLength = 4
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(35, 23)
        Me.txtGreen.TabIndex = 35
        Me.txtGreen.Text = "0"
        '
        'txtRed
        '
        Me.txtRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtRed.Location = New System.Drawing.Point(710, 6)
        Me.txtRed.MaxLength = 4
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(35, 23)
        Me.txtRed.TabIndex = 34
        Me.txtRed.Text = "0"
        '
        'picOutput
        '
        Me.picOutput.BackColor = System.Drawing.Color.Black
        Me.picOutput.Location = New System.Drawing.Point(2, 140)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(231, 113)
        Me.picOutput.TabIndex = 6
        Me.picOutput.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.cmdSave.Location = New System.Drawing.Point(243, 140)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(494, 36)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Save colour"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLoopCount)
        Me.GroupBox2.Controls.Add(Me.cmdRandom)
        Me.GroupBox2.Controls.Add(Me.cmdStop)
        Me.GroupBox2.Controls.Add(Me.cmdStart)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 71)
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
        'cmdRandom
        '
        Me.cmdRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdRandom.Location = New System.Drawing.Point(110, 36)
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
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblBlue.ForeColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(1, 108)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(61, 25)
        Me.lblBlue.TabIndex = 26
        Me.lblBlue.Text = "Blue:"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblGreen.ForeColor = System.Drawing.Color.Lime
        Me.lblGreen.Location = New System.Drawing.Point(1, 57)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(77, 25)
        Me.lblGreen.TabIndex = 25
        Me.lblGreen.Text = "Green:"
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(1, 3)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(57, 25)
        Me.lblRed.TabIndex = 24
        Me.lblRed.Text = "Red:"
        '
        'trackRed
        '
        Me.trackRed.BackColor = System.Drawing.Color.White
        Me.trackRed.Location = New System.Drawing.Point(84, 6)
        Me.trackRed.Maximum = 255
        Me.trackRed.Name = "trackRed"
        Me.trackRed.Size = New System.Drawing.Size(620, 45)
        Me.trackRed.TabIndex = 0
        Me.trackRed.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'trackGreen
        '
        Me.trackGreen.BackColor = System.Drawing.Color.White
        Me.trackGreen.Location = New System.Drawing.Point(84, 57)
        Me.trackGreen.Maximum = 255
        Me.trackGreen.Name = "trackGreen"
        Me.trackGreen.Size = New System.Drawing.Size(620, 45)
        Me.trackGreen.TabIndex = 1
        Me.trackGreen.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'trackBlue
        '
        Me.trackBlue.BackColor = System.Drawing.Color.White
        Me.trackBlue.Location = New System.Drawing.Point(84, 108)
        Me.trackBlue.Maximum = 255
        Me.trackBlue.Name = "trackBlue"
        Me.trackBlue.Size = New System.Drawing.Size(620, 45)
        Me.trackBlue.TabIndex = 2
        Me.trackBlue.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cmdCopyHex
        '
        Me.cmdCopyHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdCopyHex.Location = New System.Drawing.Point(605, 259)
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
        Me.txtHex.Location = New System.Drawing.Point(374, 259)
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
        Me.txtRGB.Location = New System.Drawing.Point(2, 259)
        Me.txtRGB.Name = "txtRGB"
        Me.txtRGB.Size = New System.Drawing.Size(225, 35)
        Me.txtRGB.TabIndex = 7
        Me.txtRGB.Text = "0, 0, 0"
        Me.txtRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCopy
        '
        Me.cmdCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cmdCopy.Location = New System.Drawing.Point(233, 259)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(135, 35)
        Me.cmdCopy.TabIndex = 8
        Me.cmdCopy.Text = "Copy to Clipboard"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabColourPage)
        Me.TabControl.Controls.Add(Me.tabSaveColours)
        Me.TabControl.Controls.Add(Me.tabHelp)
        Me.TabControl.Controls.Add(Me.tabNew)
        Me.TabControl.Location = New System.Drawing.Point(-1, 25)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(756, 322)
        Me.TabControl.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(674, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Version 0.9.0.0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbSaveAsGo)
        Me.GroupBox1.Controls.Add(Me.rdbMil)
        Me.GroupBox1.Controls.Add(Me.nudTime)
        Me.GroupBox1.Controls.Add(Me.rdbSeconds)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(474, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 73)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Random Colour generator speed"
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
        Me.nudTime.Size = New System.Drawing.Size(54, 23)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 346)
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
        Me.tabHelp.ResumeLayout(False)
        Me.tabControlHelp.ResumeLayout(False)
        Me.tabRGB.ResumeLayout(False)
        Me.tabRGB.PerformLayout()
        Me.tabColours.ResumeLayout(False)
        Me.tabSaveColours.ResumeLayout(False)
        Me.tabColourPage.ResumeLayout(False)
        Me.tabColourPage.PerformLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.trackRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabHelp As System.Windows.Forms.TabPage
    Friend WithEvents tabControlHelp As System.Windows.Forms.TabControl
    Friend WithEvents tabRGB As System.Windows.Forms.TabPage
    Friend WithEvents cmdNextTrackers As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tabColours As System.Windows.Forms.TabPage
    Friend WithEvents cmdPrevPal As System.Windows.Forms.Button
    Friend WithEvents cmdNextPal As System.Windows.Forms.Button
    Friend WithEvents tabRandom As System.Windows.Forms.TabPage
    Friend WithEvents tabRGBHEX As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabSaveColours As System.Windows.Forms.TabPage
    Friend WithEvents tabColourPage As System.Windows.Forms.TabPage
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdRandom As System.Windows.Forms.Button
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents trackRed As System.Windows.Forms.TrackBar
    Friend WithEvents trackGreen As System.Windows.Forms.TrackBar
    Friend WithEvents trackBlue As System.Windows.Forms.TrackBar
    Friend WithEvents cmdCopyHex As System.Windows.Forms.Button
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents txtRGB As System.Windows.Forms.TextBox
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents picOutput As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents rtbSaved As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents lblLoopCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBlack As System.Windows.Forms.Button
    Friend WithEvents cmdWhite As System.Windows.Forms.Button
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chbSaveAsGo As System.Windows.Forms.CheckBox
    Friend WithEvents rdbMil As System.Windows.Forms.RadioButton
    Friend WithEvents nudTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdbSeconds As System.Windows.Forms.RadioButton

End Class
