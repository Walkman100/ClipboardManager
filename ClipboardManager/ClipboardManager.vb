﻿Public Class ClipboardManager
    Dim toReplace As String
    Dim tmpSelIndex As Integer
    
    Private Sub ClipboardManager_Load() Handles MyBase.Load
        TimerClipboardChecker.Start()
    End Sub

    Private Sub CheckButtons() Handles lstLog.SelectedIndexChanged
        If lstLog.SelectedIndex = -1 Then
            btnCopy.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            btnMoveDown.Enabled = False
            btnMoveUp.Enabled = False
        Else
            btnCopy.Enabled = True
            btnDelete.Enabled = True
            btnEdit.Enabled = True
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
    End Sub

    Private Sub btnCopy_Click() Handles btnCopy.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            Clipboard.SetText(lstLog.SelectedItem)
        End If
        CheckButtons
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstLog.Items.RemoveAt(lstLog.SelectedIndex)
        End If
        CheckButtons
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
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

    Private Sub chkAutoSort_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoSort.CheckedChanged
        lstLog.Sorted = chkAutoSort.Checked
        CheckButtons
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        tmpSelIndex = lstLog.SelectedIndex
        toReplace = lstLog.Items.Item(tmpSelIndex - 1)
        lstLog.Items.RemoveAt(tmpSelIndex - 1)
        lstLog.Items.Insert(tmpSelIndex, toReplace)
        toReplace = ""
        CheckButtons
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        tmpSelIndex = lstLog.SelectedIndex
        toReplace = lstLog.Items.Item(tmpSelIndex + 1)
        lstLog.Items.RemoveAt(tmpSelIndex + 1)
        lstLog.Items.Insert(tmpSelIndex, toReplace)
        CheckButtons
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstLog.Items.Clear()
        CheckButtons
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub

    Private Sub TimerClipboardChecker_Tick(sender As Object, e As EventArgs) Handles TimerClipboardChecker.Tick
        toReplace = Clipboard.GetText
        If Not lstLog.Items.Contains(toReplace) Then
            lstLog.Items.Insert(0, toReplace)
            CheckButtons
        End If
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        NotifyIcon.Visible = True
    End Sub

    Private Sub NotifyIcon_Click(sender As Object, e As EventArgs) Handles NotifyIcon.Click
        Me.Show()
        NotifyIcon.Visible = False
    End Sub
End Class