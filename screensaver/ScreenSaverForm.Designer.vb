<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ScreenSaverForm
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
        Me.components = New System.ComponentModel.Container
        Me.backgroundChangeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'backgroundChangeTimer
        '
        Me.backgroundChangeTimer.Enabled = True
        Me.backgroundChangeTimer.Interval = 10000
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(58, 212)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(340, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "This Form is drawn in the OnPaint() and OnPaintBackground() methods."
        Me.label1.Visible = False
        '
        'ScreenSaverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 459)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScreenSaverForm"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents backgroundChangeTimer As System.Windows.Forms.Timer
    Friend WithEvents label1 As System.Windows.Forms.Label
End Class
