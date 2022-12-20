Imports System.Configuration
Imports System.Drawing.Imaging
Imports System.Security.Cryptography.X509Certificates
Imports System.Net
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows

Public Class Form1

    'create public vars to use throught form
    Public loc As String = My.Computer.FileSystem.CurrentDirectory
    Public playerFoul As New ArrayList
    'create array of various sports yo use
    Public textFiles = {"time", "period", "HomeScore", "Home", "AwayScore", "Away", "variable",
        "variable2", "fouls", "homeBonus", "awayBonus"}

    'do this when form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim otp As String = loc + "\Outputs"
        'if thew output directory !exists, do this to make it
        If System.IO.Directory.Exists(otp) = False Then
            'set the direcoty of outputs to be the `/Outputs` in the CWD
            System.IO.Directory.CreateDirectory(loc + "\Outputs")
            'for each item in the aformentioned array, crteate a text file named after it
            For Each item As String In textFiles
                File.Create(loc + "\Outputs\" & item & ".txt").Dispose()
            Next

            ' THIS WAS THE OLD WAY TO MAKE THE FILES
            'File.Create(loc + "\Outputs\time.txt").Dispose()
            'File.Create(loc + "\Outputs\period.txt").Dispose()
            'File.Create(loc + "\Outputs\HomeScore.txt").Dispose()
            'File.Create(loc + "\Outputs\Home.txt").Dispose()
            'File.Create(loc + "\Outputs\AwayScore.txt").Dispose()
            'File.Create(loc + "\Outputs\Away.txt").Dispose()
            'File.Create(loc + "\Outputs\variable.txt").Dispose()
            'File.Create(loc + "\Outputs\variable2.txt").Dispose()
            'File.Create(loc + "\Outputs\fouls.txt").Dispose()
            'File.Create(loc + "\Outputs\homeBonus.txt").Dispose()
            'File.Create(loc + "\Outputs\awayBonus.txt").Dispose()

            'If the files DO exist, then set the files equal to whatever is stored in the program from
            'the last time it was run
        ElseIf System.IO.Directory.Exists(otp) = True Then
            Dim home As String
            home = My.Computer.FileSystem.ReadAllText(loc + "\Outputs\Home.txt")
            homeName.Text = home
            Dim away As String
            away = My.Computer.FileSystem.ReadAllText(loc + "\Outputs\Away.txt")
            awayName.Text = away
        End If

        'check to see if various setting are enabled, and make the form diaplay those accurately
        If My.Settings.countMode = True Then
            CheckBox1.Checked = True
        End If
        If My.Settings.obsSetup = True Then
            CheckBox2.Checked = True
        End If
        hotkeyLabel.Text = My.Settings.startstophotkey
        'allows the form1_keyPress subprocess to listen for keypresses, even if the main form does not have focus
        Me.KeyPreview = True
        'call the subprocess to set the current sport, while the form loads
        Call setSport()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'if the key pressed is = to the key set in settings, start the timer by `perfoming a click` on 
        'the timer button to do all that jazz
        If e.KeyChar = My.Settings.startstophotkey Then
            timerControl.PerformClick()
        End If
    End Sub

    'if the home score button is preswed increment teh score
    Private Sub HomeUp_Click(sender As Object, e As EventArgs) Handles homeUp.Click
        'don't let the score go above 99 and alert the user if they try
        If homeScore.Text >= 99 Then
            homeScore.Text = 99
            MsgBox("Score cannot exceed 99!", Title:="Error")
            Return
        End If
        'set the home score +1 it`s current value
        homeScore.Text += 1
        'Write the value of the `homeScore` to the text file, for OBS to read
        Dim scores1 As System.IO.StreamWriter
        scores1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeScore.txt", False)
        scores1.Write(homeScore.Text.ToString)
        scores1.Close()
    End Sub

    'same jazz as homeUp_Click
    Private Sub HomeDown_Click(sender As Object, e As EventArgs) Handles homeDown.Click
        If homeScore.Text < 1 Then
            homeScore.Text = 0
            MsgBox("Score cannot go below 0!", Title:="Error")
            Return
        End If
        homeScore.Text -= 1
        Dim scores1 As System.IO.StreamWriter
        scores1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeScore.txt", False)
        scores1.Write(homeScore.Text.ToString)
        scores1.Close()
    End Sub

    'same jazz as homeUp_Click
    Private Sub AwayUp_Click(sender As Object, e As EventArgs) Handles awayUp.Click
        If awayScore.Text >= 99 Then
            awayScore.Text = 99
            MsgBox("Score cannot exceed 99!", Title:="Error")
            Return
        End If
        awayScore.Text = awayScore.Text + 1
        Dim scores2 As System.IO.StreamWriter
        scores2 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/awayScore.txt", False)
        scores2.Write(awayScore.Text.ToString)
        scores2.Close()
    End Sub

    'same jazz as homeUp_Click
    Private Sub AwayDown_Click(sender As Object, e As EventArgs) Handles awayDown.Click
        If awayScore.Text < 1 Then
            awayScore.Text = 0
            MsgBox("Score cannot go below 0!", Title:="Error")
            Return
        End If
        awayScore.Text = awayScore.Text - 1
        Dim scores2 As System.IO.StreamWriter
        scores2 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/awayScore.txt", False)
        scores2.Write(awayScore.Text.ToString)
        scores2.Close()
    End Sub

    'if the set down is clicked, set the respective text file to be
    'equal to the value of the down numeric value ticker
    Private Sub DownSet_Click(sender As Object, e As EventArgs) Handles downSet.Click
        Dim var1 As System.IO.StreamWriter
        var1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/variable.txt", False)
        var1.Write(downUD.Value.ToString)
        var1.Close()
    End Sub

    'same jazz as DownSet_Click
    Private Sub YtgSet_Click(sender As Object, e As EventArgs) Handles ytgSet.Click
        Dim var1 As System.IO.StreamWriter
        var1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/variable2.txt", False)
        var1.Write(ytgUD.Value.ToString)
        var1.Close()
    End Sub

    'reset the values of the home and away teams and wipe the contents if the text files
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        homeScore.Text = 0
        awayScore.Text = 0
        Dim scores1 As System.IO.StreamWriter
        scores1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeScore.txt", False)
        scores1.Write("")
        scores1.Close()
        Dim scores2 As System.IO.StreamWriter
        scores2 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/awayScore.txt", False)
        scores2.Write("")
        scores2.Close()
    End Sub

    'set the time = to 0
    Dim time As Integer = 0
    'run this code for each tick that the time in enabled
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'check the setting to either count up or down, then add or subtract one secod
        If My.Settings.countMode = True Then
            time += 1
        Else
            time -= 1
        End If

        'calulate the number of mnutes left by dividing the total time by 60
        Dim A As Integer = time \ 60
        'calc the number of sec left by perfoming modulous aritmatic
        Dim B As Integer = (time Mod 60)
        timeMin.Text = A.ToString
        timeSec.Text = B.ToString
        'if the time is less than 0, stop the timer tick and reset the display and start button
        If time < 0 Then
            Timer1.Enabled = False
            timeDisplay.Text = "0 : 00"
            timerControl.Text = "Start"
            timerControl.BackColor = Color.Green
            Return
        End If
        'if time if more than 60 seconds, beform one of the various sections of code below
        If time > 60 Then
            timeDisplay.ForeColor = Color.Empty
            'if the seconds are less than ten, add an extra 0 to the front
            If B < 10 Then
                timeDisplay.Text = A.ToString + " : 0" + B.ToString
            Else
                'else, just displkay the time
                timeDisplay.Text = A.ToString + " : " + B.ToString
            End If
            'If the time is 60 seconds, display 1 minute
        ElseIf time = 60 Then
            timeDisplay.Text = "1 : 00"
            timeDisplay.ForeColor = Color.IndianRed
            'if the time is more than nine but also less than a minute, format like this
        ElseIf time > 9 AndAlso time < 60 Then
            timeDisplay.Text = "0 : " + B.ToString
            timeDisplay.ForeColor = Color.IndianRed
        Else
            'else format like this
            timeDisplay.Text = "0 : 0" + B.ToString
            timeDisplay.ForeColor = Color.IndianRed
        End If
        'now write whatever the time display is to a text file for use in OBS
        Dim tim As System.IO.StreamWriter
        tim = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/time.txt", False)
        tim.Write(timeDisplay.Text.ToString)
        tim.Close()
    End Sub

    'this code starts or stops teh timer
    Private Sub TimerControl_Click(sender As Object, e As EventArgs) Handles timerControl.Click
        ''if not set to count up and the time is 0, do not let the ticker start
        If time < 1 AndAlso My.Settings.countMode = False Then
            MsgBox("Can't start a timer if there is no time!", Title:="Error")
            Return
        End If
        'start the timer, hide the start button, and change the button to allow for the timer
        'to be stopped
        If timerControl.Text = "Start" Then
            Timer1.Enabled = True
            timerControl.Text = "Stop"
            timerControl.BackColor = Color.Red
            timeControl.Visible = False
        Else
            Timer1.Enabled = False
            timerControl.Text = "Start"
            timerControl.BackColor = Color.Green
            timeControl.Visible = True
        End If
    End Sub

    'reset all values of the timer element and rewrite the timer text file to `0 : 00`
    Private Sub ResetTimer_Click(sender As Object, e As EventArgs) Handles resetTimer.Click
        Timer1.Enabled = False
        timerControl.Text = "Start"
        timerControl.BackColor = Color.Green
        timerControl.Enabled = True
        timeDisplay.Text = "0 : 00"
        timeDisplay.ForeColor = Color.Empty
        timeControl.Visible = True
        timeMin.Value = 0
        timeSec.Value = 0
        Dim tim As System.IO.StreamWriter
        tim = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/time.txt", False)
        tim.Write(timeDisplay.Text.ToString)
        tim.Close()
    End Sub

    'if manually editing the time, set the new time values based on the math below
    Private Sub TimeSec_ValueChanged(sender As Object, e As EventArgs) Handles timeSec.ValueChanged
        Dim C As Double = timeMin.Value
        Dim D As Double = timeSec.Value
        time = (C * 60) + D
    End Sub
    'if manually editing the time, set the new time values based on the math below
    Private Sub TimeMin_ValueChanged(sender As Object, e As EventArgs) Handles timeMin.ValueChanged
        Dim C As Double = timeMin.Value
        Dim D As Double = timeSec.Value
        time = (C * 60) + D
    End Sub


    'rewrite the time names when the update button is clicked
    Private Sub UpdateTeamName_Click(sender As Object, e As EventArgs) Handles updateTeamName.Click
        Dim home As System.IO.StreamWriter
        Dim homeN As String = homeName.Text.ToString
        home = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/Home.txt", False)
        home.Write(homeN)
        home.Close()
        Dim away As System.IO.StreamWriter
        Dim awayN As String = awayName.Text.ToString
        away = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/Away.txt", False)
        away.Write(awayN)
        away.Close()
    End Sub

    'reset the time names when the reset button is clicked
    Private Sub ResetTeamNames_Click(sender As Object, e As EventArgs) Handles resetTeamNames.Click
        Dim home As System.IO.StreamWriter
        home = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/Home.txt", False)
        home.Write("")
        home.Close()
        Dim away As System.IO.StreamWriter
        away = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/Away.txt", False)
        away.Write("")
        away.Close()
        homeName.Text = ""
        awayName.Text = ""
    End Sub

    'reset the time periods when the reset button is clicked
    Private Sub ResetPeriod_Click(sender As Object, e As EventArgs) Handles resetPeriod.Click
        Dim per As System.IO.StreamWriter
        per = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/period.txt", False)
        per.Write("")
        per.Close()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
    End Sub

    'this sub handles whenever a radio button is pressed, and writed the value of whatever that
    'radio button is to the text file to be the `period`
    Private Sub TlPeriods_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click, RadioButton5.Click
        Dim id As String = sender.Name.Substring(11)
        Dim per As System.IO.StreamWriter
        per = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/period.txt", False)
        per.Write(id.ToString)
        per.Close()
    End Sub

    'set a home bonus - if no bonus, add one, if one bonus add two, if two, reset to none 
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles homeBonus.Click
        Dim bonus As System.IO.StreamWriter
        If sender.Text = Nothing Then
            sender.Text = "B"
            bonus = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeBonus.txt", False)
            bonus.Write("B")
            bonus.Close()
        ElseIf sender.Text = "B" Then
            sender.Text = "BB"
            bonus = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeBonus.txt", False)
            bonus.Write("BB")
            bonus.Close()
        ElseIf sender.Text = "BB" Then
            sender.Text = ""
            bonus = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeBonus.txt", False)
            bonus.Write("")
            bonus.Close()
        End If
    End Sub

    'set a home bonus - if no bonus, add one, if one bonus add two, if two, reset to none 
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles awayBonus.Click
        Dim bonus As System.IO.StreamWriter
        If sender.Text = Nothing Then
            sender.Text = "B"
            bonus = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/awayBonus.txt", False)
            bonus.Write("B")
            bonus.Close()
        ElseIf sender.Text = "B" Then
            sender.Text = "BB"
            bonus = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/awayBonus.txt", False)
            bonus.Write("BB")
            bonus.Close()
        ElseIf sender.Text = "BB" Then
            sender.Text = ""
            bonus = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/awayBonus.txt", False)
            bonus.Write("")
            bonus.Close()
        End If
    End Sub

    'set the foul on a player
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles foulSet.Click
        'get the player numner
        Dim player As Integer = NumericUpDown1.Value

        'add the players number to an array
        playerFoul.Add(player)

        'cont the number of times the player has already been added the the array to determine
        'the number of fouls the player has
        Dim numberFouls As Integer = 0
        For Each num As Integer In playerFoul
            If num = player Then
                numberFouls += 1
            End If
        Next

        'write it to the output text file
        Dim fouls As System.IO.StreamWriter
        fouls = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/fouls.txt", False)
        fouls.Write("Foul: " & player.ToString & " Foul number: " & numberFouls.ToString)
        fouls.Close()

        NumericUpDown1.Value = 0
    End Sub

    ' SETTING TAB - these are handled in the tettings tab of the code (mostly)

    'Close the form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    'set the settings to the index of whtever the sport is and call
    'the set sport subprocess
    Private Sub SettingPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles settingPeriod.SelectedIndexChanged
        Dim id As String = settingPeriod.SelectedIndex
        My.Settings.gameType = id
        My.Settings.Save()
        Call setSport()
    End Sub

    'this enables/diables the count up mode and displays a warnign on the main page
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            countModeAlert.Text = "COUNT UP MODE ENABLED"
            My.Settings.countMode = True
            My.Settings.Save()

        Else
            countModeAlert.Text = ""
            My.Settings.countMode = False
            My.Settings.Save()
        End If
    End Sub

    'opens the location of whever the written text files are
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("explorer.exe", loc + "\Outputs")
    End Sub

    'this sets the sport being playes and hides/unhides the boxes-elements needed for that specific sport
    Private Sub setSport()
        'set the `period` type
        Dim sports() As String = {"Football", "Basketball", "Volleyball", "Soccer"}
        settingPeriod.Text = sports(My.Settings.gameType)
        Label9.Text = sports(My.Settings.gameType)

        Dim periodTypes() As String = {"Quarter:", "Period:", "Set:", "Half:"}
        Label5.Text = periodTypes(My.Settings.gameType)

        'football
        If My.Settings.gameType = 0 Then
            downUD.Visible = True
            ytgUD.Visible = True
            downSet.Visible = True
            ytgSet.Visible = True
            Label10.Visible = True
            Label13.Visible = True
        Else
            downUD.Visible = False
            ytgUD.Visible = False
            downSet.Visible = False
            ytgSet.Visible = False
            Label10.Visible = False
            Label13.Visible = False
        End If

        'BB
        If My.Settings.gameType = 1 Then
            Label11.Visible = True
            NumericUpDown1.Visible = True
            foulSet.Visible = True
            Label12.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            homeBonus.Visible = True
            awayBonus.Visible = True
        Else
            Label11.Visible = False
            NumericUpDown1.Visible = False
            foulSet.Visible = False
            Label12.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            homeBonus.Visible = False
            awayBonus.Visible = False
        End If

        'soccer
        If My.Settings.gameType = 3 Then
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            RadioButton5.Visible = False
            'enable count up if soccer is selected
            My.Settings.countMode = True
            My.Settings.Save()
            CheckBox1.Checked = True
        Else
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            'don't disable cout up when soccer not selected - user may want this setting enabled!
        End If
    End Sub

    'captire stat/stop key by focusing on the `Key Box` element
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles captureHotkeyButton.Click
        captureHotkeyButton.Text = "Listening..."
        keyBox.Enabled = True
        keyBox.Text = String.Empty
        keyBox.Focus()
    End Sub

    'capture whatever is pressing and save to settings
    Private Sub KeyBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keyBox.KeyPress
        captureHotkeyButton.Text = "Capture Start/Stop Hotkey"
        'enable this box
        keyBox.Enabled = False
        'if the backspace is pressing don`t set a hotkey and exit this process to
        'prevent any more code from being executed
        If e.KeyChar = Convert.ToChar(8) Then
            hotkeyLabel.Text = "No Key Set"
            My.Settings.startstophotkey = Nothing
            My.Settings.Save()
            Exit Sub
        End If
        'get the key and save to settings
        hotkeyLabel.Text = e.KeyChar
        My.Settings.startstophotkey = e.KeyChar
        My.Settings.Save()
    End Sub

    'sets the OBS setup mode on or off - this helps arrange items in OBS
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            For Each item As String In textFiles
                Dim obsmode As System.IO.StreamWriter
                obsmode = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/" & item & ".txt", False)
                obsmode.Write(item)
                obsmode.Close()
                My.Settings.obsSetup = True
            Next
        Else
            For Each item As String In textFiles
                Dim obsmode As System.IO.StreamWriter
                obsmode = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/" & item & ".txt", False)
                obsmode.Write("")
                obsmode.Close()
                My.Settings.obsSetup = False
            Next
        End If
    End Sub
End Class