﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property UserUnits() As String
            Get
                Return CType(Me("UserUnits"),String)
            End Get
            Set
                Me("UserUnits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowTips() As Boolean
            Get
                Return CType(Me("ShowTips"),Boolean)
            End Get
            Set
                Me("ShowTips") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property RenderMode() As Integer
            Get
                Return CType(Me("RenderMode"),Integer)
            End Get
            Set
                Me("RenderMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property PaletteMode() As Integer
            Get
                Return CType(Me("PaletteMode"),Integer)
            End Get
            Set
                Me("PaletteMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property BackupFolder() As String
            Get
                Return CType(Me("BackupFolder"),String)
            End Get
            Set
                Me("BackupFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property BackupActivated() As Boolean
            Get
                Return CType(Me("BackupActivated"),Boolean)
            End Get
            Set
                Me("BackupActivated") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property BackupInterval() As Integer
            Get
                Return CType(Me("BackupInterval"),Integer)
            End Get
            Set
                Me("BackupInterval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BackupFiles() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("BackupFiles"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("BackupFiles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("en")>  _
        Public Property CultureInfo() As String
            Get
                Return CType(Me("CultureInfo"),String)
            End Get
            Set
                Me("CultureInfo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowLangForm() As Boolean
            Get
                Return CType(Me("ShowLangForm"),Boolean)
            End Get
            Set
                Me("ShowLangForm") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property GeneralSettings() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("GeneralSettings"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("GeneralSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ChemSepDatabasePath() As String
            Get
                Return CType(Me("ChemSepDatabasePath"),String)
            End Get
            Set
                Me("ChemSepDatabasePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ReplaceComps() As Boolean
            Get
                Return CType(Me("ReplaceComps"),Boolean)
            End Get
            Set
                Me("ReplaceComps") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property UserDatabases() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("UserDatabases"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("UserDatabases") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ScriptPaths() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("ScriptPaths"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("ScriptPaths") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RedirectOutput() As Boolean
            Get
                Return CType(Me("RedirectOutput"),Boolean)
            End Get
            Set
                Me("RedirectOutput") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UseCOPersistenceSupport() As Boolean
            Get
                Return CType(Me("UseCOPersistenceSupport"),Boolean)
            End Get
            Set
                Me("UseCOPersistenceSupport") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SetCOSimulationContext() As Boolean
            Get
                Return CType(Me("SetCOSimulationContext"),Boolean)
            End Get
            Set
                Me("SetCOSimulationContext") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CheckForUpdates() As Boolean
            Get
                Return CType(Me("CheckForUpdates"),Boolean)
            End Get
            Set
                Me("CheckForUpdates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowDonateForm() As Boolean
            Get
                Return CType(Me("ShowDonateForm"),Boolean)
            End Get
            Set
                Me("ShowDonateForm") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UpgradeRequired() As Boolean
            Get
                Return CType(Me("UpgradeRequired"),Boolean)
            End Get
            Set
                Me("UpgradeRequired") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("True")> _
        Public Property EnableParallelProcessing() As Boolean
            Get
                Return CType(Me("EnableParallelProcessing"), Boolean)
            End Get
            Set(value As Boolean)
                Me("EnableParallelProcessing") = Value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-1")>  _
        Public Property MaxDegreeOfParallelism() As Integer
            Get
                Return CType(Me("MaxDegreeOfParallelism"),Integer)
            End Get
            Set
                Me("MaxDegreeOfParallelism") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EnableGPUProcessing() As Boolean
            Get
                Return CType(Me("EnableGPUProcessing"),Boolean)
            End Get
            Set
                Me("EnableGPUProcessing") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SelectedGPU() As String
            Get
                Return CType(Me("SelectedGPU"),String)
            End Get
            Set
                Me("SelectedGPU") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property CudafyTarget() As Integer
            Get
                Return CType(Me("CudafyTarget"),Integer)
            End Get
            Set
                Me("CudafyTarget") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CudafyDeviceID() As Integer
            Get
                Return CType(Me("CudafyDeviceID"),Integer)
            End Get
            Set
                Me("CudafyDeviceID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property UserInteractionsDatabases() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("UserInteractionsDatabases"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("UserInteractionsDatabases") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" />")>  _
        Public Property MostRecentFiles() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("MostRecentFiles"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("MostRecentFiles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowCoolPropWarning() As Boolean
            Get
                Return CType(Me("ShowCoolPropWarning"),Boolean)
            End Get
            Set
                Me("ShowCoolPropWarning") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SolverMode() As Integer
            Get
                Return CType(Me("SolverMode"),Integer)
            End Get
            Set
                Me("SolverMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ServiceBusConnectionString() As String
            Get
                Return CType(Me("ServiceBusConnectionString"),String)
            End Get
            Set
                Me("ServiceBusConnectionString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property DebugLevel() As Integer
            Get
                Return CType(Me("DebugLevel"),Integer)
            End Get
            Set
                Me("DebugLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ServerIPAddress() As String
            Get
                Return CType(Me("ServerIPAddress"),String)
            End Get
            Set
                Me("ServerIPAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ServerPort() As String
            Get
                Return CType(Me("ServerPort"),String)
            End Get
            Set
                Me("ServerPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("360")>  _
        Public Property SolverTimeoutSeconds() As Integer
            Get
                Return CType(Me("SolverTimeoutSeconds"),Integer)
            End Get
            Set
                Me("SolverTimeoutSeconds") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.DWSIM.My.MySettings
            Get
                Return Global.DWSIM.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
