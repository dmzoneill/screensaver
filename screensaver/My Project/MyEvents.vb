Namespace My

    'The following events are available for MyApplication
    '
    'Startup: Raised when the application starts, before the startup form is created.
    'Shutdown: Raised after all application forms are closed.  This event is not raised if the application is terminating abnormally.
    'UnhandledException: Raised if the application encounters an unhandled exception.
    'StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    'NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If e.CommandLine.Count > 0 Then
                ' Get the 2 character command line argument
                Dim arg As String = e.CommandLine(0).ToLower(System.Globalization.CultureInfo.InvariantCulture)
                Select Case arg
                    Case "/c"
                        ' Show the options dialog
                        Me.MainForm = My.Forms.OptionsForm
                    Case "/p"
                        ' Don't do anything for preview
                    Case "/s"
                        Me.MainForm = My.Forms.ScreenSaverForm
                    Case Else
                        MessageBox.Show("Invalid command line argument :" + arg, "Invalid Command Line Argument", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Else
                ' If no arguments were passed in, show the screensaver
                Me.MainForm = My.Forms.ScreenSaverForm
            End If

        End Sub

    End Class
End Namespace
