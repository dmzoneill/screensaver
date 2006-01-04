<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.okButton = New System.Windows.Forms.Button
        Me.cancelButton1 = New System.Windows.Forms.Button
        Me.applyButton = New System.Windows.Forms.Button
        Me.rssGroupBox = New System.Windows.Forms.GroupBox
        Me.validateButton = New System.Windows.Forms.Button
        Me.rssFeedLabel = New System.Windows.Forms.Label
        Me.rssFeedTextBox = New System.Windows.Forms.TextBox
        Me.imageGroupBox = New System.Windows.Forms.GroupBox
        Me.browseButton = New System.Windows.Forms.Button
        Me.backgroundImageFolderTextBox = New System.Windows.Forms.TextBox
        Me.backgroundImageLabel = New System.Windows.Forms.Label
        Me.backgroundImageOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.backgroundImageFolderBrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.rssGroupBox.SuspendLayout()
        Me.imageGroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.okButton.Location = New System.Drawing.Point(156, 3)
        Me.okButton.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        '
        'cancelButton1
        '
        Me.cancelButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelButton1.Location = New System.Drawing.Point(74, 3)
        Me.cancelButton1.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.cancelButton1.Name = "cancelButton1"
        Me.cancelButton1.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton1.TabIndex = 1
        Me.cancelButton1.Text = "Cancel"
        '
        'applyButton
        '
        Me.applyButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.applyButton.Location = New System.Drawing.Point(237, 3)
        Me.applyButton.Name = "applyButton"
        Me.applyButton.Size = New System.Drawing.Size(75, 23)
        Me.applyButton.TabIndex = 2
        Me.applyButton.Text = "Apply"
        '
        'rssGroupBox
        '
        Me.rssGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rssGroupBox.Controls.Add(Me.validateButton)
        Me.rssGroupBox.Controls.Add(Me.rssFeedLabel)
        Me.rssGroupBox.Controls.Add(Me.rssFeedTextBox)
        Me.rssGroupBox.Location = New System.Drawing.Point(3, 7)
        Me.rssGroupBox.Name = "rssGroupBox"
        Me.rssGroupBox.Size = New System.Drawing.Size(314, 107)
        Me.rssGroupBox.TabIndex = 3
        Me.rssGroupBox.TabStop = False
        Me.rssGroupBox.Text = "RSS Feed"
        '
        'validateButton
        '
        Me.validateButton.AutoSize = True
        Me.validateButton.Location = New System.Drawing.Point(7, 66)
        Me.validateButton.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.validateButton.Name = "validateButton"
        Me.validateButton.Size = New System.Drawing.Size(75, 23)
        Me.validateButton.TabIndex = 0
        Me.validateButton.Text = "Validate"
        '
        'rssFeedLabel
        '
        Me.rssFeedLabel.AutoSize = True
        Me.rssFeedLabel.Location = New System.Drawing.Point(7, 20)
        Me.rssFeedLabel.Name = "rssFeedLabel"
        Me.rssFeedLabel.Size = New System.Drawing.Size(68, 13)
        Me.rssFeedLabel.TabIndex = 1
        Me.rssFeedLabel.Text = "RSS 2.0 URI:"
        '
        'rssFeedTextBox
        '
        Me.rssFeedTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rssFeedTextBox.Location = New System.Drawing.Point(7, 41)
        Me.rssFeedTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.rssFeedTextBox.Name = "rssFeedTextBox"
        Me.rssFeedTextBox.Size = New System.Drawing.Size(301, 20)
        Me.rssFeedTextBox.TabIndex = 2
        '
        'imageGroupBox
        '
        Me.imageGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imageGroupBox.Controls.Add(Me.browseButton)
        Me.imageGroupBox.Controls.Add(Me.backgroundImageFolderTextBox)
        Me.imageGroupBox.Controls.Add(Me.backgroundImageLabel)
        Me.imageGroupBox.Location = New System.Drawing.Point(3, 125)
        Me.imageGroupBox.Name = "imageGroupBox"
        Me.imageGroupBox.Size = New System.Drawing.Size(314, 113)
        Me.imageGroupBox.TabIndex = 4
        Me.imageGroupBox.TabStop = False
        Me.imageGroupBox.Text = "Background Images"
        '
        'browseButton
        '
        Me.browseButton.AutoSize = True
        Me.browseButton.Location = New System.Drawing.Point(7, 68)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(75, 23)
        Me.browseButton.TabIndex = 0
        Me.browseButton.Text = "Browse..."
        '
        'backgroundImageFolderTextBox
        '
        Me.backgroundImageFolderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backgroundImageFolderTextBox.Location = New System.Drawing.Point(7, 41)
        Me.backgroundImageFolderTextBox.Name = "backgroundImageFolderTextBox"
        Me.backgroundImageFolderTextBox.Size = New System.Drawing.Size(301, 20)
        Me.backgroundImageFolderTextBox.TabIndex = 1
        '
        'backgroundImageLabel
        '
        Me.backgroundImageLabel.AutoSize = True
        Me.backgroundImageLabel.Location = New System.Drawing.Point(7, 20)
        Me.backgroundImageLabel.Name = "backgroundImageLabel"
        Me.backgroundImageLabel.Size = New System.Drawing.Size(162, 13)
        Me.backgroundImageLabel.TabIndex = 2
        Me.backgroundImageLabel.Text = "Background image directory path:"
        '
        'backgroundImageFolderBrowser
        '
        Me.backgroundImageFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyPictures
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.imageGroupBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rssGroupBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(321, 278)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.applyButton, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cancelButton1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.okButton, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 245)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(315, 30)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 296)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "OptionsForm"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowIcon = False
        Me.Text = "Screen Saver Settings"
        Me.rssGroupBox.ResumeLayout(False)
        Me.rssGroupBox.PerformLayout()
        Me.imageGroupBox.ResumeLayout(False)
        Me.imageGroupBox.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents applyButton As System.Windows.Forms.Button
    Friend WithEvents cancelButton1 As System.Windows.Forms.Button
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents backgroundImageOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rssGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rssFeedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents imageGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents validateButton As System.Windows.Forms.Button
    Friend WithEvents rssFeedLabel As System.Windows.Forms.Label
    Friend WithEvents browseButton As System.Windows.Forms.Button
    Friend WithEvents backgroundImageFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents backgroundImageLabel As System.Windows.Forms.Label
    Friend WithEvents backgroundImageFolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel 'InitializeComponent 
End Class
