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
        Me.NotificationContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaveLocation.Location = New System.Drawing.Point(12, 12)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.Size = New System.Drawing.Size(190, 20)
        Me.txtSaveLocation.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(208, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.AutoSize = True
        Me.btnStartStop.Location = New System.Drawing.Point(12, 39)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(100, 23)
        Me.btnStartStop.TabIndex = 2
        Me.btnStartStop.Text = "Enable Timer"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.Location = New System.Drawing.Point(127, 39)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 3
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(208, 39)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
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
        'ClipboardSaver
        '
        Me.AcceptButton = Me.btnStartStop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(295, 74)
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

End Class
