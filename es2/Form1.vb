Imports System.Configuration
Imports System.Drawing.Imaging
Imports System.Security.Cryptography.X509Certificates
Imports System.Net
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows

Public Class Form1

    Public loc As String = My.Computer.FileSystem.CurrentDirectory
    Public playerFoul As New ArrayList
    Public textFiles = {"time", "period", "HomeScore", "Home", "AwayScore", "Away", "variable",
        "variable2", "fouls", "homeBonus", "awayBonus"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim otp As String = loc + "\Outputs"
        If System.IO.Directory.Exists(otp) = False Then
            System.IO.Directory.CreateDirectory(loc + "\Outputs")
            For Each item As String In textFiles
                File.Create(loc + "\Outputs\" & item & ".txt").Dispose()
            Next

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
        ElseIf System.IO.Directory.Exists(otp) = True Then
            Dim home As String
            home = My.Computer.FileSystem.ReadAllText(loc + "\Outputs\Home.txt")
            homeName.Text = home
            Dim away As String
            away = My.Computer.FileSystem.ReadAllText(loc + "\Outputs\Away.txt")
            awayName.Text = away
        End If
        If My.Settings.countMode = True Then
            CheckBox1.Checked = True
        End If
        If My.Settings.obsSetup = True Then
            CheckBox2.Checked = True
        End If
        hotkeyLabel.Text = My.Settings.startstophotkey
        Me.KeyPreview = True
        Call setSport()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = My.Settings.startstophotkey Then
            timerControl.PerformClick()
        End If
    End Sub

    Private Sub homeUp_Click(sender As Object, e As EventArgs) Handles homeUp.Click
        If homeScore.Text >= 99 Then
            homeScore.Text = 99
            MsgBox("Score cannot exceed 99!", Title:="Error")
            Return
        End If
        homeScore.Text += 1
        Dim scores1 As System.IO.StreamWriter
        scores1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/homeScore.txt", False)
        scores1.Write(homeScore.Text.ToString)
        scores1.Close()
    End Sub

    Private Sub homeDown_Click(sender As Object, e As EventArgs) Handles homeDown.Click
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

    Private Sub awayUp_Click(sender As Object, e As EventArgs) Handles awayUp.Click
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

    Private Sub awayDown_Click(sender As Object, e As EventArgs) Handles awayDown.Click
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
    Private Sub varUp_Click(sender As Object, e As EventArgs) Handles varUp.Click
        If varOne.Text >= 99 Then
            varOne.Text = 99
            MsgBox("Score cannot exceed 99!", Title:="Error")
            Return
        End If
        varOne.Text += 1
        Dim var1 As System.IO.StreamWriter
        var1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/variable.txt", False)
        var1.Write(varOne.Text.ToString)
        var1.Close()
    End Sub

    Private Sub varDown_Click(sender As Object, e As EventArgs) Handles varDown.Click
        If varOne.Text < 1 Then
            varOne.Text = 0
            MsgBox("Score cannot go below 0!", Title:="Error")
            Return
        End If
        varOne.Text -= 1
        Dim var2 As System.IO.StreamWriter
        var2 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/variable.txt", False)
        var2.Write(varOne.Text.ToString)
        var2.Close()
    End Sub

    Private Sub varUp2_Click(sender As Object, e As EventArgs) Handles varUp2.Click
        If varTwo.Text >= 99 Then
            varTwo.Text = 99
            MsgBox("Score cannot exceed 99!", Title:="Error")
            Return
        End If
        varTwo.Text += 1
        Dim var1 As System.IO.StreamWriter
        var1 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/variable2.txt", False)
        var1.Write(varTwo.Text.ToString)
        var1.Close()
    End Sub

    Private Sub varDown2_Click(sender As Object, e As EventArgs) Handles varDown2.Click
        If varTwo.Text < 1 Then
            varTwo.Text = 0
            MsgBox("Score cannot go below 0!", Title:="Error")
            Return
        End If
        varTwo.Text -= 1
        Dim var2 As System.IO.StreamWriter
        var2 = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/variable2.txt", False)
        var2.Write(varTwo.Text.ToString)
        var2.Close()
    End Sub
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

    Dim time As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.countMode = True Then
            time += 1
        Else
            time -= 1
        End If

        Dim A As Integer = time \ 60
        Dim B As Integer = (time Mod 60)
        timeMin.Text = A.ToString
        timeSec.Text = B.ToString
        Select Case time
            Case Is < 0
                Timer1.Enabled = False
                timeDisplay.Text = "0 : 00"
                timerControl.Text = "Start"
                timerControl.BackColor = Color.Green
                Return
        End Select
        If time > 60 Then
            timeDisplay.ForeColor = Color.Empty
            If B < 10 Then
                timeDisplay.Text = A.ToString + " : 0" + B.ToString
            Else
                timeDisplay.Text = A.ToString + " : " + B.ToString
            End If
        ElseIf time = 60 Then
            timeDisplay.Text = "1 : 00"
            timeDisplay.ForeColor = Color.IndianRed
        ElseIf time > 9 AndAlso time < 60 Then
            timeDisplay.Text = "0 : " + B.ToString
            timeDisplay.ForeColor = Color.IndianRed
        Else
            timeDisplay.Text = "0 : 0" + B.ToString
            timeDisplay.ForeColor = Color.IndianRed
        End If
        Dim tim As System.IO.StreamWriter
        tim = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/time.txt", False)
        tim.Write(timeDisplay.Text.ToString)
        tim.Close()
    End Sub

    Private Sub timerControl_Click(sender As Object, e As EventArgs) Handles timerControl.Click
        If time < 1 AndAlso My.Settings.countMode = False Then
            MsgBox("Can't start a timer if there is no time!", Title:="Error")
            Return
        End If
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

    Private Sub resetTimer_Click(sender As Object, e As EventArgs) Handles resetTimer.Click
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

    Private Sub timeSec_ValueChanged(sender As Object, e As EventArgs) Handles timeSec.ValueChanged
        Dim C As Double = timeMin.Value
        Dim D As Double = timeSec.Value
        time = (C * 60) + D
    End Sub
    Private Sub timeMin_ValueChanged(sender As Object, e As EventArgs) Handles timeMin.ValueChanged
        Dim C As Double = timeMin.Value
        Dim D As Double = timeSec.Value
        time = (C * 60) + D
    End Sub



    Private Sub updateTeamName_Click(sender As Object, e As EventArgs) Handles updateTeamName.Click
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

    Private Sub resetTeamNames_Click(sender As Object, e As EventArgs) Handles resetTeamNames.Click
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub tlPeriods_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click, RadioButton5.Click
        Dim id As String = sender.Name.Substring(11)
        Dim per As System.IO.StreamWriter
        per = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/period.txt", False)
        per.Write(id.ToString)
        per.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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

    ' SETTING TAB

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub settingPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles settingPeriod.SelectedIndexChanged
        Dim id As String = settingPeriod.SelectedIndex
        My.Settings.gameType = id
        My.Settings.Save()
        Call setSport()
    End Sub

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("explorer.exe", loc + "\Outputs")
    End Sub

    Private Sub setSport()
        'set the `period` type
        Dim sports() As String = {"Football", "Basketball", "Volleyball", "Soccer"}
        settingPeriod.Text = sports(My.Settings.gameType)
        Label9.Text = sports(My.Settings.gameType)

        Dim periodTypes() As String = {"Quarter:", "Period:", "Set:", "Half:"}
        Label5.Text = periodTypes(My.Settings.gameType)

        'football
        If My.Settings.gameType = 0 Then
            varUp.Visible = True
            varDown.Visible = True
            varOne.Visible = True
            Label10.Visible = True
            varUp2.Visible = True
            varDown2.Visible = True
            varTwo.Visible = True
            Label13.Visible = True
        Else
            varUp.Visible = False
            varDown.Visible = False
            varOne.Visible = False
            Label10.Visible = False
            varUp2.Visible = False
            varDown2.Visible = False
            varTwo.Visible = False
            Label13.Visible = False
        End If

        'BB
        If My.Settings.gameType = 1 Then
            Label11.Visible = True
            NumericUpDown1.Visible = True
            Button4.Visible = True
            Label12.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Button6.Visible = True
            Button7.Visible = True
        Else
            Label11.Visible = False
            NumericUpDown1.Visible = False
            Button4.Visible = False
            Label12.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Button6.Visible = False
            Button7.Visible = False
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim player As Integer = NumericUpDown1.Value
        playerFoul.Add(player)

        Dim numberFouls As Integer = 0
        For Each num As Integer In playerFoul
            If num = player Then
                numberFouls += 1
            End If
        Next

        Dim fouls As System.IO.StreamWriter
        fouls = My.Computer.FileSystem.OpenTextFileWriter(loc + "/Outputs/fouls.txt", False)
        fouls.Write("Foul: " & player.ToString & " Foul number: " & numberFouls.ToString)
        fouls.Close()

        NumericUpDown1.Value = 0
    End Sub

    'captire stat/stop key
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Text = "Listening..."
        keyBox.Enabled = True
        keyBox.Text = String.Empty
        keyBox.Focus()
    End Sub

    Private Sub keyBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keyBox.KeyPress
        Button8.Text = "Capture Start/Stop Hotkey"
        keyBox.Enabled = False
        If e.KeyChar = Convert.ToChar(8) Then
            hotkeyLabel.Text = "No Key Set"
            My.Settings.startstophotkey = Nothing
            My.Settings.Save()
            Exit Sub
        End If
        hotkeyLabel.Text = e.KeyChar
        My.Settings.startstophotkey = e.KeyChar
        My.Settings.Save()
    End Sub

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