<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestsUI
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
        Dim CityLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Last_Visit_DateLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim Room1Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestsUI))
        Me.closeButton = New System.Windows.Forms.Button()
        Me.GuestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_Visit_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.DBlSaveButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addSaveButton = New System.Windows.Forms.Button()
        Me.editSaveButton = New System.Windows.Forms.Button()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.GuestNameLabel = New System.Windows.Forms.Label()
        Me.GuestNameComboBox = New System.Windows.Forms.ComboBox()
        Me.roomAvailableLabel = New System.Windows.Forms.Label()
        Me.roomAvailableListBox = New System.Windows.Forms.ListBox()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestsUIErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.First_NameLabel = New System.Windows.Forms.Label()
        Me.Last_NameLabel = New System.Windows.Forms.Label()
        Me.FormStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.FormToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Room1TextBox = New System.Windows.Forms.TextBox()
        CityLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Last_Visit_DateLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        Room1Label = New System.Windows.Forms.Label()
        CType(Me.GuestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuestBindingNavigator.SuspendLayout()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestsUIErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(37, 210)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(72, 32)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(37, 304)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(92, 32)
        EmailLabel.TabIndex = 16
        EmailLabel.Text = "email:"
        '
        'Last_Visit_DateLabel
        '
        Last_Visit_DateLabel.AutoSize = True
        Last_Visit_DateLabel.Location = New System.Drawing.Point(37, 347)
        Last_Visit_DateLabel.Name = "Last_Visit_DateLabel"
        Last_Visit_DateLabel.Size = New System.Drawing.Size(139, 32)
        Last_Visit_DateLabel.TabIndex = 18
        Last_Visit_DateLabel.Text = "Last Visit:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(37, 259)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(106, 32)
        PhoneLabel.TabIndex = 14
        PhoneLabel.Text = "Phone:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Location = New System.Drawing.Point(37, 394)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(98, 32)
        RoomLabel.TabIndex = 20
        RoomLabel.Text = "Room:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(364, 213)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(90, 32)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(37, 163)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(127, 32)
        StreetLabel.TabIndex = 6
        StreetLabel.Text = "Address:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(580, 213)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(63, 32)
        ZipLabel.TabIndex = 12
        ZipLabel.Text = "Zip:"
        '
        'Room1Label
        '
        Room1Label.AutoSize = True
        Room1Label.Location = New System.Drawing.Point(-3, 781)
        Room1Label.Name = "Room1Label"
        Room1Label.Size = New System.Drawing.Size(114, 32)
        Room1Label.TabIndex = 34
        Room1Label.Text = "Room1:"
        Room1Label.Visible = False
        '
        'closeButton
        '
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(826, 612)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(165, 56)
        Me.closeButton.TabIndex = 29
        Me.closeButton.Text = "&Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'GuestBindingNavigator
        '
        Me.GuestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GuestBindingNavigator.BindingSource = Me.GuestBindingSource
        Me.GuestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GuestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GuestBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GuestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GuestBindingNavigatorSaveItem})
        Me.GuestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GuestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GuestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GuestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GuestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GuestBindingNavigator.Name = "GuestBindingNavigator"
        Me.GuestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GuestBindingNavigator.Size = New System.Drawing.Size(1264, 31)
        Me.GuestBindingNavigator.TabIndex = 1
        Me.GuestBindingNavigator.Text = "BindingNavigator1"
        Me.GuestBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GuestBindingSource
        '
        Me.GuestBindingSource.DataSource = GetType(CottageDBDAL.Guest)
        Me.GuestBindingSource.Sort = ""
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'GuestBindingNavigatorSaveItem
        '
        Me.GuestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuestBindingNavigatorSaveItem.Enabled = False
        Me.GuestBindingNavigatorSaveItem.Image = CType(resources.GetObject("GuestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GuestBindingNavigatorSaveItem.Name = "GuestBindingNavigatorSaveItem"
        Me.GuestBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.GuestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(217, 210)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(133, 39)
        Me.CityTextBox.TabIndex = 9
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(217, 304)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(291, 39)
        Me.EmailTextBox.TabIndex = 17
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(217, 73)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(274, 39)
        Me.First_NameTextBox.TabIndex = 3
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(217, 118)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(274, 39)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'Last_Visit_DateDateTimePicker
        '
        Me.Last_Visit_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GuestBindingSource, "Last_Visit_Date", True))
        Me.Last_Visit_DateDateTimePicker.Enabled = False
        Me.Last_Visit_DateDateTimePicker.Location = New System.Drawing.Point(217, 349)
        Me.Last_Visit_DateDateTimePicker.Name = "Last_Visit_DateDateTimePicker"
        Me.Last_Visit_DateDateTimePicker.Size = New System.Drawing.Size(537, 39)
        Me.Last_Visit_DateDateTimePicker.TabIndex = 19
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(217, 259)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(291, 39)
        Me.PhoneTextBox.TabIndex = 15
        '
        'RoomTextBox
        '
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Room", True))
        Me.RoomTextBox.Location = New System.Drawing.Point(217, 394)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(200, 39)
        Me.RoomTextBox.TabIndex = 21
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(460, 210)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(97, 39)
        Me.StateTextBox.TabIndex = 11
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Street", True))
        Me.StreetTextBox.Location = New System.Drawing.Point(217, 163)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(340, 39)
        Me.StreetTextBox.TabIndex = 7
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(649, 210)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(91, 39)
        Me.ZipTextBox.TabIndex = 13
        '
        'DBlSaveButton
        '
        Me.DBlSaveButton.Location = New System.Drawing.Point(826, 546)
        Me.DBlSaveButton.Margin = New System.Windows.Forms.Padding(5)
        Me.DBlSaveButton.Name = "DBlSaveButton"
        Me.DBlSaveButton.Size = New System.Drawing.Size(165, 56)
        Me.DBlSaveButton.TabIndex = 28
        Me.DBlSaveButton.Text = "&Save"
        Me.DBlSaveButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(826, 148)
        Me.addButton.Margin = New System.Windows.Forms.Padding(5)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(165, 56)
        Me.addButton.TabIndex = 24
        Me.addButton.Text = "&Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(826, 215)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(5)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(165, 56)
        Me.deleteButton.TabIndex = 25
        Me.deleteButton.Text = "&Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(826, 281)
        Me.editButton.Margin = New System.Windows.Forms.Padding(5)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(165, 56)
        Me.editButton.TabIndex = 26
        Me.editButton.Text = "&Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'addSaveButton
        '
        Me.addSaveButton.Location = New System.Drawing.Point(826, 149)
        Me.addSaveButton.Margin = New System.Windows.Forms.Padding(5)
        Me.addSaveButton.Name = "addSaveButton"
        Me.addSaveButton.Size = New System.Drawing.Size(165, 56)
        Me.addSaveButton.TabIndex = 27
        Me.addSaveButton.Text = "Save"
        Me.addSaveButton.UseVisualStyleBackColor = True
        '
        'editSaveButton
        '
        Me.editSaveButton.Location = New System.Drawing.Point(826, 280)
        Me.editSaveButton.Margin = New System.Windows.Forms.Padding(5)
        Me.editSaveButton.Name = "editSaveButton"
        Me.editSaveButton.Size = New System.Drawing.Size(165, 56)
        Me.editSaveButton.TabIndex = 26
        Me.editSaveButton.Text = "Save"
        Me.editSaveButton.UseVisualStyleBackColor = True
        '
        'AbortButton
        '
        Me.AbortButton.Location = New System.Drawing.Point(826, 214)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(5)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(165, 56)
        Me.AbortButton.TabIndex = 25
        Me.AbortButton.Text = "&Cancel"
        Me.AbortButton.UseVisualStyleBackColor = True
        '
        'GuestNameLabel
        '
        Me.GuestNameLabel.AutoSize = True
        Me.GuestNameLabel.Location = New System.Drawing.Point(36, 49)
        Me.GuestNameLabel.Name = "GuestNameLabel"
        Me.GuestNameLabel.Size = New System.Drawing.Size(181, 32)
        Me.GuestNameLabel.TabIndex = 0
        Me.GuestNameLabel.Text = "Guest Name:"
        '
        'GuestNameComboBox
        '
        Me.GuestNameComboBox.DataSource = Me.GuestBindingSource
        Me.GuestNameComboBox.DisplayMember = "Last_Name"
        Me.GuestNameComboBox.FormattingEnabled = True
        Me.GuestNameComboBox.Location = New System.Drawing.Point(217, 48)
        Me.GuestNameComboBox.Name = "GuestNameComboBox"
        Me.GuestNameComboBox.Size = New System.Drawing.Size(382, 40)
        Me.GuestNameComboBox.TabIndex = 1
        '
        'roomAvailableLabel
        '
        Me.roomAvailableLabel.AutoSize = True
        Me.roomAvailableLabel.Location = New System.Drawing.Point(37, 438)
        Me.roomAvailableLabel.Name = "roomAvailableLabel"
        Me.roomAvailableLabel.Size = New System.Drawing.Size(587, 32)
        Me.roomAvailableLabel.TabIndex = 22
        Me.roomAvailableLabel.Text = "Room Available: (Click on list below to select)"
        '
        'roomAvailableListBox
        '
        Me.roomAvailableListBox.DataSource = Me.RoomBindingSource
        Me.roomAvailableListBox.DisplayMember = "Room1"
        Me.roomAvailableListBox.FormattingEnabled = True
        Me.roomAvailableListBox.ItemHeight = 32
        Me.roomAvailableListBox.Location = New System.Drawing.Point(217, 473)
        Me.roomAvailableListBox.Name = "roomAvailableListBox"
        Me.roomAvailableListBox.Size = New System.Drawing.Size(445, 196)
        Me.roomAvailableListBox.TabIndex = 24
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataSource = GetType(CottageDBDAL.Room)
        '
        'GuestsUIErrorProvider
        '
        Me.GuestsUIErrorProvider.ContainerControl = Me
        '
        'First_NameLabel
        '
        Me.First_NameLabel.AutoSize = True
        Me.First_NameLabel.Location = New System.Drawing.Point(37, 73)
        Me.First_NameLabel.Name = "First_NameLabel"
        Me.First_NameLabel.Size = New System.Drawing.Size(160, 32)
        Me.First_NameLabel.TabIndex = 2
        Me.First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Me.Last_NameLabel.AutoSize = True
        Me.Last_NameLabel.Location = New System.Drawing.Point(36, 118)
        Me.Last_NameLabel.Name = "Last_NameLabel"
        Me.Last_NameLabel.Size = New System.Drawing.Size(159, 32)
        Me.Last_NameLabel.TabIndex = 4
        Me.Last_NameLabel.Text = "Last Name:"
        '
        'FormStatusStrip
        '
        Me.FormStatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FormStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripStatusLabel})
        Me.FormStatusStrip.Location = New System.Drawing.Point(0, 676)
        Me.FormStatusStrip.Name = "FormStatusStrip"
        Me.FormStatusStrip.Size = New System.Drawing.Size(1032, 22)
        Me.FormStatusStrip.TabIndex = 34
        Me.FormStatusStrip.Text = "StatusStrip1"
        '
        'FormToolStripStatusLabel
        '
        Me.FormToolStripStatusLabel.Name = "FormToolStripStatusLabel"
        Me.FormToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Room1TextBox
        '
        Me.Room1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Room1", True))
        Me.Room1TextBox.Location = New System.Drawing.Point(117, 778)
        Me.Room1TextBox.Name = "Room1TextBox"
        Me.Room1TextBox.Size = New System.Drawing.Size(100, 39)
        Me.Room1TextBox.TabIndex = 35
        Me.Room1TextBox.Visible = False
        '
        'GuestsUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeButton
        Me.ClientSize = New System.Drawing.Size(1032, 698)
        Me.Controls.Add(Room1Label)
        Me.Controls.Add(Me.Room1TextBox)
        Me.Controls.Add(Me.FormStatusStrip)
        Me.Controls.Add(Me.Last_NameLabel)
        Me.Controls.Add(Me.First_NameLabel)
        Me.Controls.Add(Me.roomAvailableListBox)
        Me.Controls.Add(Me.roomAvailableLabel)
        Me.Controls.Add(Me.GuestNameComboBox)
        Me.Controls.Add(Me.GuestNameLabel)
        Me.Controls.Add(Me.AbortButton)
        Me.Controls.Add(Me.editSaveButton)
        Me.Controls.Add(Me.addSaveButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.DBlSaveButton)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Last_Visit_DateLabel)
        Me.Controls.Add(Me.Last_Visit_DateDateTimePicker)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(RoomLabel)
        Me.Controls.Add(Me.RoomTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(StreetLabel)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.GuestBindingNavigator)
        Me.Controls.Add(Me.closeButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "GuestsUI"
        Me.Text = "Guests"
        CType(Me.GuestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuestBindingNavigator.ResumeLayout(False)
        Me.GuestBindingNavigator.PerformLayout()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestsUIErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormStatusStrip.ResumeLayout(False)
        Me.FormStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents GuestBindingSource As BindingSource
    Friend WithEvents GuestBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GuestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Last_Visit_DateDateTimePicker As DateTimePicker
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents DBlSaveButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents addSaveButton As Button
    Friend WithEvents editSaveButton As Button
    Friend WithEvents AbortButton As Button
    Friend WithEvents GuestNameLabel As Label
    Friend WithEvents GuestNameComboBox As ComboBox
    Friend WithEvents roomAvailableLabel As Label
    Friend WithEvents roomAvailableListBox As ListBox
    Friend WithEvents GuestsUIErrorProvider As ErrorProvider
    Friend WithEvents First_NameLabel As Label
    Friend WithEvents Last_NameLabel As Label
    Friend WithEvents FormStatusStrip As StatusStrip
    Friend WithEvents FormToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Room1TextBox As TextBox
    Friend WithEvents RoomBindingSource As BindingSource
End Class
