Public Class frmMain

    Dim loopCount As Integer

    Private Sub UpdatescomingSoonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatescomingSoonToolStripMenuItem.Click
        checkForUpdates()
    End Sub
    Private Sub trackRed_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackRed.Scroll
        picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
        txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        txtRed.Text = trackRed.Value
    End Sub
    Private Sub trackGreen_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackGreen.Scroll
        picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
        txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        txtGreen.Text = trackGreen.Value
    End Sub
    Private Sub trackBlue_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBlue.Scroll
        picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
        txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        txtBlue.Text = trackBlue.Value
    End Sub
    Private Sub cmdCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCopy.Click
        My.Computer.Clipboard.SetText(txtRGB.Text)
    End Sub
    Private Sub cmdCopyHex_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCopyHex.Click
        My.Computer.Clipboard.SetText(Mid(txtHex.Text, 2, 8))
    End Sub

    Private Sub PlansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("My plan for future updates are to ensure you get the best user experience using this app: Some of the following are already being added: Insert Custom colour codes.")
    End Sub

    Private Sub randomise()
        Dim intHex As String = ColorTranslator.ToHtml(Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value))
        Randomize()
        trackBlue.Value = Rnd() * 255
        trackRed.Value = Rnd() * 255
        trackGreen.Value = Rnd() * 255
        txtRed.Text = trackRed.Value
        txtGreen.Text = trackGreen.Value
        txtBlue.Text = trackBlue.Value
        picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
        txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        txtHex.Text = intHex
        If chbSaveAsGo.Checked = True Then
            saveColour()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRandom.Click
        randomise()
    End Sub

    Private Sub timerColour_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerColour.Tick
        randomise()
        loopCount += 1
        lblLoopCount.Text = "Looped " & loopCount & " times"
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        If rdbSeconds.Checked = True Then
            timerColour.Interval = nudTime.Value & "000"
        End If
        If rdbMil.Checked = True Then
            timerColour.Interval = nudTime.Value
        End If
        timerColour.Start()
        cmdStop.Enabled = True
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        timerColour.Stop()
        cmdStop.Enabled = False
        loopCount = 0
    End Sub

    Private Sub cmdNextTrackers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextTrackers.Click
        tabControlHelp.SelectTab(1)
    End Sub

    Private Sub cmdNextPal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextPal.Click
        tabControlHelp.SelectTab(2)
    End Sub

    Private Sub cmdPrevPal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevPal.Click
        tabControlHelp.SelectTab(0)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        TabControl.SelectTab(3)
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        MsgBox("All Credits go to Zack Davidson for this Program", MsgBoxStyle.Information)
    End Sub
    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        End
    End Sub
    Private Sub txtRGB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRGB.TextChanged
        Dim intHex As String = ColorTranslator.ToHtml(Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value))
        txtHex.Text = intHex
    End Sub
    Private Sub cmdCustomise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomise.Click
        TabControl.SelectTab(2)
    End Sub
    Private Sub saveColour()
        rtbSaved.SelectionColor = picOutput.BackColor
        rtbSaved.SelectedText += "RGB(" & txtRGB.Text & ") Hex(" & txtHex.Text & ")" + Environment.NewLine
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        saveColour()
    End Sub
    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        rtbSaved.Text = ""
    End Sub
    Private Sub cmdCustomiseSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl.SelectTab(2)
    End Sub
    Private Sub cmdWhite_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rtbSaved.BackColor = Color.White
    End Sub
    Private Sub cmdBlack_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rtbSaved.BackColor = Color.Black
    End Sub
    Private Sub txtRed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRed.TextChanged
        If IsNumeric(txtRed.Text) Then
            If txtRed.Text > 255 Then
                txtRed.Text = 255
            End If
            If txtRed.Text < 0 Then
                txtRed.Text = 0
            End If
            trackRed.Value = txtRed.Text
            picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
            txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        Else
            txtRed.Text = trackRed.Value
        End If
    End Sub
    Private Sub txtGreen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGreen.TextChanged
        If IsNumeric(txtGreen.Text) Then
            If txtGreen.Text > 255 Then
                txtGreen.Text = 255
            End If
            If txtGreen.Text < 0 Then
                txtGreen.Text = 0
            End If
            trackGreen.Value = txtGreen.Text
            picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
            txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        Else
            txtGreen.Text = trackGreen.Value
        End If
    End Sub
    Private Sub txtBlue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlue.TextChanged
        If IsNumeric(txtBlue.Text) Then
            If txtBlue.Text > 255 Then
                txtBlue.Text = 255
            End If
            If txtBlue.Text < 0 Then
                txtBlue.Text = 0
            End If
            trackBlue.Value = txtBlue.Text
            picOutput.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value)
            txtRGB.Text = trackRed.Value & ", " & trackGreen.Value & ", " & trackBlue.Value
        Else
            txtBlue.Text = trackBlue.Value
        End If
    End Sub
    Private Sub checkForUpdates()
        Try
            Me.Opacity = 0.7
            MsgBox("Checking For Updates....", MsgBoxStyle.Information, "Checking")
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.dropboxusercontent.com/s/3xc9n6wd7bml9c2/Version.txt")
            Dim respons As System.Net.HttpWebResponse = request.GetResponse
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(respons.GetResponseStream())
            Dim newVersion As String = sr.ReadToEnd
            Dim curVersion As String = Application.ProductVersion
            If newVersion.Contains(curVersion) Then
                Me.Opacity = 10
                MsgBox("No Updates are Avalible")
            Else
                Me.Opacity = 10
                Dim update As Integer = MessageBox.Show("Updates are avalible, do you want to update? (Recommended)", "Update", MessageBoxButtons.YesNo)
                If update = DialogResult.Yes Then
                    Process.Start("https://dl.dropboxusercontent.com/s/p0xlipp489uihro/Colourz.exe")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error checking for updates")
            Me.Opacity = 10
        End Try
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        checkForUpdates()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Process.Start("www.zacksproducts.net46.net")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This program gives you the ability to generate colours and save then, it automatically comes with a RGB to hex convertion")
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=zackdavidson2011%40hotmail%2eco%2euk&lc=GB&item_name=Colourz&no_note=0&currency_code=GBP&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest")
    End Sub

    Private Sub cmdWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWhite.Click
        rtbSaved.BackColor = Color.White
    End Sub

    Private Sub cmdBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBlack.Click
        rtbSaved.BackColor = Color.Black
    End Sub

    Private Sub txtHex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHex.TextChanged

    End Sub
End Class