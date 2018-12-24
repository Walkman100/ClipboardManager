Imports System.IO.File
Imports System.IO
Imports System.Xml

Public Class ClipboardManager
    Dim toReplace As String
    Dim tmpSelIndex As Integer
    
    Dim configFileName As String = "ClipboardManager.xml"
    Dim Friend configFilePath As String = ""
    
    Private Sub ClipboardManager_Load() Handles MyBase.Load
        lblVersion.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
        
        If Environment.GetEnvironmentVariable("OS") = "Windows_NT" Then
            If Not       Directory.Exists(Path.Combine(Environment.GetEnvironmentVariable("AppData"), "WalkmanOSS")) Then
                Directory.CreateDirectory(Path.Combine(Environment.GetEnvironmentVariable("AppData"), "WalkmanOSS"))
            End If
            configFilePath =              Path.Combine(Environment.GetEnvironmentVariable("AppData"), "WalkmanOSS", configFileName)
        Else
            If Not       Directory.Exists(Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".config", "WalkmanOSS")) Then
                Directory.CreateDirectory(Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".config", "WalkmanOSS"))
            End If
            configFilePath =              Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".config", "WalkmanOSS", configFileName)
        End If
        
        If       File.Exists(Path.Combine(Application.StartupPath, configFileName)) Then
            configFilePath = Path.Combine(Application.StartupPath, configFileName)
        ElseIf File.Exists(configFileName) Then
            configFilePath = (New IO.FileInfo(configFileName)).FullName
        End If
        
        If File.Exists(configFilePath) Then
            ReadConfig()
        End If
        
        TimerClipboardChecker.Start()
    End Sub
    
    Private Sub CheckButtons() Handles lstLog.SelectedIndexChanged
        If lstLog.SelectedIndex = -1 Then
            btnCopy.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            btnLaunch.Enabled = False
            btnMoveDown.Enabled = False
            btnMoveUp.Enabled = False
        Else
            btnCopy.Enabled = True
            btnDelete.Enabled = True
            btnEdit.Enabled = True
            btnLaunch.Enabled = True
            If lstLog.SelectedIndex = 0 Then
                btnMoveUp.Enabled = False
            Else
                btnMoveUp.Enabled = True
            End If
            If lstLog.Items.Count - 1 = lstLog.SelectedIndex Then
                btnMoveDown.Enabled = False
            Else
                btnMoveDown.Enabled = True
            End If
        End If
        WritePersistant()
    End Sub

    Private Sub btnCopy_Click() Handles btnCopy.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            Clipboard.SetText(lstLog.SelectedItem)
        End If
        CheckButtons
    End Sub

    Private Sub btnDelete_Click() Handles btnDelete.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstLog.Items.RemoveAt(lstLog.SelectedIndex)
        End If
        CheckButtons
    End Sub

    Private Sub btnEdit_Click() Handles btnEdit.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            toReplace = InputBox("Enter text to replace the entry:" & vbNewLine & lstLog.SelectedItem & vbNewLine & "with:", "Edit an item", lstLog.SelectedItem)
            If toReplace <> "" Then
                lstLog.Items.Item(lstLog.SelectedIndex) = toReplace
                toReplace = ""
            End If
        End If
        CheckButtons
    End Sub
    
    Private Sub btnLaunch_Click() Handles btnLaunch.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            Try
                Shell(lstLog.SelectedItem, AppWinStyle.NormalFocus)
            Catch ex As System.IO.FileNotFoundException
                Try
                    Process.Start(lstLog.SelectedItem)
                Catch ex2 As System.ComponentModel.Win32Exception
                    If ex2.Message = "The operation was canceled by the user" Then
                    ElseIf ex2.Message = "The system cannot find the file specified" Then
                        MsgBox("File could not be found!", MsgBoxStyle.Exclamation)
                    ElseIf ex2.Message = "No application is associated with the specified file for this operation" Then
                        MsgBox("Associated program could not be found!", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("There was an error: " & ex.ToString, MsgBoxStyle.Exclamation)
                    End If
                Catch ex2 As Exception
                    MsgBox("There was an error: " & ex.ToString, MsgBoxStyle.Exclamation)
                End Try
            Catch ex As Exception
                MsgBox("There was an error: " & ex.ToString, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnMoveUp_Click() Handles btnMoveUp.Click
        tmpSelIndex = lstLog.SelectedIndex
        toReplace = lstLog.Items.Item(tmpSelIndex - 1)
        lstLog.Items.RemoveAt(tmpSelIndex - 1)
        lstLog.Items.Insert(tmpSelIndex, toReplace)
        toReplace = ""
        CheckButtons
    End Sub

    Private Sub btnMoveDown_Click() Handles btnMoveDown.Click
        tmpSelIndex = lstLog.SelectedIndex
        toReplace = lstLog.Items.Item(tmpSelIndex + 1)
        lstLog.Items.RemoveAt(tmpSelIndex + 1)
        lstLog.Items.Insert(tmpSelIndex, toReplace)
        CheckButtons
    End Sub

    Private Sub chkAutoSort_CheckedChanged() Handles chkAutoSort.CheckedChanged
        lstLog.Sorted = chkAutoSort.Checked
        SaveConfig()
        CheckButtons
    End Sub
    
    Private Sub chkMaxEntries_CheckedChanged() Handles chkMaxEntries.CheckedChanged
        grpMaxEntries.Enabled = chkMaxEntries.Checked
        SaveConfig()
    End Sub
    
    Sub txtMaxEntries_ValueChanged() Handles txtMaxEntries.ValueChanged
        SaveConfig()
    End Sub
    
    Sub optAddToStart_CheckedChanged() Handles optAddToStart.CheckedChanged
        SaveConfig()
    End Sub
    
    Sub btnSaving_Click() Handles btnSaving.Click
        SavingSettings.ShowDialog
        If SavingSettings.chkContinuous.Checked Then
            If Not Exists(SavingSettings.txtContinuous.Text) Then Create(SavingSettings.txtContinuous.Text).Close
        End If
        If SavingSettings.chkPersistant.Checked Then
            If Not Exists(SavingSettings.txtPersistant.Text) Then Create(SavingSettings.txtPersistant.Text).Close
            WritePersistant()
        End If
    End Sub

    Private Sub btnHide_Click() Handles btnHide.Click
        Me.Hide()
        TrayIcon.Visible = True
    End Sub

    Private Sub TrayIcon_Click() Handles TrayIcon.Click
        Me.Show()
        TrayIcon.Visible = False
    End Sub

    Private Sub btnClear_Click() Handles btnClear.Click
        lstLog.Items.Clear()
        CheckButtons
    End Sub

    Private Sub btnEnd_Click() Handles btnEnd.Click
        Application.Exit()
    End Sub

    Private Sub TimerClipboardChecker_Tick() Handles TimerClipboardChecker.Tick
        If Clipboard.ContainsText Then
            toReplace = Clipboard.GetText
            If Not lstLog.Items.Contains(toReplace) Then
                If SavingSettings.chkContinuous.Checked Then
                    AppendAllText(SavingSettings.txtContinuous.Text, toReplace & vbNewLine)
                End If
                If optAddToStart.Checked = True Then
                    lstLog.Items.Insert(0, toReplace)
                Else
                    lstLog.Items.Add(toReplace)
                End If
            End If
        End If
        If chkMaxEntries.Checked Then
            If lstLog.Items.Count > txtMaxEntries.Text Then
                Do Until lstLog.Items.Count <= txtMaxEntries.Text
                    lstLog.Items.RemoveAt(txtMaxEntries.Text)
                Loop
            End If
        End If
        CheckButtons
    End Sub
    
    Sub ReadPersistant
        If SavingSettings.chkPersistant.Checked Then
            lstLog.Items.Clear
            For Each item In IO.File.ReadAllLines(SavingSettings.txtPersistant.Text)
                lstLog.Items.Add(item)
            Next
        End If
    End Sub
    
    Sub WritePersistant
        If SavingSettings.chkPersistant.Checked And SavingSettings.txtPersistant.Text <> "" Then
            WriteAllText(SavingSettings.txtPersistant.Text, "")
            For Each item In lstLog.Items
                AppendAllText(SavingSettings.txtPersistant.Text, item & vbNewLine)
            Next
        End If
    End Sub
    
    Sub ReadConfig()
        Dim reader As XmlReader = XmlReader.Create(configFilePath)
        Try
            reader.Read()
        Catch ex As XmlException
            reader.Close
            Exit Sub
        End Try
        
        If reader.IsStartElement() AndAlso reader.Name = "ClipboardManager" Then
            If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "Settings" Then
                While reader.read
                    If reader.IsStartElement Then
                        Select Case reader.Name
                            Case "AutoSort"
                                reader.Read
                                If reader.Value = "True" Then chkAutoSort.Checked = True Else chkAutoSort.Checked = False
                            Case "AddNewItemsToStart"
                                reader.Read
                                If reader.Value = "True" Then optAddToStart.Checked = True Else optAddToEnd.Checked = True
                            Case "MaxEntriesEnabled"
                                reader.Read
                                If reader.Value = "True" Then chkMaxEntries.Checked = True Else chkMaxEntries.Checked = False
                            Case "MaxEntries"
                                reader.Read
                                txtMaxEntries.Value = Decimal.Parse(reader.Value)
                            Case "ContinuousStorageEnabled"
                                reader.Read
                                If reader.Value = "True" Then
                                    SavingSettings.chkContinuous.Checked = True
                                Else
                                    SavingSettings.chkContinuous.Checked = False
                                End If
                            Case "ContinuousStoragePath"
                                reader.Read
                                SavingSettings.txtContinuous.Text = reader.Value
                            Case "PersistantStorageEnabled"
                                reader.Read
                                If reader.Value = "True" Then
                                    SavingSettings.chkPersistant.Checked = True
                                Else
                                    SavingSettings.chkPersistant.Checked = False
                                End If
                            Case "PersistantStoragePath"
                                reader.Read
                                SavingSettings.txtPersistant.Text = reader.Value
                        End Select
                    End If
                End While
            End If
        End If
        
        reader.Close
    End Sub
    
    Sub SaveConfig()
        Dim XMLwSettings As New XmlWriterSettings()
        XMLwSettings.Indent = True
        Dim writer As XmlWriter = XmlWriter.Create(configFilePath, XMLwSettings)
        
        Try
            writer.WriteStartDocument()
            writer.WriteStartElement("ClipboardManager")
            
            writer.WriteStartElement("Settings")
                writer.WriteElementString("AutoSort", chkAutoSort.Checked)
                writer.WriteElementString("AddNewItemsToStart", optAddToStart.Checked)
                writer.WriteElementString("MaxEntriesEnabled", chkMaxEntries.Checked)
                writer.WriteElementString("MaxEntries", txtMaxEntries.Value)
                writer.WriteElementString("ContinuousStorageEnabled", SavingSettings.chkContinuous.Checked)
                writer.WriteElementString("ContinuousStoragePath", SavingSettings.txtContinuous.Text)
                writer.WriteElementString("PersistantStorageEnabled", SavingSettings.chkPersistant.Checked)
                writer.WriteElementString("PersistantStoragePath", SavingSettings.txtPersistant.Text)
            writer.WriteEndElement()
            
            writer.WriteEndElement()
            writer.WriteEndDocument()
        Finally
            writer.Close
        End Try
    End Sub
End Class