Imports System.Data.Entity
Imports System.Linq
Imports System.Drawing.Printing
Public Class ReservationPrintUI
    Private dbContext As New CottageDBDAL.CottagesEntities()
    Private Sub ReservationPrintUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbContext.Reservations.Load()
        ReservationBindingSource.DataSource = dbContext.Reservations.Local
    End Sub

    Private Sub previewButton_Click(sender As Object, e As EventArgs) Handles previewButton.Click
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            MessageBox.Show("no printer installed")
        Else
            reservationPrintPreviewDialog.Document = reservationPrintDocument
            reservationPrintPreviewDialog.ShowDialog()
        End If
    End Sub

    Private Sub reservationPrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles reservationPrintDocument.PrintPage
        Dim fontObject As Font
        Dim yPosition As Integer
        Dim xPosition As Integer

        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top

        Dim controlText As String = Nothing

        For Each controlObject As Control In Me.Controls
            If Not (TypeOf controlObject Is Button) AndAlso Not (TypeOf controlObject Is BindingNavigator) Then
                controlText = controlObject.Text
                Select Case controlObject.Name
                    Case "arrivaldateTimePicker"
                        fontObject = New Font("Segoe UI", 9.0F, FontStyle.Underline)
                    Case "departuredateTimePicker"
                        fontObject = New Font("Segoe UI", 9.0F, FontStyle.Underline)
                    Case Else
                        fontObject = controlObject.Font
                End Select

                xPosition = leftMargin + controlObject.Location.X
                yPosition = topMargin + controlObject.Location.Y


                e.Graphics.DrawString(controlText, fontObject, Brushes.Black, xPosition, yPosition)
            End If
        Next

        e.Graphics.DrawRectangle(Pens.Black, leftMargin - 15, topMargin, Me.Width, Me.Height - 90)
    End Sub


    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            MessageBox.Show("no printer installed")
        Else
            reservationPrintDocument.Print()
        End If
    End Sub

End Class