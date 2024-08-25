Imports BalfoursBusinessClassLibrary.Classes.BalfoursEnterprises
Imports BalfoursBusinessClassLibrary.Classes.SpecialisedFunctions

Public Class RecordCheckerMain
    Dim mColour1 As Color = Color.White
    Dim mColour2 As Color = Color.FromArgb(255, 51, 51, 51)
    Public Sub NewChild(Optional ByVal Filename As String = Nothing)
        Dim f As New RecordCheckerChild
        f.Text = "Untitled Base"
        f.MyTabPage = MainMDITabControl.TabPages.Add(f)
        If Filename Is Nothing Or Filename = "" Then
        Else
            f.OpenFile(Filename)
        End If
    End Sub

    Private Sub RecordCheckerMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ClosingFormCommands(Me, BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition", e, MainMDITabControl)
    End Sub
    Private Sub SendArguementData(ByVal ArgumentIn As String)
        Select Case LCase(ArgumentIn)
            Case Is = "-newopen"
                NewChild("newopen")
            Case Is = "-silent"
                End
            Case Is = "-forced"
                NewChild()
            Case Else
                Dim fileOpening As String = ArgumentIn.Replace("%20", " ")
                NewChild(fileOpening)
        End Select
    End Sub
    Private Sub RecordCheckerMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim BPop As New BalfoursBusinessExtensionLibrary.Controls.PopUpMenu
        BPop.TransferTabControlToBBCPopUpMenu(TabControl1, mcolour1, mcolour2)


        Try
            c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition\", "version", Application.ProductVersion)
            c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition\", "exe version", System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision)
        Catch ex As Exception
        End Try

        Dim s As Integer
        Try
            s = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision
        Catch ex As Exception

        End Try

        'this sets the info
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition\", "installpath location", My.Application.Info.DirectoryPath)
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition\", "exepath location", Application.ExecutablePath)

        OpeningCommands(Me, BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition")

        MainMDITabControl.Theme = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition", "theme")

        MainMDITabControl.ReloadTheme()

        If My.Application.CommandLineArgs.Count = 0 Then
            NewChild()
        Else
            Try
                For Each arg As String In My.Application.CommandLineArgs
                    SendArguementData(arg)
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Sub ShowOptions()
        SidebarWithGlassPanel.Visible = InvertBoolean(SidebarWithGlassPanel.Visible)
    End Sub
    Private Sub MainMDITabControl_PreferrencesButtonClicked() Handles MainMDITabControl.PreferrencesButtonClicked
        ShowOptions()
    End Sub
    Private Sub MainMDITabControl_Tabs_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MainMDITabControl.Tabs_DoubleClick
        NewChild()
    End Sub
End Class