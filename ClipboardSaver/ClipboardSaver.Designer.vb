<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClipboardSaver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClipboardSaver))
        Me.txtSaveLocation = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.NotificationIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotificationContextMenuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuStartStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerClipboardChecker = New System.Windows.Forms.Timer(Me.components)
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtDateDelimiter1 = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.grpNameFormat = New System.Windows.Forms.GroupBox()
        Me.txtDateDelimiter2 = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtDateTimeDelimiter = New System.Windows.Forms.TextBox()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.txtTimeDelimiter1 = New System.Windows.Forms.TextBox()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.txtTimeDelimiter2 = New System.Windows.Forms.TextBox()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.txtTimeDelimiter3 = New System.Windows.Forms.TextBox()
        Me.lblMillisecond = New System.Windows.Forms.Label()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.NotificationContextMenu.SuspendLayout()
        Me.grpNameFormat.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaveLocation.Location = New System.Drawing.Point(12, 12)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.ReadOnly = True
        Me.txtSaveLocation.Size = New System.Drawing.Size(504, 20)
        Me.txtSaveLocation.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(12, 38)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartStop.Location = New System.Drawing.Point(174, 38)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(180, 23)
        Me.btnStartStop.TabIndex = 3
        Me.btnStartStop.Text = "Enable Timer"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.Location = New System.Drawing.Point(360, 38)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(441, 38)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "Close"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'NotificationIcon
        '
        Me.NotificationIcon.ContextMenuStrip = Me.NotificationContextMenu
        Me.NotificationIcon.Icon = CType(resources.GetObject("NotificationIcon.Icon"), System.Drawing.Icon)
        Me.NotificationIcon.Text = "Clipboard Image Saver"
        '
        'NotificationContextMenu
        '
        Me.NotificationContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationContextMenuShow, Me.NotificationContextMenuBrowse, Me.NotificationContextMenuStartStop, Me.NotificationContextMenuEnd})
        Me.NotificationContextMenu.Name = "NotificationContextMenu"
        Me.NotificationContextMenu.Size = New System.Drawing.Size(256, 92)
        '
        'NotificationContextMenuShow
        '
        Me.NotificationContextMenuShow.Name = "NotificationContextMenuShow"
        Me.NotificationContextMenuShow.Size = New System.Drawing.Size(255, 22)
        Me.NotificationContextMenuShow.Text = "Show Clipboard Image Saver"
        '
        'NotificationContextMenuBrowse
        '
        Me.NotificationContextMenuBrowse.Name = "NotificationContextMenuBrowse"
        Me.NotificationContextMenuBrowse.Size = New System.Drawing.Size(255, 22)
        Me.NotificationContextMenuBrowse.Text = "Change Screenshot Directory..."
        '
        'NotificationContextMenuStartStop
        '
        Me.NotificationContextMenuStartStop.Name = "NotificationContextMenuStartStop"
        Me.NotificationContextMenuStartStop.Size = New System.Drawing.Size(255, 22)
        Me.NotificationContextMenuStartStop.Text = "Start Timer"
        '
        'NotificationContextMenuEnd
        '
        Me.NotificationContextMenuEnd.Name = "NotificationContextMenuEnd"
        Me.NotificationContextMenuEnd.Size = New System.Drawing.Size(255, 22)
        Me.NotificationContextMenuEnd.Text = "Close"
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Select a folder to save images to:"
        '
        'TimerClipboardChecker
        '
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(93, 38)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtDateDelimiter1
        '
        Me.txtDateDelimiter1.Location = New System.Drawing.Point(41, 19)
        Me.txtDateDelimiter1.MaxLength = 2
        Me.txtDateDelimiter1.Name = "txtDateDelimiter1"
        Me.txtDateDelimiter1.Size = New System.Drawing.Size(20, 20)
        Me.txtDateDelimiter1.TabIndex = 8
        Me.txtDateDelimiter1.Text = "-"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(6, 22)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Year"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(67, 22)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblMonth.TabIndex = 9
        Me.lblMonth.Text = "Month"
        '
        'grpNameFormat
        '
        Me.grpNameFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNameFormat.Controls.Add(Me.txtExtension)
        Me.grpNameFormat.Controls.Add(Me.lblMillisecond)
        Me.grpNameFormat.Controls.Add(Me.txtTimeDelimiter3)
        Me.grpNameFormat.Controls.Add(Me.lblSecond)
        Me.grpNameFormat.Controls.Add(Me.txtTimeDelimiter2)
        Me.grpNameFormat.Controls.Add(Me.lblMinute)
        Me.grpNameFormat.Controls.Add(Me.lblYear)
        Me.grpNameFormat.Controls.Add(Me.txtTimeDelimiter1)
        Me.grpNameFormat.Controls.Add(Me.txtDateDelimiter1)
        Me.grpNameFormat.Controls.Add(Me.lblHour)
        Me.grpNameFormat.Controls.Add(Me.lblMonth)
        Me.grpNameFormat.Controls.Add(Me.txtDateTimeDelimiter)
        Me.grpNameFormat.Controls.Add(Me.txtDateDelimiter2)
        Me.grpNameFormat.Controls.Add(Me.lblDay)
        Me.grpNameFormat.Location = New System.Drawing.Point(12, 67)
        Me.grpNameFormat.Name = "grpNameFormat"
        Me.grpNameFormat.Size = New System.Drawing.Size(504, 45)
        Me.grpNameFormat.TabIndex = 6
        Me.grpNameFormat.TabStop = False
        Me.grpNameFormat.Text = "File name format"
        '
        'txtDateDelimiter2
        '
        Me.txtDateDelimiter2.Location = New System.Drawing.Point(110, 19)
        Me.txtDateDelimiter2.MaxLength = 2
        Me.txtDateDelimiter2.Name = "txtDateDelimiter2"
        Me.txtDateDelimiter2.Size = New System.Drawing.Size(20, 20)
        Me.txtDateDelimiter2.TabIndex = 10
        Me.txtDateDelimiter2.Text = "-"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(136, 22)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(26, 13)
        Me.lblDay.TabIndex = 11
        Me.lblDay.Text = "Day"
        '
        'txtDateTimeDelimiter
        '
        Me.txtDateTimeDelimiter.Location = New System.Drawing.Point(168, 19)
        Me.txtDateTimeDelimiter.MaxLength = 2
        Me.txtDateTimeDelimiter.Name = "txtDateTimeDelimiter"
        Me.txtDateTimeDelimiter.Size = New System.Drawing.Size(20, 20)
        Me.txtDateTimeDelimiter.TabIndex = 12
        Me.txtDateTimeDelimiter.Text = "_"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(194, 22)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(30, 13)
        Me.lblHour.TabIndex = 13
        Me.lblHour.Text = "Hour"
        '
        'txtTimeDelimiter1
        '
        Me.txtTimeDelimiter1.Location = New System.Drawing.Point(230, 19)
        Me.txtTimeDelimiter1.MaxLength = 2
        Me.txtTimeDelimiter1.Name = "txtTimeDelimiter1"
        Me.txtTimeDelimiter1.Size = New System.Drawing.Size(20, 20)
        Me.txtTimeDelimiter1.TabIndex = 14
        Me.txtTimeDelimiter1.Text = "."
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = True
        Me.lblMinute.Location = New System.Drawing.Point(256, 22)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(39, 13)
        Me.lblMinute.TabIndex = 15
        Me.lblMinute.Text = "Minute"
        '
        'txtTimeDelimiter2
        '
        Me.txtTimeDelimiter2.Location = New System.Drawing.Point(301, 19)
        Me.txtTimeDelimiter2.MaxLength = 2
        Me.txtTimeDelimiter2.Name = "txtTimeDelimiter2"
        Me.txtTimeDelimiter2.Size = New System.Drawing.Size(20, 20)
        Me.txtTimeDelimiter2.TabIndex = 16
        Me.txtTimeDelimiter2.Text = "."
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(327, 22)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(44, 13)
        Me.lblSecond.TabIndex = 17
        Me.lblSecond.Text = "Second"
        '
        'txtTimeDelimiter3
        '
        Me.txtTimeDelimiter3.Location = New System.Drawing.Point(377, 19)
        Me.txtTimeDelimiter3.MaxLength = 2
        Me.txtTimeDelimiter3.Name = "txtTimeDelimiter3"
        Me.txtTimeDelimiter3.Size = New System.Drawing.Size(20, 20)
        Me.txtTimeDelimiter3.TabIndex = 18
        Me.txtTimeDelimiter3.Text = "."
        '
        'lblMillisecond
        '
        Me.lblMillisecond.AutoSize = True
        Me.lblMillisecond.Location = New System.Drawing.Point(403, 22)
        Me.lblMillisecond.Name = "lblMillisecond"
        Me.lblMillisecond.Size = New System.Drawing.Size(59, 13)
        Me.lblMillisecond.TabIndex = 19
        Me.lblMillisecond.Text = "Millisecond"
        '
        'txtExtension
        '
        Me.txtExtension.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExtension.Location = New System.Drawing.Point(468, 19)
        Me.txtExtension.MaxLength = 6
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(30, 20)
        Me.txtExtension.TabIndex = 20
        Me.txtExtension.Text = ".png"
        '
        'ClipboardSaver
        '
        Me.AcceptButton = Me.btnStartStop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(528, 127)
        Me.Controls.Add(Me.grpNameFormat)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtSaveLocation)
        Me.HelpButton = True
        Me.Name = "ClipboardSaver"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Image Saver"
        Me.NotificationContextMenu.ResumeLayout(False)
        Me.grpNameFormat.ResumeLayout(False)
        Me.grpNameFormat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSaveLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents NotificationIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TimerClipboardChecker As System.Windows.Forms.Timer
    Friend WithEvents NotificationContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NotificationContextMenuShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuStartStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtDateDelimiter1 As System.Windows.Forms.TextBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents grpNameFormat As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateDelimiter2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents txtDateTimeDelimiter As System.Windows.Forms.TextBox
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents txtTimeDelimiter1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMinute As System.Windows.Forms.Label
    Friend WithEvents lblMillisecond As System.Windows.Forms.Label
    Friend WithEvents txtTimeDelimiter3 As System.Windows.Forms.TextBox
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtTimeDelimiter2 As System.Windows.Forms.TextBox
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox

End Class
