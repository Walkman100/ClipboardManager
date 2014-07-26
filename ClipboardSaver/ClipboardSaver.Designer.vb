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
        Me.txtSaveLocation = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.NotificationIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
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
        Me.btnEnd.Location = New System.Drawing.Point(208, 39)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "Close"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'NotificationIcon
        '
        Me.NotificationIcon.Text = "Clipboard Image Saver"
        Me.NotificationIcon.Visible = True
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Select a folder to save images to:"
        '
        'ClipboardSaver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 74)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtSaveLocation)
        Me.Name = "ClipboardSaver"
        Me.Text = "Clipboard Image Saver"
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

End Class
