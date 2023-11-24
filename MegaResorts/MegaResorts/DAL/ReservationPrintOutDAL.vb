Public Class ReservationPrintOutDAL
    Public Function GetAllReservationPrintOut() As List(Of ReservationPrintOut)
        Dim dbcontext As New CottageDBDAL.CottagesEntities()
        Dim roomReservationList As New List(Of ReservationPrintOut)
        Dim query = (From aReservation In dbContext.Reservations
                     From aRoom In dbContext.Rooms
                     From aBed In dbContext.Beds
                     Where aReservation.Room = aRoom.Room1 AndAlso aRoom.BedCode = aBed.BedCode
                     Select aReservation.Guest, aReservation.Arrival, aReservation.Departure, aReservation.Card, aReservation.CreditCardNumber, aReservation.Room, aRoom.Jacuzzi, aRoom.Fireplace, aRoom.Private_Access, aBed.BedType, aBed.WeekdayRate, aBed.WeekendRate).ToList()
        For Each entry In query
            Dim aPrintOut As New ReservationPrintOut()
            aPrintOut.Guest = entry.Guest
            aPrintOut.ArrivalDate = entry.Arrival
            aPrintOut.CreditCard = entry.CreditCardNumber
            aPrintOut.CreditCardType = entry.Card
            aPrintOut.Room = entry.Room
            aPrintOut.Jacuzzi = entry.Jacuzzi
            aPrintOut.FirePlace = entry.Fireplace
            aPrintOut.Private_Access = entry.Private_Access
            aPrintOut.Bedtype = entry.BedType
            aPrintOut.WeekDayRate = Convert.ToDecimal(entry.WeekdayRate)
            aPrintOut.WeekendRate = Convert.ToDecimal(entry.WeekendRate)
        Next
        Return roomReservationList
    End Function
End Class
