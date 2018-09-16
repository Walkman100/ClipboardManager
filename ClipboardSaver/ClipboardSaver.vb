Public Class ClipboardSaver
    Dim ScreenCapture As System.Drawing.Image

    Sub ClipboardSaver_Load() Handles Me.Shown
        txtSaveLocation.Text = My.Settings.LastDir
        If txtSaveLocation.Text = "" Then
            txtSaveLocation.Text = Environment.GetEnvironmentVariable("USERPROFILE") & "\Pictures\Screenshots"
        End If
        If not IO.Directory.Exists(txtSaveLocation.text) then
            IO.Directory.CreateDirectory(txtSaveLocation.text)
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
        lblVersion.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith("hide") Then
                HideClipboardSaver()
            End If
            If s.ToLower.StartsWith("autostart") Then
                StartStop()
            End If
        Next
    End Sub

    Sub StartStop() Handles btnStartStop.Click, NotificationContextMenuStartStop.Click
        If btnStartStop.Text = "Start Checking for Images" Then
            btnStartStop.Text = "Stop Checking for Images"
            NotificationContextMenuStartStop.Text = "Stop Checking for Images"
            NotificationIcon.Text = "Clipboard Image Saver" & vbNewLine & "Checking for images"
            TimerClipboardChecker.Start()
        Else
            btnStartStop.Text = "Start Checking for Images"
            NotificationContextMenuStartStop.Text = "Start Checking for Images"
            NotificationIcon.Text = "Clipboard Image Saver" & vbNewLine & "Not checking for images."
            TimerClipboardChecker.Stop()
        End If
    End Sub

    Sub SelectFolder() Handles btnBrowse.Click, NotificationContextMenuBrowse.Click
        FolderBrowserDialog.SelectedPath = txtSaveLocation.Text
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtSaveLocation.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Sub OpenFolder() Handles btnOpen.Click, NotificationContextMenuOpen.Click
        Process.Start(txtSaveLocation.Text)
    End Sub

    Sub HideClipboardSaver() Handles btnHide.Click
        Me.Hide()
        NotificationIcon.Visible = True
    End Sub

    Sub ShowClipboardSaver() Handles NotificationContextMenuShow.Click, NotificationIcon.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront
        NotificationIcon.Visible = False
    End Sub

    Sub CloseClipboardSaver() Handles btnEnd.Click, NotificationContextMenuEnd.Click
        Application.Exit()
    End Sub

    Sub txtSaveLocation_TextChanged() Handles txtSaveLocation.TextChanged
        My.Settings.LastDir = txtSaveLocation.Text
    End Sub

    Sub TimerClipboardChecker_Tick() Handles TimerClipboardChecker.Tick
        If Clipboard.ContainsImage = True Then
            SaveClipboardImage
            Try
                Clipboard.Clear()
            Catch ex As Exception
                If chkShowClear.Checked = True Then
                    MsgBox("Error clearing clipboard after saving! (This can probably be ignored) The error was:" & vbNewLine & _
                                ex.ToString, MsgBoxStyle.Information, "Error Clearing Clipboard")
                End If
            End Try
        End If
    End Sub
    
    Sub SaveClipboardImage(Optional alwaysShow As Boolean = False)
        Try
            ScreenCapture = Clipboard.GetImage
            ScreenCapture.Save(txtSaveLocation.Text & "\" & DateTime.Now.Year & txtDateDelimiter1.Text & DateTime.Now.Month & txtDateDelimiter2.Text & DateTime.Now.Day & _
                               txtDateTimeDelimiter.Text & DateTime.Now.Hour & txtTimeDelimiter1.Text & DateTime.Now.Minute & txtTimeDelimiter2.Text & DateTime.Now.Second & _
                               txtTimeDelimiter3.Text & DateTime.Now.Millisecond & txtExtension.Text)
        Catch ex As Exception
            If chkShowSave.Checked or alwaysShow Then
                TimerClipboardChecker.Stop()
                MsgBox("Error saving screenshot! The error was:" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Error Saving Screenshot!")
                TimerClipboardChecker.Start()
            End If
        End Try
    End Sub
    
    Sub SaveDropdownClipboard_Click() Handles SaveDropdownClipboard.Click
        If Clipboard.ContainsImage = True Then
            SaveClipboardImage(True)
        Else
            MsgBox("No image found in Clipboard!", MsgBoxStyle.Critical, "No image in clipboard")
        End If
    End Sub
    
    Sub SaveDropdownCapture_Click() Handles SaveDropdownCapture.Click
        SendKeys.SendWait("{PRTSC}")
    End Sub
    
    Sub SaveDropdownCaptureSave_Click() Handles SaveDropdownCaptureSave.Click
        SaveDropdownCapture_Click
        SaveDropdownClipboard_Click
    End Sub

    Sub SaveSettings() Handles chkShowSave.Click, chkShowClear.Click, _
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

    Sub lnkShowOptions_LinkClicked() Handles lnkShowOptions.LinkClicked
        MsgBox("hide: Starts Clipboard Image Saver in the taskbar" & vbNewLine & _
               "autostart: Start checking for images automatically" & vbNewLine & _
               "ChangeCheckState [Only when started when an instance is already running]: Starts or stops checking for images depending on checking state before command is run", _
               MsgBoxStyle.Information, "Clipboard image saver Launch options")
    End Sub
End Class