<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomsUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BedTypeLabel As System.Windows.Forms.Label
        Dim FirePlaceLabel As System.Windows.Forms.Label
        Dim JacuzziLabel As System.Windows.Forms.Label
        Dim PrivateAccessLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim WeedEndRateLabel As System.Windows.Forms.Label
        Dim WeekDayRateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomsUI))
        Me.closeButton = New System.Windows.Forms.Button()
        Me.CottageRoom_BedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.CottageRoom_BedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BedTypeTextBox = New System.Windows.Forms.TextBox()
        Me.FirePlaceCheckBox = New System.Windows.Forms.CheckBox()
        Me.JacuzziCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrivateAccessCheckBox = New System.Windows.Forms.CheckBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.WeedEndRateTextBox = New System.Windows.Forms.TextBox()
        Me.WeekDayRateTextBox = New System.Windows.Forms.TextBox()
        Me.roomComboBoxLabel = New System.Windows.Forms.Label()
        Me.roomComboBox = New System.Windows.Forms.ComboBox()
        Me.CottageRoom_BedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        BedTypeLabel = New System.Windows.Forms.Label()
        FirePlaceLabel = New System.Windows.Forms.Label()
        JacuzziLabel = New System.Windows.Forms.Label()
        PrivateAccessLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        WeedEndRateLabel = New System.Windows.Forms.Label()
        WeekDayRateLabel = New System.Windows.Forms.Label()
        CType(Me.CottageRoom_BedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CottageRoom_BedBindingNavigator.SuspendLayout()
        CType(Me.CottageRoom_BedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BedTypeLabel
        '
        BedTypeLabel.AutoSize = True
        BedTypeLabel.Location = New System.Drawing.Point(20, 92)
        BedTypeLabel.Name = "BedTypeLabel"
        BedTypeLabel.Size = New System.Drawing.Size(144, 32)
        BedTypeLabel.TabIndex = 2
        BedTypeLabel.Text = "Bed Type:"
        '
        'FirePlaceLabel
        '
        FirePlaceLabel.AutoSize = True
        FirePlaceLabel.Location = New System.Drawing.Point(594, 195)
        FirePlaceLabel.Name = "FirePlaceLabel"
        FirePlaceLabel.Size = New System.Drawing.Size(151, 32)
        FirePlaceLabel.TabIndex = 4
        FirePlaceLabel.Text = "Fire Place:"
        '
        'JacuzziLabel
        '
        JacuzziLabel.AutoSize = True
        JacuzziLabel.Location = New System.Drawing.Point(594, 101)
        JacuzziLabel.Name = "JacuzziLabel"
        JacuzziLabel.Size = New System.Drawing.Size(118, 32)
        JacuzziLabel.TabIndex = 6
        JacuzziLabel.Text = "Jacuzzi:"
        '
        'PrivateAccessLabel
        '
        PrivateAccessLabel.AutoSize = True
        PrivateAccessLabel.Location = New System.Drawing.Point(594, 147)
        PrivateAccessLabel.Name = "PrivateAccessLabel"
        PrivateAccessLabel.Size = New System.Drawing.Size(210, 32)
        PrivateAccessLabel.TabIndex = 8
        PrivateAccessLabel.Text = "Private Access:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Location = New System.Drawing.Point(648, 24)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(98, 32)
        RoomLabel.TabIndex = 10
        RoomLabel.Text = "Room:"
        RoomLabel.Visible = False
        '
        'WeedEndRateLabel
        '
        WeedEndRateLabel.AutoSize = True
        WeedEndRateLabel.Location = New System.Drawing.Point(17, 200)
        WeedEndRateLabel.Name = "WeedEndRateLabel"
        WeedEndRateLabel.Size = New System.Drawing.Size(222, 32)
        WeedEndRateLabel.TabIndex = 12
        WeedEndRateLabel.Text = "Weed End Rate:"
        '
        'WeekDayRateLabel
        '
        WeekDayRateLabel.AutoSize = True
        WeekDayRateLabel.Location = New System.Drawing.Point(20, 147)
        WeekDayRateLabel.Name = "WeekDayRateLabel"
        WeekDayRateLabel.Size = New System.Drawing.Size(219, 32)
        WeekDayRateLabel.TabIndex = 14
        WeekDayRateLabel.Text = "Week Day Rate:"
        '
        'closeButton
        '
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(334, 279)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(158, 53)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "&Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'CottageRoom_BedBindingNavigator
        '
        Me.CottageRoom_BedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CottageRoom_BedBindingNavigator.BindingSource = Me.CottageRoom_BedBindingSource
        Me.CottageRoom_BedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CottageRoom_BedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CottageRoom_BedBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CottageRoom_BedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CottageRoom_BedBindingNavigatorSaveItem})
        Me.CottageRoom_BedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CottageRoom_BedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CottageRoom_BedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CottageRoom_BedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CottageRoom_BedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CottageRoom_BedBindingNavigator.Name = "CottageRoom_BedBindingNavigator"
        Me.CottageRoom_BedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CottageRoom_BedBindingNavigator.Size = New System.Drawing.Size(1116, 31)
        Me.CottageRoom_BedBindingNavigator.TabIndex = 1
        Me.CottageRoom_BedBindingNavigator.Text = "BindingNavigator1"
        Me.CottageRoom_BedBindingNavigator.Visible = False
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
        'CottageRoom_BedBindingNavigatorSaveItem
        '
        Me.CottageRoom_BedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CottageRoom_BedBindingNavigatorSaveItem.Enabled = False
        Me.CottageRoom_BedBindingNavigatorSaveItem.Image = CType(resources.GetObject("CottageRoom_BedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CottageRoom_BedBindingNavigatorSaveItem.Name = "CottageRoom_BedBindingNavigatorSaveItem"
        Me.CottageRoom_BedBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.CottageRoom_BedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BedTypeTextBox
        '
        Me.BedTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CottageRoom_BedBindingSource, "BedType", True))
        Me.BedTypeTextBox.Enabled = False
        Me.BedTypeTextBox.Location = New System.Drawing.Point(248, 85)
        Me.BedTypeTextBox.Name = "BedTypeTextBox"
        Me.BedTypeTextBox.Size = New System.Drawing.Size(329, 39)
        Me.BedTypeTextBox.TabIndex = 3
        '
        'FirePlaceCheckBox
        '
        Me.FirePlaceCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CottageRoom_BedBindingSource, "FirePlace", True))
        Me.FirePlaceCheckBox.Enabled = False
        Me.FirePlaceCheckBox.Location = New System.Drawing.Point(810, 200)
        Me.FirePlaceCheckBox.Name = "FirePlaceCheckBox"
        Me.FirePlaceCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.FirePlaceCheckBox.TabIndex = 5
        Me.FirePlaceCheckBox.UseVisualStyleBackColor = True
        '
        'JacuzziCheckBox
        '
        Me.JacuzziCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CottageRoom_BedBindingSource, "Jacuzzi", True))
        Me.JacuzziCheckBox.Enabled = False
        Me.JacuzziCheckBox.Location = New System.Drawing.Point(810, 109)
        Me.JacuzziCheckBox.Name = "JacuzziCheckBox"
        Me.JacuzziCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.JacuzziCheckBox.TabIndex = 7
        Me.JacuzziCheckBox.UseVisualStyleBackColor = True
        '
        'PrivateAccessCheckBox
        '
        Me.PrivateAccessCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CottageRoom_BedBindingSource, "PrivateAccess", True))
        Me.PrivateAccessCheckBox.Enabled = False
        Me.PrivateAccessCheckBox.Location = New System.Drawing.Point(810, 152)
        Me.PrivateAccessCheckBox.Name = "PrivateAccessCheckBox"
        Me.PrivateAccessCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PrivateAccessCheckBox.TabIndex = 9
        Me.PrivateAccessCheckBox.UseVisualStyleBackColor = True
        '
        'RoomTextBox
        '
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CottageRoom_BedBindingSource, "Room", True))
        Me.RoomTextBox.Location = New System.Drawing.Point(752, 21)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(83, 39)
        Me.RoomTextBox.TabIndex = 11
        Me.RoomTextBox.Visible = False
        '
        'WeedEndRateTextBox
        '
        Me.WeedEndRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CottageRoom_BedBindingSource, "WeekEndRate", True))
        Me.WeedEndRateTextBox.Enabled = False
        Me.WeedEndRateTextBox.Location = New System.Drawing.Point(245, 200)
        Me.WeedEndRateTextBox.Name = "WeedEndRateTextBox"
        Me.WeedEndRateTextBox.Size = New System.Drawing.Size(329, 39)
        Me.WeedEndRateTextBox.TabIndex = 13
        '
        'WeekDayRateTextBox
        '
        Me.WeekDayRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CottageRoom_BedBindingSource, "WeekDayRate", True))
        Me.WeekDayRateTextBox.Enabled = False
        Me.WeekDayRateTextBox.Location = New System.Drawing.Point(245, 147)
        Me.WeekDayRateTextBox.Name = "WeekDayRateTextBox"
        Me.WeekDayRateTextBox.Size = New System.Drawing.Size(329, 39)
        Me.WeekDayRateTextBox.TabIndex = 15
        '
        'roomComboBoxLabel
        '
        Me.roomComboBoxLabel.AutoSize = True
        Me.roomComboBoxLabel.Location = New System.Drawing.Point(24, 41)
        Me.roomComboBoxLabel.Name = "roomComboBoxLabel"
        Me.roomComboBoxLabel.Size = New System.Drawing.Size(98, 32)
        Me.roomComboBoxLabel.TabIndex = 16
        Me.roomComboBoxLabel.Text = "Room:"
        '
        'roomComboBox
        '
        Me.roomComboBox.FormattingEnabled = True
        Me.roomComboBox.Location = New System.Drawing.Point(248, 33)
        Me.roomComboBox.Name = "roomComboBox"
        Me.roomComboBox.Size = New System.Drawing.Size(326, 40)
        Me.roomComboBox.TabIndex = 17
        '
        'CottageRoom_BedBindingSource
        '
        Me.CottageRoom_BedBindingSource.DataSource = GetType(MegaResorts.CottageRoom_Bed)
        '
        'RoomsUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeButton
        Me.ClientSize = New System.Drawing.Size(863, 362)
        Me.Controls.Add(Me.roomComboBox)
        Me.Controls.Add(Me.roomComboBoxLabel)
        Me.Controls.Add(BedTypeLabel)
        Me.Controls.Add(Me.BedTypeTextBox)
        Me.Controls.Add(FirePlaceLabel)
        Me.Controls.Add(Me.FirePlaceCheckBox)
        Me.Controls.Add(JacuzziLabel)
        Me.Controls.Add(Me.JacuzziCheckBox)
        Me.Controls.Add(PrivateAccessLabel)
        Me.Controls.Add(Me.PrivateAccessCheckBox)
        Me.Controls.Add(RoomLabel)
        Me.Controls.Add(Me.RoomTextBox)
        Me.Controls.Add(WeedEndRateLabel)
        Me.Controls.Add(Me.WeedEndRateTextBox)
        Me.Controls.Add(WeekDayRateLabel)
        Me.Controls.Add(Me.WeekDayRateTextBox)
        Me.Controls.Add(Me.CottageRoom_BedBindingNavigator)
        Me.Controls.Add(Me.closeButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "RoomsUI"
        Me.Text = "Rooms"
        CType(Me.CottageRoom_BedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CottageRoom_BedBindingNavigator.ResumeLayout(False)
        Me.CottageRoom_BedBindingNavigator.PerformLayout()
        CType(Me.CottageRoom_BedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents CottageRoom_BedBindingSource As BindingSource
    Friend WithEvents CottageRoom_BedBindingNavigator As BindingNavigator
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
    Friend WithEvents CottageRoom_BedBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BedTypeTextBox As TextBox
    Friend WithEvents FirePlaceCheckBox As CheckBox
    Friend WithEvents JacuzziCheckBox As CheckBox
    Friend WithEvents PrivateAccessCheckBox As CheckBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents WeedEndRateTextBox As TextBox
    Friend WithEvents WeekDayRateTextBox As TextBox
    Friend WithEvents roomComboBoxLabel As Label
    Friend WithEvents roomComboBox As ComboBox
End Class
