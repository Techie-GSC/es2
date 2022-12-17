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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.hotkeyLabel = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.settingPeriod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.countModeAlert = New System.Windows.Forms.Label()
        Me.resetTeamNames = New System.Windows.Forms.Button()
        Me.timeControl = New System.Windows.Forms.TableLayoutPanel()
        Me.timeSec = New System.Windows.Forms.NumericUpDown()
        Me.timeMin = New System.Windows.Forms.NumericUpDown()
        Me.resetTimer = New System.Windows.Forms.Button()
        Me.timerControl = New System.Windows.Forms.Button()
        Me.timeDisplay = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tlPeriods = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.updateTeamName = New System.Windows.Forms.Button()
        Me.awayDown = New System.Windows.Forms.Button()
        Me.homeDown = New System.Windows.Forms.Button()
        Me.awayUp = New System.Windows.Forms.Button()
        Me.homeUp = New System.Windows.Forms.Button()
        Me.awayScore = New System.Windows.Forms.Label()
        Me.homeScore = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.awayName = New System.Windows.Forms.TextBox()
        Me.homeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.keyBox = New System.Windows.Forms.TextBox()
        Me.downUD = New System.Windows.Forms.NumericUpDown()
        Me.ytgUD = New System.Windows.Forms.NumericUpDown()
        Me.downSet = New System.Windows.Forms.Button()
        Me.ytgSet = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.timeControl.SuspendLayout()
        CType(Me.timeSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlPeriods.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.downUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ytgUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.hotkeyLabel)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.settingPeriod)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(532, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(380, 112)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "OBS Set Up Mode:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(279, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(179, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Press ""Backspace"" to delete hotkey"
        '
        'hotkeyLabel
        '
        Me.hotkeyLabel.AutoSize = True
        Me.hotkeyLabel.Location = New System.Drawing.Point(382, 16)
        Me.hotkeyLabel.Name = "hotkeyLabel"
        Me.hotkeyLabel.Size = New System.Drawing.Size(0, 13)
        Me.hotkeyLabel.TabIndex = 9
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(279, 29)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(143, 32)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Capture Start/Stop Hotkey"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(279, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Start/Stop Hotkey:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Tan
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(421, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 71)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Open Outputs"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(84, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Count Up:"
        '
        'settingPeriod
        '
        Me.settingPeriod.FormattingEnabled = True
        Me.settingPeriod.Items.AddRange(New Object() {"Football", "Basketball", "Volleyball", "Soccer"})
        Me.settingPeriod.Location = New System.Drawing.Point(84, 14)
        Me.settingPeriod.Name = "settingPeriod"
        Me.settingPeriod.Size = New System.Drawing.Size(82, 21)
        Me.settingPeriod.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(33, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sport:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(406, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 40)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Exit Program"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.ytgSet)
        Me.TabPage1.Controls.Add(Me.downSet)
        Me.TabPage1.Controls.Add(Me.ytgUD)
        Me.TabPage1.Controls.Add(Me.downUD)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.NumericUpDown1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.countModeAlert)
        Me.TabPage1.Controls.Add(Me.resetTeamNames)
        Me.TabPage1.Controls.Add(Me.timeControl)
        Me.TabPage1.Controls.Add(Me.resetTimer)
        Me.TabPage1.Controls.Add(Me.timerControl)
        Me.TabPage1.Controls.Add(Me.timeDisplay)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.tlPeriods)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.updateTeamName)
        Me.TabPage1.Controls.Add(Me.awayDown)
        Me.TabPage1.Controls.Add(Me.homeDown)
        Me.TabPage1.Controls.Add(Me.awayUp)
        Me.TabPage1.Controls.Add(Me.homeUp)
        Me.TabPage1.Controls.Add(Me.awayScore)
        Me.TabPage1.Controls.Add(Me.homeScore)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.awayName)
        Me.TabPage1.Controls.Add(Me.homeName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(532, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scoreboard"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(115, 340)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Away"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(70, 340)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Home"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(115, 355)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(29, 20)
        Me.Button7.TabIndex = 60
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(73, 355)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 20)
        Me.Button6.TabIndex = 59
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Bonus:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(282, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Down:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(436, 295)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 19)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Foul"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(436, 274)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(70, 20)
        Me.NumericUpDown1.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Foul by:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(288, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "YTG:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(83, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 23)
        Me.Label9.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(20, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sport:"
        '
        'countModeAlert
        '
        Me.countModeAlert.AutoSize = True
        Me.countModeAlert.ForeColor = System.Drawing.Color.Red
        Me.countModeAlert.Location = New System.Drawing.Point(233, 9)
        Me.countModeAlert.Name = "countModeAlert"
        Me.countModeAlert.Size = New System.Drawing.Size(0, 13)
        Me.countModeAlert.TabIndex = 44
        '
        'resetTeamNames
        '
        Me.resetTeamNames.Location = New System.Drawing.Point(129, 121)
        Me.resetTeamNames.Name = "resetTeamNames"
        Me.resetTeamNames.Size = New System.Drawing.Size(81, 21)
        Me.resetTeamNames.TabIndex = 7
        Me.resetTeamNames.Text = "Reset Teams"
        Me.resetTeamNames.UseVisualStyleBackColor = True
        '
        'timeControl
        '
        Me.timeControl.ColumnCount = 2
        Me.timeControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.timeControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.timeControl.Controls.Add(Me.timeSec, 1, 0)
        Me.timeControl.Controls.Add(Me.timeMin, 0, 0)
        Me.timeControl.Location = New System.Drawing.Point(249, 87)
        Me.timeControl.Name = "timeControl"
        Me.timeControl.RowCount = 1
        Me.timeControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.timeControl.Size = New System.Drawing.Size(141, 43)
        Me.timeControl.TabIndex = 42
        '
        'timeSec
        '
        Me.timeSec.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.timeSec.Location = New System.Drawing.Point(73, 3)
        Me.timeSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.timeSec.Name = "timeSec"
        Me.timeSec.Size = New System.Drawing.Size(65, 34)
        Me.timeSec.TabIndex = 1
        '
        'timeMin
        '
        Me.timeMin.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.timeMin.Location = New System.Drawing.Point(3, 3)
        Me.timeMin.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.timeMin.Name = "timeMin"
        Me.timeMin.Size = New System.Drawing.Size(64, 34)
        Me.timeMin.TabIndex = 0
        '
        'resetTimer
        '
        Me.resetTimer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.resetTimer.Location = New System.Drawing.Point(261, 197)
        Me.resetTimer.Name = "resetTimer"
        Me.resetTimer.Size = New System.Drawing.Size(117, 28)
        Me.resetTimer.TabIndex = 21
        Me.resetTimer.Text = "Reset Timer"
        Me.resetTimer.UseVisualStyleBackColor = False
        '
        'timerControl
        '
        Me.timerControl.BackColor = System.Drawing.Color.Green
        Me.timerControl.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.timerControl.Location = New System.Drawing.Point(261, 136)
        Me.timerControl.Name = "timerControl"
        Me.timerControl.Size = New System.Drawing.Size(117, 58)
        Me.timerControl.TabIndex = 20
        Me.timerControl.Text = "Start"
        Me.timerControl.UseVisualStyleBackColor = False
        '
        'timeDisplay
        '
        Me.timeDisplay.AutoSize = True
        Me.timeDisplay.Font = New System.Drawing.Font("Tahoma", 49.8!, System.Drawing.FontStyle.Bold)
        Me.timeDisplay.Location = New System.Drawing.Point(218, 15)
        Me.timeDisplay.Name = "timeDisplay"
        Me.timeDisplay.Size = New System.Drawing.Size(228, 81)
        Me.timeDisplay.TabIndex = 19
        Me.timeDisplay.Text = "0 : 00"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 20)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Reset Period"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tlPeriods
        '
        Me.tlPeriods.ColumnCount = 5
        Me.tlPeriods.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlPeriods.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlPeriods.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlPeriods.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlPeriods.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlPeriods.Controls.Add(Me.RadioButton5, 4, 0)
        Me.tlPeriods.Controls.Add(Me.RadioButton4, 3, 0)
        Me.tlPeriods.Controls.Add(Me.RadioButton3, 2, 0)
        Me.tlPeriods.Controls.Add(Me.RadioButton2, 1, 0)
        Me.tlPeriods.Controls.Add(Me.RadioButton1, 0, 0)
        Me.tlPeriods.Location = New System.Drawing.Point(71, 277)
        Me.tlPeriods.Name = "tlPeriods"
        Me.tlPeriods.RowCount = 1
        Me.tlPeriods.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlPeriods.Size = New System.Drawing.Size(180, 29)
        Me.tlPeriods.TabIndex = 17
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(147, 3)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton5.Size = New System.Drawing.Size(30, 17)
        Me.RadioButton5.TabIndex = 45
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(111, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton4.Size = New System.Drawing.Size(30, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(75, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(30, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(39, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(30, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(30, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(18, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Period:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(192, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 39)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Reset Scores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'updateTeamName
        '
        Me.updateTeamName.Location = New System.Drawing.Point(44, 121)
        Me.updateTeamName.Name = "updateTeamName"
        Me.updateTeamName.Size = New System.Drawing.Size(81, 21)
        Me.updateTeamName.TabIndex = 6
        Me.updateTeamName.Text = "Update Teams"
        Me.updateTeamName.UseVisualStyleBackColor = True
        '
        'awayDown
        '
        Me.awayDown.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.awayDown.Location = New System.Drawing.Point(144, 231)
        Me.awayDown.Name = "awayDown"
        Me.awayDown.Size = New System.Drawing.Size(28, 29)
        Me.awayDown.TabIndex = 14
        Me.awayDown.Text = "▼"
        Me.awayDown.UseVisualStyleBackColor = True
        '
        'homeDown
        '
        Me.homeDown.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.homeDown.Location = New System.Drawing.Point(71, 231)
        Me.homeDown.Name = "homeDown"
        Me.homeDown.Size = New System.Drawing.Size(28, 29)
        Me.homeDown.TabIndex = 13
        Me.homeDown.Text = "▼"
        Me.homeDown.UseVisualStyleBackColor = True
        '
        'awayUp
        '
        Me.awayUp.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.awayUp.Location = New System.Drawing.Point(142, 165)
        Me.awayUp.Name = "awayUp"
        Me.awayUp.Size = New System.Drawing.Size(28, 29)
        Me.awayUp.TabIndex = 10
        Me.awayUp.Text = "▲"
        Me.awayUp.UseVisualStyleBackColor = True
        '
        'homeUp
        '
        Me.homeUp.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.homeUp.Location = New System.Drawing.Point(71, 165)
        Me.homeUp.Name = "homeUp"
        Me.homeUp.Size = New System.Drawing.Size(28, 29)
        Me.homeUp.TabIndex = 9
        Me.homeUp.Text = "▲"
        Me.homeUp.UseVisualStyleBackColor = True
        '
        'awayScore
        '
        Me.awayScore.AutoSize = True
        Me.awayScore.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.awayScore.Location = New System.Drawing.Point(142, 196)
        Me.awayScore.Name = "awayScore"
        Me.awayScore.Size = New System.Drawing.Size(33, 37)
        Me.awayScore.TabIndex = 12
        Me.awayScore.Text = "0"
        '
        'homeScore
        '
        Me.homeScore.AutoSize = True
        Me.homeScore.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.homeScore.Location = New System.Drawing.Point(71, 196)
        Me.homeScore.Name = "homeScore"
        Me.homeScore.Size = New System.Drawing.Size(33, 37)
        Me.homeScore.TabIndex = 11
        Me.homeScore.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Team Score:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Team Name:"
        '
        'awayName
        '
        Me.awayName.Location = New System.Drawing.Point(70, 96)
        Me.awayName.Name = "awayName"
        Me.awayName.Size = New System.Drawing.Size(86, 20)
        Me.awayName.TabIndex = 5
        '
        'homeName
        '
        Me.homeName.Location = New System.Drawing.Point(71, 56)
        Me.homeName.Name = "homeName"
        Me.homeName.Size = New System.Drawing.Size(86, 20)
        Me.homeName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Away Team:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Home Team:"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(540, 469)
        Me.TabControl1.TabIndex = 0
        '
        'keyBox
        '
        Me.keyBox.Location = New System.Drawing.Point(569, 21)
        Me.keyBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.keyBox.Name = "keyBox"
        Me.keyBox.Size = New System.Drawing.Size(24, 20)
        Me.keyBox.TabIndex = 1
        '
        'downUD
        '
        Me.downUD.Location = New System.Drawing.Point(326, 259)
        Me.downUD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.downUD.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.downUD.Name = "downUD"
        Me.downUD.Size = New System.Drawing.Size(43, 20)
        Me.downUD.TabIndex = 63
        '
        'ytgUD
        '
        Me.ytgUD.Location = New System.Drawing.Point(326, 286)
        Me.ytgUD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ytgUD.Name = "ytgUD"
        Me.ytgUD.Size = New System.Drawing.Size(43, 20)
        Me.ytgUD.TabIndex = 64
        '
        'downSet
        '
        Me.downSet.Location = New System.Drawing.Point(375, 261)
        Me.downSet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.downSet.Name = "downSet"
        Me.downSet.Size = New System.Drawing.Size(43, 19)
        Me.downSet.TabIndex = 65
        Me.downSet.Text = "Set"
        Me.downSet.UseVisualStyleBackColor = True
        '
        'ytgSet
        '
        Me.ytgSet.Location = New System.Drawing.Point(375, 287)
        Me.ytgSet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ytgSet.Name = "ytgSet"
        Me.ytgSet.Size = New System.Drawing.Size(43, 19)
        Me.ytgSet.TabIndex = 66
        Me.ytgSet.Text = "Set"
        Me.ytgSet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 471)
        Me.Controls.Add(Me.keyBox)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(859, 867)
        Me.MinimumSize = New System.Drawing.Size(489, 424)
        Me.Name = "Form1"
        Me.Text = "EScorboard"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.timeControl.ResumeLayout(False)
        CType(Me.timeSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlPeriods.ResumeLayout(False)
        Me.tlPeriods.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.downUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ytgUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents settingPeriod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents countModeAlert As Label
    Friend WithEvents resetTeamNames As Button
    Friend WithEvents timeControl As TableLayoutPanel
    Friend WithEvents timeSec As NumericUpDown
    Friend WithEvents timeMin As NumericUpDown
    Friend WithEvents resetTimer As Button
    Friend WithEvents timerControl As Button
    Friend WithEvents timeDisplay As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents tlPeriods As TableLayoutPanel
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents updateTeamName As Button
    Friend WithEvents awayDown As Button
    Friend WithEvents homeDown As Button
    Friend WithEvents awayUp As Button
    Friend WithEvents homeUp As Button
    Friend WithEvents awayScore As Label
    Friend WithEvents homeScore As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents awayName As TextBox
    Friend WithEvents homeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents hotkeyLabel As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents keyBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ytgSet As Button
    Friend WithEvents downSet As Button
    Friend WithEvents ytgUD As NumericUpDown
    Friend WithEvents downUD As NumericUpDown
End Class
