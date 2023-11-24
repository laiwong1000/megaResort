'This is an abstract parent class
Public MustInherit Class RoomReservation
    Protected Const GSTDECIMAL As Decimal = 1.05D 'GST is decimal

    Protected Property StartDate() As Date
    Protected Property EndDate() As Date
    Protected Property IsCAAMemberBoolean() As Boolean 'if true, receive 10% off

    'these are calculated var
    Protected IsStartDateMay2SpetBoolean As Boolean 'if true, increase the rate by 25%
    Protected IsStartDateWeekDayBoolean As Boolean 'if true, calculate according to the the weekday rate
    Protected NumberOfNightsInteger As Integer = 0 'calculate number of nights according to the endDate and startDate
    Public Sub New()
    End Sub

    Public Sub New(ByVal StartDate As Date, ByVal EndDate As Date, ByVal IsCAAMemberBoolean As Boolean)

        If (EndDate.Subtract(StartDate).Days < 0) Then
            Throw New ArgumentException("EndDay should be at least one day later than StartDate")
        Else
            Me.StartDate = StartDate
            Me.EndDate = EndDate
            Me.NumberOfNightsInteger = EndDate.Subtract(StartDate).Days + 1 'winForm code
            'Me.NumberOfNightsInteger = EndDate.Subtract(StartDate).Days
            Me.IsCAAMemberBoolean = IsCAAMemberBoolean

            If (StartDate.Month >= 5 AndAlso StartDate.Month <= 9) Then
                IsStartDateMay2SpetBoolean = True
            Else
                IsStartDateMay2SpetBoolean = False
            End If

            If (StartDate.DayOfWeek = DayOfWeek.Friday OrElse StartDate.DayOfWeek = DayOfWeek.Saturday) Then
                IsStartDateWeekDayBoolean = False
            Else
                IsStartDateWeekDayBoolean = True
            End If
        End If
    End Sub

    Public Overridable Function CalculateRate() As Decimal
        Dim roomRateDecimal As Decimal = 1D

        If IsCAAMemberBoolean Then
            roomRateDecimal = roomRateDecimal * 0.9D 'CAA member gets 10% discount
        End If

        If (IsStartDateMay2SpetBoolean) Then
            roomRateDecimal = roomRateDecimal * 1.25D 'add peak season charge
        End If

        Return roomRateDecimal * NumberOfNightsInteger * GSTDECIMAL 'add GST and times number of nights
    End Function

End Class

'child classes differ only by the room rate according to the size of the room
Public Class KingRoomReservation
    Inherits RoomReservation
    Private ReadOnly WeekDayRateDecimal As Decimal = 95D
    Private ReadOnly WeekEndRateDecimal As Decimal = 105D

    Public Sub New(ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal IsCAAMemberBoolean As Boolean)
        MyBase.New(StartDate, EndDate, IsCAAMemberBoolean)
    End Sub

    Public Overrides Function CalculateRate() As Decimal
        If IsStartDateWeekDayBoolean Then
            Return WeekDayRateDecimal * MyBase.CalculateRate()
        Else
            Return WeekEndRateDecimal * MyBase.CalculateRate()
        End If
    End Function
End Class

Public Class QueenRoomReservation
    Inherits RoomReservation
    Private ReadOnly WeekDayRateDecimal As Decimal = 85D
    Private ReadOnly WeekEndRateDecimal As Decimal = 95D

    Public Sub New(ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal IsCAAMemberBoolean As Boolean)
        MyBase.New(StartDate, EndDate, IsCAAMemberBoolean)
    End Sub

    Public Overrides Function CalculateRate() As Decimal
        If IsStartDateWeekDayBoolean Then
            Return WeekDayRateDecimal * MyBase.CalculateRate()
        Else
            Return WeekEndRateDecimal * MyBase.CalculateRate()
        End If
    End Function
End Class

Public Class DoubleRoomReservation
    Inherits RoomReservation
    Private ReadOnly WeekDayRateDecimal As Decimal = 69.95D
    Private ReadOnly WeekEndRateDecimal As Decimal = 79.95D

    Public Sub New(ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal IsCAAMemberBoolean As Boolean)
        MyBase.New(StartDate, EndDate, IsCAAMemberBoolean)
    End Sub

    Public Overrides Function CalculateRate() As Decimal
        If IsStartDateWeekDayBoolean Then
            Return WeekDayRateDecimal * MyBase.CalculateRate()
        Else
            Return WeekEndRateDecimal * MyBase.CalculateRate()
        End If
    End Function
End Class

