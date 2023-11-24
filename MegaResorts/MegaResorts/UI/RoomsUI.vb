Public Class RoomsUI
    Private dbContext As CottageDBDAL.CottagesEntities = Nothing
    Private RoomBedDal As Room_BedDbAccess
    Private CottageRoom_BedList As List(Of CottageRoom_Bed)
    Private Sub RoomsUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoomBedDal = New Room_BedDbAccess()
        CottageRoom_BedList = New List(Of CottageRoom_Bed)

        If (dbContext IsNot Nothing) Then
            dbContext.Dispose()
        End If
        dbContext = New CottageDBDAL.CottagesEntities()

        Try
            CottageRoom_BedList = RoomBedDal.GetAllCottageRooms_Beds(dbContext)
            CottageRoom_BedBindingSource.DataSource = CottageRoom_BedList
            roomComboBox.DataSource = CottageRoom_BedBindingSource
            roomComboBox.DisplayMember = "room"
            roomComboBox.SelectedIndex = 0
            CottageRoom_BedBindingSource.Position = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub roomComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomComboBox.SelectedIndexChanged
        CottageRoom_BedBindingSource.Position = roomComboBox.SelectedIndex
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
End Class