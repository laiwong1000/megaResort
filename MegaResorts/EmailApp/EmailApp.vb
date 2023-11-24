Imports System.Net.Mail

Public Class EmailApp
    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        Try
            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential(senderEmailTextBox.Text, passwdTextBox.Text)
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress(fromTextBox.Text)
            e_mail.Subject = subjectTextBox.Text
            e_mail.To.Add(toTextBox.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = messageTextBox.Text
            smtp_server.Send(e_mail)
            MsgBox("Mail Sended,  thank you")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class