
'''<summary>
''' Screen responsible for reading and writing common user settings.  
''' </summary>
Public Class OptionsForm

    Private Sub OptionsForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Load the text boxes from the current settings
        Try
            backgroundImageFolderTextBox.Text = My.Settings.BackgroundImagePath
            rssFeedTextBox.Text = My.Settings.RssFeedUri
        Catch
            MessageBox.Show("There was a problem reading in the settings for your screen saver.")
        End Try
    End Sub

    '''<summary>
    '''Updates the apply button to be active only if changes 
    '''have been made since apply was last pressed
    '''</summary>
    Private Sub UpdateApply()
        If My.Settings.BackgroundImagePath <> backgroundImageFolderTextBox.Text OrElse My.Settings.RssFeedUri <> rssFeedTextBox.Text Then
            applyButton.Enabled = True
        Else
            applyButton.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Applies all the changes since apply button was last pressed
    ''' </summary>
    Private Sub ApplyChanges()
        My.Settings.BackgroundImagePath = backgroundImageFolderTextBox.Text
        My.Settings.RssFeedUri = rssFeedTextBox.Text
        My.Settings.Save()
    End Sub


    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles okButton.Click
        Try
            ApplyChanges()
        Catch ex As Exception
            MessageBox.Show("Your settings couldn't be saved.  Make sure that you have a .config file in the same directory as your screensaver.", "Failed to Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Close()
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancelButton1.Click
        Close()
    End Sub


    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles applyButton.Click
        ApplyChanges()
        applyButton.Enabled = False
    End Sub



    Private Sub validateButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles validateButton.Click
        ' Check whether the user provided URI points to a valid RSS feed
        Try
            RssFeed.FromUri(rssFeedTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Not a valid RSS feed.", "Not a valid RSS feed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        MessageBox.Show("Valid RSS feed.", "Valid RSS feed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub browseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseButton.Click
        ' Open a file open dialog to choose an image
        Dim result As DialogResult = backgroundImageFolderBrowser.ShowDialog()
        If result = DialogResult.OK Then
            backgroundImageFolderTextBox.Text = backgroundImageFolderBrowser.SelectedPath
            UpdateApply()
        End If

    End Sub

    Private Sub rssFeedTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rssFeedTextBox.TextChanged
        UpdateApply()
    End Sub

    Private Sub backgroundImageFolderTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles backgroundImageFolderTextBox.TextChanged
        UpdateApply()
    End Sub

End Class