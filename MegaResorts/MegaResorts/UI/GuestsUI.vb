Imports System.Data.Entity
Imports System.Data.Entity.Validation

Public Class GuestsUI
    Private dbContext As CottageDBDAL.CottagesEntities = Nothing

    Private RoomDAL As New Room_BedDbAccess
    Private RoomList As New List(Of CottageDBDAL.Room)

    Private hasUnsavedChangesBoolean As Boolean = False

    Private BeforeEditFirstNameString As String = ""
    Private BeforeEditLastNameString As String = ""

    Private isAddingModeBoolean As Boolean = False
    Private isEditingModeBoolean As Boolean = False

    Private Sub GuestsUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDB()

        RoomList = RoomDAL.GetAllCottageDBRooms(dbContext)
        RoomBindingSource.DataSource = RoomList
        roomAvailableListBox.DataSource = RoomBindingSource

        ShowViewMode()
        GuestNameComboBox.SelectedIndex = 0
    End Sub

    Private Sub LoadDB()
        If (dbContext IsNot Nothing) Then
            dbContext.Dispose()
        End If

        Try
            dbContext = New CottageDBDAL.CottagesEntities()
            dbContext.Guests.OrderBy(Function(CurrGuest) CurrGuest.Last_Name).ThenBy(Function(CurrGuest) CurrGuest.First_Name).Load()
            GuestBindingSource.DataSource = dbContext.Guests.Local
            GuestBindingSource.AllowNew = True
            GuestNameComboBox.DataSource = GuestBindingSource

            hasUnsavedChangesBoolean = False
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.Message, "DB Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuestNameComboBox_Format(sender As Object, e As ListControlConvertEventArgs) Handles GuestNameComboBox.Format
        Dim aGuest As CottageDBDAL.Guest = CType(e.ListItem, CottageDBDAL.Guest)
        e.Value = aGuest.Last_Name + ", " + aGuest.First_Name
    End Sub

    Private Sub GuestNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GuestNameComboBox.SelectedIndexChanged
        GuestBindingSource.Position = GuestNameComboBox.SelectedIndex
        GuestsUIErrorProvider.Clear()
        UpdateStatusLabel()
    End Sub

    Private Sub roomAvailableListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomAvailableListBox.SelectedIndexChanged
        If roomAvailableListBox.SelectedIndex > -1 Then
            Dim aRoom As CottageDBDAL.Room = CType(roomAvailableListBox.SelectedItem, CottageDBDAL.Room)
            RoomTextBox.Text = aRoom.Room1
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        GuestBindingSource.AddNew()
        GuestBindingSource.MoveLast()
        ShowAddingMode()
    End Sub

    Private Sub addSaveButton_Click(sender As Object, e As EventArgs) Handles addSaveButton.Click
        GuestsUIErrorProvider.Clear()
        If (PhoneTextBox.Text = "") Then
            GuestsUIErrorProvider.SetError(PhoneTextBox, "Phone number cannot be empty")
        Else
            GuestBindingSource.EndEdit()
            Try
                SaveDb()
                LoadDB()
                ShowViewMode()
                GuestNameComboBox.SelectedIndex = GuestNameComboBox.Items.Count - 1
            Catch ex As Exception
                If (ex.Message = "PK Violation") Then
                    'GuestsUIErrorProvider handled the error
                Else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub

    Private Sub SaveDb()
        Try
            Dim rowsUpdatedInteger As Integer = dbContext.SaveChanges()
            Dim feedBackString As String = String.Format("{0} rows updated to DB", rowsUpdatedInteger)
            hasUnsavedChangesBoolean = False
            MessageBox.Show(feedBackString, "DB Updated Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If (PhoneTextBox.Text = "") Then
                GuestsUIErrorProvider.SetError(PhoneTextBox, "Phone number cannot be empty")
            Else
                GuestsUIErrorProvider.SetError(PhoneTextBox, "Phone number already exists. Please use a different phone number")
            End If
            Throw New Exception("PK Violation")
        End Try
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        GuestBindingSource.RemoveCurrent()
        hasUnsavedChangesBoolean = True
        UpdateStatusLabel()
    End Sub

    'it is the cancelbutton on UI 
    'renamed to avoid name conflit 
    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click
        If isEditingModeBoolean Then
            First_NameTextBox.Text = BeforeEditFirstNameString
            Last_NameTextBox.Text = BeforeEditLastNameString
        End If
        GuestBindingSource.CancelEdit()
        ShowViewMode()
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        ShowEditingMode()
        BeforeEditFirstNameString = First_NameTextBox.Text
        BeforeEditLastNameString = Last_NameTextBox.Text
    End Sub

    Private Sub editSaveButton_Click(sender As Object, e As EventArgs) Handles editSaveButton.Click
        GuestsUIErrorProvider.Clear()
        Dim selectedIndexInt As Integer = GuestNameComboBox.SelectedIndex
        GuestBindingSource.EndEdit()
        hasUnsavedChangesBoolean = True
        ShowViewMode()
        GuestNameComboBox.SelectedIndex = selectedIndexInt
    End Sub

    Private Sub DBlSaveButton_Click(sender As Object, e As EventArgs) Handles DBlSaveButton.Click
        If (isAddingModeBoolean) Then
            addSaveButton_Click(sender, e)
        Else
            Try
                SaveDb()
                LoadDB()
                ShowViewMode()
                GuestNameComboBox.SelectedIndex = 0
            Catch ex As Exception
                If (ex.Message = "PK Violation") Then
                    'GuestsUIErrorProvider handled the error
                Else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        If hasUnsavedChangesBoolean Then
            Dim DR As DialogResult = MessageBox.Show("Do you want to Save changes to Database?", "Saving Unsaved changes...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If DR = DialogResult.Yes Then
                SaveDb()
                If (dbContext IsNot Nothing) Then
                    dbContext.Dispose()
                End If
                Me.Close()
            ElseIf DR = DialogResult.No Then
                If (dbContext IsNot Nothing) Then
                    dbContext.Dispose()
                End If
                Me.Close()
            Else
                'do nothing and close the dialog
            End If
        Else
            If (dbContext IsNot Nothing) Then
                dbContext.Dispose()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub UpdateStatusLabel()
        FormToolStripStatusLabel.Text = String.Format("Record {0} of {1}", GuestNameComboBox.SelectedIndex + 1, GuestNameComboBox.Items.Count)
    End Sub

    Private Sub ShowViewMode()
        isAddingModeBoolean = False
        isEditingModeBoolean = False
        GuestNameLabel.Visible = True
        GuestNameComboBox.Visible = True

        First_NameLabel.Visible = False
        Last_NameLabel.Visible = False
        First_NameTextBox.Visible = False
        Last_NameTextBox.Visible = False

        roomAvailableLabel.Visible = False
        roomAvailableListBox.Visible = False


        addButton.Visible = True
        addButton.Enabled = True
        deleteButton.Visible = True
        editButton.Visible = True
        editButton.Enabled = True

        addSaveButton.Visible = False
        AbortButton.Visible = False
        editSaveButton.Visible = False

        StreetTextBox.Enabled = False
        CityTextBox.Enabled = False
        StateTextBox.Enabled = False
        ZipTextBox.Enabled = False
        PhoneTextBox.Enabled = False
        EmailTextBox.Enabled = False
        Last_Visit_DateDateTimePicker.Enabled = False
        RoomTextBox.Enabled = False

        GuestsUIErrorProvider.Clear()
        UpdateStatusLabel()
    End Sub

    Private Sub ShowAddingMode()
        isAddingModeBoolean = True
        isEditingModeBoolean = False

        GuestNameLabel.Visible = False
        GuestNameComboBox.Visible = False

        First_NameLabel.Visible = True
        Last_NameLabel.Visible = True
        First_NameTextBox.Visible = True
        Last_NameTextBox.Visible = True

        roomAvailableLabel.Visible = True
        roomAvailableListBox.Visible = True

        addButton.Visible = False
        deleteButton.Visible = False
        editButton.Visible = True
        editButton.Enabled = False


        addSaveButton.Visible = True
        AbortButton.Visible = True
        editSaveButton.Visible = False

        StreetTextBox.Enabled = True
        CityTextBox.Enabled = True
        StateTextBox.Enabled = True
        ZipTextBox.Enabled = True
        PhoneTextBox.Enabled = True
        EmailTextBox.Enabled = True
        Last_Visit_DateDateTimePicker.Enabled = True
        RoomTextBox.Enabled = False

        FormToolStripStatusLabel.Text = String.Format("Recording {0} of {0} Adding", GuestNameComboBox.Items.Count)
        GuestsUIErrorProvider.Clear()
    End Sub

    Private Sub ShowEditingMode()
        isAddingModeBoolean = False
        isEditingModeBoolean = False
        GuestNameLabel.Visible = False
        GuestNameComboBox.Visible = False

        First_NameLabel.Visible = True
        Last_NameLabel.Visible = True
        First_NameTextBox.Visible = True
        Last_NameTextBox.Visible = True

        roomAvailableLabel.Visible = True
        roomAvailableListBox.Visible = True

        addButton.Visible = True
        addButton.Enabled = False
        deleteButton.Visible = False
        editButton.Visible = False

        addSaveButton.Visible = False
        AbortButton.Visible = True
        editSaveButton.Visible = True

        StreetTextBox.Enabled = True
        CityTextBox.Enabled = True
        StateTextBox.Enabled = True
        ZipTextBox.Enabled = True
        'Phone number is PK. assume PK cannot be edited.
        'If a user wants to change his phone number
        'delete the record with the old phone number
        'then add a record with the new phone number
        PhoneTextBox.Enabled = False
        EmailTextBox.Enabled = True
        Last_Visit_DateDateTimePicker.Enabled = True
        RoomTextBox.Enabled = False

        UpdateStatusLabel()
        FormToolStripStatusLabel.Text &= " Editing"
        GuestsUIErrorProvider.Clear()
    End Sub

    Private Sub Last_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Last_NameTextBox.TextChanged

    End Sub

    Private Sub First_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles First_NameTextBox.TextChanged

    End Sub
End Class