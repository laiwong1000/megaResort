Public Class Room_BedDbAccess

    'this function get rooms and beds info from join table of dbContext.Rooms and dbContext.Beds
    Public Function GetAllCottageRooms_Beds(ByVal DBContext As CottageDBDAL.CottagesEntities) As List(Of CottageRoom_Bed)
        Try
            Dim ReturnList As New List(Of CottageRoom_Bed)
            Dim Query = (From aRoom In DBContext.Rooms
                         From aBed In DBContext.Beds
                         Where aRoom.BedCode = aBed.BedCode
                         Order By aRoom.Room1
                         Select aRoom.Room1, aBed.BedType, aBed.WeekdayRate, aBed.WeekendRate, aRoom.Jacuzzi, aRoom.Private_Access, aRoom.Fireplace).ToList()
            For Each rb In Query
                Dim aRoom As New CottageRoom_Bed With {
                    .Room = rb.Room1,
                    .BedType = rb.BedType,
                    .WeekDayRate = String.Format("{0:C}", CType(rb.WeekdayRate, Decimal)),
                    .WeekEndRate = String.Format("{0:c}", CType(rb.WeekendRate, Decimal)),
                    .Jacuzzi = rb.Jacuzzi,
                    .PrivateAccess = rb.Private_Access,
                    .FirePlace = rb.Fireplace
                }
                ReturnList.Add(aRoom)
            Next
            Return ReturnList
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
    End Function

    Public Function GetAllCottageDBRooms(ByVal DBContext As CottageDBDAL.CottagesEntities) As List(Of CottageDBDAL.Room)
        Try
            Dim Query = From aRoom In DBContext.Rooms
                        Order By aRoom.Room1
                        Select aRoom
            Return Query.ToList()
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
    End Function
End Class
