Public Class Reservation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        If IsPostBack Then

        Else
            clearControls()
        End If
        'RefresH()
    End Sub
    'Private Sub DisplaySignout()
    '    LoginHyperLink.Visible = True
    '    registerHyperLink.Visible = True
    '    LoginLabel.Visible = False
    '    signOutButton.Visible = False
    'End Sub

    'Private Sub DisplaySignIn()
    '    LoginLabel.Visible = True
    '    signOutButton.Visible = True
    '    LoginHyperLink.Visible = False
    '    registerHyperLink.Visible = False
    '    LoginLabel.Text = String.Format("hi, {0}   ", Session("UserName"))
    'End Sub
    'Public Sub RefresH()
    '    If (Session("UserName") = Nothing) Then
    '        DisplaySignout()
    '    Else
    '        DisplaySignIn()
    '    End If
    'End Sub

    'Protected Sub signOutButton_Click(sender As Object, e As EventArgs) Handles signOutButton.Click
    '    Session.Clear()
    '    RefresH()
    'End Sub
    Protected Sub reservationButton_Click(sender As Object, e As EventArgs) Handles reservationButton.Click
        If (GuestNameTextBox.Text = "") Then
            'do thing and wont be here
        Else
            Try
                arrivingErrorLabel.Text = ""
                If (arrivalCalendar.SelectedDate < Now.Date()) Then
                    arrivingErrorLabel.Text = "Arrival day cannot be in the past"
                    Throw New Exception("1")
                End If
                DepartureErrorLabel.Text = ""
                If (departureCalendar.SelectedDate <> Nothing) AndAlso (arrivalCalendar.SelectedDate > departureCalendar.SelectedDate) AndAlso (departureCalendar.SelectedDate <= Now.Date()) Then
                    DepartureErrorLabel.Text = "Departure date cannot be earlier than arrival day"
                    Throw New Exception("2")
                End If

                Dim aReservation As New CottageDBDAL.Reservation()
                aReservation.Guest = GuestNameTextBox.Text
                aReservation.Room = roomTypeDropDownList.SelectedValue
                aReservation.Arrival = arrivalCalendar.SelectedDate
                If departureCalendar.SelectedDate <> Nothing Then
                    aReservation.Departure = departureCalendar.SelectedDate
                End If
                aReservation.Card = creditCardTypeDropDownList.SelectedValue
                aReservation.CreditCardNumber = creditCardTextBox.Text
                Dim dbContext = New CottageDBDAL.CottagesEntities
                dbContext.Reservations.Add(aReservation)
                dbContext.SaveChanges()
                dbContext.Dispose()
                Response.Redirect("confirmation.aspx")
            Catch ex As Exception
                If ((ex.Message = "1") OrElse (ex.Message = "2")) Then
                    'handled
                Else
                    dbErrorLabel.Text = "reservation on the same day is made with your name already"
                End If
            End Try
        End If
    End Sub

    Private Sub clearControls()
        GuestNameTextBox.Text = ""
        roomTypeDropDownList.ClearSelection()
        arrivalCalendar.SelectedDate = Now.Date
        departureCalendar.SelectedDate = Nothing
        creditCardTypeDropDownList.ClearSelection()
        creditCardTextBox.Text = ""
        dbErrorLabel.Text = ""
        arrivingErrorLabel.Text = ""
        DepartureErrorLabel.Text = ""
    End Sub
    Protected Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearControls()
    End Sub

    Protected Sub arrivalCalendar_SelectionChanged(sender As Object, e As EventArgs) Handles arrivalCalendar.SelectionChanged

        If (departureCalendar.SelectedDate = Nothing) Then

        Else
            departureCalendar.SelectedDate = arrivalCalendar.SelectedDate.AddDays(1)
        End If


    End Sub
End Class