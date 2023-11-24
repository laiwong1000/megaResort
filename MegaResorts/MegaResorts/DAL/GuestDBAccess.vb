Public Class GuestDBAccess
    Public Function GetALlGuests(ByVal DBContext As CottageDBDAL.CottagesEntities) As List(Of CottageDBDAL.Guest)
        Try
            Dim Query = From aGuest In DBContext.Guests
                        Order By aGuest.Last_Name, aGuest.First_Name
                        Select aGuest
            Return Query.ToList()
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
    End Function
End Class
