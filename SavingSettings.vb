<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class SavingSettings
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private Sub InitializeComponent()
        Me.chkContinuous = New System.Windows.Forms.CheckBox()
        Me.grpContinuous = New System.Windows.Forms.GroupBox()
        Me.btnContinous = New System.Windows.Forms.Button()
        Me.txtContinuous = New System.Windows.Forms.TextBox()
        Me.chkPersistant = New System.Windows.Forms.CheckBox()
        Me.grpPersistant = New System.Windows.Forms.GroupBox()
        Me.btnPersistant = New System.Windows.Forms.Button()
        Me.txtPersistant = New System.Windows.Forms.TextBox()
        Me.grpContinuous.SuspendLayout
        Me.grpPersistant.SuspendLayout
        Me.SuspendLayout
        'chkContinuous
        Me.chkContinuous.AutoSize = true
        Me.chkContinuous.Location = New System.Drawing.Point(21, 11)
        Me.chkContinuous.Name = "chkContinuous"
        Me.chkContinuous.Size = New System.Drawing.Size(327, 17)
        Me.chkContinuous.TabIndex = 15
        Me.chkContinuous.Text = "Continuous saving: Save any text change in the clipboard to file"
        Me.chkContinuous.UseVisualStyleBackColor = true
        AddHandler Me.chkContinuous.CheckedChanged, AddressOf Me.chkContinuous_CheckedChanged
        'grpContinuous
        Me.grpContinuous.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpContinuous.Controls.Add(Me.btnContinous)
        Me.grpContinuous.Controls.Add(Me.txtContinuous)
        Me.grpContinuous.Enabled = false
        Me.grpContinuous.Location = New System.Drawing.Point(12, 12)
        Me.grpContinuous.Name = "grpContinuous"
        Me.grpContinuous.Size = New System.Drawing.Size(373, 50)
        Me.grpContinuous.TabIndex = 14
        Me.grpContinuous.TabStop = false
        'btnContinous
        Me.btnContinous.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnContinous.Location = New System.Drawing.Point(292, 20)
        Me.btnContinous.Name = "btnContinous"
        Me.btnContinous.Size = New System.Drawing.Size(75, 23)
        Me.btnContinous.TabIndex = 1
        Me.btnContinous.Text = "Browse..."
        Me.btnContinous.UseVisualStyleBackColor = true
        AddHandler Me.btnContinous.Click, AddressOf Me.btnContinous_Click
        'txtContinuous
        Me.txtContinuous.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtContinuous.Location = New System.Drawing.Point(6, 22)
        Me.txtContinuous.Name = "txtContinuous"
        Me.txtContinuous.ReadOnly = true
        Me.txtContinuous.Size = New System.Drawing.Size(280, 20)
        Me.txtContinuous.TabIndex = 0
        'chkPersistant
        Me.chkPersistant.AutoSize = true
        Me.chkPersistant.Location = New System.Drawing.Point(21, 67)
        Me.chkPersistant.Name = "chkPersistant"
        Me.chkPersistant.Size = New System.Drawing.Size(336, 17)
        Me.chkPersistant.TabIndex = 17
        Me.chkPersistant.Text = "Persistant storage: keep the file up-to-date with ClipboardManager"
        Me.chkPersistant.UseVisualStyleBackColor = true
        AddHandler Me.chkPersistant.CheckedChanged, AddressOf Me.chkPersistant_CheckedChanged
        'grpPersistant
        Me.grpPersistant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpPersistant.Controls.Add(Me.btnPersistant)
        Me.grpPersistant.Controls.Add(Me.txtPersistant)
        Me.grpPersistant.Enabled = false
        Me.grpPersistant.Location = New System.Drawing.Point(12, 68)
        Me.grpPersistant.Name = "grpPersistant"
        Me.grpPersistant.Size = New System.Drawing.Size(373, 50)
        Me.grpPersistant.TabIndex = 16
        Me.grpPersistant.TabStop = false
        'btnPersistant
        Me.btnPersistant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnPersistant.Location = New System.Drawing.Point(292, 20)
        Me.btnPersistant.Name = "btnPersistant"
        Me.btnPersistant.Size = New System.Drawing.Size(75, 23)
        Me.btnPersistant.TabIndex = 3
        Me.btnPersistant.Text = "Browse..."
        Me.btnPersistant.UseVisualStyleBackColor = true
        AddHandler Me.btnPersistant.Click, AddressOf Me.btnPersistant_Click
        'txtPersistant
        Me.txtPersistant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPersistant.Location = New System.Drawing.Point(6, 22)
        Me.txtPersistant.Name = "txtPersistant"
        Me.txtPersistant.ReadOnly = true
        Me.txtPersistant.Size = New System.Drawing.Size(280, 20)
        Me.txtPersistant.TabIndex = 2
        'SavingSettings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 132)
        Me.Controls.Add(Me.chkPersistant)
        Me.Controls.Add(Me.grpPersistant)
        Me.Controls.Add(Me.chkContinuous)
        Me.Controls.Add(Me.grpContinuous)
        Me.Name = "SavingSettings"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Saving Settings"
        Me.grpContinuous.ResumeLayout(false)
        Me.grpContinuous.PerformLayout
        Me.grpPersistant.ResumeLayout(false)
        Me.grpPersistant.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
        
        sfdContinuous.DefaultExt = "txt"
        sfdContinuous.FileName = "ClipboardManager.ClipboardLog.txt"
        sfdContinuous.Filter = "Text files|*.txt|All files|*.*"
        sfdContinuous.InitialDirectory = Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS"
        sfdContinuous.OverwritePrompt = False
        sfdContinuous.Title = "Select a file to save the clipboard to:"
        
        sfdPersistant.DefaultExt = "txt"
        sfdPersistant.FileName = "ClipboardManager.CurrentList.txt"
        sfdPersistant.Filter = "Text files|*.txt|All files|*.*"
        sfdPersistant.InitialDirectory = Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS"
        sfdPersistant.OverwritePrompt = False
        sfdPersistant.Title = "Select a file to keep up-to-date with ClipboardManager:"
    End Sub
    Friend txtPersistant As System.Windows.Forms.TextBox
    Private btnPersistant As System.Windows.Forms.Button
    Friend txtContinuous As System.Windows.Forms.TextBox
    Private btnContinous As System.Windows.Forms.Button
    Private grpPersistant As System.Windows.Forms.GroupBox
    Friend chkPersistant As System.Windows.Forms.CheckBox
    Private grpContinuous As System.Windows.Forms.GroupBox
    Friend chkContinuous As System.Windows.Forms.CheckBox
    
    Dim sfdContinuous As New SaveFileDialog
    Dim sfdPersistant As New SaveFileDialog
    
    Sub chkContinuous_CheckedChanged()
        grpContinuous.Enabled = chkContinuous.Checked
        If chkContinuous.Checked And txtContinuous.Text = "" Then btnContinous_Click
    End Sub
    
    Sub btnContinous_Click()
        If Not IO.Directory.Exists(sfdContinuous.InitialDirectory) Then
            IO.Directory.CreateDirectory(sfdContinuous.InitialDirectory)
        End If
        If sfdContinuous.ShowDialog = DialogResult.OK Then
            txtContinuous.Text = sfdContinuous.FileName
        ElseIf txtContinuous.Text = ""
            chkContinuous.Checked = False
        End If
    End Sub
    
    Sub chkPersistant_CheckedChanged()
        grpPersistant.Enabled = chkPersistant.Checked
        If chkPersistant.Checked And txtPersistant.Text = "" Then btnPersistant_Click
    End Sub
    
    Sub btnPersistant_Click()
        If Not IO.Directory.Exists(sfdPersistant.InitialDirectory) Then
            IO.Directory.CreateDirectory(sfdPersistant.InitialDirectory)
        End If
        If sfdPersistant.ShowDialog = DialogResult.OK Then
            txtPersistant.Text = sfdPersistant.FileName
        ElseIf txtPersistant.Text = ""
            chkPersistant.Checked = False
        End If
    End Sub
End Class
