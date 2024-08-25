<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordCheckerMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordCheckerMain))
        Me.DropDownItemList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BlackTopBar = New System.Windows.Forms.Panel()
        Me.SidebarWithGlassPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxPanel = New System.Windows.Forms.Panel()
        Me.BbcRevolutionaryCheckbox6 = New BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox()
        Me.BbcRevolutionaryCheckbox5 = New BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox()
        Me.BbcRevolutionaryCheckbox4 = New BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox()
        Me.BbcRevolutionaryCheckbox3 = New BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox()
        Me.BbcRevolutionaryCheckbox2 = New BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox()
        Me.lblChangeInfo = New System.Windows.Forms.Label()
        Me.BbcRevolutionaryCheckbox1 = New BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonContainerLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdInsertAnID = New System.Windows.Forms.Button()
        Me.cmdAssociateFiles = New System.Windows.Forms.Button()
        Me.cmdCreateOracleFile = New System.Windows.Forms.Button()
        Me.cmdDeleteOracleFile = New System.Windows.Forms.Button()
        Me.cmdChangeDefaultFont = New System.Windows.Forms.Button()
        Me.cmdObtainStickyEncrypt = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CompressionPanel = New System.Windows.Forms.Panel()
        Me.MainMDITabControl = New BalfoursBusinessClassLibrary.Controls.TabControlWithOrb()
        Me.BbcBottomBar1 = New BalfoursBusinessClassLibrary.BBUI.Controls.BBBottomBar
        Me.BbcTopBar1 = New BalfoursBusinessClassLibrary.BBUI.Controls.BBTopBar()
        Me.SidebarWithGlassPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CheckBoxPanel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ButtonContainerLayoutPanel.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DropDownItemList
        '
        Me.DropDownItemList.Name = "ContextMenuStrip1"
        Me.DropDownItemList.Size = New System.Drawing.Size(61, 4)
        '
        'BlackTopBar
        '
        Me.BlackTopBar.BackColor = System.Drawing.Color.White
        Me.BlackTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BlackTopBar.Location = New System.Drawing.Point(0, 0)
        Me.BlackTopBar.Name = "BlackTopBar"
        Me.BlackTopBar.Size = New System.Drawing.Size(354, 31)
        Me.BlackTopBar.TabIndex = 1013
        '
        'SidebarWithGlassPanel
        '
        Me.SidebarWithGlassPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SidebarWithGlassPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SidebarWithGlassPanel.Controls.Add(Me.Panel1)
        Me.SidebarWithGlassPanel.Controls.Add(Me.BlackTopBar)
        Me.SidebarWithGlassPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarWithGlassPanel.ForeColor = System.Drawing.Color.White
        Me.SidebarWithGlassPanel.Location = New System.Drawing.Point(0, 65)
        Me.SidebarWithGlassPanel.Name = "SidebarWithGlassPanel"
        Me.SidebarWithGlassPanel.Size = New System.Drawing.Size(354, 427)
        Me.SidebarWithGlassPanel.TabIndex = 21
        Me.SidebarWithGlassPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 396)
        Me.Panel1.TabIndex = 1024
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(354, 396)
        Me.TabControl1.TabIndex = 1023
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.CheckBoxPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(346, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "Change general settings related to the software"
        Me.TabPage1.Text = "General"
        '
        'CheckBoxPanel
        '
        Me.CheckBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox6)
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox5)
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox4)
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox3)
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox2)
        Me.CheckBoxPanel.Controls.Add(Me.lblChangeInfo)
        Me.CheckBoxPanel.Controls.Add(Me.BbcRevolutionaryCheckbox1)
        Me.CheckBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxPanel.Location = New System.Drawing.Point(3, 3)
        Me.CheckBoxPanel.Name = "CheckBoxPanel"
        Me.CheckBoxPanel.Size = New System.Drawing.Size(340, 364)
        Me.CheckBoxPanel.TabIndex = 1019
        '
        'BbcRevolutionaryCheckbox6
        '
        Me.BbcRevolutionaryCheckbox6.AutoSize = True
        Me.BbcRevolutionaryCheckbox6.Location = New System.Drawing.Point(5, 148)
        Me.BbcRevolutionaryCheckbox6.Name = "BbcRevolutionaryCheckbox6"
        Me.BbcRevolutionaryCheckbox6.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox6.RegistryLocationToWritePath = "Software\Balfour Enterprises\Elements Office Ultra\Wonderword Ultra Edition"
        Me.BbcRevolutionaryCheckbox6.RegistryLocationToWriteValue = "autoConvertSmilies"
        Me.BbcRevolutionaryCheckbox6.Size = New System.Drawing.Size(162, 17)
        Me.BbcRevolutionaryCheckbox6.TabIndex = 1023
        Me.BbcRevolutionaryCheckbox6.Text = "Automatically convert Smilies"
        Me.BbcRevolutionaryCheckbox6.UseVisualStyleBackColor = True
        '
        'BbcRevolutionaryCheckbox5
        '
        Me.BbcRevolutionaryCheckbox5.AutoSize = True
        Me.BbcRevolutionaryCheckbox5.Location = New System.Drawing.Point(5, 125)
        Me.BbcRevolutionaryCheckbox5.Name = "BbcRevolutionaryCheckbox5"
        Me.BbcRevolutionaryCheckbox5.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox5.RegistryLocationToWritePath = "Software\Balfour Enterprises\Elements Office Ultra\Wonderword Ultra Edition"
        Me.BbcRevolutionaryCheckbox5.RegistryLocationToWriteValue = "showSB"
        Me.BbcRevolutionaryCheckbox5.Size = New System.Drawing.Size(104, 17)
        Me.BbcRevolutionaryCheckbox5.TabIndex = 1022
        Me.BbcRevolutionaryCheckbox5.Text = "Show Status bar"
        Me.BbcRevolutionaryCheckbox5.UseVisualStyleBackColor = True
        '
        'BbcRevolutionaryCheckbox4
        '
        Me.BbcRevolutionaryCheckbox4.AutoSize = True
        Me.BbcRevolutionaryCheckbox4.Location = New System.Drawing.Point(5, 102)
        Me.BbcRevolutionaryCheckbox4.Name = "BbcRevolutionaryCheckbox4"
        Me.BbcRevolutionaryCheckbox4.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox4.RegistryLocationToWritePath = "Software\Balfour Enterprises\Elements Office Ultra\Wonderword Ultra Edition"
        Me.BbcRevolutionaryCheckbox4.RegistryLocationToWriteValue = "useSpecialOrientation"
        Me.BbcRevolutionaryCheckbox4.Size = New System.Drawing.Size(158, 17)
        Me.BbcRevolutionaryCheckbox4.TabIndex = 1021
        Me.BbcRevolutionaryCheckbox4.Text = "Set orientation automatically"
        Me.BbcRevolutionaryCheckbox4.UseVisualStyleBackColor = True
        '
        'BbcRevolutionaryCheckbox3
        '
        Me.BbcRevolutionaryCheckbox3.AutoSize = True
        Me.BbcRevolutionaryCheckbox3.Location = New System.Drawing.Point(5, 79)
        Me.BbcRevolutionaryCheckbox3.Name = "BbcRevolutionaryCheckbox3"
        Me.BbcRevolutionaryCheckbox3.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox3.RegistryLocationToWritePath = "Software\Balfour Enterprises\Elements Office Ultra\Wonderword Ultra Edition"
        Me.BbcRevolutionaryCheckbox3.RegistryLocationToWriteValue = "showBRWarnings"
        Me.BbcRevolutionaryCheckbox3.Size = New System.Drawing.Size(214, 17)
        Me.BbcRevolutionaryCheckbox3.TabIndex = 1020
        Me.BbcRevolutionaryCheckbox3.Text = "Show BlackRabbit Start Script warnings"
        Me.BbcRevolutionaryCheckbox3.UseVisualStyleBackColor = True
        '
        'BbcRevolutionaryCheckbox2
        '
        Me.BbcRevolutionaryCheckbox2.AutoSize = True
        Me.BbcRevolutionaryCheckbox2.Location = New System.Drawing.Point(5, 56)
        Me.BbcRevolutionaryCheckbox2.Name = "BbcRevolutionaryCheckbox2"
        Me.BbcRevolutionaryCheckbox2.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox2.RegistryLocationToWritePath = "Software\Balfour Enterprises\Elements Office Ultra\Wonderword Ultra Edition"
        Me.BbcRevolutionaryCheckbox2.RegistryLocationToWriteValue = "ignoreLinks"
        Me.BbcRevolutionaryCheckbox2.Size = New System.Drawing.Size(120, 17)
        Me.BbcRevolutionaryCheckbox2.TabIndex = 1019
        Me.BbcRevolutionaryCheckbox2.Text = "Ignore link warnings"
        Me.BbcRevolutionaryCheckbox2.UseVisualStyleBackColor = True
        '
        'lblChangeInfo
        '
        Me.lblChangeInfo.AutoSize = True
        Me.lblChangeInfo.Location = New System.Drawing.Point(2, 13)
        Me.lblChangeInfo.Name = "lblChangeInfo"
        Me.lblChangeInfo.Size = New System.Drawing.Size(282, 13)
        Me.lblChangeInfo.TabIndex = 1018
        Me.lblChangeInfo.Text = "Some changes take effect after the application is restarted"
        '
        'BbcRevolutionaryCheckbox1
        '
        Me.BbcRevolutionaryCheckbox1.AutoSize = True
        Me.BbcRevolutionaryCheckbox1.Location = New System.Drawing.Point(5, 33)
        Me.BbcRevolutionaryCheckbox1.Name = "BbcRevolutionaryCheckbox1"
        Me.BbcRevolutionaryCheckbox1.RegistryKeyToWriteValue = BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser
        Me.BbcRevolutionaryCheckbox1.RegistryLocationToWritePath = "Software\Balfour Enterprises\Elements Office Ultra\Wonderword Ultra Edition"
        Me.BbcRevolutionaryCheckbox1.RegistryLocationToWriteValue = "showStartup"
        Me.BbcRevolutionaryCheckbox1.Size = New System.Drawing.Size(128, 17)
        Me.BbcRevolutionaryCheckbox1.TabIndex = 14
        Me.BbcRevolutionaryCheckbox1.Text = "Show Welcome page"
        Me.BbcRevolutionaryCheckbox1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ButtonContainerLayoutPanel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(346, 463)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "Change settings which are specific to the software."
        Me.TabPage2.Text = "Specific"
        '
        'ButtonContainerLayoutPanel
        '
        Me.ButtonContainerLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonContainerLayoutPanel.ColumnCount = 2
        Me.ButtonContainerLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonContainerLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonContainerLayoutPanel.Controls.Add(Me.cmdInsertAnID, 1, 2)
        Me.ButtonContainerLayoutPanel.Controls.Add(Me.cmdAssociateFiles, 0, 0)
        Me.ButtonContainerLayoutPanel.Controls.Add(Me.cmdCreateOracleFile, 0, 1)
        Me.ButtonContainerLayoutPanel.Controls.Add(Me.cmdDeleteOracleFile, 1, 1)
        Me.ButtonContainerLayoutPanel.Controls.Add(Me.cmdChangeDefaultFont, 0, 2)
        Me.ButtonContainerLayoutPanel.Controls.Add(Me.cmdObtainStickyEncrypt, 1, 0)
        Me.ButtonContainerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonContainerLayoutPanel.ForeColor = System.Drawing.Color.Black
        Me.ButtonContainerLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.ButtonContainerLayoutPanel.Name = "ButtonContainerLayoutPanel"
        Me.ButtonContainerLayoutPanel.RowCount = 5
        Me.ButtonContainerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ButtonContainerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ButtonContainerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ButtonContainerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ButtonContainerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonContainerLayoutPanel.Size = New System.Drawing.Size(340, 457)
        Me.ButtonContainerLayoutPanel.TabIndex = 1016
        '
        'cmdInsertAnID
        '
        Me.cmdInsertAnID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdInsertAnID.Image = CType(resources.GetObject("cmdInsertAnID.Image"), System.Drawing.Image)
        Me.cmdInsertAnID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInsertAnID.Location = New System.Drawing.Point(173, 63)
        Me.cmdInsertAnID.Name = "cmdInsertAnID"
        Me.cmdInsertAnID.Size = New System.Drawing.Size(164, 24)
        Me.cmdInsertAnID.TabIndex = 9
        Me.cmdInsertAnID.Text = "Insert a StickyEncrypt ID"
        Me.cmdInsertAnID.UseVisualStyleBackColor = True
        '
        'cmdAssociateFiles
        '
        Me.cmdAssociateFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAssociateFiles.Location = New System.Drawing.Point(3, 3)
        Me.cmdAssociateFiles.Name = "cmdAssociateFiles"
        Me.cmdAssociateFiles.Size = New System.Drawing.Size(164, 24)
        Me.cmdAssociateFiles.TabIndex = 1
        Me.cmdAssociateFiles.Text = "Associate files"
        Me.cmdAssociateFiles.UseVisualStyleBackColor = True
        '
        'cmdCreateOracleFile
        '
        Me.cmdCreateOracleFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdCreateOracleFile.Location = New System.Drawing.Point(3, 33)
        Me.cmdCreateOracleFile.Name = "cmdCreateOracleFile"
        Me.cmdCreateOracleFile.Size = New System.Drawing.Size(164, 24)
        Me.cmdCreateOracleFile.TabIndex = 4
        Me.cmdCreateOracleFile.Text = "Create an Oracle Installation"
        Me.cmdCreateOracleFile.UseVisualStyleBackColor = True
        '
        'cmdDeleteOracleFile
        '
        Me.cmdDeleteOracleFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDeleteOracleFile.Location = New System.Drawing.Point(173, 33)
        Me.cmdDeleteOracleFile.Name = "cmdDeleteOracleFile"
        Me.cmdDeleteOracleFile.Size = New System.Drawing.Size(164, 24)
        Me.cmdDeleteOracleFile.TabIndex = 7
        Me.cmdDeleteOracleFile.Text = "Delete an Oracle Installation"
        Me.cmdDeleteOracleFile.UseVisualStyleBackColor = True
        '
        'cmdChangeDefaultFont
        '
        Me.cmdChangeDefaultFont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdChangeDefaultFont.Image = CType(resources.GetObject("cmdChangeDefaultFont.Image"), System.Drawing.Image)
        Me.cmdChangeDefaultFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChangeDefaultFont.Location = New System.Drawing.Point(3, 63)
        Me.cmdChangeDefaultFont.Name = "cmdChangeDefaultFont"
        Me.cmdChangeDefaultFont.Size = New System.Drawing.Size(164, 24)
        Me.cmdChangeDefaultFont.TabIndex = 5
        Me.cmdChangeDefaultFont.Text = "Change default font"
        Me.cmdChangeDefaultFont.UseVisualStyleBackColor = True
        '
        'cmdObtainStickyEncrypt
        '
        Me.cmdObtainStickyEncrypt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdObtainStickyEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdObtainStickyEncrypt.Location = New System.Drawing.Point(173, 3)
        Me.cmdObtainStickyEncrypt.Name = "cmdObtainStickyEncrypt"
        Me.cmdObtainStickyEncrypt.Size = New System.Drawing.Size(164, 24)
        Me.cmdObtainStickyEncrypt.TabIndex = 8
        Me.cmdObtainStickyEncrypt.Text = "Obtain StickyEncrypt ID"
        Me.cmdObtainStickyEncrypt.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.CompressionPanel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(346, 463)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Tag = "Change compression settings."
        Me.TabPage3.Text = "Compression"
        '
        'CompressionPanel
        '
        Me.CompressionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompressionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CompressionPanel.Location = New System.Drawing.Point(0, 0)
        Me.CompressionPanel.Name = "CompressionPanel"
        Me.CompressionPanel.Size = New System.Drawing.Size(346, 131)
        Me.CompressionPanel.TabIndex = 0
        '
        'MainMDITabControl
        '
        Me.MainMDITabControl.AddDefaultContextItemsAfter = True
        Me.MainMDITabControl.AddDefaultContextItemsBefore = True
        Me.MainMDITabControl.AddRecentAndFavouritesToMenu = False
        Me.MainMDITabControl.Alignment = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.TabAlignment.Top
        Me.MainMDITabControl.BackColor = System.Drawing.SystemColors.Control
        Me.MainMDITabControl.BackHighColor = System.Drawing.Color.White
        Me.MainMDITabControl.BackLowColor = System.Drawing.Color.White
        Me.MainMDITabControl.ControlButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MainMDITabControl.DefaultOrbOption = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.OrbRaiseOption.DefaultOrbMenu
        Me.MainMDITabControl.DefaultSoftwareColour = System.Drawing.Color.Red
        Me.MainMDITabControl.DelayDrag = True
        Me.MainMDITabControl.DeleteTabsMode = False
        Me.MainMDITabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMDITabControl.DropDownFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MainMDITabControl.DropDownItemList = Nothing
        Me.MainMDITabControl.FontBoldOnSelect = False
        Me.MainMDITabControl.ForeColor = System.Drawing.Color.White
        Me.MainMDITabControl.ForeColorDisabled = System.Drawing.Color.Black
        Me.MainMDITabControl.LeftOffset = 3
        Me.MainMDITabControl.LinkedBottomBar = Me.BbcBottomBar1
        Me.MainMDITabControl.LinkedTopBar = Me.BbcTopBar1
        Me.MainMDITabControl.LinkedForm = Me
        Me.MainMDITabControl.LinkedGlassControl1 = Me.BlackTopBar
        Me.MainMDITabControl.LinkedTopBar = Nothing
        Me.MainMDITabControl.Location = New System.Drawing.Point(354, 65)
        Me.MainMDITabControl.MenuRenderer = Nothing
        Me.MainMDITabControl.Name = "MainMDITabControl"
        Me.MainMDITabControl.OrbGlowOnHover = True
        Me.MainMDITabControl.OrbImage = CType(resources.GetObject("MainMDITabControl.OrbImage"), System.Drawing.Image)
        Me.MainMDITabControl.OrbTooltip = "Click this button to get started"
        Me.MainMDITabControl.OrbVisible = True
        Me.MainMDITabControl.OrbWidth = 28
        Me.MainMDITabControl.OverrideTheme = True
        Me.MainMDITabControl.PingSpeed = 500.0!
        Me.MainMDITabControl.RegistryLocation = "Software\Balfour Enterprises\Elements Office Ultra\Record Checker Ultra Edition"
        Me.MainMDITabControl.SetBackLowColorWithTheme = True
        Me.MainMDITabControl.SetFormTextAutomatically = True
        Me.MainMDITabControl.ShowAddNewBrowserButton = True
        Me.MainMDITabControl.Size = New System.Drawing.Size(628, 427)
        Me.MainMDITabControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.MainMDITabControl.TabApplicationWebsite = Nothing
        Me.MainMDITabControl.TabBackHighAlpha = 100
        Me.MainMDITabControl.TabBackHighColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MainMDITabControl.TabBackLowColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MainMDITabControl.TabBorderEnhanceWeight = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.Weight.Medium
        Me.MainMDITabControl.TabCloseButtonImage = Nothing
        Me.MainMDITabControl.TabCloseButtonImageDisabled = Nothing
        Me.MainMDITabControl.TabCloseButtonImageHot = Nothing
        Me.MainMDITabControl.TabControlIcon = Nothing
        Me.MainMDITabControl.TabIndex = 1
        Me.MainMDITabControl.TabMinimumWidth = 200
        Me.MainMDITabControl.TabPingColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MainMDITabControl.TabsDirection = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.FlowDirection.LeftToRight
        Me.MainMDITabControl.TabSpecification = "Document"
        Me.MainMDITabControl.Theme = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.ThemeType.Custom
        Me.MainMDITabControl.ThemeCustomFilename = Nothing
        Me.MainMDITabControl.TopSeparator = False
        Me.MainMDITabControl.UseCircularOrb = True
        Me.MainMDITabControl.UseCustomColours = False
        Me.MainMDITabControl.UseDragOnBar = False
        Me.MainMDITabControl.UseGenericBBTheme = True
        Me.MainMDITabControl.UseInvertColourOnDropDownButtonOnGlassTheme = True
        Me.MainMDITabControl.UseThemes = True
        Me.MainMDITabControl.WebsiteForThemeDownload = "http://www.jamiebalfour.co.uk/Business/Theme.bbt"
        '
        'BbcBottomBar1
        '
        Me.BbcBottomBar1.BackColor = System.Drawing.SystemColors.Control
        Me.BbcBottomBar1.BackgroundImage = CType(resources.GetObject("BbcBottomBar1.BackgroundImage"), System.Drawing.Image)
        Me.BbcBottomBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BbcBottomBar1.CopyrightLabelBorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BbcBottomBar1.CopyrightText = "Record Checker Ultra Edition Copyright 2009 - 2012 Balfour Enterprises"
        Me.BbcBottomBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BbcBottomBar1.ForeColor = System.Drawing.Color.Black
        Me.BbcBottomBar1.LinkedForm = Nothing
        Me.BbcBottomBar1.Location = New System.Drawing.Point(0, 492)
        Me.BbcBottomBar1.Name = "BbcBottomBar1"
        Me.BbcBottomBar1.Recent1String = "Recent 1"
        Me.BbcBottomBar1.Recent2String = "Recent 2"
        Me.BbcBottomBar1.Recent3String = "Recent 3"
        Me.BbcBottomBar1.Recent4String = "Recent 4"
        Me.BbcBottomBar1.RotatingOrb = CType(resources.GetObject("BbcBottomBar1.RotatingOrb"), System.Drawing.Image)
        Me.BbcBottomBar1.RotatingOrbBackColour = System.Drawing.Color.Transparent
        Me.BbcBottomBar1.RotatingOrbBorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BbcBottomBar1.ShowCloseOnStartMenu = True
        Me.BbcBottomBar1.ShowDocumentsOnStartMenu = True
        Me.BbcBottomBar1.ShowOrb = False
        Me.BbcBottomBar1.ShowProgramsOnStartMenu = False
        Me.BbcBottomBar1.ShowSettingsOnStartMenu = True
        Me.BbcBottomBar1.ShowStartMenu = False
        Me.BbcBottomBar1.Size = New System.Drawing.Size(982, 28)
        Me.BbcBottomBar1.TabIndex = 2
        Me.BbcBottomBar1.UseHyperMode = False
        '
        'BbcTopBar1
        '
        Me.BbcTopBar1.BackgroundImage = CType(resources.GetObject("BbcTopBar1.BackgroundImage"), System.Drawing.Image)
        Me.BbcTopBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BbcTopBar1.BoldText = "ultra"
        Me.BbcTopBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BbcTopBar1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbcTopBar1.ForeColor = System.Drawing.Color.Black
        Me.BbcTopBar1.HoverColor = System.Drawing.Color.LightBlue
        Me.BbcTopBar1.LinkedForm = Me
        Me.BbcTopBar1.Location = New System.Drawing.Point(0, 0)
        Me.BbcTopBar1.MainImage = Nothing
        Me.BbcTopBar1.Name = "BbcTopBar1"
        Me.BbcTopBar1.ShowHelpAndSupport = False
        Me.BbcTopBar1.Size = New System.Drawing.Size(982, 65)
        Me.BbcTopBar1.StandardText1 = "record checker"
        Me.BbcTopBar1.StandardText2 = "edition"
        Me.BbcTopBar1.TabIndex = 0
        Me.BbcTopBar1.UseNonStandardSizes = False
        '
        'RecordCheckerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 520)
        Me.Controls.Add(Me.MainMDITabControl)
        Me.Controls.Add(Me.SidebarWithGlassPanel)
        Me.Controls.Add(Me.BbcTopBar1)
        Me.Controls.Add(Me.BbcBottomBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "RecordCheckerMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Record Checker Ultra Edition"
        Me.SidebarWithGlassPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.CheckBoxPanel.ResumeLayout(False)
        Me.CheckBoxPanel.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ButtonContainerLayoutPanel.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbcTopBar1 As BalfoursBusinessClassLibrary.BBUI.Controls.BBTopBar
    Friend WithEvents MainMDITabControl As BalfoursBusinessClassLibrary.Controls.TabControlWithOrb
    Friend WithEvents BbcBottomBar1 As BalfoursBusinessClassLibrary.BBUI.Controls.BBBottomBar
    Friend WithEvents DropDownItemList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BlackTopBar As System.Windows.Forms.Panel
    Friend WithEvents SidebarWithGlassPanel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxPanel As System.Windows.Forms.Panel
    Friend WithEvents BbcRevolutionaryCheckbox6 As BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox
    Friend WithEvents BbcRevolutionaryCheckbox5 As BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox
    Friend WithEvents BbcRevolutionaryCheckbox4 As BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox
    Friend WithEvents BbcRevolutionaryCheckbox3 As BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox
    Friend WithEvents BbcRevolutionaryCheckbox2 As BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox
    Friend WithEvents lblChangeInfo As System.Windows.Forms.Label
    Friend WithEvents BbcRevolutionaryCheckbox1 As BalfoursBusinessClassLibrary.Controls.RevolutionaryCheckbox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonContainerLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdInsertAnID As System.Windows.Forms.Button
    Friend WithEvents cmdAssociateFiles As System.Windows.Forms.Button
    Friend WithEvents cmdCreateOracleFile As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteOracleFile As System.Windows.Forms.Button
    Friend WithEvents cmdChangeDefaultFont As System.Windows.Forms.Button
    Friend WithEvents cmdObtainStickyEncrypt As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CompressionPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
