<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationPrintUI
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
        Dim ArrivalLabel As System.Windows.Forms.Label
        Dim CardLabel As System.Windows.Forms.Label
        Dim CreditCardNumberLabel As System.Windows.Forms.Label
        Dim DepartureLabel As System.Windows.Forms.Label
        Dim GuestLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationPrintUI))
        Me.ReservationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ReservationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ArrivalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CardTextBox = New System.Windows.Forms.TextBox()
        Me.CreditCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DepartureDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GuestTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.printButton = New System.Windows.Forms.Button()
        Me.previewButton = New System.Windows.Forms.Button()
        Me.reservationPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.reservationPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        ArrivalLabel = New System.Windows.Forms.Label()
        CardLabel = New System.Windows.Forms.Label()
        CreditCardNumberLabel = New System.Windows.Forms.Label()
        DepartureLabel = New System.Windows.Forms.Label()
        GuestLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        CType(Me.ReservationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReservationBindingNavigator.SuspendLayout()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArrivalLabel
        '
        ArrivalLabel.AutoSize = True
        ArrivalLabel.Location = New System.Drawing.Point(32, 147)
        ArrivalLabel.Name = "ArrivalLabel"
        ArrivalLabel.Size = New System.Drawing.Size(104, 32)
        ArrivalLabel.TabIndex = 1
        ArrivalLabel.Text = "Arrival:"
        '
        'CardLabel
        '
        CardLabel.AutoSize = True
        CardLabel.Location = New System.Drawing.Point(368, 147)
        CardLabel.Name = "CardLabel"
        CardLabel.Size = New System.Drawing.Size(84, 32)
        CardLabel.TabIndex = 3
        CardLabel.Text = "Card:"
        '
        'CreditCardNumberLabel
        '
        CreditCardNumberLabel.AutoSize = True
        CreditCardNumberLabel.Location = New System.Drawing.Point(368, 247)
        CreditCardNumberLabel.Name = "CreditCardNumberLabel"
        CreditCardNumberLabel.Size = New System.Drawing.Size(274, 32)
        CreditCardNumberLabel.TabIndex = 5
        CreditCardNumberLabel.Text = "Credit Card Number:"
        '
        'DepartureLabel
        '
        DepartureLabel.AutoSize = True
        DepartureLabel.Location = New System.Drawing.Point(23, 247)
        DepartureLabel.Name = "DepartureLabel"
        DepartureLabel.Size = New System.Drawing.Size(149, 32)
        DepartureLabel.TabIndex = 7
        DepartureLabel.Text = "Departure:"
        '
        'GuestLabel
        '
        GuestLabel.AutoSize = True
        GuestLabel.Location = New System.Drawing.Point(23, 57)
        GuestLabel.Name = "GuestLabel"
        GuestLabel.Size = New System.Drawing.Size(99, 32)
        GuestLabel.TabIndex = 9
        GuestLabel.Text = "Guest:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Location = New System.Drawing.Point(368, 57)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(98, 32)
        RoomLabel.TabIndex = 11
        RoomLabel.Text = "Room:"
        '
        'ReservationBindingNavigator
        '
        Me.ReservationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReservationBindingNavigator.BindingSource = Me.ReservationBindingSource
        Me.ReservationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReservationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReservationBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ReservationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReservationBindingNavigatorSaveItem})
        Me.ReservationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReservationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReservationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReservationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReservationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReservationBindingNavigator.Name = "ReservationBindingNavigator"
        Me.ReservationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReservationBindingNavigator.Size = New System.Drawing.Size(699, 31)
        Me.ReservationBindingNavigator.TabIndex = 0
        Me.ReservationBindingNavigator.Text = "BindingNavigator1"
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
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataSource = GetType(CottageDBDAL.Reservation)
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
        'ReservationBindingNavigatorSaveItem
        '
        Me.ReservationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReservationBindingNavigatorSaveItem.Enabled = False
        Me.ReservationBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReservationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReservationBindingNavigatorSaveItem.Name = "ReservationBindingNavigatorSaveItem"
        Me.ReservationBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.ReservationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ArrivalDateTimePicker
        '
        Me.ArrivalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservationBindingSource, "Arrival", True))
        Me.ArrivalDateTimePicker.Location = New System.Drawing.Point(29, 182)
        Me.ArrivalDateTimePicker.Name = "ArrivalDateTimePicker"
        Me.ArrivalDateTimePicker.Size = New System.Drawing.Size(298, 39)
        Me.ArrivalDateTimePicker.TabIndex = 2
        '
        'CardTextBox
        '
        Me.CardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Card", True))
        Me.CardTextBox.Location = New System.Drawing.Point(374, 182)
        Me.CardTextBox.Name = "CardTextBox"
        Me.CardTextBox.Size = New System.Drawing.Size(257, 39)
        Me.CardTextBox.TabIndex = 4
        '
        'CreditCardNumberTextBox
        '
        Me.CreditCardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "CreditCardNumber", True))
        Me.CreditCardNumberTextBox.Location = New System.Drawing.Point(374, 284)
        Me.CreditCardNumberTextBox.Name = "CreditCardNumberTextBox"
        Me.CreditCardNumberTextBox.Size = New System.Drawing.Size(257, 39)
        Me.CreditCardNumberTextBox.TabIndex = 6
        '
        'DepartureDateTimePicker
        '
        Me.DepartureDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservationBindingSource, "Departure", True))
        Me.DepartureDateTimePicker.Location = New System.Drawing.Point(29, 282)
        Me.DepartureDateTimePicker.Name = "DepartureDateTimePicker"
        Me.DepartureDateTimePicker.Size = New System.Drawing.Size(298, 39)
        Me.DepartureDateTimePicker.TabIndex = 8
        '
        'GuestTextBox
        '
        Me.GuestTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Guest", True))
        Me.GuestTextBox.Location = New System.Drawing.Point(29, 92)
        Me.GuestTextBox.Name = "GuestTextBox"
        Me.GuestTextBox.Size = New System.Drawing.Size(298, 39)
        Me.GuestTextBox.TabIndex = 10
        '
        'RoomTextBox
        '
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Room", True))
        Me.RoomTextBox.Location = New System.Drawing.Point(374, 92)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(257, 39)
        Me.RoomTextBox.TabIndex = 12
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(501, 384)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(130, 44)
        Me.printButton.TabIndex = 13
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'previewButton
        '
        Me.previewButton.Location = New System.Drawing.Point(322, 384)
        Me.previewButton.Name = "previewButton"
        Me.previewButton.Size = New System.Drawing.Size(130, 44)
        Me.previewButton.TabIndex = 14
        Me.previewButton.Text = "Preview"
        Me.previewButton.UseVisualStyleBackColor = True
        '
        'reservationPrintDocument
        '
        '
        'reservationPrintPreviewDialog
        '
        Me.reservationPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.reservationPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.reservationPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.reservationPrintPreviewDialog.Enabled = True
        Me.reservationPrintPreviewDialog.Icon = CType(resources.GetObject("reservationPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.reservationPrintPreviewDialog.Name = "reservationPrintPreviewDialog"
        Me.reservationPrintPreviewDialog.Visible = False
        '
        'ReservationPrintUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 549)
        Me.Controls.Add(Me.previewButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(ArrivalLabel)
        Me.Controls.Add(Me.ArrivalDateTimePicker)
        Me.Controls.Add(CardLabel)
        Me.Controls.Add(Me.CardTextBox)
        Me.Controls.Add(CreditCardNumberLabel)
        Me.Controls.Add(Me.CreditCardNumberTextBox)
        Me.Controls.Add(DepartureLabel)
        Me.Controls.Add(Me.DepartureDateTimePicker)
        Me.Controls.Add(GuestLabel)
        Me.Controls.Add(Me.GuestTextBox)
        Me.Controls.Add(RoomLabel)
        Me.Controls.Add(Me.RoomTextBox)
        Me.Controls.Add(Me.ReservationBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ReservationPrintUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservationPrintUI"
        CType(Me.ReservationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReservationBindingNavigator.ResumeLayout(False)
        Me.ReservationBindingNavigator.PerformLayout()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationBindingNavigator As BindingNavigator
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
    Friend WithEvents ReservationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ArrivalDateTimePicker As DateTimePicker
    Friend WithEvents CardTextBox As TextBox
    Friend WithEvents CreditCardNumberTextBox As TextBox
    Friend WithEvents DepartureDateTimePicker As DateTimePicker
    Friend WithEvents GuestTextBox As TextBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents printButton As Button
    Friend WithEvents previewButton As Button
    Friend WithEvents reservationPrintDocument As Printing.PrintDocument
    Friend WithEvents reservationPrintPreviewDialog As PrintPreviewDialog
End Class
