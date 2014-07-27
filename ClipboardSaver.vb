Public Class ClipboardSaver
    Dim ScreenCapture As System.Drawing.Image
    Private Sub ClipboardSaver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSaveLocation.Text = My.Settings.LastDir
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If btnStartStop.Text = "Enable Timer" Then
            btnStartStop.Text = "Disable Timer"
            NotificationContextMenuStartStop.Text = "Stop Timer"
            TimerClipboardChecker.Start()
        Else
            btnStartStop.Text = "Enable Timer"
            NotificationContextMenuStartStop.Text = "Start Timer"
            TimerClipboardChecker.Stop()
        End If
    End Sub

    Private Sub NotificationContextMenuStartStop_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuStartStop.Click
        If NotificationContextMenuStartStop.Text = "Start Timer" Then
            btnStartStop.Text = "Disable Timer"
            NotificationContextMenuStartStop.Text = "Stop Timer"
            TimerClipboardChecker.Start()
        Else
            btnStartStop.Text = "Enable Timer"
            NotificationContextMenuStartStop.Text = "Start Timer"
            TimerClipboardChecker.Stop()
        End If
    End Sub

    Private Sub SelectFolder(sender As Object, e As EventArgs) Handles btnBrowse.Click, NotificationContextMenuBrowse.Click
        FolderBrowserDialog.ShowDialog()
        txtSaveLocation.Text = FolderBrowserDialog.SelectedPath
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
            ScreenCapture = Clipboard.GetImage
            ScreenCapture.Save(DateTime.Now.Year & "." & DateTime.Now.Month & "." & DateTime.Now.Day & "_" & DateTime.Now.Hour & "." & DateTime.Now.Minute & "." & DateTime.Now.Second & "." & DateTime.Now.Millisecond & ".png")
            Clipboard.Clear()
        End If
    End Sub
End Class