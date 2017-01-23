Imports System.IO.File

Public Class ClipboardManager
    Dim toReplace As String
    Dim tmpSelIndex As Integer
    
    Private Sub ClipboardManager_Load() Handles MyBase.Load
        TimerClipboardChecker.Start()
        chkAutoSort.Checked = My.Settings.AutoSort
        optAddToStart.Checked = My.Settings.AddNewItemsToStart
        optAddToEnd.Checked = Not My.Settings.AddNewItemsToStart
        If My.Settings.MaxEntries = 0 Then
            txtMaxEntries.Value = 28
            chkMaxEntries.Checked = False
        Else
            txtMaxEntries.Value = My.Settings.MaxEntries
            chkMaxEntries.Checked = True
        End If
        If Not My.Settings.ContinuousStoragePath = "" Then
            SavingSettings.txtContinuous.Text = My.Settings.ContinuousStoragePath
            SavingSettings.chkContinuous.Checked = True
        End If
        If Not My.Settings.PersistantStoragePath = "" Then
            SavingSettings.txtPersistant.Text = My.Settings.PersistantStoragePath
            SavingSettings.chkPersistant.Checked = True
            ReadPersistant()
        End If
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
        My.Settings.AutoSort = chkAutoSort.Checked
        My.Settings.Save
        CheckButtons
    End Sub
    
    Private Sub chkMaxEntries_CheckedChanged() Handles chkMaxEntries.CheckedChanged
        grpMaxEntries.Enabled = chkMaxEntries.Checked
        If chkMaxEntries.Checked Then
            My.Settings.MaxEntries = txtMaxEntries.Value
        Else
            My.Settings.MaxEntries = 0
        End If
        My.Settings.Save
    End Sub
    
    Sub txtMaxEntries_ValueChanged() Handles txtMaxEntries.ValueChanged
        If chkMaxEntries.Checked Then
            My.Settings.MaxEntries = txtMaxEntries.Value
            My.Settings.Save
        End If
    End Sub
    
    Sub optAddToStart_CheckedChanged() Handles optAddToStart.CheckedChanged
        My.Settings.AddNewItemsToStart = optAddToStart.Checked
        My.Settings.Save
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
        My.Settings.Save
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
End Class