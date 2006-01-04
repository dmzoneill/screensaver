Imports System.Collections.Generic
Imports System.IO


''' <summary>
''' Screen responsible for rendering the primary visual content of the screen saver.  
''' </summary>
''' <remarks>
''' The form is entirely custom drawn using GDI+ graphics objects.  To alter display, 
''' modify graphics code or host new UI controls on the form.  
''' </remarks>
Public Class ScreenSaverForm

    'stores the rss feed item data to be displayed
    Private rss As RssFeed

    'objects for displaying RSS contents
    Private rssView As ItemListView(Of RssItem)
    Private WithEvents rssDescriptionView As ItemDescriptionView(Of RssItem)
    Private WithEvents descriptionFadeTimer As Timer

    'stores images to display in the background
    Private backgroundImages As List(Of Image)

    'stores the index of the current image
    Private currentImageIndex As Integer

    ' Keep track of whether the screensaver has become active.
    Private isActive As Boolean = False

    ' Keep track of the location of the mouse
    Private mouseLocation As Point

    'Array of all images we can display
    Private IMAGE_FILE_EXTENSIONS As String() = {"*.bmp", "*.gif", "*.png", "*.jpg", "*.jpeg"}

    Public Sub New()
        InitializeComponent()

        SetupScreenSaver()
        LoadBackgroundImage()

        LoadRssFeed()

        ' Initialize the ItemListView to display the description of the 
        ' RssItem.  It is placed on the right side of the screen.            
        rssView = New ItemListView(Of RssItem)(Me.rss.MainChannel.Title, Me.rss.MainChannel.Items)
        InitializeRssView()

        ' Initialize the ItemDescriptionView to display the description of the 
        ' RssItem.  It is placed on the right side of the screen.
        rssDescriptionView = New ItemDescriptionView(Of RssItem)
        InitializeRssDescriptionView()

        descriptionFadeTimer = rssDescriptionView.FadeTimer

    End Sub

   

    '''<summary>
    '''Set up the main form as a full screen screensaver.
    '''</summary>
    Private Sub SetupScreenSaver()
        ' Use double buffering to improve drawing performance
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
	' Capture the mouse
	Me.Capture = True

        ' Set the application to full screen mode and hide the mouse
        Bounds = Screen.PrimaryScreen.Bounds
        WindowState = FormWindowState.Maximized
        ShowInTaskbar = False
        DoubleBuffered = True
        BackgroundImageLayout = ImageLayout.Stretch

    End Sub


    ''' <summary>
    ''' Loads images from the specific location into memory for display.  
    ''' </summary>
    ''' <remarks>
    ''' Tries to load images from the user-specified path, else uses default images
    ''' saved in resource designer.  
    ''' </remarks>
    Private Sub LoadBackgroundImage()

        ' Initialize the background images
        backgroundImages = New List(Of Image)
        currentImageIndex = 0

        If Directory.Exists(My.Settings.BackgroundImagePath)
            Try
                ' Try to load the images given by the user
                LoadImagesFromFolder()
            Catch
                ' If this fails, load the default images
                LoadDefaultBackgroundImages()
            End Try
        End If

        If backgroundImages.Count = 0
            LoadDefaultBackgroundImages()
        End If

    End Sub

    Private Sub LoadImagesFromFolder()

        Dim currentImage As Image
        Dim backgroundImageDir As DirectoryInfo = new DirectoryInfo(My.Settings.BackgroundImagePath)

        ' For each image extension (.jpg, .bmp, etc.)
        For Each imageExtension As String In IMAGE_FILE_EXTENSIONS
            ' For each file in the directory provided by the user
            For Each file As FileInfo In backgroundImageDir.GetFiles(imageExtension)
                ' Try to load the image
                Try
                    currentImage = Image.FromFile(file.FullName)
                    backgroundImages.Add(currentImage)
                Catch ex As OutOfMemoryException
                    ' If the image can't be loaded, move on.
                    Continue For
                End Try
            Next
        Next

    End Sub

    Private Sub LoadDefaultBackgroundImages()
        ' If the background images could not be loaded for any reason
        ' use the image stored in the resources 
        backgroundImages.Add(My.Resources.SSaverBackground)
        backgroundImages.Add(My.Resources.SSaverBackground2)
    End Sub

    ''' <summary>
    ''' Loads RSS feed data from the user-specified location.  
    ''' </summary>
    ''' <remarks>Tries to load from the user specified URI, else loads static error text data from the Settings designer.  </remarks>
    Private Sub LoadRssFeed()
        Try
            ' Try to get it from the users settings
            rss = RssFeed.FromUri(My.Settings.RssFeedUri)
        Catch ex As Exception
            My.Application.Log.WriteEntry(String.Format("There was a problem loading the RSS feed from the specified URI: {0}", ex.Message))
            My.Application.Log.WriteException(ex)

            ' If there is any problem loading the RSS load an error message RSS feed
            rss = RssFeed.FromText(My.Resources.DefaultRSSText)
        End Try

    End Sub

    ''' <summary>
    ''' Initialize display properties of the rssView.
    ''' </summary>
    Private Sub InitializeRssView()
        rssView.BackColor = Color.FromArgb(120, 240, 234, 232)
        rssView.BorderColor = Color.White
        rssView.ForeColor = Color.FromArgb(255, 40, 40, 40)
        rssView.SelectedBackColor = Color.FromArgb(200, 105, 61, 76)
        rssView.SelectedForeColor = Color.FromArgb(255, 204, 184, 163)
        rssView.TitleBackColor = Color.Empty
        rssView.TitleForeColor = Color.FromArgb(255, 240, 234, 232)
        rssView.MaxItemsToShow = 20
        rssView.MinItemsToShow = 15
        rssView.Location = New Point(Width / 10, Height / 10)
        rssView.Size = New Size(Width / 2, Height / 2)
    End Sub

    ''' <summary>
    ''' Initialize display properties of the rssDescriptionView.
    ''' </summary>
    Private Sub InitializeRssDescriptionView()
        rssDescriptionView.DisplayItem = rssView.SelectedItem
        rssDescriptionView.ForeColor = Color.FromArgb(255, 240, 234, 232)
        rssDescriptionView.TitleFont = rssView.TitleFont
        rssDescriptionView.LineColor = Color.FromArgb(120, 240, 234, 232)
        rssDescriptionView.LineWidth = 2.0F

        rssDescriptionView.FadeTimer.Interval = 40
        rssDescriptionView.Location = New Point(3 * Width / 4, Height / 3)
        rssDescriptionView.Size = New Size(Width / 4, Height / 2)

    End Sub

    Private Sub ScreenSaverForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        ' Set IsActive and MouseLocation only the first time this event is called.
        If Not isActive Then
            mouseLocation = MousePosition
            isActive = True
        Else
            ' If the mouse has moved significantly since first call, close.
            If Math.Abs(MousePosition.X - mouseLocation.X) > 10 OrElse Math.Abs(MousePosition.Y - mouseLocation.Y) > 10 Then
                Close()
            End If
        End If

    End Sub


    Private Sub ScreenSaverForm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Close()
    End Sub


    Private Sub ScreenSaverForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        Close()
    End Sub


    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        ' Draw the current background image stretched to fill the full screen
        e.Graphics.DrawImage(backgroundImages(currentImageIndex), 0, 0, Size.Width, Size.Height)

    End Sub


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        rssView.Paint(e)
        rssDescriptionView.Paint(e)

    End Sub


    Private Sub backgroundChangeTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles backgroundChangeTimer.Tick
        ' Change the background image to the next image.
        currentImageIndex = (currentImageIndex + 1) Mod backgroundImages.Count

    End Sub


    Private Sub rssDescriptionView_FadingComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles rssDescriptionView.FadingComplete
        rssView.NextArticle()
        rssDescriptionView.DisplayItem = rssView.SelectedItem

    End Sub


    Private Sub FadeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles descriptionFadeTimer.Tick
        Me.Refresh()

    End Sub

End Class