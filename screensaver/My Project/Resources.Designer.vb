﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50215.44
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

<Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope:="member", Target:="My.Resources.Resources.get_ResourceManager():System.Resources.ResourceManager"),  _
 Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope:="member", Target:="My.Resources.Resources.get_Culture():System.Globalization.CultureInfo"),  _
 Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope:="member", Target:="My.Resources.Resources.set_Culture(System.Globalization.CultureInfo):Void")> 

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleName()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If (resourceMan Is Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("screensaver.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;rss version=&quot;2.0&quot;&gt;&lt;channel&gt;&lt;title&gt;RSS Feed Not Available&lt;/title&gt;&lt;link&gt;http://msdn.microsoft.com/vbasic/rss.xml&lt;/link&gt;&lt;description&gt;The RSS feed could not be loaded.&lt;/description&gt;&lt;language&gt;en-us&lt;/language&gt;&lt;ttl&gt;1440&lt;/ttl&gt;&lt;item&gt;&lt;title&gt;You may not be connected to the internet.&lt;/title&gt;&lt;description&gt;If you are trying to use an RSS feed on the internet check your Internet connection.&lt;/description&gt;&lt;link&gt;http://msdn.microsoft.com/vbasic/rss.xml&lt;/link&gt;&lt;/item&gt;&lt;item&gt;&lt;title&gt;Try selecting a different RSS feed.&lt;/title&gt;&lt;des[rest of String was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DefaultRSSText() As String
            Get
                Return ResourceManager.GetString("DefaultRSSText", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property SSaverBackground() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("SSaverBackground", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SSaverBackground2() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("SSaverBackground2", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
