Imports System.IO
Imports BalfoursBusinessClassLibrary.Classes.Displays
Imports BalfoursBusinessClassLibrary.Classes.BalfoursEnterprises
Imports BalfoursBusinessClassLibrary.Classes.RegistryActions
Imports BalfoursBusinessClassLibrary.Classes.SpecialisedFunctions
Imports BalfoursBusinessClassLibrary.Classes.Conversion
Public Class RecordCheckerChild
    Dim mColour1 As Color = Color.White
    Dim mColour2 As Color = Color.FromArgb(255, 51, 51, 51)
    Dim mCurrentFile As String
    Dim tColumn As DataGridViewColumn
    Dim lastBarcode As String
    Public Property MyTabPage As BalfoursBusinessClassLibrary.Controls.TabPage
    Public Sub OpenFile(Optional ByVal Filename As String = "")
        If Filename Is "" Or Filename = "newopen" Then
            Dim OpenFileDialog1 As New OpenFileDialog
            OpenFileDialog1.Filter = "All supported (*.rux, *.csv)|*.rux; *.csv|Record Checker Ultra Extension (*.rux)|*.rux|Comma Seperated Values (*.csv)|*.csv"
            OpenFileDialog1.RestoreDirectory = True
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                DataGridView1.OpenFile(OpenFileDialog1.FileName)
                RefreshRecent(OpenFileDialog1.FileName)
                mCurrentFile = OpenFileDialog1.FileName
                Me.Text = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Name
            End If
        Else
            DataGridView1.OpenFile(Filename)
            RefreshRecent(Filename)
            mCurrentFile = Filename
            Me.Text = My.Computer.FileSystem.GetFileInfo(Filename).Name
        End If

    End Sub
    Public Sub Save(Optional ByVal Filename As String = Nothing)
        If Filename = Nothing Then
            Dim sfd1 As New SaveFileDialog
            sfd1.Filter = "Record Checker Ultra Extension (*.rux)|*.rux|Comma Seperated Values (*.csv)|*.csv"
            If sfd1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Filename = sfd1.FileName
            Else
                Exit Sub
            End If
        End If
        DataGridView1.DatabaseTitle = BbcCrossedTextBox2.Text
        DataGridView1.DatabaseAuthor = BbcCrossedTextBox3.Text
        DataGridView1.SaveFile(Filename)
        RefreshRecent(Filename)
        mCurrentFile = Filename
        Me.Text = My.Computer.FileSystem.GetFileInfo(Filename).Name
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Save(mCurrentFile)
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Save()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFile()
        BbcCrossedTextBox2.Text = DataGridView1.DatabaseTitle
        BbcCrossedTextBox3.Text = DataGridView1.DatabaseAuthor
    End Sub
    Private Sub TextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Public Sub RefreshRecent(ByVal Filename As String)
        AddToRecents(Filename, "Elements Office Ultra", "Database", DropDownItemsToArrayOfToolstripItem(RecentFilesToolStripMenuItem))
        RecentFilesUpdate()
    End Sub
    Public Sub RecentFilesUpdate()
        RecentFilesUpdater("Database", "Elements Office Ultra", DropDownItemsToArrayOfToolstripItem(RecentFilesToolStripMenuItem))
    End Sub
    Private Sub RecordCheckerChild_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.SpellChecker()
        AdvantageMenu(MenuStrip1)
        RecentFilesUpdate()
    End Sub
    Private Sub SearchTextBox_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles BbcCrossedTextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            BbcCrossedTextBox1.Button1PerformClick()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        DataGridView1.NewFile()
    End Sub
    Private Sub AutocheckColumnToolStripMenuItem_DropDownItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles AutocheckColumnToolStripMenuItem.DropDownItemClicked
        For Each c As DataGridViewColumn In DataGridView1.Columns
            If c.HeaderText.StartsWith(e.ClickedItem.Text) Then
                tColumn = c
                Exit For
            End If
        Next
    End Sub

    Private Sub AutocheckColumnToolStripMenuItem_DropDownOpening(sender As Object, e As System.EventArgs) Handles AutocheckColumnToolStripMenuItem.DropDownOpening
        AutocheckColumnToolStripMenuItem.DropDownItems.Clear()
        For Each c As DataGridViewColumn In DataGridView1.Columns
            If DataGridView1.GetCellType(c.CellType) = BalfoursBusinessExtensionLibrary.Controls.RecordCheckerUltraControl.CellType.Checkbox Then
                Dim i As New ToolStripMenuItem
                i.Text = c.HeaderText
                i.Name = c.Index

                AutocheckColumnToolStripMenuItem.DropDownItems.Add(i)
                BarcodeModeToolStripMenuItem.Checked = True
            End If
        Next
    End Sub
    Sub PressKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, BbcCrossedTextBox1.KeyPress
        If BarcodeModeToolStripMenuItem.Checked = True Then
            CleartString.Stop()
            CleartString.Start()
            CleartString.Enabled = True
        End If

    End Sub
    Private Sub ClearString_Tick(sender As System.Object, e As System.EventArgs) Handles CleartString.Tick
        CleartString.Enabled = False
        lastBarcode = BbcCrossedTextBox1.Text
        BbcCrossedTextBox1.Button1PerformClick()
        BbcCrossedTextBox1.Text = Nothing
        BbcCrossedTextBox1.Focus()
        BbcCrossedTextBox1.Select()
    End Sub

    Private Sub SearchForTermToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchForTermToolStripMenuItem.Click
        Dim search As String = BBTextInputBox("Please insert the search term. ", mColour1, mColour2, "Search terms")

        If Not DataGridView1.CurrentCell.RowIndex + 1 > DataGridView1.Rows.Count Then
            DataGridView1.SelectSearchCells(search, DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex + 1)
        Else
            DataGridView1.SelectSearchCells(search, DataGridView1.CurrentCell.ColumnIndex, 0)
        End If
    End Sub

    Private Sub BarcodeModeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarcodeModeToolStripMenuItem.Click
        BarcodeBottomPanel.Visible = BarcodeModeToolStripMenuItem.Checked
    End Sub

    Private Sub NewColumnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewColumnToolStripMenuItem.Click
        Dim ls As New List(Of String)
        ls.Add("Checkbox")
        ls.Add("Drop down")
        ls.Add("Image")
        ls.Add("Script")
        ls.Add("Text")
        Dim result As String = BBComboInputBox("Which type of column would you like to use?", mColour1, mColour2,  ls)
        Dim l As String = BBTextInputBox("Please insert the column name", mColour1, mColour2, "Name")
        If UseGenericChoicesToolStripMenuItem.Checked = True Then
            DataGridView1.AddColumnOfType(l, result, genericOptionList.ToArray)
        Else
            DataGridView1.AddColumnOfType(l, result)
        End If

        prevType = result
    End Sub
    Dim prevType As String
    Private Sub AddColumnOfSameTypeAgainToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddColumnOfSameTypeAgainToolStripMenuItem.Click
        Dim l As String = BBTextInputBox("Please insert the column name", mColour1, mColour2, "Name")

        If UseGenericChoicesToolStripMenuItem.Checked = True Then
            DataGridView1.AddColumnOfType(l, prevType, genericOptionList.ToArray)
        Else
            DataGridView1.AddColumnOfType(l, prevType)
        End If
    End Sub
   
    Private Sub RemoveColumnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveColumnToolStripMenuItem.Click
        DataGridView1.RemoveColumn()
    End Sub
    Private Sub FileToolStripMenuItem_DropDownOpened(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.DropDownOpened, EditToolStripMenuItem.DropDownOpened, ViewToolStripMenuItem.DropDownOpened, _
  ToolsToolStripMenuItem.DropDownOpened, GridToolStripMenuItem.DropDownOpened, HelpToolStripMenuItem.DropDownOpened

        sender.ForeColor = Color.Black
    End Sub
    Private Sub FileToolStripMenuItem_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.DropDownClosed, EditToolStripMenuItem.DropDownClosed, ViewToolStripMenuItem.DropDownClosed, _
     ToolsToolStripMenuItem.DropDownClosed, GridToolStripMenuItem.DropDownClosed, HelpToolStripMenuItem.DropDownClosed

        sender.ForeColor = Color.White
    End Sub
    Private Sub BbcCrossedTextBox1_Button1Clicked() Handles BbcCrossedTextBox1.Button1Clicked
        If BarcodeModeToolStripMenuItem.Checked = True Then
            DataGridView1.CheckUncheckColumnAutomatically(BbcCrossedTextBox1.Text, tColumn.Index)
        Else
            If Not DataGridView1.CurrentCell.RowIndex + 1 > DataGridView1.Rows.Count Then
                DataGridView1.SelectSearchCells(BbcCrossedTextBox1.Text, DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex + 1)
            Else
                DataGridView1.SelectSearchCells(BbcCrossedTextBox1.Text, DataGridView1.CurrentCell.ColumnIndex, 0)
            End If
        End If
    End Sub

    Private Sub SearchForCodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchForCodeToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        BBAboutDialog("Record Checker Ultra Edition", mColour1, mColour2, "Copyright 2009 - 2012 Balfour's Enterprises", "2.0.0.300", Me.Icon, "", True, "This application is part of the Elements Office Suite and therefore its license is bound to the the license of the parent software", "Complies with: " & vbCrLf & "BBSA-WUX" & vbCrLf & "BBSA-RUX" & vbCrLf & "BBSA-BIF")
    End Sub

    Private Sub SetBackColourToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetBackColourToolStripMenuItem.Click
        DataGridView1.ChangeCellBackColour()
    End Sub

    Private Sub SetFontColourToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetFontColourToolStripMenuItem.Click
        DataGridView1.ChangeCellForeColour()
    End Sub

    Private Sub SetFontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetFontToolStripMenuItem.Click
        DataGridView1.ChangeCellFont()
    End Sub

    Private Sub AddNewRowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewRowToolStripMenuItem.Click
        Try
            DataGridView1.Rows.Insert(DataGridView1.CurrentCell.RowIndex, 1)
        Catch ex As Exception
            MsgBox("To add a new row (record) you must have at least one column (field).", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click, CutToolStripMenuItem1.Click
        DataGridView1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click, CopyToolStripMenuItem1.Click
        DataGridView1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click, PasteToolStripMenuItem1.Click
        DataGridView1.Paste()
    End Sub
    Private Sub DropDownBoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DropDownBoxToolStripMenuItem.Click
        Dim s As String = DataGridView1(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex).GetType.ToString
        If s.ToString.Contains("DataGridViewComboBoxCell") Then
            Dim i As New DataGridViewComboBoxCell
            i = DataGridView1(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex)
            i.Items.Add(BBTextInputBox("Please insert an item to add to the combo box", mColour1, mColour2))
        End If
    End Sub
    Private Sub GridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GridToolStripMenuItem.Click
        Try
            Dim s As String = DataGridView1(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentCell.RowIndex).GetType.ToString
            If s.ToString.Contains("DataGridViewComboBoxCell") Then
                DropDownBoxToolStripMenuItem.Enabled = True
            Else
                DropDownBoxToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            DropDownBoxToolStripMenuItem.Enabled = False
        End Try
    End Sub
    Dim genericOptionList As New List(Of String)
    Private Sub CreateAGenericListOfOptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateAGenericListOfOptionsToolStripMenuItem.Click
        Dim i As String = BBTextInputBox("Please insert an option. To stop adding options click Cancel", mColour1, mColour2)
        While Not i Is Nothing
            genericOptionList.Add(i)
            i = BBTextInputBox("Please insert an option. To stop adding options click Cancel", mColour1, mColour2)
        End While
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick, DataGridView1.CellContentDoubleClick
        Try
            Dim s As String = DataGridView1(e.ColumnIndex, e.RowIndex).GetType.ToString
            If s.Contains("DataGridViewImageCell") Then
                Dim ofd1 As New OpenFileDialog
                ofd1.Filter = "All supported images (*.jpg, *.png, *.gif, *.bmp)|*.jpg; *.png; *.gif; *.bmp"
                If ofd1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim i As DataGridViewImageCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    i.Value = Image.FromFile(ofd1.FileName)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RemoveRowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveRowToolStripMenuItem.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LockToolStripMenuItem.Click
        Try
            If DataGridView1(0, 0).ReadOnly = True Then
                For c = 0 To DataGridView1.ColumnCount - 1
                    For r = 0 To DataGridView1.RowCount - 1
                        DataGridView1(c, r).ReadOnly = False
                        LockToolStripMenuItem.Checked = False
                    Next
                Next
            Else
                For c = 0 To DataGridView1.ColumnCount - 1
                    For r = 0 To DataGridView1.RowCount - 1
                        DataGridView1(c, r).ReadOnly = True
                        LockToolStripMenuItem.Checked = True
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox("There must be content in the database in order to lock every cell")
        End Try


    End Sub

    Private Sub EditImageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SpellCheckerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpellCheckerToolStripMenuItem.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RecentFilesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecentFilesToolStripMenuItem.Click

    End Sub

    Private Sub RecentFilesToolStripMenuItem_DropDownItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles RecentFilesToolStripMenuItem.DropDownItemClicked
        OpenFile(e.ClickedItem.ToolTipText)
    End Sub

    Private Sub MySQLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MySQLToolStripMenuItem.Click

    End Sub
    Dim mysql_server As String = "mysql.seahorse.arvixe.com"
    Dim mysql_user As String = "jb130791_Site"
    Dim mysql_pass As String = ""
    Dim mysql_db As String = ""
    Dim dl_DGV As New DataGridView
    Private Sub CheckMySQLDetails()
        If mysql_server = "" Then
            mysql_server = BBTextInputBox("Please insert the server name.", mColour1, mColour2)
        End If
        If mysql_user = "" Then
            mysql_user = BBTextInputBox("Please insert your username.", mColour1, mColour2)
        End If
        If mysql_pass = "" Then
            mysql_pass = BBTextInputBox("Please insert your password.", mColour1, mColour2, , True)
        End If
        If mysql_db = "" Then
            mysql_db = BBTextInputBox("Please insert the database to connect to.", mColour1, mColour2)
        End If
    End Sub
    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        CheckMySQLDetails()

        Dim mysql As New BalfoursBusinessClassLibrary.WrapperClasses.MySQLWrapper
        mysql.MySQL_InitiateConnection(mysql_server, mysql_user, mysql_pass, mysql_db)

        Dim table As String = BBTextInputBox("Please insert the name of the table you wish to open.", mColour1, mColour2)
        mysql.MySQL_FetchArrayToDatagridview("SELECT * FROM " + table, DataGridView1)

        For Each s As DataGridViewColumn In DataGridView1.Columns
            dl_DGV.Columns.Add(s.Name, s.HeaderText)
        Next

        For posY = 0 To DataGridView1.RowCount - 1
            dl_DGV.Rows.Add(1)
            For posX = 0 To DataGridView1.ColumnCount - 1
                dl_DGV(posX, posY).Value = DataGridView1(posX, posY).Value
            Next
        Next

    End Sub

    Private Sub OpenAConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAConnectionToolStripMenuItem.Click
        mysql_server = BBTextInputBox("Please insert the server name.", mColour1, mColour2)
        mysql_user = BBTextInputBox("Please insert your username.", mColour1, mColour2)
        mysql_pass = BBTextInputBox("Please insert your password.", mColour1, mColour2, , True)
        mysql_db = BBTextInputBox("Please insert the database to connect to.", mColour1, mColour2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For posY = 0 To DataGridView1.RowCount - 1
            For posX = 0 To DataGridView1.ColumnCount - 1
                If Not (dl_DGV(posX, posY).Value = DataGridView1(posX, posY).Value) Then
                    MsgBox(posX & " " & posY)
                End If
            Next
        Next
    End Sub
End Class
