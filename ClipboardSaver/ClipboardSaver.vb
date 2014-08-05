Public Class ClipboardSaver
    Dim ScreenCapture As System.Drawing.Image

    Private Sub ClipboardSaver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSaveLocation.Text = My.Settings.LastDir
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If btnStartStop.Text = "Start Checking for Images" Then
            btnStartStop.Text = "Stop Checking for Images"
            NotificationContextMenuStartStop.Text = "Stop Checking for Images"
            TimerClipboardChecker.Start()
        Else
            btnStartStop.Text = "Start Checking for Images"
            NotificationContextMenuStartStop.Text = "Start Checking for Images"
            TimerClipboardChecker.Stop()
        End If
    End Sub

    Private Sub NotificationContextMenuStartStop_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuStartStop.Click
        If NotificationContextMenuStartStop.Text = "Start Checking for Images" Then
            btnStartStop.Text = "Stop Checking for Images"
            NotificationContextMenuStartStop.Text = "Stop Checking for Images"
            TimerClipboardChecker.Start()
        Else
            btnStartStop.Text = "Start Checking for Images"
            NotificationContextMenuStartStop.Text = "Start Checking for Images"
            TimerClipboardChecker.Stop()
        End If
    End Sub

    Private Sub SelectFolder(sender As Object, e As EventArgs) Handles btnBrowse.Click, NotificationContextMenuBrowse.Click
        FolderBrowserDialog.ShowDialog()
        txtSaveLocation.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub OpenFolder(sender As Object, e As EventArgs) Handles btnOpen.Click, NotificationContextMenuOpen.Click
        Process.Start(txtSaveLocation.Text)
    End Sub

    Private Sub HideClipboardSaver(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        NotificationIcon.Visible = True
    End Sub

    Private Sub ShowClipboardSaver(sender As Object, e As EventArgs) Handles NotificationContextMenuShow.Click, NotificationIcon.DoubleClick
        Me.Show()
        NotificationIcon.Visible = False
    End Sub

    Private Sub CloseClipboardSaver(sender As Object, e As EventArgs) Handles btnEnd.Click, NotificationContextMenuEnd.Click
        Application.Exit()
    End Sub

    Private Sub txtSaveLocation_TextChanged(sender As Object, e As EventArgs) Handles txtSaveLocation.TextChanged
        My.Settings.LastDir = txtSaveLocation.Text
    End Sub

    Private Sub TimerClipboardChecker_Tick(sender As Object, e As EventArgs) Handles TimerClipboardChecker.Tick
        If Clipboard.ContainsImage = True Then
            Try
                ScreenCapture = Clipboard.GetImage
                ScreenCapture.Save(txtSaveLocation.Text & "\" & DateTime.Now.Year & txtDateDelimiter1.Text & DateTime.Now.Month & txtDateDelimiter2.Text & DateTime.Now.Day & _
                                   txtDateTimeDelimiter.Text & DateTime.Now.Hour & txtTimeDelimiter1.Text & DateTime.Now.Minute & txtTimeDelimiter2.Text & DateTime.Now.Second & _
                                   txtTimeDelimiter3.Text & DateTime.Now.Millisecond & txtExtension.Text)
            Catch ex As Exception
                If chkShowSave.Checked = True Then
                    TimerClipboardChecker.Stop()
                    MsgBox("Error saving screenshot! The error was:" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Error Saving Screenshot!")
                    TimerClipboardChecker.Start()
                End If
            End Try
            Try
                Clipboard.Clear()
            Catch ex As Exception
                If chkShowClear.Checked = True Then
                    MsgBox("Error clearing clipboard after saving! (This can probably be ignored) The error was:" & vbNewLine & ex.ToString, MsgBoxStyle.Information, "Error Clearing Clipboard")
                End If
            End Try
        End If
    End Sub
End Class