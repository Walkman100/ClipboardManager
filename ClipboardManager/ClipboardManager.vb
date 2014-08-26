Public Class ClipboardManager

    Private Sub ClipboardManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerClipboardChecker.Start()
    End Sub

    Private Sub lstLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLog.SelectedIndexChanged
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
            btnMoveDown.Enabled = True
            btnMoveUp.Enabled = True
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            Clipboard.SetText(lstLog.Text)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstLog.Items.RemoveAt(lstLog.SelectedIndex)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstLog.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstLog.Items.Item(lstLog.SelectedIndex) = InputBox("Enter text to replace """ & lstLog.SelectedItem & """ with:", "Replace an item", lstLog.SelectedItem)
        End If
    End Sub

    Private Sub chkAutoSort_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoSort.CheckedChanged
        lstLog.Sorted = chkAutoSort.Checked
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click

    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstLog.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub

    Private Sub TimerClipboardChecker_Tick(sender As Object, e As EventArgs) Handles TimerClipboardChecker.Tick
        If Not lstLog.Items.Contains(Clipboard.GetText) Then
            lstLog.Items.Insert(0, Clipboard.GetText)
        End If
    End Sub
End Class
