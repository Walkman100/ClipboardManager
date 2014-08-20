Public Class ClipboardSaver
    Dim ScreenCapture As System.Drawing.Image

    Private Sub ClipboardSaver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSaveLocation.Text = My.Settings.LastDir
        If txtSaveLocation.Text = "" Then
            txtSaveLocation.Text = Environment.GetEnvironmentVariable("USERPROFILE") & "\Pictures\Screenshots"
        End If
        chkShowSave.Checked = My.Settings.ShowSave
        chkShowClear.Checked = My.Settings.ShowClear
        txtDateDelimiter1.Text = My.Settings.DateDelimiter1
        txtDateDelimiter2.Text = My.Settings.DateDelimiter2
        txtDateTimeDelimiter.Text = My.Settings.DateTimeDelimiter
        txtTimeDelimiter1.Text = My.Settings.TimeDelimiter1
        txtTimeDelimiter2.Text = My.Settings.TimeDelimiter2
        txtTimeDelimiter3.Text = My.Settings.TimeDelimiter3
        txtExtension.Text = My.Settings.Extension
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith("hide") Then
                HideClipboardSaver(Nothing, Nothing)
            End If
            If s.ToLower.StartsWith("autostart") Then
                StartStop(Nothing, Nothing)
            End If
        Next
    End Sub

    Sub StartStop(sender As Object, e As EventArgs) Handles btnStartStop.Click, NotificationContextMenuStartStop.Click
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

    Private Sub SelectFolder(sender As Object, e As EventArgs) Handles btnBrowse.Click, NotificationContextMenuBrowse.Click
        FolderBrowserDialog.ShowDialog()
        txtSaveLocation.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub OpenFolder(sender As Object, e As EventArgs) Handles btnOpen.Click, NotificationContextMenuOpen.Click
        Process.Start(txtSaveLocation.Text)
    End Sub

    Sub HideClipboardSaver(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        NotificationIcon.Visible = True
    End Sub

    Sub ShowClipboardSaver(sender As Object, e As EventArgs) Handles NotificationContextMenuShow.Click, NotificationIcon.DoubleClick
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

    Private Sub lnkShowOptions_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkShowOptions.LinkClicked
        MsgBox("hide: Starts Clipboard Image Saver in the taskbar" & vbNewLine & "autostart: Start checking for images automatically" & vbNewLine & "ChangeCheckState [Only when started when an istance is already running]: Starts or stops checking for images depending on checking state before command is run", MsgBoxStyle.Information, "Clipboard image saver Launch options")
    End Sub

    Private Sub chkShowSave_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowSave.Click
        My.Settings.ShowSave = chkShowSave.Checked
    End Sub

    Private Sub chkShowClear_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowClear.Click
        My.Settings.ShowClear = chkShowClear.Checked
    End Sub

    Private Sub ClipboardSaver_KeyPress(sender As Object, e As KeyEventArgs) Handles _
            txtDateDelimiter1.KeyUp, txtDateDelimiter2.KeyUp, txtDateTimeDelimiter.KeyUp, _
            txtTimeDelimiter1.KeyUp, txtTimeDelimiter2.KeyUp, txtTimeDelimiter3.KeyUp, txtExtension.KeyUp
        My.Settings.ShowSave = chkShowSave.Checked
        My.Settings.ShowClear = chkShowClear.Checked
        My.Settings.DateDelimiter1 = txtDateDelimiter1.Text
        My.Settings.DateDelimiter2 = txtDateDelimiter2.Text
        My.Settings.DateTimeDelimiter = txtDateTimeDelimiter.Text
        My.Settings.TimeDelimiter1 = txtTimeDelimiter1.Text
        My.Settings.TimeDelimiter2 = txtTimeDelimiter2.Text
        My.Settings.TimeDelimiter3 = txtTimeDelimiter3.Text
        My.Settings.Extension = txtExtension.Text
        My.Settings.Save()
    End Sub

    Private Sub btnSaveOnce_Click(sender As Object, e As EventArgs) Handles btnSaveOnce.Click
        If Clipboard.ContainsImage = True Then
            Try
                ScreenCapture = Clipboard.GetImage
                ScreenCapture.Save(txtSaveLocation.Text & "\" & DateTime.Now.Year & txtDateDelimiter1.Text & DateTime.Now.Month & txtDateDelimiter2.Text & DateTime.Now.Day & _
                                   txtDateTimeDelimiter.Text & DateTime.Now.Hour & txtTimeDelimiter1.Text & DateTime.Now.Minute & txtTimeDelimiter2.Text & DateTime.Now.Second & _
                                   txtTimeDelimiter3.Text & DateTime.Now.Millisecond & txtExtension.Text)
            Catch ex As Exception
                TimerClipboardChecker.Stop()
                MsgBox("Error saving screenshot! The error was:" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Error Saving Screenshot!")
                TimerClipboardChecker.Start()
            End Try
        Else
            MsgBox("No image found in Clipboard!", MsgBoxStyle.Critical, "No image in clipboard")
        End If
    End Sub
End Class