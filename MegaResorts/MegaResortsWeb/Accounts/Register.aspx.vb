Imports System.Data.Entity
Imports System.Data

Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None
        If (IsPostBack) Then
        Else
            questionDropDownList1.SelectedIndex = 0
        End If
    End Sub

    Protected Sub createButton_Click(sender As Object, e As EventArgs) Handles createButton.Click
        PK_ViolationLabel.Text = ""
        passwdNotMatchedLabel.Text = ""
        Try
            If (passwdTextBox.Text <> confirmPasswdTextBox.Text) Then
                passwdNotMatchedLabel.Text = "Passwords are not matched"
                Throw New Exception("1")
            End If
            Dim dbContext As New MegaResortsWeb.RewardsMembersEntities()
            Dim aNewMember As New MegaResortsWeb.User()
            aNewMember.userName = userNameTextBox.Text
            aNewMember.password = passwdTextBox.Text
            aNewMember.email = emailTextBox.Text
            aNewMember.securityQuestion = questionDropDownList1.SelectedValue
            aNewMember.securityAnswer = ansTextBox.Text
            dbContext.Users.Add(aNewMember)
            dbContext.SaveChanges()
            dbContext.Dispose()
            Response.Redirect("~/Accounts/UserCreated.aspx")
        Catch ex As Exception
            If (ex.Message <> "1") Then
                PK_ViolationLabel.Text = "the user already exist"
            End If
        End Try
    End Sub
End Class