
Imports RoomReservationCalculationWCF
Imports MegaResorts

Public Class RoomReservationCalculationService
    Implements IRoomReservationCalculationService

    Public Sub New()
    End Sub

    Public Function Calculate(startDateString As String, endDateString As String, isCAAString As String, bedSize As String) As Decimal Implements IRoomReservationCalculationService.Calculate
        Dim aReservation As MegaResorts.RoomReservation
        Dim startDate As DateTime = Convert.ToDateTime(startDateString)
        Dim endDate As DateTime = Convert.ToDateTime(endDateString)
        Dim isCAA As Boolean = Convert.ToBoolean(isCAAString)

        Select Case bedSize.ToLower()
            Case "king"
                aReservation = New KingRoomReservation(startDate, endDate, isCAA)
                Return aReservation.CalculateRate()
            Case "queen"
                aReservation = New QueenRoomReservation(startDate, endDate, isCAA)
                Return aReservation.CalculateRate()
            Case "double"
                aReservation = New DoubleRoomReservation(startDate, endDate, isCAA)
                Return aReservation.CalculateRate()
            Case Else
                Return -1
        End Select
    End Function
End Class
