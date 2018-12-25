Partial Class ClipboardManager
    Inherits System.Windows.Forms.Form
    
    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer
    
    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.chkAutoSort = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.TimerClipboardChecker = New System.Windows.Forms.Timer(Me.components)
        Me.btnHide = New System.Windows.Forms.Button()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.grpAddTo = New System.Windows.Forms.GroupBox()
        Me.optAddToEnd = New System.Windows.Forms.RadioButton()
        Me.optAddToStart = New System.Windows.Forms.RadioButton()
        Me.grpMaxEntries = New System.Windows.Forms.GroupBox()
        Me.txtMaxEntries = New System.Windows.Forms.NumericUpDown()
        Me.chkMaxEntries = New System.Windows.Forms.CheckBox()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.btnSaving = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpAddTo.SuspendLayout
        Me.grpMaxEntries.SuspendLayout
        CType(Me.txtMaxEntries,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lstLog
        '
        Me.lstLog.AllowDrop = true
        Me.lstLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstLog.FormattingEnabled = true
        Me.lstLog.HorizontalScrollbar = true
        Me.lstLog.IntegralHeight = false
        Me.lstLog.Location = New System.Drawing.Point(12, 25)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstLog.Size = New System.Drawing.Size(296, 417)
        Me.lstLog.TabIndex = 0
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = true
        Me.lblRecent.Location = New System.Drawing.Point(12, 9)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(120, 13)
        Me.lblRecent.TabIndex = 1
        Me.lblRecent.Text = "Recent Clipboard Items:"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Enabled = false
        Me.btnCopy.Location = New System.Drawing.Point(314, 12)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(100, 23)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy Item"
        Me.btnCopy.UseVisualStyleBackColor = true
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Enabled = false
        Me.btnDelete.Location = New System.Drawing.Point(314, 41)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = true
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Enabled = false
        Me.btnEdit.Location = New System.Drawing.Point(314, 70)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 23)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit Item..."
        Me.btnEdit.UseVisualStyleBackColor = true
        '
        'chkAutoSort
        '
        Me.chkAutoSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkAutoSort.AutoSize = true
        Me.chkAutoSort.Location = New System.Drawing.Point(320, 186)
        Me.chkAutoSort.Name = "chkAutoSort"
        Me.chkAutoSort.Size = New System.Drawing.Size(70, 17)
        Me.chkAutoSort.TabIndex = 5
        Me.chkAutoSort.Text = "Auto-Sort"
        Me.chkAutoSort.UseVisualStyleBackColor = true
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(314, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear List"
        Me.btnClear.UseVisualStyleBackColor = true
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMoveUp.Enabled = false
        Me.btnMoveUp.Location = New System.Drawing.Point(314, 128)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveUp.TabIndex = 6
        Me.btnMoveUp.Text = "Move Item Up"
        Me.btnMoveUp.UseVisualStyleBackColor = true
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMoveDown.Enabled = false
        Me.btnMoveDown.Location = New System.Drawing.Point(314, 157)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveDown.TabIndex = 7
        Me.btnMoveDown.Text = "Move Item Down"
        Me.btnMoveDown.UseVisualStyleBackColor = true
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(314, 419)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(100, 23)
        Me.btnEnd.TabIndex = 10
        Me.btnEnd.Text = "Close"
        Me.btnEnd.UseVisualStyleBackColor = true
        '
        'TimerClipboardChecker
        '
        Me.TimerClipboardChecker.Interval = 500
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnHide.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHide.Location = New System.Drawing.Point(314, 361)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(100, 23)
        Me.btnHide.TabIndex = 8
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = true
        '
        'TrayIcon
        '
        Me.TrayIcon.Icon = Global.ClipboardManager.Resources.animationmanager
        Me.TrayIcon.Text = "Clipboard Manager"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Click to open)"
        '
        'grpAddTo
        '
        Me.grpAddTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpAddTo.Controls.Add(Me.optAddToEnd)
        Me.grpAddTo.Controls.Add(Me.optAddToStart)
        Me.grpAddTo.Location = New System.Drawing.Point(314, 209)
        Me.grpAddTo.Name = "grpAddTo"
        Me.grpAddTo.Size = New System.Drawing.Size(105, 65)
        Me.grpAddTo.TabIndex = 11
        Me.grpAddTo.TabStop = false
        Me.grpAddTo.Text = "Add new items to:"
        '
        'optAddToEnd
        '
        Me.optAddToEnd.AutoSize = true
        Me.optAddToEnd.Location = New System.Drawing.Point(6, 42)
        Me.optAddToEnd.Name = "optAddToEnd"
        Me.optAddToEnd.Size = New System.Drawing.Size(71, 17)
        Me.optAddToEnd.TabIndex = 1
        Me.optAddToEnd.Text = "End of list"
        Me.optAddToEnd.UseVisualStyleBackColor = true
        '
        'optAddToStart
        '
        Me.optAddToStart.AutoSize = true
        Me.optAddToStart.Checked = true
        Me.optAddToStart.Location = New System.Drawing.Point(6, 19)
        Me.optAddToStart.Name = "optAddToStart"
        Me.optAddToStart.Size = New System.Drawing.Size(74, 17)
        Me.optAddToStart.TabIndex = 0
        Me.optAddToStart.TabStop = true
        Me.optAddToStart.Text = "Start of list"
        Me.optAddToStart.UseVisualStyleBackColor = true
        '
        'grpMaxEntries
        '
        Me.grpMaxEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpMaxEntries.Controls.Add(Me.txtMaxEntries)
        Me.grpMaxEntries.Location = New System.Drawing.Point(314, 280)
        Me.grpMaxEntries.Name = "grpMaxEntries"
        Me.grpMaxEntries.Size = New System.Drawing.Size(105, 46)
        Me.grpMaxEntries.TabIndex = 12
        Me.grpMaxEntries.TabStop = false
        '
        'txtMaxEntries
        '
        Me.txtMaxEntries.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtMaxEntries.Location = New System.Drawing.Point(6, 19)
        Me.txtMaxEntries.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMaxEntries.Name = "txtMaxEntries"
        Me.txtMaxEntries.Size = New System.Drawing.Size(93, 20)
        Me.txtMaxEntries.TabIndex = 0
        Me.txtMaxEntries.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'chkMaxEntries
        '
        Me.chkMaxEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkMaxEntries.AutoSize = true
        Me.chkMaxEntries.Checked = true
        Me.chkMaxEntries.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaxEntries.Location = New System.Drawing.Point(318, 279)
        Me.chkMaxEntries.Name = "chkMaxEntries"
        Me.chkMaxEntries.Size = New System.Drawing.Size(84, 17)
        Me.chkMaxEntries.TabIndex = 13
        Me.chkMaxEntries.Text = "Max Entries:"
        Me.chkMaxEntries.UseVisualStyleBackColor = true
        '
        'btnLaunch
        '
        Me.btnLaunch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnLaunch.Enabled = false
        Me.btnLaunch.Location = New System.Drawing.Point(314, 99)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(100, 23)
        Me.btnLaunch.TabIndex = 14
        Me.btnLaunch.Text = "Launch Item"
        Me.btnLaunch.UseVisualStyleBackColor = true
        '
        'btnSaving
        '
        Me.btnSaving.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSaving.Location = New System.Drawing.Point(314, 332)
        Me.btnSaving.Name = "btnSaving"
        Me.btnSaving.Size = New System.Drawing.Size(100, 23)
        Me.btnSaving.TabIndex = 15
        Me.btnSaving.Text = "Saving options..."
        Me.btnSaving.UseVisualStyleBackColor = true
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVersion.Location = New System.Drawing.Point(404, 444)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(21, 9)
        Me.lblVersion.TabIndex = 16
        Me.lblVersion.Text = "1.0.0"
        '
        'ClipboardManager
        '
        Me.AcceptButton = Me.btnCopy
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnHide
        Me.ClientSize = New System.Drawing.Size(426, 454)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnSaving)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkMaxEntries)
        Me.Controls.Add(Me.grpMaxEntries)
        Me.Controls.Add(Me.grpAddTo)
        Me.Controls.Add(Me.btnMoveDown)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.chkAutoSort)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.lblRecent)
        Me.Controls.Add(Me.lstLog)
        Me.HelpButton = true
        Me.Icon = Global.ClipboardManager.Resources.animationmanager
        Me.Name = "ClipboardManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Manager"
        Me.grpAddTo.ResumeLayout(false)
        Me.grpAddTo.PerformLayout
        Me.grpMaxEntries.ResumeLayout(false)
        CType(Me.txtMaxEntries,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnSaving As System.Windows.Forms.Button
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend optAddToEnd As System.Windows.Forms.RadioButton
    Friend WithEvents optAddToStart As System.Windows.Forms.RadioButton
    Friend WithEvents chkMaxEntries As System.Windows.Forms.CheckBox
    Friend WithEvents txtMaxEntries As System.Windows.Forms.NumericUpDown
    Friend grpMaxEntries As System.Windows.Forms.GroupBox
    Friend grpAddTo As System.Windows.Forms.GroupBox
    Friend WithEvents lstLog As System.Windows.Forms.ListBox
    Friend lblRecent As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents chkAutoSort As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMoveUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveDown As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents TimerClipboardChecker As System.Windows.Forms.Timer
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
End Class
