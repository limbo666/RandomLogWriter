Imports System.DirectoryServices.ActiveDirectory
Imports System.IO

Public Class Form1
    Dim random As New Random()
    Dim words As New List(Of String)()
    Dim logFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\myrandomlog.log"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
        If Timer1.Enabled = True Then
            Button1.Text = "Stop"
        Else
            Button1.Text = "Start"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Generate random interval between 1 and 35 seconds
        Dim interval As Integer = random.Next(1000, 35001)
        Timer1.Interval = interval

        ' Generate random text and log it
        GenerateRandomText()
    End Sub

    Sub GetAllSettings()

        Me.Top = RegGetSetting("Settings", "Top", 100)
        Me.Left = RegGetSetting("Settings", "Left", 100)
        TxtCustom.Text = RegGetSetting("Settings", "TxtCustom", "")
        txtpath.Text = RegGetSetting("Settings", "TxtPath", "")
        If txtpath.Text = "" Then
            txtpath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\myrandomlog.log"
        End If
        ChkCritical.Checked = RegGetSetting("Settings", "ChkCritical", False)
        ChkCustom.Checked = RegGetSetting("Settings", "ChkCustom", False)
        ChkFatal.Checked = RegGetSetting("Settings", "ChkFatal", False)
        ChkError.Checked = RegGetSetting("Settings", "ChkError", False)
        ChkWarning.Checked = RegGetSetting("Settings", "ChkWarning", False)
        ChkInfo.Checked = RegGetSetting("Settings", "ChkInfo", False)
    End Sub
    Sub SaveAllSettings()
        RegSaveSetting("Settings", "Top", Me.Top)
        RegSaveSetting("Settings", "Left", Me.Left)
        RegSaveSetting("Settings", "TxtCustom", TxtCustom.Text)
        RegSaveSetting("Settings", "TxtPath", txtpath.Text)

        RegSaveSetting("Settings", "ChkCritical", ChkCritical.Checked)
        RegSaveSetting("Settings", "ChkCustom", ChkCustom.Checked)
        RegSaveSetting("Settings", "ChkFatal", ChkFatal.Checked)
        RegSaveSetting("Settings", "ChkError", ChkError.Checked)
        RegSaveSetting("Settings", "ChkWarning", ChkWarning.Checked)
        RegSaveSetting("Settings", "ChkInfo", ChkInfo.Checked)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllSettings()
        ' Load words from file
        LoadWordsFromFile()
        ' Initialize timer interval to a random value between 1 and 35 seconds
        Timer1.Interval = random.Next(1000, 35001)


    End Sub

    Private Sub LoadWordsFromFile()
        ' Check if words.txt exists in the same directory as the executable
        Dim filePath As String = Path.Combine(Application.StartupPath, "words.txt")

        If Not File.Exists(filePath) Then
            ' If words.txt doesn't exist, create it using content from the resource file "words"
            Try
                ' Get the content of the resource file "words"
                Dim wordsResource As String = My.Resources.words

                ' Write the content to words.txt
                File.WriteAllText(filePath, wordsResource)
            Catch ex As Exception
                MessageBox.Show("Error writing words.txt file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ' Now that words.txt should exist, load its content
        If File.Exists(filePath) Then
            ' Read all lines from the file
            Dim lines As String() = File.ReadAllLines(filePath)
            ' Add each line (word) to the list of words
            words.AddRange(lines)
        Else
            MessageBox.Show("Failed to create or locate words.txt file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    'Private Sub LoadWordsFromFile()
    '    ' Check if file exists
    '    Dim filePath As String = Path.Combine(Application.StartupPath, "words.txt")
    '    If File.Exists(filePath) Then
    '        ' Read all lines from the file
    '        Dim lines As String() = File.ReadAllLines(filePath)
    '        ' Add each line (word) to the list of words
    '        words.AddRange(lines)
    '    Else
    '        MessageBox.Show("Word file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Private Sub GenerateRandomText()
        If words.Count > 0 Then
            ' Initialize random text
            Dim randomText As String = ""
            ' Initialize indicator
            Dim indicator As String = ""

            ' Create a list to store the enabled indicators
            Dim enabledIndicators As New List(Of String)

            ' Check which checkboxes are enabled and add their indicators to the list
            If ChkInfo.Checked Then
                enabledIndicators.Add("Info:")
            End If
            If ChkWarning.Checked Then
                enabledIndicators.Add("Warning:")
            End If
            If ChkError.Checked Then
                enabledIndicators.Add("Error:")
            End If
            If ChkCritical.Checked Then
                enabledIndicators.Add("Critical:")
            End If
            If ChkFatal.Checked Then
                enabledIndicators.Add("Fatal:")
            End If
            If ChkCustom.Checked Then
                enabledIndicators.Add(TxtCustom.Text.Trim() & ":")
            End If

            ' Check if any indicators are enabled
            If enabledIndicators.Count > 0 Then
                ' Choose a random indicator from the list of enabled indicators
                indicator = enabledIndicators(random.Next(enabledIndicators.Count))
            End If

            ' Generate three random lines
            For i As Integer = 1 To 3
                ' Generate a random index to select a word from the list
                Dim randomIndex As Integer = random.Next(0, words.Count)
                ' Select a random word
                Dim randomWord As String = words(randomIndex)
                ' Append random word to the random text
                randomText &= randomWord & " "
            Next

            ' Format the current date time
            Dim formattedDateTime As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")
            ' Generate the log line
            Dim logLine As String = $"{formattedDateTime}    {indicator}{randomText.Trim()}"
            ' Append the log line to the log file
            File.AppendAllText(logFilePath, logLine & Environment.NewLine)
            ' Display the time on Label1
            Label1.Text = formattedDateTime
            ' Display the random text on Label2
            Label2.Text = randomText.Trim()
        Else
            MessageBox.Show("No words available to generate random text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ChkCustom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustom.CheckedChanged
        TxtCustom.Enabled = ChkCustom.Checked
    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectfile.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Log files (*.log)|*.log|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            logFilePath = openFileDialog.FileName
            txtpath.Text = logFilePath
        End If

        ' Create an empty file if it doesn't exist
        If Not File.Exists(logFilePath) Then
            File.Create(logFilePath).Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Generate random text and log it
        GenerateRandomText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmAbout.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Log files (*.log)|*.log|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.FileName = "mylog"
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Add the appropriate file extension if not provided by the user
            If Path.GetExtension(filePath) = "" Then
                filePath &= ".log" ' Default extension is .log
            End If

            ' Create an empty file if it doesn't exist
            If Not File.Exists(filePath) Then
                Try
                    File.Create(filePath).Close()
                    MessageBox.Show("Log file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error creating log file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("File already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Assign the filename path to the TextBox
            txtpath.Text = filePath
        End If
    End Sub

    Private Sub txtpath_TextChanged(sender As Object, e As EventArgs) Handles txtpath.TextChanged
        logFilePath = txtpath.Text
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveAllSettings()
    End Sub
End Class

'Imports System.IO

'Public Class Form1
'    Dim random As New Random()
'    Dim words As New List(Of String)()
'    Dim logFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\myrandomlog.log"

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        Timer1.Enabled = Not Timer1.Enabled
'        If Timer1.Enabled = True Then
'            Button1.Text = "Stop"
'        Else
'            Button1.Text = "Start"
'        End If
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        ' Generate random interval between 1 and 35 seconds
'        Dim interval As Integer = random.Next(1000, 35001)
'        Timer1.Interval = interval

'        ' Generate random text and log it
'        GenerateRandomText()
'    End Sub

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Initialize timer interval to a random value between 1 and 35 seconds
'        Timer1.Interval = random.Next(1000, 35001)

'        ' Load words from file
'        LoadWordsFromFile()
'    End Sub

'    Private Sub LoadWordsFromFile()
'        ' Check if file exists
'        Dim filePath As String = Path.Combine(Application.StartupPath, "words.txt")
'        If File.Exists(filePath) Then
'            ' Read all lines from the file
'            Dim lines As String() = File.ReadAllLines(filePath)
'            ' Add each line (word) to the list of words
'            words.AddRange(lines)
'        Else
'            MessageBox.Show("Word file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End If
'    End Sub

'    'Private Sub GenerateRandomText()
'    '    If words.Count > 0 Then
'    '        ' Initialize random text
'    '        Dim randomText As String = ""
'    '        ' Generate three random lines
'    '        For i As Integer = 1 To 3
'    '            ' Generate a random index to select a word from the list
'    '            Dim randomIndex As Integer = random.Next(0, words.Count)
'    '            ' Select a random word
'    '            Dim randomWord As String = words(randomIndex)
'    '            ' Append random word to the random text
'    '            randomText &= randomWord & " "
'    '        Next
'    '        ' Format the current date time
'    '        Dim formattedDateTime As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")
'    '        ' Generate the log line
'    '        Dim logLine As String = $"{formattedDateTime}    {randomText.Trim()}"
'    '        ' Append the log line to the log file
'    '        File.AppendAllText(logFilePath, logLine & Environment.NewLine)
'    '        ' Display the time on Label1
'    '        Label1.Text = formattedDateTime
'    '        ' Display the random text on Label2
'    '        Label2.Text = randomText.Trim()
'    '    Else
'    '        MessageBox.Show("No words available to generate random text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    '    End If
'    'End Sub

'    Private Sub GenerateRandomText()
'        If words.Count > 0 Then
'            ' Initialize random text
'            Dim randomText As String = ""
'            ' Initialize indicator
'            Dim indicator As String = ""

'            ' Create a list to store the enabled indicators
'            Dim enabledIndicators As New List(Of String)

'            ' Check which checkboxes are enabled and add their indicators to the list
'            If ChkInfo.Checked Then
'                enabledIndicators.Add("Info:")
'            End If
'            If ChkWarning.Checked Then
'                enabledIndicators.Add("Warning:")
'            End If
'            If ChkError.Checked Then
'                enabledIndicators.Add("Error:")
'            End If
'            If ChkCritical.Checked Then
'                enabledIndicators.Add("Critical:")
'            End If
'            If ChkFatal.Checked Then
'                enabledIndicators.Add("Fatal:")
'            End If
'            If ChkCustom.Checked Then
'                enabledIndicators.Add(TxtCustom.Text.Trim() & ":")
'            End If

'            ' Check if any indicators are enabled
'            If enabledIndicators.Count > 0 Then
'                ' Choose a random indicator from the list of enabled indicators
'                indicator = enabledIndicators(random.Next(enabledIndicators.Count))
'            End If

'            ' Generate three random lines
'            For i As Integer = 1 To 3
'                ' Generate a random index to select a word from the list
'                Dim randomIndex As Integer = random.Next(0, words.Count)
'                ' Select a random word
'                Dim randomWord As String = words(randomIndex)
'                ' Append random word to the random text
'                randomText &= randomWord & " "
'            Next

'            ' Format the current date time
'            Dim formattedDateTime As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")
'            ' Generate the log line
'            Dim logLine As String = $"{formattedDateTime}    {indicator}{randomText.Trim()}"
'            ' Append the log line to the log file
'            File.AppendAllText(logFilePath, logLine & Environment.NewLine)
'            ' Display the time on Label1
'            Label1.Text = formattedDateTime
'            ' Display the random text on Label2
'            Label2.Text = randomText.Trim()
'        Else
'            MessageBox.Show("No words available to generate random text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End If
'    End Sub



'    'Private Sub GenerateRandomText()
'    '    If words.Count > 0 Then
'    '        ' Initialize random text
'    '        Dim randomText As String = ""
'    '        ' Initialize indicator
'    '        Dim indicator As String = ""

'    '        ' Create a list to store the enabled indicators
'    '        Dim enabledIndicators As New List(Of String)

'    '        ' Check which checkboxes are enabled and add their indicators to the list
'    '        If ChkInfo.Checked Then
'    '            enabledIndicators.Add("Info:")
'    '        End If
'    '        If ChkWarning.Checked Then
'    '            enabledIndicators.Add("Warning:")
'    '        End If
'    '        If ChkError.Checked Then
'    '            enabledIndicators.Add("Error:")
'    '        End If
'    '        If ChkCritical.Checked Then
'    '            enabledIndicators.Add("Critical:")
'    '        End If
'    '        If ChkFatal.Checked Then
'    '            enabledIndicators.Add("Fatal:")
'    '        End If
'    '        If ChkCustom.Checked Then
'    '            enabledIndicators.Add(TxtCustom.Text.Trim() & ":")
'    '        End If

'    '        ' Check if any indicators are enabled
'    '        If enabledIndicators.Count > 0 Then
'    '            ' Choose a random indicator from the list of enabled indicators
'    '            indicator = enabledIndicators(random.Next(enabledIndicators.Count))

'    '            ' Generate three random lines
'    '            For i As Integer = 1 To 3
'    '                ' Generate a random index to select a word from the list
'    '                Dim randomIndex As Integer = random.Next(0, words.Count)
'    '                ' Select a random word
'    '                Dim randomWord As String = words(randomIndex)
'    '                ' Append random word to the random text
'    '                randomText &= randomWord & " "
'    '            Next

'    '            ' Format the current date time
'    '            Dim formattedDateTime As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")
'    '            ' Generate the log line
'    '            Dim logLine As String = $"{formattedDateTime}    {indicator}    {randomText.Trim()}"
'    '            ' Append the log line to the log file
'    '            File.AppendAllText(logFilePath, logLine & Environment.NewLine)
'    '            ' Display the time on Label1
'    '            Label1.Text = formattedDateTime
'    '            ' Display the random text on Label2
'    '            Label2.Text = randomText.Trim()
'    '        Else
'    '            MessageBox.Show("No indicators are enabled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    '        End If
'    '    Else
'    '        MessageBox.Show("No words available to generate random text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    '    End If
'    'End Sub




'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        ' Generate random text and log it
'        GenerateRandomText()
'    End Sub

'    Private Sub ChkCustom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustom.CheckedChanged
'        txtCustom.enabled = ChkCustom.Checked
'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        FrmAbout.ShowDialog()

'    End Sub
'End Class
