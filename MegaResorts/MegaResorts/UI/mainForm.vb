Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeToolStripStatusLabel.Text = String.Format("{0}  {1}", Now.ToShortDateString, Now.ToShortTimeString)
        textToolStripStatusLabel.Text = "Get it all - Get away to Mega Resorts"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GuestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestsToolStripMenuItem.Click
        Dim childForm As New GuestsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub RoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomsToolStripMenuItem.Click
        Dim childForm As New RoomsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub ReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationsToolStripMenuItem.Click
        Dim childForm As New ReservationsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim newAboutBox As New About()
        newAboutBox.ShowDialog()
    End Sub

    Private Sub guestsToolStripButton_Click(sender As Object, e As EventArgs) Handles guestsToolStripButton.Click
        Dim childForm As New GuestsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub roomsToolStripButton_Click(sender As Object, e As EventArgs) Handles roomsToolStripButton.Click
        Dim childForm As New RoomsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub reservationsToolStripButton_Click(sender As Object, e As EventArgs) Handles reservationsToolStripButton.Click
        Dim childForm As New ReservationsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub



    Private Sub GuestsContextMenuItem_Click(sender As Object, e As EventArgs) Handles GuestsContextMenuItem.Click
        Dim childForm As New GuestsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub RoomsContextMenuItem_Click(sender As Object, e As EventArgs) Handles RoomsContextMenuItem.Click
        Dim childForm As New RoomsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub ReservationsContextMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationsContextMenuItem.Click
        Dim childForm As New ReservationsUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub printReservationsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles printReservationsToolStripMenuItem1.Click
        Dim childForm As New ReservationPrintUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub printReservationToolStripButton_Click(sender As Object, e As EventArgs) Handles printReservationToolStripButton.Click
        Dim childForm As New ReservationPrintUI()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub
End Class
