Imports MegaResorts
Imports System.Net.Http
Imports System.Xml.Linq
Imports <xmlns="http://schemas.microsoft.com/2003/10/Serialization">

Public Class ReservationsUI
    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkinDateTimePicker.MinDate = Date.Today 'reservation cannot be made in the past day
        checkinDateTimePicker.MaxDate = Date.Today.AddYears(1) 'reservation can be made more than a year
        checkoutDateTimePicker.MinDate = Date.Today.AddDays(1) 'the end date cannot be made in the past or today
        checkoutDateTimePicker.MaxDate = Date.Today.AddYears(1) 'reservation cannot be made more than a year
    End Sub
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        If (service IsNot Nothing) Then
            service.Dispose()
        End If
        Me.Close()
    End Sub

    Private service As HttpClient = New HttpClient()
    Private Async Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ''''''''''''''''''''''''consume WCF code
        roomPriceTextBox.Clear()
        If (ValidateControls()) Then
            Dim startDateString As String = checkinDateTimePicker.Value.ToString("yyyy-MM-dd")
            Dim endDateString As String = checkoutDateTimePicker.Value.ToString("yyyy-MM-dd")
            Dim isCAAString As String = CaaCheckBox.Checked.ToString()
            Dim bedSizeString As String = ""
            Try

                If (kingRadioButton.Checked) Then
                    bedSizeString = "king"
                End If

                If (queenRadioButton.Checked) Then
                    bedSizeString = "queen"
                End If

                If (doubleRadioButton.Checked) Then
                    bedSizeString = "Double"
                End If

                Dim urlString As String = String.Format("http://localhost:18625/RoomReservationCalculationService.svc/Calculate/{0}/{1}/{2}/{3}", startDateString, endDateString, isCAAString, bedSizeString)
                Dim result = Await service.GetStringAsync(New Uri(urlString))
                Dim xmlResponse = XDocument.Parse(result)
                Dim rateDecimal As Decimal = Convert.ToDecimal(xmlResponse.Elements().First.Value)
                roomPriceTextBox.Text = String.Format("{0:C}", rateDecimal)
            Catch ex As Exception
                reservationFormErrorProvider.SetError(checkoutDateTimePicker, "invalid startDate/endDate selected")
                'MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    '''''''''''''''window form code
    'roomPriceTextBox.Clear()
    'If (ValidateControls()) Then
    '    Try
    '        Dim newRoomReservation As RoomReservation = Nothing

    '        If (kingRadioButton.Checked) Then
    '            newRoomReservation = New KingRoomReservation(checkinDateTimePicker.Value, checkoutDateTimePicker.Value, CaaCheckBox.Checked)
    '        End If

    '        If (queenRadioButton.Checked) Then
    '            newRoomReservation = New QueenRoomReservation(checkinDateTimePicker.Value, checkoutDateTimePicker.Value, CaaCheckBox.Checked)
    '        End If

    '        If (doubleRadioButton.Checked) Then
    '            newRoomReservation = New DoubleRoomReservation(checkinDateTimePicker.Value, checkoutDateTimePicker.Value, CaaCheckBox.Checked)
    '        End If

    '        roomPriceTextBox.Text = String.Format("{0:C}", newRoomReservation.CalculateRate())
    '    Catch ex As Exception
    '        reservationFormErrorProvider.SetError(checkoutDateTimePicker, ex.Message)
    '    End Try

    'End If
    '''''''''''''''''''end of window form code
    'End Sub

    'this function validate if the required field: name and credit card number are not empty.
    'also the number of night is greater than 0 that is the checkoutdateTimePicker is at least 1 day later than the checkInDateTimePicker
    Private Function ValidateControls() As Boolean
        reservationFormErrorProvider.Clear()
        Dim isValidBoolean As Boolean = True
        If (customerNameTextBox.Text = "") Then
            reservationFormErrorProvider.SetError(customerNameTextBox, "Please enter your name")
            isValidBoolean = False
        End If
        If (creditCardNumberTextBox.Text = "") Then
            reservationFormErrorProvider.SetError(creditCardNumberTextBox, "Please enter a valid credit card number")
            isValidBoolean = False
        End If
        'If checkoutDateTimePicker.Value.Subtract(checkinDateTimePicker.Value).Days < 0 Then
        '    reservationFormErrorProvider.SetError(checkoutDateTimePicker, "Check out Date must be at lease one day later than check in date")
        '    isValidBoolean = False
        'End If
        If (kingRadioButton.Checked = False AndAlso queenRadioButton.Checked = False AndAlso doubleRadioButton.Checked = False) Then
            reservationFormErrorProvider.SetError(BedSizeGroupBox, "Please select a room size")
        End If
        Return isValidBoolean
    End Function

    Private Sub creditCardTypeComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles creditCardTypeComboBox.KeyPress
        e.Handled = True
    End Sub
End Class