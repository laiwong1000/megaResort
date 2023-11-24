<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationsUI
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
        Me.closeButton = New System.Windows.Forms.Button()
        Me.customerNameLabel = New System.Windows.Forms.Label()
        Me.customerNameTextBox = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.provinceTextBox = New System.Windows.Forms.TextBox()
        Me.postalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.checkinDateLabel = New System.Windows.Forms.Label()
        Me.checkinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.checkoutDateLabel = New System.Windows.Forms.Label()
        Me.checkoutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BedSizeGroupBox = New System.Windows.Forms.GroupBox()
        Me.doubleRadioButton = New System.Windows.Forms.RadioButton()
        Me.queenRadioButton = New System.Windows.Forms.RadioButton()
        Me.kingRadioButton = New System.Windows.Forms.RadioButton()
        Me.CaaCheckBox = New System.Windows.Forms.CheckBox()
        Me.creditCardTypeLabel = New System.Windows.Forms.Label()
        Me.creditCardTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.creditCardNumLabel = New System.Windows.Forms.Label()
        Me.creditCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.roomPriceLabel = New System.Windows.Forms.Label()
        Me.roomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.reservationFormErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BedSizeGroupBox.SuspendLayout()
        CType(Me.reservationFormErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(840, 608)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(157, 52)
        Me.closeButton.TabIndex = 20
        Me.closeButton.Text = "&Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'customerNameLabel
        '
        Me.customerNameLabel.AutoSize = True
        Me.customerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerNameLabel.Location = New System.Drawing.Point(13, 28)
        Me.customerNameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.customerNameLabel.Name = "customerNameLabel"
        Me.customerNameLabel.Size = New System.Drawing.Size(219, 32)
        Me.customerNameLabel.TabIndex = 0
        Me.customerNameLabel.Text = "Customer &Name"
        '
        'customerNameTextBox
        '
        Me.customerNameTextBox.Location = New System.Drawing.Point(268, 28)
        Me.customerNameTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.customerNameTextBox.Name = "customerNameTextBox"
        Me.customerNameTextBox.Size = New System.Drawing.Size(445, 39)
        Me.customerNameTextBox.TabIndex = 1
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Location = New System.Drawing.Point(13, 88)
        Me.addressLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(119, 32)
        Me.addressLabel.TabIndex = 2
        Me.addressLabel.Text = "&Address"
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(268, 84)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(445, 39)
        Me.addressTextBox.TabIndex = 3
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(268, 129)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(157, 39)
        Me.cityTextBox.TabIndex = 4
        '
        'provinceTextBox
        '
        Me.provinceTextBox.Location = New System.Drawing.Point(445, 129)
        Me.provinceTextBox.Name = "provinceTextBox"
        Me.provinceTextBox.Size = New System.Drawing.Size(93, 39)
        Me.provinceTextBox.TabIndex = 5
        '
        'postalCodeTextBox
        '
        Me.postalCodeTextBox.Location = New System.Drawing.Point(555, 129)
        Me.postalCodeTextBox.Name = "postalCodeTextBox"
        Me.postalCodeTextBox.Size = New System.Drawing.Size(158, 39)
        Me.postalCodeTextBox.TabIndex = 6
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(13, 203)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(98, 32)
        Me.phoneLabel.TabIndex = 7
        Me.phoneLabel.Text = "&Phone"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Location = New System.Drawing.Point(268, 186)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(445, 39)
        Me.phoneTextBox.TabIndex = 8
        '
        'checkinDateLabel
        '
        Me.checkinDateLabel.AutoSize = True
        Me.checkinDateLabel.Location = New System.Drawing.Point(13, 266)
        Me.checkinDateLabel.Name = "checkinDateLabel"
        Me.checkinDateLabel.Size = New System.Drawing.Size(208, 32)
        Me.checkinDateLabel.TabIndex = 9
        Me.checkinDateLabel.Text = "Check - &In Date"
        '
        'checkinDateTimePicker
        '
        Me.checkinDateTimePicker.Location = New System.Drawing.Point(268, 262)
        Me.checkinDateTimePicker.Name = "checkinDateTimePicker"
        Me.checkinDateTimePicker.Size = New System.Drawing.Size(488, 39)
        Me.checkinDateTimePicker.TabIndex = 10
        '
        'checkoutDateLabel
        '
        Me.checkoutDateLabel.AutoSize = True
        Me.checkoutDateLabel.Location = New System.Drawing.Point(13, 322)
        Me.checkoutDateLabel.Name = "checkoutDateLabel"
        Me.checkoutDateLabel.Size = New System.Drawing.Size(231, 32)
        Me.checkoutDateLabel.TabIndex = 11
        Me.checkoutDateLabel.Text = "Check - &Out Date"
        '
        'checkoutDateTimePicker
        '
        Me.checkoutDateTimePicker.Location = New System.Drawing.Point(268, 318)
        Me.checkoutDateTimePicker.Name = "checkoutDateTimePicker"
        Me.checkoutDateTimePicker.Size = New System.Drawing.Size(488, 39)
        Me.checkoutDateTimePicker.TabIndex = 12
        '
        'BedSizeGroupBox
        '
        Me.BedSizeGroupBox.Controls.Add(Me.doubleRadioButton)
        Me.BedSizeGroupBox.Controls.Add(Me.queenRadioButton)
        Me.BedSizeGroupBox.Controls.Add(Me.kingRadioButton)
        Me.BedSizeGroupBox.Location = New System.Drawing.Point(168, 385)
        Me.BedSizeGroupBox.Name = "BedSizeGroupBox"
        Me.BedSizeGroupBox.Size = New System.Drawing.Size(570, 113)
        Me.BedSizeGroupBox.TabIndex = 13
        Me.BedSizeGroupBox.TabStop = False
        Me.BedSizeGroupBox.Text = "Select Size of Bed"
        '
        'doubleRadioButton
        '
        Me.doubleRadioButton.AutoSize = True
        Me.doubleRadioButton.Location = New System.Drawing.Point(388, 54)
        Me.doubleRadioButton.Name = "doubleRadioButton"
        Me.doubleRadioButton.Size = New System.Drawing.Size(131, 36)
        Me.doubleRadioButton.TabIndex = 2
        Me.doubleRadioButton.TabStop = True
        Me.doubleRadioButton.Text = "&Double"
        Me.doubleRadioButton.UseVisualStyleBackColor = True
        '
        'queenRadioButton
        '
        Me.queenRadioButton.AutoSize = True
        Me.queenRadioButton.Location = New System.Drawing.Point(217, 54)
        Me.queenRadioButton.Name = "queenRadioButton"
        Me.queenRadioButton.Size = New System.Drawing.Size(126, 36)
        Me.queenRadioButton.TabIndex = 1
        Me.queenRadioButton.TabStop = True
        Me.queenRadioButton.Text = "&Queen"
        Me.queenRadioButton.UseVisualStyleBackColor = True
        '
        'kingRadioButton
        '
        Me.kingRadioButton.AutoSize = True
        Me.kingRadioButton.Location = New System.Drawing.Point(51, 54)
        Me.kingRadioButton.Name = "kingRadioButton"
        Me.kingRadioButton.Size = New System.Drawing.Size(98, 36)
        Me.kingRadioButton.TabIndex = 0
        Me.kingRadioButton.TabStop = True
        Me.kingRadioButton.Text = "&King"
        Me.kingRadioButton.UseVisualStyleBackColor = True
        '
        'CaaCheckBox
        '
        Me.CaaCheckBox.AutoSize = True
        Me.CaaCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CaaCheckBox.Location = New System.Drawing.Point(168, 517)
        Me.CaaCheckBox.Name = "CaaCheckBox"
        Me.CaaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CaaCheckBox.Size = New System.Drawing.Size(295, 36)
        Me.CaaCheckBox.TabIndex = 14
        Me.CaaCheckBox.Text = "CAA/CARP member"
        Me.CaaCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CaaCheckBox.UseVisualStyleBackColor = True
        '
        'creditCardTypeLabel
        '
        Me.creditCardTypeLabel.AutoSize = True
        Me.creditCardTypeLabel.Location = New System.Drawing.Point(13, 580)
        Me.creditCardTypeLabel.Name = "creditCardTypeLabel"
        Me.creditCardTypeLabel.Size = New System.Drawing.Size(260, 32)
        Me.creditCardTypeLabel.TabIndex = 15
        Me.creditCardTypeLabel.Text = "&Type of Credit Card"
        '
        'creditCardTypeComboBox
        '
        Me.creditCardTypeComboBox.FormattingEnabled = True
        Me.creditCardTypeComboBox.Items.AddRange(New Object() {"Visa", "Master", "American Express"})
        Me.creditCardTypeComboBox.Location = New System.Drawing.Point(279, 577)
        Me.creditCardTypeComboBox.Name = "creditCardTypeComboBox"
        Me.creditCardTypeComboBox.Size = New System.Drawing.Size(445, 40)
        Me.creditCardTypeComboBox.TabIndex = 16
        '
        'creditCardNumLabel
        '
        Me.creditCardNumLabel.AutoSize = True
        Me.creditCardNumLabel.Location = New System.Drawing.Point(13, 628)
        Me.creditCardNumLabel.Name = "creditCardNumLabel"
        Me.creditCardNumLabel.Size = New System.Drawing.Size(266, 32)
        Me.creditCardNumLabel.TabIndex = 17
        Me.creditCardNumLabel.Text = "Cr&edit Card Number"
        '
        'creditCardNumberTextBox
        '
        Me.creditCardNumberTextBox.Location = New System.Drawing.Point(279, 633)
        Me.creditCardNumberTextBox.Name = "creditCardNumberTextBox"
        Me.creditCardNumberTextBox.Size = New System.Drawing.Size(445, 39)
        Me.creditCardNumberTextBox.TabIndex = 18
        '
        'roomPriceLabel
        '
        Me.roomPriceLabel.AutoSize = True
        Me.roomPriceLabel.Location = New System.Drawing.Point(804, 250)
        Me.roomPriceLabel.Name = "roomPriceLabel"
        Me.roomPriceLabel.Size = New System.Drawing.Size(193, 32)
        Me.roomPriceLabel.TabIndex = 20
        Me.roomPriceLabel.Text = "Price of Room"
        '
        'roomPriceTextBox
        '
        Me.roomPriceTextBox.Location = New System.Drawing.Point(783, 297)
        Me.roomPriceTextBox.Name = "roomPriceTextBox"
        Me.roomPriceTextBox.ReadOnly = True
        Me.roomPriceTextBox.Size = New System.Drawing.Size(243, 39)
        Me.roomPriceTextBox.TabIndex = 21
        Me.roomPriceTextBox.TabStop = False
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(783, 351)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(243, 41)
        Me.calculateButton.TabIndex = 19
        Me.calculateButton.Text = "Calculate &Rate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'reservationFormErrorProvider
        '
        Me.reservationFormErrorProvider.ContainerControl = Me
        '
        'ReservationsUI
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 691)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.roomPriceTextBox)
        Me.Controls.Add(Me.roomPriceLabel)
        Me.Controls.Add(Me.creditCardNumberTextBox)
        Me.Controls.Add(Me.creditCardNumLabel)
        Me.Controls.Add(Me.creditCardTypeComboBox)
        Me.Controls.Add(Me.creditCardTypeLabel)
        Me.Controls.Add(Me.CaaCheckBox)
        Me.Controls.Add(Me.BedSizeGroupBox)
        Me.Controls.Add(Me.checkoutDateTimePicker)
        Me.Controls.Add(Me.checkoutDateLabel)
        Me.Controls.Add(Me.checkinDateTimePicker)
        Me.Controls.Add(Me.checkinDateLabel)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.postalCodeTextBox)
        Me.Controls.Add(Me.provinceTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.customerNameTextBox)
        Me.Controls.Add(Me.customerNameLabel)
        Me.Controls.Add(Me.closeButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ReservationsUI"
        Me.Text = "Reservations"
        Me.BedSizeGroupBox.ResumeLayout(False)
        Me.BedSizeGroupBox.PerformLayout()
        CType(Me.reservationFormErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents customerNameLabel As Label
    Friend WithEvents customerNameTextBox As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents provinceTextBox As TextBox
    Friend WithEvents postalCodeTextBox As TextBox
    Friend WithEvents phoneLabel As Label
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents checkinDateLabel As Label
    Friend WithEvents checkinDateTimePicker As DateTimePicker
    Friend WithEvents checkoutDateLabel As Label
    Friend WithEvents checkoutDateTimePicker As DateTimePicker
    Friend WithEvents BedSizeGroupBox As GroupBox
    Friend WithEvents doubleRadioButton As RadioButton
    Friend WithEvents queenRadioButton As RadioButton
    Friend WithEvents kingRadioButton As RadioButton
    Friend WithEvents CaaCheckBox As CheckBox
    Friend WithEvents creditCardTypeLabel As Label
    Friend WithEvents creditCardTypeComboBox As ComboBox
    Friend WithEvents creditCardNumLabel As Label
    Friend WithEvents creditCardNumberTextBox As TextBox
    Friend WithEvents roomPriceLabel As Label
    Friend WithEvents roomPriceTextBox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents reservationFormErrorProvider As ErrorProvider
End Class
