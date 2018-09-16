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
        Me.NotificationContextMenuBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationContextMenuStartStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuSeperator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationContextMenuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerClipboardChecker = New System.Windows.Forms.Timer(Me.components)
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtDateDelimiter1 = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.grpNameFormat = New System.Windows.Forms.GroupBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.lblMillisecond = New System.Windows.Forms.Label()
        Me.txtTimeDelimiter3 = New System.Windows.Forms.TextBox()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.txtTimeDelimiter2 = New System.Windows.Forms.TextBox()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.txtTimeDelimiter1 = New System.Windows.Forms.TextBox()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.txtDateTimeDelimiter = New System.Windows.Forms.TextBox()
        Me.txtDateDelimiter2 = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.chkShowSave = New System.Windows.Forms.CheckBox()
        Me.chkShowClear = New System.Windows.Forms.CheckBox()
        Me.lnkShowOptions = New System.Windows.Forms.LinkLabel()
        Me.SaveToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveDropdown = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveDropdownClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDropdownCapture = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDropdownCaptureSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.NotificationContextMenu.SuspendLayout
        Me.grpNameFormat.SuspendLayout
        Me.SaveToolStrip.SuspendLayout
        Me.SuspendLayout
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtSaveLocation.Location = New System.Drawing.Point(12, 12)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.ReadOnly = true
        Me.txtSaveLocation.Size = New System.Drawing.Size(442, 20)
        Me.txtSaveLocation.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(12, 38)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'btnStartStop
        '
        Me.btnStartStop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnStartStop.Location = New System.Drawing.Point(174, 38)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(180, 23)
        Me.btnStartStop.TabIndex = 3
        Me.btnStartStop.Text = "Start Checking for Images"
        Me.btnStartStop.UseVisualStyleBackColor = true
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnHide.Location = New System.Drawing.Point(360, 38)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = true
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(441, 38)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "Close"
        Me.btnEnd.UseVisualStyleBackColor = true
        '
        'NotificationIcon
        '
        Me.NotificationIcon.ContextMenuStrip = Me.NotificationContextMenu
        Me.NotificationIcon.Icon = CType(resources.GetObject("NotificationIcon.Icon"),System.Drawing.Icon)
        Me.NotificationIcon.Text = "Clipboard Image Saver"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Not checking for images."
        '
        'NotificationContextMenu
        '
        Me.NotificationContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationContextMenuBrowse, Me.NotificationContextMenuOpen, Me.NotificationContextMenuSeperator1, Me.NotificationContextMenuStartStop, Me.NotificationContextMenuSeperator2, Me.NotificationContextMenuShow, Me.NotificationContextMenuEnd})
        Me.NotificationContextMenu.Name = "NotificationContextMenu"
        Me.NotificationContextMenu.Size = New System.Drawing.Size(263, 148)
        '
        'NotificationContextMenuBrowse
        '
        Me.NotificationContextMenuBrowse.Name = "NotificationContextMenuBrowse"
        Me.NotificationContextMenuBrowse.Size = New System.Drawing.Size(262, 22)
        Me.NotificationContextMenuBrowse.Text = "Change Screenshot Directory..."
        '
        'NotificationContextMenuOpen
        '
        Me.NotificationContextMenuOpen.Name = "NotificationContextMenuOpen"
        Me.NotificationContextMenuOpen.Size = New System.Drawing.Size(262, 22)
        Me.NotificationContextMenuOpen.Text = "Open screenshot folder"
        '
        'NotificationContextMenuSeperator1
        '
        Me.NotificationContextMenuSeperator1.Name = "NotificationContextMenuSeperator1"
        Me.NotificationContextMenuSeperator1.Size = New System.Drawing.Size(259, 6)
        '
        'NotificationContextMenuStartStop
        '
        Me.NotificationContextMenuStartStop.Name = "NotificationContextMenuStartStop"
        Me.NotificationContextMenuStartStop.Size = New System.Drawing.Size(262, 22)
        Me.NotificationContextMenuStartStop.Text = "Start Checking for Images"
        '
        'NotificationContextMenuSeperator2
        '
        Me.NotificationContextMenuSeperator2.Name = "NotificationContextMenuSeperator2"
        Me.NotificationContextMenuSeperator2.Size = New System.Drawing.Size(259, 6)
        '
        'NotificationContextMenuShow
        '
        Me.NotificationContextMenuShow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NotificationContextMenuShow.Name = "NotificationContextMenuShow"
        Me.NotificationContextMenuShow.Size = New System.Drawing.Size(262, 22)
        Me.NotificationContextMenuShow.Text = "Show Clipboard Image Saver"
        '
        'NotificationContextMenuEnd
        '
        Me.NotificationContextMenuEnd.Name = "NotificationContextMenuEnd"
        Me.NotificationContextMenuEnd.Size = New System.Drawing.Size(262, 22)
        Me.NotificationContextMenuEnd.Text = "Close"
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Select a folder to save images to:"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(93, 38)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = true
        '
        'txtDateDelimiter1
        '
        Me.txtDateDelimiter1.Location = New System.Drawing.Point(41, 19)
        Me.txtDateDelimiter1.MaxLength = 1
        Me.txtDateDelimiter1.Name = "txtDateDelimiter1"
        Me.txtDateDelimiter1.Size = New System.Drawing.Size(20, 20)
        Me.txtDateDelimiter1.TabIndex = 8
        Me.txtDateDelimiter1.Text = "-"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = true
        Me.lblYear.Location = New System.Drawing.Point(6, 22)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Year"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = true
        Me.lblMonth.Location = New System.Drawing.Point(67, 22)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblMonth.TabIndex = 9
        Me.lblMonth.Text = "Month"
        '
        'grpNameFormat
        '
        Me.grpNameFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.grpNameFormat.TabStop = false
        Me.grpNameFormat.Text = "File name format"
        '
        'txtExtension
        '
        Me.txtExtension.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtExtension.Location = New System.Drawing.Point(468, 19)
        Me.txtExtension.MaxLength = 6
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(30, 20)
        Me.txtExtension.TabIndex = 20
        Me.txtExtension.Text = ".png"
        '
        'lblMillisecond
        '
        Me.lblMillisecond.AutoSize = true
        Me.lblMillisecond.Location = New System.Drawing.Point(403, 22)
        Me.lblMillisecond.Name = "lblMillisecond"
        Me.lblMillisecond.Size = New System.Drawing.Size(59, 13)
        Me.lblMillisecond.TabIndex = 19
        Me.lblMillisecond.Text = "Millisecond"
        '
        'txtTimeDelimiter3
        '
        Me.txtTimeDelimiter3.Location = New System.Drawing.Point(377, 19)
        Me.txtTimeDelimiter3.MaxLength = 1
        Me.txtTimeDelimiter3.Name = "txtTimeDelimiter3"
        Me.txtTimeDelimiter3.Size = New System.Drawing.Size(20, 20)
        Me.txtTimeDelimiter3.TabIndex = 18
        Me.txtTimeDelimiter3.Text = "."
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = true
        Me.lblSecond.Location = New System.Drawing.Point(327, 22)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(44, 13)
        Me.lblSecond.TabIndex = 17
        Me.lblSecond.Text = "Second"
        '
        'txtTimeDelimiter2
        '
        Me.txtTimeDelimiter2.Location = New System.Drawing.Point(301, 19)
        Me.txtTimeDelimiter2.MaxLength = 1
        Me.txtTimeDelimiter2.Name = "txtTimeDelimiter2"
        Me.txtTimeDelimiter2.Size = New System.Drawing.Size(20, 20)
        Me.txtTimeDelimiter2.TabIndex = 16
        Me.txtTimeDelimiter2.Text = "."
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = true
        Me.lblMinute.Location = New System.Drawing.Point(256, 22)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(39, 13)
        Me.lblMinute.TabIndex = 15
        Me.lblMinute.Text = "Minute"
        '
        'txtTimeDelimiter1
        '
        Me.txtTimeDelimiter1.Location = New System.Drawing.Point(230, 19)
        Me.txtTimeDelimiter1.MaxLength = 1
        Me.txtTimeDelimiter1.Name = "txtTimeDelimiter1"
        Me.txtTimeDelimiter1.Size = New System.Drawing.Size(20, 20)
        Me.txtTimeDelimiter1.TabIndex = 14
        Me.txtTimeDelimiter1.Text = "."
        '
        'lblHour
        '
        Me.lblHour.AutoSize = true
        Me.lblHour.Location = New System.Drawing.Point(194, 22)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(30, 13)
        Me.lblHour.TabIndex = 13
        Me.lblHour.Text = "Hour"
        '
        'txtDateTimeDelimiter
        '
        Me.txtDateTimeDelimiter.Location = New System.Drawing.Point(168, 19)
        Me.txtDateTimeDelimiter.MaxLength = 1
        Me.txtDateTimeDelimiter.Name = "txtDateTimeDelimiter"
        Me.txtDateTimeDelimiter.Size = New System.Drawing.Size(20, 20)
        Me.txtDateTimeDelimiter.TabIndex = 12
        Me.txtDateTimeDelimiter.Text = "_"
        '
        'txtDateDelimiter2
        '
        Me.txtDateDelimiter2.Location = New System.Drawing.Point(110, 19)
        Me.txtDateDelimiter2.MaxLength = 1
        Me.txtDateDelimiter2.Name = "txtDateDelimiter2"
        Me.txtDateDelimiter2.Size = New System.Drawing.Size(20, 20)
        Me.txtDateDelimiter2.TabIndex = 10
        Me.txtDateDelimiter2.Text = "-"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = true
        Me.lblDay.Location = New System.Drawing.Point(136, 22)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(26, 13)
        Me.lblDay.TabIndex = 11
        Me.lblDay.Text = "Day"
        '
        'chkShowSave
        '
        Me.chkShowSave.AutoSize = true
        Me.chkShowSave.Checked = true
        Me.chkShowSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowSave.Location = New System.Drawing.Point(12, 118)
        Me.chkShowSave.Name = "chkShowSave"
        Me.chkShowSave.Size = New System.Drawing.Size(110, 17)
        Me.chkShowSave.TabIndex = 7
        Me.chkShowSave.Text = "Show Save errors"
        Me.chkShowSave.UseVisualStyleBackColor = true
        '
        'chkShowClear
        '
        Me.chkShowClear.AutoSize = true
        Me.chkShowClear.Location = New System.Drawing.Point(128, 118)
        Me.chkShowClear.Name = "chkShowClear"
        Me.chkShowClear.Size = New System.Drawing.Size(109, 17)
        Me.chkShowClear.TabIndex = 8
        Me.chkShowClear.Text = "Show Clear errors"
        Me.chkShowClear.UseVisualStyleBackColor = true
        '
        'lnkShowOptions
        '
        Me.lnkShowOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lnkShowOptions.AutoSize = true
        Me.lnkShowOptions.Location = New System.Drawing.Point(410, 119)
        Me.lnkShowOptions.Name = "lnkShowOptions"
        Me.lnkShowOptions.Size = New System.Drawing.Size(106, 13)
        Me.lnkShowOptions.TabIndex = 9
        Me.lnkShowOptions.TabStop = true
        Me.lnkShowOptions.Text = "Show launch options"
        '
        'SaveToolStrip
        '
        Me.SaveToolStrip.AllowMerge = false
        Me.SaveToolStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SaveToolStrip.AutoSize = false
        Me.SaveToolStrip.CanOverflow = false
        Me.SaveToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SaveToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SaveToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveDropdown})
        Me.SaveToolStrip.Location = New System.Drawing.Point(457, 9)
        Me.SaveToolStrip.Name = "SaveToolStrip"
        Me.SaveToolStrip.Size = New System.Drawing.Size(62, 26)
        Me.SaveToolStrip.TabIndex = 12
        '
        'SaveDropdown
        '
        Me.SaveDropdown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveDropdownClipboard, Me.SaveDropdownCapture, Me.SaveDropdownCaptureSave})
        Me.SaveDropdown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaveDropdown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveDropdown.Name = "SaveDropdown"
        Me.SaveDropdown.Size = New System.Drawing.Size(61, 23)
        Me.SaveDropdown.Text = "Save..."
        '
        'SaveDropdownClipboard
        '
        Me.SaveDropdownClipboard.AutoToolTip = true
        Me.SaveDropdownClipboard.Name = "SaveDropdownClipboard"
        Me.SaveDropdownClipboard.Size = New System.Drawing.Size(328, 22)
        Me.SaveDropdownClipboard.Text = "Save to file from Clipboard"
        '
        'SaveDropdownCapture
        '
        Me.SaveDropdownCapture.AutoToolTip = true
        Me.SaveDropdownCapture.Name = "SaveDropdownCapture"
        Me.SaveDropdownCapture.Size = New System.Drawing.Size(328, 22)
        Me.SaveDropdownCapture.Text = "Capture screen to Clipboard"
        '
        'SaveDropdownCaptureSave
        '
        Me.SaveDropdownCaptureSave.AutoToolTip = true
        Me.SaveDropdownCaptureSave.Name = "SaveDropdownCaptureSave"
        Me.SaveDropdownCaptureSave.Size = New System.Drawing.Size(328, 22)
        Me.SaveDropdownCaptureSave.Text = "Capture screen to Clipboard and save to file"
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVersion.Location = New System.Drawing.Point(506, 137)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(21, 9)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "1.0.0"
        '
        'ClipboardSaver
        '
        Me.AcceptButton = Me.btnStartStop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(528, 147)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.SaveToolStrip)
        Me.Controls.Add(Me.lnkShowOptions)
        Me.Controls.Add(Me.chkShowClear)
        Me.Controls.Add(Me.chkShowSave)
        Me.Controls.Add(Me.grpNameFormat)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtSaveLocation)
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ClipboardSaver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Image Saver"
        Me.NotificationContextMenu.ResumeLayout(false)
        Me.grpNameFormat.ResumeLayout(false)
        Me.grpNameFormat.PerformLayout
        Me.SaveToolStrip.ResumeLayout(false)
        Me.SaveToolStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private lblVersion As System.Windows.Forms.Label
    Private WithEvents SaveDropdownCaptureSave As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents SaveDropdownCapture As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents SaveDropdownClipboard As System.Windows.Forms.ToolStripMenuItem
    Private SaveDropdown As System.Windows.Forms.ToolStripDropDownButton
    Private SaveToolStrip As System.Windows.Forms.ToolStrip
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
    Friend WithEvents NotificationContextMenuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuSeperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NotificationContextMenuSeperator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkShowSave As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowClear As System.Windows.Forms.CheckBox
    Friend WithEvents lnkShowOptions As System.Windows.Forms.LinkLabel

End Class
